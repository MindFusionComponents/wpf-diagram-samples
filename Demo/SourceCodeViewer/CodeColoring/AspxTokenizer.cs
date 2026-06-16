//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace MindFusion.CodeColoring
{
    /// <summary>
    /// Represents an ITokenizer which operates on ASPX input.
    /// </summary>
    public class AspxTokenizer : XamlTokenizer
    {
        /// <summary>
        /// Initializes a new instance of the AspxTokenizer class.
        /// </summary>
        public AspxTokenizer()
        {
        }

        public override List<Token> Tokenize(string source)
        {
            string commentRegex = "(\\<![ \r\n\t]*(--([^\\-]|[\r\n]|-[^\\-])*--[ \r\n\t]*)\\>)|((?<=<%)((?s)--.*?--)(?=%>))";
            string attributeValueRegex = "\"[^\"]*\"";
            string delimiterRegex = "(:|</|<|/>|>|=)";
            string identifierRegex = "\\b([a-zA-Z.]+)\\b";
            string inlineCodeRegex = "(\\<%|%>)";

            Regex regex = new Regex(string.Format("({0})|({1})|({2})|({3})|({4})",
                commentRegex, inlineCodeRegex, attributeValueRegex, delimiterRegex, identifierRegex));

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
                else if (m.Groups[9].Success)
                    token.Type = TokenType.XamlAttributeValue;
                else if (m.Groups[10].Success)
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
                else if (m.Groups[12].Success)
                {
                    if (firstIdentifier)
                        token.Type = TokenType.XamlTag;
                    else
                        token.Type = TokenType.XamlAttributeName;
                }
                else if (m.Groups[7].Success)
                {
                    token.Type = TokenType.AspxInlineCode;
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
    }
}
