using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MindFusion.CodeColoring
{
	/// <summary>
	/// Represents an ITokenizer which operates on JavaScript input.
	/// </summary>
	public class CssTokenizer : ITokenizer
	{
		/// <summary>
		/// Initializes a new instance of the CssTokenizer class.
		/// </summary>
		public CssTokenizer()
		{

		}

		/// <summary>
		/// ITokenizer.Tokenize implementation.
		/// </summary>
		public List<Token> Tokenize(string source)
		{
			// Comments
			string commentRegex = "\\/\\*.*?\\*\\/";
			// Identifiers
			string identifierRegex = "^(?!(\\{|\\}|\\/\\*|<)).+(?<!;)$";
			// Attribute names
			string attributeNameRegex = ".*?:";
			// Attribute values
			string attributeValueRegex = ".*?;";

			// String values
			string stringRegex = "\"[^\"\\\r\n]*(?:\\.[^\"\\\r\n]*)*\"";

			// All
			Regex regex = new Regex(string.Format("({0})|({1})|({2})|({3})|({4})", 
				commentRegex, identifierRegex, attributeNameRegex, attributeValueRegex, stringRegex));
			var matches = regex.Matches(source);

			int p = 0;
			List<Token> tokens = new List<Token>();
			foreach (Match m in matches)
			{
				if (m.Index > p)
					tokens.Add(new Token() { Value = source.Substring(p, m.Index - p) });

				bool delimiterRemoved = false;
				string delimiter = String.Empty;
				Token token = new Token()
				{
					Value = source.Substring(m.Index, m.Length),
				};
				if (m.Groups[1].Success)
					token.Type = TokenType.Comment;
				else if (m.Groups[2].Success)
				{
					token.Type = TokenType.XamlTag;
					if (token.Value.EndsWith(","))
					{
						token.Value = token.Value.Remove(token.Value.Length - 1);
						delimiterRemoved = true;
						delimiter = ",";
					}
				}
				else if (m.Groups[4].Success)
				{
					token.Type = TokenType.XamlAttributeName;
					if (token.Value.EndsWith(":"))
					{
						token.Value = token.Value.Remove(token.Value.Length - 1);
						delimiterRemoved = true;
						delimiter = ":";
					}
				}
				else if (m.Groups[5].Success)
				{
					token.Type = TokenType.XamlAttributeValue;
					if (token.Value.EndsWith(";"))
					{
						token.Value = token.Value.Remove(token.Value.Length - 1);
						delimiterRemoved = true;
						delimiter = ";";
					}
				}
				else if (m.Groups[6].Success)
					token.Type = TokenType.String;

				tokens.Add(token);

				if (delimiterRemoved)
					tokens.Add(new Token() { Value = delimiter, Type = TokenType.Normal });

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
	}
}
