//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.FractalLayout
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			diagramView.LightweightPresenters = true;
			diagram.LinkHeadShape = null;
		}

		void button_Click(object sender, RoutedEventArgs e)
		{
			diagram.ClearAll();

			var root = diagram.Factory.CreateShapeNode(nodeBounds);
			RandomTree(root, 5, 4);
			Arrange(root);
		}

		void Arrange(DiagramNode root)
		{
			var layout = new MindFusion.Diagramming.Wpf.Layout.FractalLayout();
			layout.Root = root;
			layout.Arrange(diagram);

			diagram.ResizeToFitItems(5);
			diagramView.ZoomToFit();
		}

		void RandomTree(DiagramNode node, int depth, int minChildren)
		{
			if (depth <= 0)
				return;

			var diagram = node.Parent;
			var children = random.Next(depth) - 1 + minChildren;

			if (diagram.Nodes.Count < 3 && children < 2)
				children = 2;

			for (var i = 0; i < children; ++i)
			{
				// create child node and link
				var child = diagram.Factory.CreateShapeNode(nodeBounds);
				child.Brush = brushes[depth % brushes.Length];
				diagram.Factory.CreateDiagramLink(node, child);

				// build child branch
				RandomTree(child, depth - 1, minChildren);
			}
		}

		void OnMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
		{
			// zoom in or out at the mouse position
			var newZoom = diagramView.ZoomFactor + e.Delta / 60.0;
			if (newZoom > 5)
			{
				var viewPoint = e.GetPosition(diagramView);
				var zoomCenter = diagramView.ViewToDiagram(viewPoint);
				diagramView.SetZoomFactor(newZoom, zoomCenter);
			}

			// stop the scrollviewer from scrolling
			e.Handled = true;
		}

		Random random = new Random();
		Rect nodeBounds = new Rect(0, 0, 50, 50);

		// use differect brush for each tree level
		static Point po = new Point(0.3, 0.3);
		Brush[] brushes = new[]
		{
			new RadialGradientBrush(Colors.LightSteelBlue, Colors.BlueViolet) { GradientOrigin = po},
			new RadialGradientBrush(Colors.White, Colors.LightBlue) { GradientOrigin = po},
			new RadialGradientBrush(Colors.White, Colors.DeepSkyBlue) { GradientOrigin = po},
			new RadialGradientBrush(Colors.LimeGreen, Colors.Green) { GradientOrigin = po}
		};
	}
}
