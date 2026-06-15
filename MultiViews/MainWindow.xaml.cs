//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.MultiViews
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			myDiagram = new Diagram();

			var xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(Properties.Resources.Flowchart);
			myDiagram.LoadFromXml(xmlDocument);

			viewList = new List<DiagramView>();
		}

		private void myAdd_Click(object sender, RoutedEventArgs e)
		{
			DiagramView view = new DiagramView();
			view.Diagram = myDiagram;

			MindFusion.UI.Wpf.Window window = new MindFusion.UI.Wpf.Window();
			window.Width = 600;
			window.Height = 600;
			window.Content = view;
			window.Show(windowHost);

			viewList.Add(view);
		}

		private void myRemove_Click(object sender, RoutedEventArgs e)
		{
			if (viewList.Count > 0)
			{
				windowHost.Windows.Remove(windowHost.Windows[windowHost.Windows.Count - 1]);
				viewList.Remove(viewList[viewList.Count - 1]);
			}
		}


		Diagram myDiagram;
		List<DiagramView> viewList;
	}
}
