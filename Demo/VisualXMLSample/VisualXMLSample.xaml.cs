//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
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
	/// Interaction logic for VisualXMLSample.xaml
	/// </summary>
	public partial class VisualXMLSample : Page
	{
		public VisualXMLSample()
		{
			InitializeComponent();
		}

		private void DemoPage_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.ClearAll();
			//SetWorldFont();
			diagram.BackBrush = Brushes.White;
			diagram.Bounds = new Rect(0, 0, 800, 1000);
			diagram.RouteLinks = false;
			diagram.NodesExpandable = true;
			ShapeNode b = diagram.Factory.CreateShapeNode(10, 10, 350, 50);
			b.Transparent = true;
			b.Brush = Brushes.White;
			b.Text = "Press the LoadXML button below to display XML content";
			b.TextBrush = Brushes.Black;
			b.FontFamily = new FontFamily("Times New Roman");
			b.FontSize = 16;
			b.Locked = true;
		}
	}
}
