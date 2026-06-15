//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Xml;
using System.Windows.Media.Effects;


namespace MindFusion.Diagramming.Wpf.Samples.CS.DecisionLayout
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			terminalBrush = new LinearGradientBrush(
				Color.FromArgb(0xFF, 0xFF, 0xFF, 0xC0), Color.FromArgb(0xFF, 0xBF, 0xBF, 0x90), 90);
			decisionBrush = new LinearGradientBrush(
				Color.FromArgb(0xFF, 0xF0, 0xFF, 0xFF), Color.FromArgb(0xFF, 0x7F, 0xDF, 0x8F), 90);
			normalBrush = new LinearGradientBrush(
				Color.FromArgb(0xFF, 0xE0, 0xFF, 0xFF), Color.FromArgb(0xFF, 0xA8, 0xBF, 0xBF), 90);

			diagram.NodeEffects.Add(new GlassEffect());
		}

		private void loadSample_Click(object sender, RoutedEventArgs e)
		{
			var resourceStream = Application.GetResourceStream(new Uri("flowchart.xml", UriKind.Relative));
			if (resourceStream != null && resourceStream.Stream != null)
			{
				using (var stream = resourceStream.Stream)
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(stream);
					diagram.LoadFromXml(doc);
					diagram.NodeEffects.Add(new GlassEffect());
				}
			}
		}

		private void layout_Click(object sender, RoutedEventArgs e)
		{
			ArrangeDiagram();
		}

		private void layoutRandomDiagram_Click(object sender, RoutedEventArgs e)
		{
			diagram.ClearAll();

			var startNode = diagram.Factory.CreateShapeNode(0, 0, 120, 40);
			startNode.Brush = terminalBrush;
			startNode.StrokeThickness = 2;
			startNode.FontWeight = FontWeights.Bold;
			startNode.Text = "START";
			startNode.Tag = "start";
			startNode.Shape = Shapes.Ellipse;

			var endNode = diagram.Factory.CreateShapeNode(0, 0, 120, 40);
			endNode.Brush = terminalBrush;
			endNode.FontWeight = FontWeights.Bold;
			endNode.StrokeThickness = 2;
			endNode.Text = "END";
			endNode.Shape = Shapes.Ellipse;

			const int maxLength = 10;
			var all = new List<ShapeNode>();
			var remaining = new Queue<List<ShapeNode>>();

			remaining.Enqueue(new List<ShapeNode>(new ShapeNode[] { startNode }));

			var random = new Random(DateTime.Now.Millisecond);
			int length = 0;
			while (remaining.Count > 0)
			{
				var newNodes = new List<ShapeNode>();
				bool createdNew = false;

				var next = remaining.Dequeue();
				for (var n = 0; n < next.Count; n++)
				{
					var node = next[n];
					var isDecision = node.Tag is bool;

					ShapeNode previousChoice = null;
					int outLinks = isDecision ? 2 : 1;
					string[] linkTexts = isDecision ? new string[] { "YES", "NO" } : new string[] { "" };
					for (int i = 0; i < outLinks; i++)
					{
						// Create new or link to an existing node;
						// Create at least one new node for each level
						bool createNew = random.Next(maxLength) > length;
						if (!createdNew && n == next.Count - 1)
							createNew = true;
						if (length == maxLength)
							createNew = false;

						DiagramLink link;
						if (createNew)
						{
							// New decision or an operation node
							bool newDecision = random.Next(3) > 0 && !isDecision;
							var newNode = diagram.Factory.CreateShapeNode(0, 0, 120, 40);
							if (newDecision)
							{
								newNode.Shape = Shapes.Decision;
								newNode.AnchorPattern = AnchorPattern.Decision2In2Out;
								newNode.Brush = decisionBrush;
								newNode.Text = "Decision";
								newNode.Tag = true;
							}
							else
							{
								newNode.Shape = Shapes.Rectangle;
								newNode.Brush = normalBrush;
								newNode.Text = "Operation";
							}

							link = diagram.Factory.CreateDiagramLink(node, newNode);
							newNodes.Add(newNode);
							createdNew = true;
						}
						else
						{
							// Link to an existing node. If length == maxLength, link to the end node
							if (length == maxLength || remaining.Count == 0)
							{
								link = diagram.Factory.CreateDiagramLink(node, endNode);
							}
							else
							{
								// Make sure both choices don't lead to the same node
								ShapeNode choice = null;
								while (choice == previousChoice)
									choice = all[random.Next(all.Count)];
								link = diagram.Factory.CreateDiagramLink(node, choice);
								previousChoice = choice;
							}
						}

						link.Text = linkTexts[i];
					}

					all.Add(node);
				}

				if (newNodes.Count > 0)
					remaining.Enqueue(newNodes);

				length++;
			}

			ArrangeDiagram();
		}

		private void ArrangeDiagram()
		{
			var layout = new MindFusion.Diagramming.Wpf.Layout.DecisionLayout();
			layout.HorizontalPadding = 30;
			layout.VerticalPadding = 30;
			layout.StartNode = diagram.FindNode("start");
			layout.Arrange(diagram);
		}


		private Brush terminalBrush;
		private Brush decisionBrush;
		private Brush normalBrush;
	}
}
