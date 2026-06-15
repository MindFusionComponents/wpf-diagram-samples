//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for TreeLayout.xaml
	/// </summary>
	public partial class TreeLayoutPage : Page
	{
		public TreeLayoutPage()
		{
			InitializeComponent();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"TreeLayout.xml");
			diagram.NodeCreated += new EventHandler<NodeEventArgs>(diagram_NodeCreated);

			overlayImage = (diagram.Nodes[0] as ShapeNode).Image;
		}

		void diagram_NodeCreated(object sender, NodeEventArgs e)
		{
			ShapeNode shapeNode = e.Node as ShapeNode;
			if (shapeNode != null)
			{
				shapeNode.Image = overlayImage;
				shapeNode.ImageAlign = ImageAlign.Stretch;
			}
		}


		private ImageSource overlayImage;
	}
}
