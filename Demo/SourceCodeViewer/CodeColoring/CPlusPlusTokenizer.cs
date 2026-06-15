//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace MindFusion.CodeColoring
{
	/// <summary>
	/// Represents an ITokenizer which operates on C++ input.
	/// </summary>
	public class CPlusPlusTokenizer : ITokenizer
	{
		/// <summary>
		/// Initializes a new instance of the CPlusPlusTokenizer class.
		/// </summary>
		public CPlusPlusTokenizer()
		{
		}

		/// <summary>
		/// ITokenizer.Tokenize implementation.
		/// </summary>
		public List<Token> Tokenize(string source)
		{
			// Keywords
			string keywordRegex = "\\b(asm|auto|bad_cast|bad_typeid|bool|break|case|catch|char|class|const|const_cast|continue|default|delete|do|double|dynamic_cast|else|enum|except|explicit|extern|false|finally|float|for|friend|goto|if|inline|int|long|mutable|namespace|new|operator|private|protected|public|register|reinterpret_cast|return|short|signed|sizeof|static|static_cast|struct|switch|template|this|throw|true|try|type_info|typedef|typeid|typename|union|unsigned|using|virtual|void|volatile|while)\\b";
			// Strings
			string stringRegex = "\"[^\"\\\r\n]*(?:\\.[^\"\\\r\n]*)*\"";
			// Comments
			string commentRegex = "//.[^\\\r\n]*";
			// Int number
			string numberRegex = "[-+]?\\b\\d+\\b";
			// Hex number
			string hexRegex = "\\b0[xX][0-9a-fA-F]+\\b";
			// Float number
			string floatRegex = "(\\b[0-9]+\\.([0-9]+\\b)?|\\.[0-9]+\\b)";
			// All
			Regex regex = new Regex(string.Format("({0})|({1})|({2})|({3})|({4})|({5})",
				stringRegex, commentRegex, numberRegex, hexRegex, floatRegex, keywordRegex));

			var matches = regex.Matches(source);

			int p = 0;
			List<Token> tokens = new List<Token>();
			foreach (Match m in matches)
			{
				if (m.Index > p)
					tokens.Add(new Token() { Value = source.Substring(p, m.Index - p) });

				Token token = new Token()
				{
					Value = source.Substring(m.Index, m.Length),
				};

				if (m.Groups[1].Success)
					token.Type = TokenType.String;
				else if (m.Groups[2].Success)
					token.Type = TokenType.Comment;
				else if (m.Groups[3].Success ||
					m.Groups[4].Success ||
					m.Groups[5].Success)
					token.Type = TokenType.Number;
				else if (m.Groups[8].Success)
					token.Type = TokenType.Keyword;

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
	}
}
