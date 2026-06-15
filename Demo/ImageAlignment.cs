//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
//

using System;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Specifies the alignment of an image.
	/// </summary>
	[Flags]
	public enum ImageAlignment
	{
		/// <summary>
		/// Invalid image alignment.
		/// </summary>
		Invalid = -1,
		/// <summary>
		/// Same as Center.
		/// </summary>
		None = 0x0,
		/// <summary>
		/// The image is aligned to the left side of
		/// the layout rectangle.
		/// </summary>
		Left = 0x01,
		/// <summary>
		/// The image is aligned to the top side of
		/// the layout rectangle.
		/// </summary>
		Top = 0x02,
		/// <summary>
		/// The image is aligned to the right side of
		/// the layout rectangle.
		/// </summary>
		Right = 0x04,
		/// <summary>
		/// The image is aligned to the bottom side of
		/// the layout rectangle.
		/// </summary>
		Bottom = 0x08,
		/// <summary>
		/// The image is centered within the layout rectangle.
		/// </summary>
		Center = 0x10,
		/// <summary>
		/// The image is stretched to fit in the layout
		/// rectangle, but its original ratio is preserved.
		/// </summary>
		Fit = 0x200,
		/// <summary>
		/// The image is tiled across the layout rectangle.
		/// </summary>
		Tile = 0x400,
		/// <summary>
		/// The image is stretched. Equal to Left | Top | Right | Bottom.
		/// </summary>
		Stretch = Left | Top | Right | Bottom
	}
}
