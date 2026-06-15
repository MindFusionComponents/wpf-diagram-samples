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
using System.Windows.Shapes;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for AddTreeViewItemForm.xaml
	/// </summary>
	public partial class AddTreeViewItemForm : Window
	{
		public AddTreeViewItemForm()
		{
			InitializeComponent();

			images = new ImageSource[]
			{
				new BitmapImage(new Uri(MainWindow.ResourcesPath + @"TreeIcons/1.png", UriKind.Relative)),
				new BitmapImage(new Uri(MainWindow.ResourcesPath + @"TreeIcons/2.png", UriKind.Relative)),
				new BitmapImage(new Uri(MainWindow.ResourcesPath + @"TreeIcons/3.png", UriKind.Relative)),
				new BitmapImage(new Uri(MainWindow.ResourcesPath + @"TreeIcons/4.png", UriKind.Relative)),
			};
		}

		public string ItemLabel
		{
			get { return _labelEdit.Text; }
			set { _labelEdit.Text = value; }
		}

		public ImageSource ItemImage
		{
			get
			{
				if (_iconList.SelectedItems.Count == 0)
					return images[0];

				return images[_iconList.SelectedIndex];
			}
		}

		public int ItemImageIndex
		{
			get { return _iconList.SelectedIndex == 0 ? 0 : _iconList.SelectedIndex; }
			set { }//_iconList.Items[]. = true; }
		}

		public Color ItemColor
		{
			get
			{
				byte r = byte.Parse(txBcolorR.Text);
				byte g = byte.Parse(txBcolorG.Text);
				byte b = byte.Parse(txBcolorB.Text);

				if (r < 0 || r > 255)
					r = 150;
				if (g < 0 || g > 255)
					g = 150;
				if (b < 0 || b > 255)
					b = 150;

				return Color.FromRgb(r, g, b);
			}
			set
			{
				txBcolorR.Text = value.R.ToString();
				txBcolorG.Text = value.G.ToString();
				txBcolorB.Text = value.B.ToString();
			}
		}


		private ImageSource[] images;

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
		}

	}
}
