//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
	/// Interaction logic for BigRadialLayout.xaml
	/// </summary>
	public partial class BigRadialLayoutPage : Page
	{
		public BigRadialLayoutPage()
		{
			InitializeComponent();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.ClearAll();
			diagram.MeasureUnit = GraphicsUnit.Millimeter;
			diagram.LinkShape = LinkShape.Polyline;
			diagram.LinkSegments = 1;
			diagram.DynamicLinks = true;
			diagram.DefaultShape = Shapes.Ellipse;
			diagram.BackBrush = new SolidColorBrush(Colors.White);
			diagram.LinkHeadShape = ArrowHeads.None;
			diagram.SelectAfterCreate = false;

			Style linkStyle = new Style();
			linkStyle.Setters.Add(new Setter(DiagramLink.BrushProperty, Brushes.Gainsboro));
			diagram.DiagramLinkStyle = linkStyle;
		}
	}
}
