//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Media;
using System.Xml;

using MindFusion.Layout;
using MindFusion.Diagramming.Wpf.Layout;
using MindFusion.Diagramming.Wpf.Lanes;


namespace MindFusion.Diagramming.Wpf.Samples.CS.ProcessLayout
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Init();
			LoadFile();
		}

		private void Init()
		{
			random = new Random(DateTime.Now.Second);
		}

		private void LoadFile()
		{
			var resourceStream = Application.GetResourceStream(new Uri("Process.fc", UriKind.Relative));
			if (resourceStream != null && resourceStream.Stream != null)
			{
				using (var stream = resourceStream.Stream)
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(stream);

					diagram.LoadFromXml(doc);

					diagram.BackBrush = new SolidColorBrush(Colors.AliceBlue);
				}
			}

			foreach (DiagramNode node in diagram.Nodes)
			{
				Point position = new Point(
					random.Next((int)(diagram.Bounds.X), (int)(diagram.Bounds.Right)),
					random.Next((int)(diagram.Bounds.Y), (int)(diagram.Bounds.Bottom)));
				Size size = new Size(node.Bounds.Width, node.Bounds.Height);

				node.Bounds = new Rect(position, size);
				InitNode(node);
			}

			foreach (DiagramLink link in diagram.Links)
			{
				link.Brush = new SolidColorBrush(Colors.LightSkyBlue);
				//link.Pen = new Pen(Brushes.DarkBlue, 0.1);
				link.Stroke = Brushes.DarkBlue;
				link.StrokeThickness = 1;
				//link.HeadPen = new Pen(Brushes.DarkBlue, 1);
				link.HeadShape = ArrowHeads.Triangle;
			}

			diagram.LaneGrid[null, null].Style.BottomBorderPen = new Pen(Brushes.LightSteelBlue, 0.5);
			diagram.LaneGrid[null, null].Style.LeftBorderPen = new Pen(Brushes.LightSteelBlue, 0.5);
			diagram.LaneGrid[null, null].Style.RightBorderPen = new Pen(Brushes.LightSteelBlue, 0.5);
			diagram.LaneGrid[null, null].Style.TopBorderPen = new Pen(Brushes.LightSteelBlue, 0.5);
		}

		private void InitNode(DiagramNode node)
		{
			node.Brush = new SolidColorBrush(Colors.CornflowerBlue);
			//node.Pen = new Pen(Brushes.Navy, 0.5);
			node.Stroke = Brushes.Navy;
			node.StrokeThickness = 1;
			node.ToolTip = "Lane number: " + node.LayoutTraits[SwimlaneLayoutTraits.Lane];
		}

		private void randomizeButton_Click(object sender, RoutedEventArgs e)
		{
			Init();
			LoadFile();
		}

		private void arrangeButton_Click(object sender, RoutedEventArgs e)
		{
			// Apply SwimlaneLayout
			SwimlaneLayout layout = new SwimlaneLayout();
			layout.Anchoring = Anchoring.Reassign;
			layout.NodeDistance = 40;
			layout.LaneDistance = 30;
			layout.Arrange(diagram);

			diagram.ResizeToFitItems(10);

			// Zoom to show the whole diagram
			Rect r = diagram.Bounds;
			r.Inflate(25, 5);
			diagram.Bounds = r;
			diagramView.ZoomToRect(r);
		}

		private void diagram_NodeCreated(object sender, NodeEventArgs e)
		{
			// Assign the new node to the swimlane that contains its center
			e.Node.LayoutTraits[SwimlaneLayoutTraits.Lane] = 0;

			Rect cellBounds = new Rect();
			ICell cell = diagram.LaneGrid.GetCellFromPoint(e.Node.GetCenter(), ref cellBounds);
			if (cell != null)
			{
				int index = diagram.LaneGrid.GetCellRow(cell);
				e.Node.LayoutTraits[SwimlaneLayoutTraits.Lane] = index;
			}

			InitNode(e.Node);
		}


		private Random random;
	}
}
