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
	/// Interaction logic for NetSample.xaml
	/// </summary>
	public partial class NetSample : Page
	{
		public NetSample()
		{
			InitializeComponent();
		}

		private void DemoPage_Loaded(object sender, RoutedEventArgs e)
		{
			//SetWorldFont();
			diagram.SelectAfterCreate = false;

			diagram.BackBrush = Brushes.AliceBlue;
			diagramView.Behavior = Behavior.DrawLinks;
			diagram.LinkHeadShape = ArrowHeads.Tetragon;
			diagram.DefaultShape = Shapes.Rectangle;

			Style linkStyle = new Style();
			linkStyle.Setters.Add(new Setter(DiagramLink.StrokeProperty, Brushes.Black));
			linkStyle.Setters.Add(new Setter(DiagramLink.BrushProperty, Brushes.YellowGreen));
			diagram.DiagramLinkStyle = linkStyle;
		}
	}
}
