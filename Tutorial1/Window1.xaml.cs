//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Collections.Generic;
using System.Windows;
using System.Xml.Linq;

using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Tutorial1
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void OnWindowLoaded(object sender, RoutedEventArgs e)
		{
			var nodeMap = new Dictionary<string, DiagramNode>();
			var bounds = new Rect(0, 0, 60, 22);

			// load the graph xml
			var xml = XDocument.Load("SampleGraph.xml");
			var graph = xml.Element("Graph");

			// load node data
			var nodes = graph.Descendants("Node");
			foreach (var node in nodes)
			{
				var diagramNode = diagram.Factory.CreateShapeNode(bounds);
				nodeMap[node.Attribute("id").Value] = diagramNode;
				diagramNode.Text = node.Attribute("name").Value;
			}

			// load link data
			var links = graph.Descendants("Link");
			foreach (var link in links)
			{
				diagram.Factory.CreateDiagramLink(
					nodeMap[link.Attribute("origin").Value],
					nodeMap[link.Attribute("target").Value]);
			}

			// arrange the graph
			var layout = new LayeredLayout();
			layout.Arrange(diagram);
		}
	}
}
