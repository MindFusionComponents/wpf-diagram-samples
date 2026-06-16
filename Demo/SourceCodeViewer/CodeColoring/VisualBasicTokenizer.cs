//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace MindFusion.CodeColoring
{
	/// <summary>
	/// Represents an ITokenizer which operates on VB.NET input.
	/// </summary>
	public class VisualBasicTokenizer : ITokenizer
	{
		/// <summary>
		/// Initializes a new instance of the VisualBasicTokenizer class.
		/// </summary>
		public VisualBasicTokenizer()
		{
		}

		/// <summary>
		/// ITokenizer.Tokenize implementation.
		/// </summary>
		public List<Token> Tokenize(string source)
		{
			// Keywords
			string keywordRegex = "(?i)\\b(AddHandler|AddressOf|Alias|And|AndAlso|Ansi|As|Assembly|Auto|Boolean|ByRef|Byte|ByVal|Call|Case|Catch|CBool|CByte|CChar|CDate|CDec|CDbl|Char|CInt|Class|CLng|CObj|Const|CShort|CSng|CStr|CType|Date|Decimal|Declare|Default|Delegate|Dim|DirectCast|Do|Double|Each|Else|ElseIf|End|Enum|Erase|Error|Event|Exit|False|Finally|For|Friend|Function|Get|GetType|GoSub|GoTo|Handles|If|Implements|Imports|In|Inherits|Integer|Interface|Is|Let|Lib|Like|Long|Loop|Me|Mod|Module|MustInherit|MustOverride|MyBase|MyClass|Namespace|New|Next|Not|Nothing|NotInheritable|NotOverridable|Object|On|Option|Optional|Or|OrElse|Overloads|Overridable|Overrides|ParamArray|Preserve|Private|Property|Protected|Public|RaiseEvent|ReadOnly|ReDim|REM|RemoveHandler|Resume|Return|Select|Set|Shadows|Shared|Short|Single|Static|Step|Stop|String|Structure|Sub|SyncLock|Then|Throw|To|True|Try|TypeOf|Unicode|Until|Variant|When|While|With|WithEvents|WriteOnly|Xor)\\b";
			// Strings
			string stringRegex = "\"[^\"\\\r\n]*(?:\\.[^\"\\\r\n]*)*\"";
			// Comments
			string commentRegex = "'.[^\"\\\r\n]*";
			// Int number
			string numberRegex = "[-+]?\\b\\d+\\b";
			// Hex number &H80000000
			string hexRegex = "&\\b[H][0-9a-fA-F]+\\b";
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
