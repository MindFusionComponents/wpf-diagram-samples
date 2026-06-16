//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;


namespace MindFusion.CodeColoring
{
	/// <summary>
	/// Specifies the type of a token in the input string.
	/// </summary>
	public enum TokenType
	{
		/// <summary>
		/// Specifies a XAML opening or closing bracket.
		/// </summary>
		XamlBracket,

		/// <summary>
		/// Specifies a XAML tag or its namespace prefix.
		/// </summary>
		XamlTag,

		/// <summary>
		/// Specifies the colon separator between a tag or attribute and its namespace prefix.
		/// </summary>
		XamlNsSeparator,

		/// <summary>
		/// Specifies a XAML attribute or its namespace prefix.
		/// </summary>
		XamlAttributeName,

		/// <summary>
		/// Specifies a XAML attribute value, including the quotes.
		/// </summary>
		XamlAttributeValue,

		/// <summary>
		/// Specifies a XAML assignment between the attribute name and value.
		/// </summary>
		XamlAttributeAssignment,

		/// <summary>
		/// Specifies a C# or VB.NET keyword, such as true, void and null.
		/// </summary>
		Keyword,

		/// <summary>
		/// Specifies a C# or VB.NET number, in any format.
		/// </summary>
		Number,

		/// <summary>
		/// Specifies a C# or VB.NET string, including the quotes.
		/// </summary>
		String,

		/// <summary>
		/// Specifies a C# or VB.NET comment, including the comment slashes.
		/// </summary>
		Comment,

		/// <summary>
		/// Specifies regular text.
		/// </summary>
		Normal,
        
        /// <summary>
        /// Specifies ASPX inline code block (&lt;% or %&gt;)
        /// </summary>
        AspxInlineCode
	}
}
