//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Windows;
using System.Windows.Media;

using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.CustomTemplates
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			diagram.LinkHeadShape = ArrowHeads.Triangle;
			diagram.DiagramLinkStyle = new System.Windows.Style();
			diagram.DiagramLinkStyle.Setters.Add(new Setter(DiagramLink.BrushProperty, Brushes.Black));
			diagram.LinkHeadShapeSize = 12;
			diagram.LinkShape = LinkShape.Cascading;
			diagram.RoundedLinks = true;
			diagram.RoundedLinksRadius = 10;
			diagram.LinkSegments = 3;
			diagramView.Behavior = Behavior.Modify;
		}

		private void OnWindowLoaded(object sender, RoutedEventArgs e)
		{
			// Create the hierarchy
			var node1 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Mike Powell",
				Text = "This is the leader of the sample organization.",
				Index = 2
			};
			diagram.Nodes.Add(node1);

			var node2 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Emily Williams",
				Text = "Emily is the leader highest in the PR hierarchy.",
				Index = 1
			};
			diagram.Nodes.Add(node2);

			var node3 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Jacob Smith",
				Text = "Jacob is responsible for the research, development and support.",
				Index = 5
			};
			diagram.Nodes.Add(node3);
				
			var node4 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Joshua King",
				Text = "Manages client relationship and delivery.",
				Index = 5,
				Title = "Client Management"
			};
			diagram.Nodes.Add(node4);

			var node5 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Benjamin Shields",
				Text = "Controls lower-level PR activities.",
				Index = 1,
				Title = "Public Relations, Lvl2"
			};
			diagram.Nodes.Add(node5);

			var node6 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Brianna Higgins",
				Text = "Brianna is a high-level expert performing various consuling services in the PR area.",
				Index = 7
			};
			diagram.Nodes.Add(node6);

			var node7 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Alyssa Garrett",
				Text = "The chief of the research and analysis department.",
				Index = 4
			};
			diagram.Nodes.Add(node7);

			var node8 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Olivia Sanders",
				Text = "Mrs. Sanders is in charge of the level one support team.",
				Index = 0
			};
			diagram.Nodes.Add(node8);

			var node9 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Gabriel Blackwell",
				Text = "The manager of the planning, development and QA departments.",
				Index = 6,
				Title = "Development Lead"
			};
			diagram.Nodes.Add(node9);

			var node10 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Anthony Cooper",
				Text = "Anthony is in charge for all physical delivieries both inbound and outbound.",
				Index = 3,
				Title = "Delivery Supervisor"
			};
			diagram.Nodes.Add(node10);

			var node11 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Charles Kimberley",
				Text = "Responsible for planning and software architecture designs.",
				Index = 6,
				Title = "Planning"
			};
			diagram.Nodes.Add(node11);

			var node12 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Robert Farrell",
				Text = "Robert is in charge of the implementation teams.",
				Index = 6,
				Title = "Senior Programmer"
			};
			diagram.Nodes.Add(node12);

			var node13 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Alexandra Hurst",
				Text = "Alexandra supervises all testing groups.",
				Index = 6,
				Title = "QA"
			};
			diagram.Nodes.Add(node13);

			var node14 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Brian Boyle",
				Text = "Brian is the leader of the internal testing team.",
				Index = 6,
				Title = "Internal Testing"
			};
			diagram.Nodes.Add(node14);

			var node15 = new OrgChartNode
			{
				Bounds = new Rect(0, 0, 300, 160),
				FullName = "Kaylee Langley",
				Text = "Responsible for managing the public alpha and beta tests.",
				Index = 6,
				Title = "Internal Testing"
			};
			diagram.Nodes.Add(node15);

			diagram.Factory.CreateDiagramLink(node1, node2);
			diagram.Factory.CreateDiagramLink(node1, node3);
			diagram.Factory.CreateDiagramLink(node1, node4);
			diagram.Factory.CreateDiagramLink(node2, node5);
			diagram.Factory.CreateDiagramLink(node2, node6);
			diagram.Factory.CreateDiagramLink(node3, node7);
			diagram.Factory.CreateDiagramLink(node3, node8);
			diagram.Factory.CreateDiagramLink(node3, node9);
			diagram.Factory.CreateDiagramLink(node4, node10);
			diagram.Factory.CreateDiagramLink(node9, node11);
			diagram.Factory.CreateDiagramLink(node9, node12);
			diagram.Factory.CreateDiagramLink(node9, node13);
			diagram.Factory.CreateDiagramLink(node13, node14);
			diagram.Factory.CreateDiagramLink(node13, node15);

			TreeLayout layout = new TreeLayout();
			layout.Type = TreeLayoutType.Centered;
			layout.LinkStyle = TreeLayoutLinkType.Cascading3;
			layout.Direction = TreeLayoutDirections.TopToBottom;
			layout.KeepRootPosition = false;
			layout.LevelDistance = 40;
			layout.Arrange(diagram);
		}

		private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			diagramView.ZoomFactor = e.NewValue;
		}
	}
}
