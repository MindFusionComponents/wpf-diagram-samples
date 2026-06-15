//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	public class PictureControl : Control
	{
		public PictureControl()
		{
			//DefaultStyleKeyProperty.OverrideMetadata(typeof(PictureControl), new FrameworkPropertyMetadata(typeof(PictureControl)));
			imageAlignment = ImageAlignment.Center;
		}

		/// <summary>
		/// UIElement.OnRender override.
		/// </summary>
		/// <param name="drawingContext">
		/// The drawing instructions for a specific element.
		/// </param>
		protected override void OnRender(DrawingContext drawingContext)
		{
			if (image == null)
			{
				if (!string.IsNullOrEmpty(MainWindow.ResourcesPath))
					image = new BitmapImage(new Uri(MainWindow.ResourcesPath + source));
			}

			Rect r = new Rect(RenderSize);
			drawingContext.DrawRectangle(Background, null, r);
			if (image != null)
			{
				try
				{
					drawingContext.PushClip(new RectangleGeometry(r));
					ImagePainter.Draw(drawingContext, image, r, imageAlignment);
				}
				finally
				{
					drawingContext.Pop();
				}
			}
			drawingContext.DrawRectangle(null, new Pen(BorderBrush, 1), r);
		}

		[Category("Appearance")]
		[Description("The image displayed in the picture control.")]
		[DefaultValue(null)]
		public string Path
		{
			get { return source; }
			set
			{
				source = value;
			}
		}

		[Category("Appearance")]
		[Description("The image displayed in the picture control.")]
		[DefaultValue(null)]
		public BitmapSource Image
		{
			get { return image; }
			set
			{
				image = value;
			}
		}

		[Category("Appearance")]
		[Description("The alignment of the displayed image.")]
		[DefaultValue(typeof(ImageAlignment), "Center")]
		public ImageAlignment ImageAlignment
		{
			get { return imageAlignment; }
			set
			{
				imageAlignment = value;
			}
		}

		private BitmapSource image = null;
		private string source;
		private ImageAlignment imageAlignment;
	}
}
