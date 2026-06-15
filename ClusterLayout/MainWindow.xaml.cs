//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Windows;

using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.ClusterLayout
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			diagram.DefaultShape = Shapes.Ellipse;
			diagram.LinkHeadShape = ArrowHeads.PointerArrow;
			diagram.LinkHeadShapeSize = 10;
		}

		void button_Click(object sender, RoutedEventArgs e)
		{
			RandomGraph();
			Arrange();
		}

		private void Arrange()
		{
			var layout = new CompositeLayout();
			layout.RotateSubgraphs = true;
			layout.PartitionMethod = MindFusion.Layout.PartitionMethod.LinkDensity;

			var subgraphLayout = new CircularLayout();
			subgraphLayout.Radius = 0;
			subgraphLayout.SplitGraph = false;
			layout.SubgraphLayout = subgraphLayout;

			var masterLayout = new AnnealLayout();
			masterLayout.CrossingLinksCost = 0;
			layout.MasterLayout = masterLayout;

			layout.Arrange(diagram);

			diagram.ResizeToFitItems(15);
		}

		private void RandomGraph()
		{
			diagram.ClearAll();

			var rnd = new Random();
			int numClusters = rnd.Next(4, 8);
			var clusters = new List<List<DiagramNode>>();
			for (int i = 0; i < numClusters; i++)
			{
				int clusterSize = rnd.Next(10, 18);
				var cluster = CreateCluster(clusterSize);
				clusters.Add(cluster);
			}

			for (int i = 0; i < numClusters; i++)
			{
				var cluster1 = clusters[i];
				var cluster2 = clusters[(i + 1) % numClusters];
				var cluster3 = clusters[(i + rnd.Next(1, numClusters - 1)) % numClusters];
				var cluster4 = clusters[(i + rnd.Next(1, numClusters - 1)) % numClusters];

				var node1 = cluster1[rnd.Next(cluster1.Count)];
				var node2 = cluster2[rnd.Next(cluster2.Count)];
				var node3 = cluster3[rnd.Next(cluster3.Count)];
				var node4 = cluster4[rnd.Next(cluster4.Count)];

				diagram.Factory.CreateDiagramLink(node1, node2);
				diagram.Factory.CreateDiagramLink(node1, node3);
				diagram.Factory.CreateDiagramLink(node1, node4);
			}
		}

		List<DiagramNode> CreateCluster(int numNodes)
		{
			var cluster = new List<DiagramNode>();
			for (int n = 0; n < numNodes; ++n)
			{
				var node = diagram.Factory.CreateShapeNode(0, 0, 30, 30);
				cluster.Add(node);
			}

			for (int i = 0; i < numNodes; i++)
			{
				for (int j = i + 1; j < numNodes; j++)
				{
					var node1 = cluster[i];
					var node2 = cluster[j];
					diagram.Factory.CreateDiagramLink(node1, node2);
				}
			}

			return cluster;
		}
	}
}
