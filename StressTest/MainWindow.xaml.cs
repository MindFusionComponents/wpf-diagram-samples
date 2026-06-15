using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MindFusion.Diagramming.Wpf;


namespace StressTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		void OnCreateItems(object sender, RoutedEventArgs e)
		{
			var diagram = new Diagram();

			diagram.DefaultShape = Shapes.Rectangle;
			diagram.ValidityChecks = false;
			diagram.AutoResize = AutoResize.None;
			diagram.SelectionOnTop = false;
			diagram.SelectAfterCreate = false;

			var total = 10000;
			var rowSize = (int)Math.Sqrt(total);
			var size = 80;
			var dist = 120;

			var diagSize = rowSize * dist;
			diagram.Bounds = new Rect(
				0, 0, diagSize, diagSize);

			var x = diagram.Bounds.Left;
			var y = diagram.Bounds.Top;
			for (int i = 0; i < total; i++)
			{
				var node = diagram.Factory.CreateShapeNode(x, y, size, size);
				node.Text = i.ToString();
				if (x > diagram.Bounds.Left)
				{
					diagram.Factory.CreateDiagramLink(
						diagram.Nodes[i - 1], diagram.Nodes[i]);
				}

				x += dist;
				if (x >= diagram.Bounds.Right)
				{
					x = diagram.Bounds.Left;
					y += dist;
				}
			}

			diagram.EnableSpatialIndex = true;
			diagramView.LightweightPresenters = true;
			diagramView.Diagram = diagram;
		}
	}
}
