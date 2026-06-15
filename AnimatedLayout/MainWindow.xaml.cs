//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Threading;

using MindFusion.Layout;
using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.AnimatedLayout
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			diagram.Selection.AllowMultipleSelection = false;
			diagram.LinkHeadShape = ArrowHeads.None;

			// create a sample tree to arrange
			for (int i = 0; i < 30; ++i)
			{
				if (i < 6)
				{
					var node = diagram.Factory.CreateShapeNode(0, 0, 60, 60);
					if (i > 0)
						diagram.Factory.CreateDiagramLink(node, diagram.Nodes[i - 1]).Locked = true;
				}
				else
				{
					var node = diagram.Factory.CreateShapeNode(0, 0, 40, 40);
					diagram.Factory.CreateDiagramLink(node, diagram.Nodes[i / 5]).Locked = true;
				}
			}

			// SpringLayout is good for animation as iterative force-directed process
			InitSpringLayout();

			// start the animation timer
			timer = new DispatcherTimer();
			timer.Interval = new TimeSpan(0, 0, 0, 0, interval);
			timer.Tick += OnTimerTick;
			timer.Start();
		}

		private void InitSpringLayout()
		{
			layout = new SpringLayout();
			layout.NodeDistance *= 2.0 / 3;
			layout.IterationCount = 1200;
			layout.SplitGraph = false;
			layout.MinimizeCrossings = false;
			layout.LayoutMethod = SpringLayoutMethod.Classic;
			layout.BeginArrange(diagram, null);

			iteration = 0;
		}

		void OnTimerTick(object sender, EventArgs e)
		{
			// run a few SpringLayout iterations per each frame; less iteratons per frame
			// will lead to smoother animation but would need more time to complete
			layout.Iterate(iteration, iteration + 5);
			iteration += 5;

			if (iteration > 1200)
				timer.Stop();
		}

		private void OnNodeModifying(object sender, NodeValidationEventArgs e)
		{
			foreach (DiagramNode node in diagram.Nodes)
				node.LayoutTraits[SpringLayoutTraits.Frozen] = false;

			e.Node.LayoutTraits[SpringLayoutTraits.Frozen] = true;
			InitSpringLayout();

			if (timer.Interval.Milliseconds == interval)
				timer.Interval = new TimeSpan(0, 0, 0, 0, 120);
		}

		private void OnNodeModified(object sender, NodeEventArgs e)
		{
			timer.Interval = new TimeSpan(0, 0, 0, 0, interval);
		}

		private DispatcherTimer timer;
		private SpringLayout layout;
		private int iteration;
		private int interval = 40;
	}
}
