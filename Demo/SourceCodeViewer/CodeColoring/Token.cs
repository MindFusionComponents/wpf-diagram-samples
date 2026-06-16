//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;


namespace MindFusion.CodeColoring
{
	/// <summary>
	/// Represents an isolated part in an input string.
	/// </summary>
	public class Token
	{
		/// <summary>
		/// Initializes a new instance of the Token class.
		/// </summary>
		public Token()
		{
			Type = TokenType.Normal;
		}

		/// <summary>
		/// Object.ToString override.
		/// </summary>
		public override string ToString()
		{
			return Value;
		}


		/// <summary>
		/// Gets or sets the type of the token.
		/// </summary>
		public TokenType Type
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the token text.
		/// </summary>
		public string Value
		{
			get;
			set;
		}
	}
}
