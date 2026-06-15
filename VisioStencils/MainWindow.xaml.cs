//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Effects;

using Microsoft.Win32;


namespace MindFusion.Diagramming.Wpf.Samples.CS.VisioStencils
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			var stencilFolder = StencilFolder;
			if (!string.IsNullOrEmpty(stencilFolder))
				LoadStencil(System.IO.Path.Combine(stencilFolder, "Countries.vsx"));
		}

		private void LoadStencil(string fileName)
		{
			var stencil = VisioStencil.LoadFromXml(fileName, CreateImage);

			nodeListView.Items.Clear();
			foreach (var master in stencil.Masters)
			{
				var node = new VisioNode(diagram);
				node.Bounds = new Rect(0, 0, 48, 48);
				node.Content = VisioContent.Create(stencil, master.UniversalName);

				NodeListView.SetLabel(node, master.UniversalName);

				nodeListView.Items.Add(node);
			}
		}

		private ImageSource CreateImage(Stream stream)
		{
			var image = new Metafile(stream);

			const int size = 256;
			using (var bitmap = new Bitmap(size, size, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
			{
				using (var graphics = Graphics.FromImage(bitmap))
				{
					graphics.DrawImage(image, 0, 0, size, size);

					using (var memoryStream = new MemoryStream())
					{
						bitmap.Save(memoryStream, ImageFormat.Png);

						var result = new BitmapImage();
						result.BeginInit();
						result.StreamSource = memoryStream;
						result.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
						result.CacheOption = BitmapCacheOption.OnLoad;
						result.EndInit();

						return result;
					}
				}
			}
		}

		private void menuItemOpenStencil_Click(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.Filter = "Visio stencils (*.vsx)|*.vsx|All Files|*.*||";
			dialog.InitialDirectory = StencilFolder;
			if (dialog.ShowDialog(this) == true)
				LoadStencil(dialog.FileName);
		}

		private void menuItemExit_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}


		public string StencilFolder
		{
			get
			{
				if (string.IsNullOrEmpty(stencilFolder))
				{
					var executablePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
					var currentFolder = System.IO.Path.GetDirectoryName(executablePath);

					var info = new DirectoryInfo(currentFolder).Parent;
					while (info != null)
					{
						var checkFolder = System.IO.Path.Combine(info.FullName, @"Redistributable\VisioStencils");
						if (Directory.Exists(checkFolder))
						{
							stencilFolder = checkFolder;
							break;
						}

						info = info.Parent;
					}
				}

				return stencilFolder;
			}
		}


		private string stencilFolder;
	}
}