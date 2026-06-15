//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;


namespace MindFusion.Diagramming.Wpf.Samples.CS.LayeredLayout
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		void button_Click(object sender, RoutedEventArgs e)
		{
			RandomGraph();
			Arrange();
		}

		private void Arrange()
		{
			var layout = new MindFusion.Diagramming.Wpf.Layout.LayeredLayout();
			layout.Anchoring = Anchoring.Reassign;
			layout.EnforceLinkFlow = true;
			layout.StraightenLongLinks = true;
			layout.NodeDistance = 10;
			layout.LayerDistance = 15;
			layout.Arrange(diagram);

			diagram.ResizeToFitItems(5);
			diagramView.ZoomToFit();
		}

		private void RandomGraph()
		{
			diagram.ClearAll();

			for (int i = 0; i < 30; ++ i)
			{
				int c = diagram.Nodes.Count;
				int g = 2 + random.Next(15);
				for (int j = 0; j < g; ++j)
				{
					var node = diagram.Factory.CreateShapeNode(0, 0, 40, 40);
					node.AnchorPattern = AnchorPattern.TopInBottomOut;
					if (j > 0)
						diagram.Factory.CreateDiagramLink(diagram.Nodes[diagram.Nodes.Count - 2], node);
				}
				if (i > 0)
				{
					for (int j = 0; j < 1 + random.Next(3); ++j)
						diagram.Factory.CreateDiagramLink(
							diagram.Nodes[random.Next(c)],
							diagram.Nodes[c + random.Next(g)]);
				}
			}
		}

		Random random = new Random();
	}
}
