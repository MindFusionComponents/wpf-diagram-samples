//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Windows;
using System.Xml.Linq;

using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Tutorial2
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
			var root = diagram.Factory.CreateShapeNode(nodeBounds);
			root.Text = "Project";
			var document = XDocument.Load("SampleTree.xml");
			CreateChildren(root, document.Element("Project"));

			var layout = new TreeLayout();
			layout.Type = TreeLayoutType.Cascading;
			layout.Direction = TreeLayoutDirections.LeftToRight;
			layout.LinkStyle = TreeLayoutLinkType.Cascading2;
			layout.NodeDistance = 5;
			layout.LevelDistance = -25;	// let horizontal positions overlap
			layout.Arrange(diagram);
		}

		private void CreateChildren(DiagramNode parentDiagNode, XElement parentXmlElement)
		{
			foreach (var element in parentXmlElement.Elements("Activity"))
			{
				var node = diagram.Factory.CreateShapeNode(nodeBounds);
				node.Text = element.Attribute("Name").Value;
				diagram.Factory.CreateDiagramLink(parentDiagNode, node);
				CreateChildren(node, element);
			}
		}

		Rect nodeBounds = new Rect(0, 0, 100, 22);
	}
}
