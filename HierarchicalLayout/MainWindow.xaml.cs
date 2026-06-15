//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Media;
using System.Xml;

using MindFusion.Layout;
using MindFusion.Diagramming.Wpf.Layout;
using System.Windows.Media.Animation;


namespace MindFusion.Diagramming.Wpf.Samples.CS.HierarchicalLayout
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			LoadFile();

			Style linkStyle = new Style();
			linkStyle.Setters.Add(new Setter(DiagramLink.StrokeThicknessProperty, 0.25));
			linkStyle.Setters.Add(new Setter(DiagramLink.HeadStrokeThicknessProperty, 0.25));
			diagram.DiagramLinkStyle = linkStyle;
			Style shapeNodeStyle = new Style();
			shapeNodeStyle.Setters.Add(new Setter(ShapeNode.StrokeThicknessProperty, 0.25));
			diagram.ShapeNodeStyle = shapeNodeStyle;
		}

		private void LoadFile()
		{
			var resourceStream = Application.GetResourceStream(new Uri("Diagram.fc", UriKind.Relative));
			if (resourceStream != null && resourceStream.Stream != null)
			{
				using (var stream = resourceStream.Stream)
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(stream);

					diagram.LoadFromXml(doc);
				}
			}
		}

		private void arrangeButton_Click(object sender, RoutedEventArgs e)
		{
			var offscreen = new Diagram();
			offscreen.LoadFromString(diagram.SaveToString());

			// Apply HierarchicalLayout
			var layout = new MindFusion.Diagramming.Wpf.Layout.HierarchicalLayout();
			layout.LinkBendFactor = 1.1;
			layout.LevelDistance = 40;
			if (!layout.Arrange(diagram))
			{
				MessageBox.Show(this, "The layout failed.\nMake sure that the nodes in the layout have specified levels. " +
					"Also make sure that no link connects nodes from the same level.", "Hierarchical Layout",
					MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else
			{
				diagram.ResizeToFitItems(10);
			}
		}
	}
}
