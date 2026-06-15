//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using GraphicsUnit = MindFusion.Diagramming.Wpf.GraphicsUnit;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Provides advanced methods for drawing images.
	/// </summary>
	internal sealed class ImagePainter
	{
		/// <summary>
		/// Prevent instantiation.
		/// </summary>
		private ImagePainter()
		{
		}

		/// <summary>
		/// Draws the specified image in the target rectangle
		/// in the specified graphics using the specified image alignment.
		/// </summary>
		public static void Draw(DrawingContext g, BitmapSource image,
			Rect rect, ImageAlignment align)
		{
			Draw(g, image, rect, align, TransparencyOpaque);
		}

		/// <summary>
		/// Draws the specified image in the target rectangle
		/// in the specified graphics using the specified image
		/// alignment and semitransparency factor. The transparency
		/// ranges from 0 (invisible) to 255 (opaque).
		/// </summary>
		public static void Draw(DrawingContext g, BitmapSource image,
			Rect rect, ImageAlignment align, int transparency)
		{
			Rect rc = Utilities.FromLTRB(
				rect.Left, rect.Top, rect.Right, rect.Bottom);
			Draw(g, image, rc, align, transparency, true);
		}


		/// <summary>
		/// Internal worker method.
		/// </summary>
		private static void Draw(DrawingContext g, BitmapSource image,
			Rect rect, ImageAlignment align, int transparency, bool wholeNumbers)
		{
			// Empty destination rect ?
			if (rect.Width == 0 || rect.Height == 0)
				return;

			if (image == null || g == null ||
				align == ImageAlignment.Invalid)
				return;

			if (transparency < 0)
				transparency = 0;
			if (transparency > 255)
				transparency = 255;

			// Check if we are fully transparent
			if (transparency == 0)
				return;

			FormatConvertedBitmap formatedBitmapSource = new FormatConvertedBitmap();
			formatedBitmapSource.BeginInit();
			formatedBitmapSource.Source = image;


			double xoff = 0, yoff = 0; // offsets
			double dw = 0, dh = 0; // destination size
			double sw = 0, sh = 0; // source size

			sw = image.Width;
			sh = image.Height;
			dw = sw;
			dh = sh;

			// 0-width or 0-height image ?
			if (sw == 0 || sh == 0)
				return;

			if ((align & ImageAlignment.Fit) > 0)
			{
				double w = rect.Width;
				double h = rect.Height;

				double ratDest = w / h;
				double ratSrc = sw / sh;

				if (ratDest == 0 || ratSrc == 0)
					return;

				if (ratDest > ratSrc)
				{
					// Stretch vertically
					dw = ratSrc * h;
					dh = h;

					yoff = 0;
				}
				else
				{
					// Stretch horizontally
					dw = w;
					dh = w / ratSrc;

					xoff = 0;
				}
			}

			if ((align & ImageAlignment.Left) > 0)
			{
				xoff = 0;

				if ((align & ImageAlignment.Right) > 0)
				{
					// Stretch horizontally
					dw = rect.Width;
				}
			}
			else if ((align & ImageAlignment.Right) > 0)
			{
				xoff = rect.Width - dw;
			}

			if ((align & ImageAlignment.Top) == 0 &&
				(align & ImageAlignment.Bottom) == 0)
			{
				// Center vertically
				yoff = (rect.Height - dh) / 2;
				if (wholeNumbers)
					yoff = (double)Math.Round(yoff);
			}

			if ((align & ImageAlignment.Top) > 0)
			{
				yoff = 0;

				if ((align & ImageAlignment.Bottom) > 0)
				{
					// Stretch vertically
					dh = rect.Height;
				}
			}
			else if ((align & ImageAlignment.Bottom) > 0)
			{
				yoff = rect.Height - dh;
			}

			if ((align & ImageAlignment.Left) == 0 &&
				(align & ImageAlignment.Right) == 0)
			{
				// Center horizontally
				xoff = (rect.Width - dw) / 2;
				if (wholeNumbers)
					xoff = (double)Math.Round(xoff);
			}

			if ((align & ImageAlignment.Tile) > 0)
			{
				double dx = rect.X + xoff;
				double dy = rect.Y + yoff;

				while (dx > rect.X)
					dx -= dw;
				while (dy > rect.Y)
					dy -= dh;

				for (double i = dx; i < rect.Right; i += dw)
				{
					for (double j = dy; j < rect.Bottom; j += dh)
					{
						Rect r = new Rect((int)i, (int)j, (int)dw, (int)dh);
						g.DrawImage(image, r);
					}
				}
			}
			else
			{
				Rect r = new Rect((int)(rect.X + xoff), (int)(rect.Y + yoff), (int)dw, (int)dh);
				g.DrawImage(image, r);
			}
		}

		public static int TransparencyInvisible = 0;
		public static int TransparencyOpaque = 255;
	}
}
