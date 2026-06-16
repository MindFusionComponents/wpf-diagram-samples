//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;


namespace MindFusion.CodeColoring
{
	/// <summary>
	/// Represents an object, which can split an input string to its tokens.
	/// </summary>
	public interface ITokenizer
	{
		/// <summary>
		/// Splits the specified string to tokens.
		/// </summary>
		List<Token> Tokenize(string source);
	}
}
