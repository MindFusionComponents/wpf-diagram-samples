//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;


namespace MindFusion.CodeColoring
{
	/// <summary>
	/// Represents an ITokenizer which operates on XAML input.
	/// </summary>
	public class XamlTokenizer : ITokenizer
	{
		/// <summary>
		/// Initializes a new instance of the XamlTokenizer class.
		/// </summary>
		public XamlTokenizer()
		{
		}

		/// <summary>
		/// ITokenizer.Tokenize implementation.
		/// </summary>
		public virtual List<Token> Tokenize(string source)
		{
			string commentRegex = "\\<![ \r\n\t]*(--([^\\-]|[\r\n]|-[^\\-])*--[ \r\n\t]*)\\>";
			string attributeValueRegex = "\"[^\"]*\"";
			string delimiterRegex = "(:|</|<|/>|>|=)";
			string identifierRegex = "\\b([a-zA-Z.]+)\\b";

			Regex regex = new Regex(string.Format("({0})|({1})|({2})|({3})",
				commentRegex, attributeValueRegex, delimiterRegex, identifierRegex));

			var matches = regex.Matches(source);

			int p = 0;
			List<Token> tokens = new List<Token>();
			bool firstIdentifier = false;
			foreach (Match m in matches)
			{
				if (m.Index > p)
				{
					tokens.Add(new Token() { Value = source.Substring(p, m.Index - p) });
					firstIdentifier = false;
				}

				Token token = new Token()
				{
					Value = source.Substring(m.Index, m.Length),
				};

				if (m.Groups[1].Success)
					token.Type = TokenType.Comment;
				else if (m.Groups[4].Success)
					token.Type = TokenType.XamlAttributeValue;
				else if (m.Groups[5].Success)
				{
					if (token.Value == "=")
						token.Type = TokenType.XamlAttributeAssignment;
					else if (token.Value == ":")
						token.Type = TokenType.XamlNsSeparator;
					else
						token.Type = TokenType.XamlBracket;

					if (token.Value == "<" || token.Value == "</")
						firstIdentifier = true;
				}
				else if (m.Groups[7].Success)
				{
					if (firstIdentifier)
						token.Type = TokenType.XamlTag;
					else
						token.Type = TokenType.XamlAttributeName;
				}
				else
				{
					firstIdentifier = false;
				}

				tokens.Add(token);

				p = m.Index + m.Length;
			}

			if (p < source.Length)
			{
				tokens.Add(new Token()
				{
					Value = source.Substring(p),
				});
			}

			return tokens;
		}

		/// <summary>
		/// Reads the XML hierarchy and creates the corresponding tokens.
		/// </summary>
		private void LoadTokens(List<Token> tokens, XmlNode node, int depth)
		{
			if (node is XmlWhitespace)
			{
				tokens.Add(new Token() { Value = node.Value });
				return;
			}

			AddOpeningTag(tokens, node, depth);

			foreach (XmlNode child in node.ChildNodes)
				LoadTokens(tokens, child, depth + 1);

			if (node.HasChildNodes)
				AddClosingTag(tokens, node, depth);
		}

		private void AddOpeningTag(List<Token> tokens, XmlNode node, int depth)
		{
			Token tokenName = new Token();
			Token tokenOpeningBracket = new Token();
			Token tokenClosingBracket = new Token();

			tokenOpeningBracket.Value = "<";
			tokenOpeningBracket.Type = TokenType.XamlBracket;
			tokenName.Value = node.LocalName;
			tokenName.Type = TokenType.XamlTag;
			if (!node.HasChildNodes)
				tokenClosingBracket.Value = "/>";
			else
				tokenClosingBracket.Value = ">";
			tokenClosingBracket.Type = TokenType.XamlBracket;

			tokens.Add(tokenOpeningBracket);
			string prefix = node.GetPrefixOfNamespace(node.NamespaceURI);
			if (!string.IsNullOrEmpty(prefix))
			{
				Token tokenPrefix = new Token() { Value = prefix, Type = TokenType.XamlTag };
				Token tokenColon = new Token() { Value = ":", Type = TokenType.XamlNsSeparator };

				tokens.Add(tokenPrefix);
				tokens.Add(tokenColon);
			}

			tokens.Add(tokenName);

			// Adding all attributes
			LoadAttributes(tokens, node, depth + 1);

			if (!node.HasChildNodes)
			{
				Token tokenWhitespace = new Token() { Value = " " };
				tokens.Add(tokenWhitespace);
			}

			tokens.Add(tokenClosingBracket);
		}

		private void AddClosingTag(List<Token> tokens, XmlNode node, int depth)
		{
			//tokens.Add(new LineBreak());
			//AddDepthSpaces(tokens, depth);

			Token tokenName = new Token();
			Token tokenOpeningBracket = new Token();
			Token tokenClosingBracket = new Token();

			tokenOpeningBracket.Value = "</";
			tokenOpeningBracket.Type = TokenType.XamlBracket;
			tokenClosingBracket.Value = ">";
			tokenClosingBracket.Type = TokenType.XamlBracket;
			tokenName.Value = node.LocalName;
			tokenName.Type = TokenType.XamlTag;

			tokens.Add(tokenOpeningBracket);

			string prefix = node.GetPrefixOfNamespace(node.NamespaceURI);
			if (!string.IsNullOrEmpty(prefix))
			{
				Token tokenPrefix = new Token() { Value = prefix, Type = TokenType.XamlTag };
				Token tokenColon = new Token() { Value = ":", Type = TokenType.XamlNsSeparator };

				tokens.Add(tokenPrefix);
				tokens.Add(tokenColon);
			}

			tokens.Add(tokenName);
			tokens.Add(tokenClosingBracket);
		}

		/// <summary>
		/// Adds all tag's attributes, if any, to the token collection.
		/// </summary>
		private void LoadAttributes(List<Token> tokens, XmlNode node, int depth)
		{
			XmlElement element = node as XmlElement;
			if (element == null)
				return;

			if (!element.HasAttributes)
				return;

			foreach (XmlAttribute attribute in element.Attributes)
				AddAttribute(tokens, node, attribute, depth);
		}

		private void AddAttribute(List<Token> tokens, XmlNode node, XmlAttribute attribute, int depth)
		{
			Token tokenAttributeName = new Token();
			tokenAttributeName.Value = attribute.LocalName;
			tokenAttributeName.Type = TokenType.XamlAttributeName;

			Token tokenWhitespace = new Token() { Value = " " };
			tokens.Add(tokenWhitespace);

			string prefix = node.GetPrefixOfNamespace(attribute.NamespaceURI);
			if (!string.IsNullOrEmpty(prefix))
			{
				Token tokenPrefix = new Token() { Value = prefix, Type = TokenType.XamlAttributeName };
				Token tokenColon = new Token() { Value = ":", Type = TokenType.XamlNsSeparator };

				tokens.Add(tokenPrefix);
				tokens.Add(tokenColon);
			}

			Token tokenAttributeAssignment = new Token();
			tokenAttributeAssignment.Value = "=";
			tokenAttributeAssignment.Type = TokenType.XamlAttributeAssignment;

			Token tokenAttributeValue = new Token();
			tokenAttributeValue.Value = string.Format("\"{0}\"", attribute.Value);
			tokenAttributeValue.Type = TokenType.XamlAttributeValue;

			tokens.Add(tokenAttributeName);
			tokens.Add(tokenAttributeAssignment);
			tokens.Add(tokenAttributeValue);
		}
	}
}
