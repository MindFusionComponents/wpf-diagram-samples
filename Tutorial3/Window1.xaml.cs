//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Media.Imaging;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Tutorial3
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
			var node1 = new OrgChartNode
			{
				Bounds = new Rect(100, 60, 240, 100),
				Title = "CEO",
				FullName = "John Smith",
				Text = "Our beloved leader. \r\n" +
					"The CEO of this great corporation.",
				Image = new BitmapImage(
					new Uri("016.png", UriKind.Relative))
			};
			diagram.Nodes.Add(node1);

			var node2 = new OrgChartNode
			{
				Bounds = new Rect(220, 220, 240, 100),
				Title = "CIO",
				FullName = "Bob Smith",
				Text = "The CIO of this great corporation.",
				Image = new BitmapImage(
					new Uri("ac0026-64.png", UriKind.Relative))
			};
			diagram.Nodes.Add(node2);

			diagram.Factory.CreateDiagramLink(node1, node2);
		}
	}
}
