//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Fishbone
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();			

			backbone = diagram.Factory.CreateShapeNode(
				0, 225, 800, 4, Shapes.Rectangle);
			backbone.Brush = Brushes.Black;
			backbone.EnabledHandles = AdjustmentHandles.None;
			backbone.HandlesStyle = HandlesStyle.Invisible;

			diagramView.CustomBehavior = new FishboneBehavior(diagramView, backbone);
			diagram.MinimumNodeSize = new Size(0.1, 0.1);
		}		

		private void diagram_NodeCreated(object sender, NodeEventArgs e)
		{
			if (e.Node is CauseNode)
				e.Node.Constraints.MoveDirection = DirectionConstraint.Horizontal;
		}

		private ShapeNode backbone;
	}
}
