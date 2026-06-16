//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
//

using System.Windows;
using System.Windows.Controls;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	public class ImageDragData
	{
		public ImageDragData(Image image, Size size)
		{
			_image = image;
			_size = size;
		}

		public Image Image
		{
			get { return _image; }
		}

		public Size Size
		{
			get { return _size; }
		}


		private Image _image;
		private Size _size;
	}
}
