//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
//

using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for VisioNodes.xaml
	/// </summary>
	public partial class VisioNodes : Page
	{
		public VisioNodes()
		{
			InitializeComponent();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			if (!Directory.Exists(MainWindow.VisioStencilRoot))
			{
				MessageBox.Show("The Visio stencils directory could not be found.",
					"MindFusion.Diagramming Demo", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else
			{
				diagram.ClearAll();

				diagram.BackBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0xF2, 0xFA, 0xFF));
				diagram.ShowGrid = true;

				var style = new Style();
				style.Setters.Add(new Setter(FontFamilyProperty, new FontFamily("Segoe UI")));
				style.Setters.Add(new Setter(FontSizeProperty, 9.0));
				diagram.ShapeNodeStyle = style;

				var stencilFile = System.IO.Path.Combine(MainWindow.VisioStencilRoot, "UAsymbols.vsx");
				MainWindow.LoadVisioStencil(diagram, stencilFile);
			}
		}
	}
}
