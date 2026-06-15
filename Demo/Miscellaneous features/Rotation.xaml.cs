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
	/// Interaction logic for Rotation.xaml
	/// </summary>
	public partial class Rotation : Page
	{
		public Rotation()
		{
			InitializeComponent();
		}

		private void DemoPage_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.AllowDrop = true;
			diagram.DocumentPlane.AllowDrop = true;
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"Rotation.xml");

			foreach (DiagramNode node in diagram.Nodes)
				node.AllowDrop = true;
		}
	}
}
