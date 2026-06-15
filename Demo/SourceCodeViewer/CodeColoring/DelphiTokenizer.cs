//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace MindFusion.CodeColoring
{
	/// <summary>
	/// Represents an ITokenizer which operates on Delphi input.
	/// </summary>
	public class DelphiTokenizer : ITokenizer
	{
		/// <summary>
		/// Initializes a new instance of the DelphiTokenizer class.
		/// </summary>
		public DelphiTokenizer()
		{
		}

		/// <summary>
		/// ITokenizer.Tokenize implementation.
		/// </summary>
		public List<Token> Tokenize(string source)
		{
			// Keywords
			string keywordRegex = "(?i)\\b(And|Array|As|Begin|Case|Class|Const|Constructor|Destructor|Div|Do|DownTo|Else|End|Except|File|Finally|For|Function|Goto|If|Implementation|In|Inherited|Interface|Is|Mod|Not|Object|Of|On|Or|Packed|Procedure|Program|Property|Raise|Record|Repeat|Set|Shl|Shr|Then|ThreadVar|To|Try|Type|Unit|Until|Uses|Var|While|With|Xor|AnsiChar|AnsiString|Array|Boolean|Byte|Cardinal|Char|Class|Comp|Currency|Double|Extended|File|Int64|Integer|LongInt|LongWord|PAnsiChar|PAnsiString|PChar|PCurrency|PDateTime|PExtended|PInt64|Pointer|PShortString|PString|PVariant|PWideChar|PWideString|Real|Real48|Record|ShortInt|ShortString|Single|SmallInt|String|TConvFamily|TConvType|TDateTime|Text|TextFile|TFloatFormat|TFormatSettings|TObject|TPoint|TRect|TReplaceFlags|TSearchRec|TSysCharSet|TThreadFunc|Variant|WideChar|WideString|Word|Nil)\\b";
			// Strings
			string stringRegex = "\'[^\'\\\r\n]*(?:\\.[^\'\\\r\n]*)*\'";
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
