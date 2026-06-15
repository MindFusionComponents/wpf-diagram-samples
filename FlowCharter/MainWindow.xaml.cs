//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

using Shape = MindFusion.Diagramming.Wpf.Shape;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;
using MouseButton = MindFusion.Diagramming.Wpf.MouseButton;

using MindFusion.Diagramming.Wpf.Commands;


namespace MindFusion.Diagramming.Wpf.Samples.CS.FlowCharter
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		MenuItem mIDelete = null;

		public MainWindow()
		{
			InitializeComponent();

			XmlDocument document = new XmlDocument();
			document.LoadXml(Properties.Resources.Diagram);
			diagram.LoadFromXml(document);

			foreach (var node in diagram.Nodes)
				node.ClearValue(ShapeNode.BrushProperty);

			foreach (var link in diagram.Links)
			{
				var dx = link.EndPoint.X - link.StartPoint.X;
				var dy = link.EndPoint.Y - link.StartPoint.Y;
				if (dx < -2 * dy)
				{
					link.OriginAnchor = 1;
					link.Route();
				}
			}

			diagram.NodeCreated += (s, e) =>
				{
					e.Node.ClearValue(ShapeNode.BrushProperty);
					e.Node.EnabledHandles = AdjustmentHandles.All;
					e.Node.TextAlignment = TextAlignment.Center;
					e.Node.TextVerticalAlignment = AlignmentY.Center;
					var containerNode = e.Node as ContainerNode;
					if (containerNode != null)
						containerNode.Margin = 4;
				};
			diagram.EnterInplaceEditMode += (s, e) =>
				{
                    e.EditControl.FontSize = e.Item.GetDiagramItem().FontSize;
					e.EditControl.Padding = new Thickness(0);
				};
			diagram.Selection.StrokeThickness = 0.2;

			mIDelete = new MenuItem();
			mIDelete.Header = "Delete";
			mIDelete.Click += new RoutedEventHandler(mIDelete_Click);
			
			_contextMenu = new ContextMenu();
			_contextMenu.Items.Add(mIDelete);
			this.ContextMenu = _contextMenu;

			SolidColorBrush defAnch = new SolidColorBrush(Colors.Red);

			_nodes = new Node[]
				{
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Alternative.Id), // get shape by string id
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(30, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.PunchedCard.Id),
					new Node(
						AnchorPattern.Decision2In2Out,
						Shapes.Decision.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Delay.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(15, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(15, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.DirectAccessStorage.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 20, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 80, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 80, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 20, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.DiskStorage.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(40, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(40, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Display.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.DividedEvent.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.DividedProcess.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Document.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.InternalStorage.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(25, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(75, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 25, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 25, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.BeginLoop.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 40, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Input.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(80, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.ManualOperation.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(80, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.MessageFromUser.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(20, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.MessageToUser.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(45, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.MultiDocument.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 10, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 10, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 10, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Microform.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(80, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.PrimitiveFromCall.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(20, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.PrimitiveToCall.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Procedure.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(15, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 70, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(15, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 70, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Start.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch)
						}),
						Shapes.Tape.Id),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 52, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 52, true, true, MarkStyle.Circle, defAnch)
						}),
						"Table2x2"),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 52, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 74, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 30, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 52, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 74, true, true, MarkStyle.Circle, defAnch)
						}),
						"Table3x3"),
					new Node(
						new AnchorPattern(new AnchorPoint[]
						{
							new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
							new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch)
						}),
						"Container")
				};
			
			_connectors = new Connector[]
				{
					new Connector(
						ArrowHeads.Arrow,
						"Arrow"),
					new Connector(
						ArrowHeads.BackSlash,
						"Back slash"),
					new Connector(
						ArrowHeads.BowArrow,
						"Bow arrow"),
					new Connector(
						ArrowHeads.Circle,
						"Circle"),
					new Connector(
						ArrowHeads.DoubleArrow,
						"Double arrow"),
					new Connector(
						ArrowHeads.None,
						"None"),
					new Connector(
						ArrowHeads.Pentagon,
						"Pentagon"),
					new Connector(
						ArrowHeads.PointerArrow,
						"Pointer"),
					new Connector(
						ArrowHeads.Quill,
						"Quill"),
					new Connector(
						ArrowHeads.Reversed,
						"Reversed"),
					new Connector(
						ArrowHeads.RevTriangle,
						"Reversed triangle"),
					new Connector(
						ArrowHeads.RevWithCirc,
						"Reversed with Circle"),
					new Connector(
						ArrowHeads.RevWithLine,
						"Reversed with Line"),
					new Connector(
						ArrowHeads.Rhombus,
						"Rhombus"),
					new Connector(
						ArrowHeads.Slash,
						"Slash"),
					new Connector(
						ArrowHeads.Tetragon,
						"Tetragon"),
					new Connector(
						ArrowHeads.Triangle,
						"Triangle")
				};
			foreach (Connector c in _connectors)
				InitConnectorListItems(c);

			_connectorList.SelectedIndex = 0;

			diagram.UndoManager.UndoEnabled = true;
			diagram.UndoManager.History.Capacity = 30;
			diagram.Bounds = new Rect(0, 0, 219, 297);

			diagram.ActiveItemHandlesStyle.HandlePen.Thickness = 0.2;
			diagram.SelectedItemHandlesStyle.HandlePen.Thickness = 0.2;
			diagram.LinkHeadShapeSize = 6;
			diagram.CellFrameStyle = CellFrameStyle.None;

			diagram.RoutingOptions.TriggerRerouting |= RerouteLinks.WhileCreating;
			diagram.RouteLinks = true;

			originalShapeNodeStyle = diagram.ShapeNodeStyle;
			originalDiagramLinkStyle = diagram.DiagramLinkStyle;
		}

		void mIDelete_Click(object sender, RoutedEventArgs e)
		{
			if (diagram.ActiveItem == null)
				return;

			diagram.Items.Remove(diagram.ActiveItem);
		}

		void InitConnectorListItems(Connector c)
		{
			Grid sp = new Grid();
			//sp.Background = Brushes.White;
			sp.Height = 25;
			sp.Width = 157;

			TextBlock textBlock = new TextBlock();
			//textBlock.Background = Brushes.White;
			textBlock.Text = c.Name;
			textBlock.VerticalAlignment = VerticalAlignment.Top;
			textBlock.HorizontalAlignment = HorizontalAlignment.Left;
			textBlock.Width = 80;
			textBlock.Height = 30;
			textBlock.Margin = new Thickness(25, 0, 0, 0);

			var drawingVisual = new DrawingVisual();
			var drawingContext = drawingVisual.RenderOpen();
			var defaultStroke = GetStyleValue(
				diagram.DiagramLinkStyle, DiagramLink.StrokeProperty) as Brush;
			var defaultBrush = GetStyleValue(
				diagram.DiagramLinkStyle, DiagramLink.BrushProperty) as Brush;
			drawingContext.DrawLine(
				new Pen(defaultStroke, 1), new Point(1, 8), new Point(16, 8));
			DiagramLink.DrawArrowhead(
				drawingContext, new Pen(defaultStroke, 1), defaultBrush,
				c.Head, new Point(50, 0), new Point(16, 8), new Point(1, 8), 12);
			drawingContext.Close();

			sp.Children.Add(new VisualHost(drawingVisual));
			sp.Children.Add(textBlock);
			
			_connectorList.Items.Add(sp);
		}

		public class VisualHost : FrameworkElement
		{
			protected override int VisualChildrenCount
			{
				get 
				{ 
					return 1;
				}
			}

			protected override Visual GetVisualChild(int index)
			{
				return visual;
			}

			public VisualHost(DrawingVisual visual)
			{
				this.visual = visual;
			}

			DrawingVisual visual;
		}

		Node[] _nodes = null;
		Connector[] _connectors = null;

		void mIFNew_Click(object sender, RoutedEventArgs e)
		{
			diagram.ClearAll();
		}

		void mIFOpen_Click(object sender, RoutedEventArgs e)
		{
			if (openFileDialog.ShowDialog() == true)
			{
				try
				{
					diagram.LoadFromXml(openFileDialog.FileName);
				}
				catch
				{
					MessageBox.Show("Invalid file format.");
				}
			}
		}

		void mIFSave_Click(object sender, RoutedEventArgs e)
		{
			if (saveFileDialog.ShowDialog() == true)
			{
				diagram.SaveToXml(saveFileDialog.FileName);
			}
		}

		void mIFPreview_Click(object sender, RoutedEventArgs e)
		{
			if (diagram.Items.Count == 0)
				return;

			diagram.PrintOptions.DocumentName = "Flowchart";
			diagram.PrintOptions.EnableImages = false;
			diagram.PrintOptions.EnableInterior = true;
			diagram.PrintOptions.EnableShadows = true;
			diagram.PrintOptions.Scale = 100;
			diagram.PrintPreview();
		}

		void mIFPrint_Click(object sender, RoutedEventArgs e)
		{
			if (diagram.Items.Count == 0)
				return;

			diagram.PrintOptions.DocumentName = "Flowchart";
			diagram.PrintOptions.EnableImages = false;
			diagram.PrintOptions.EnableInterior = true;
			diagram.PrintOptions.EnableShadows = true;
			diagram.PrintOptions.Scale = 100;
			diagram.Print();
		}

		void mIExit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		OpenFileDialog openFileDialog = new OpenFileDialog();
		SaveFileDialog saveFileDialog = new SaveFileDialog();

		void mIEdit_Click(object sender, RoutedEventArgs e)
		{
			if (diagram.UndoManager.History.NextUndo != null)
			{
				mIEUndo.IsEnabled = true;
				mIEUndo.Header = "Undo " + diagram.UndoManager.History.NextUndo.Title;
			}
			else
			{
				mIEUndo.IsEnabled = false;
				mIEUndo.Header = "Undo";
			}
			if (diagram.UndoManager.History.NextRedo != null)
			{
				mIERedo.IsEnabled = true;
				mIERedo.Header = "Redo " + diagram.UndoManager.History.NextRedo.Title;
			}
			else
			{
				mIERedo.IsEnabled = false;
				mIERedo.Header = "Redo";
			}
		}

		void mIEUndo_Click(object sender, RoutedEventArgs e)
		{
			diagram.UndoManager.Undo();
		}

		void mIERedo_Click(object sender, RoutedEventArgs e)
		{
			diagram.UndoManager.Redo();
		}

		

		NodeProps _selected;

		void diagram_NodeDeactivated(object sender, NodeEventArgs e)
		{
			_propertyGrid.SelectedObject = null;
			_selected = null;
		}

		void diagram_LinkClicked(object sender, LinkEventArgs e)
		{
			if (e.MouseButton != MouseButton.Right)
				return;

			diagram.Selection.Clear();
			e.Link.Selected = true;

			Point pt = diagramView.DiagramToView(e.MousePosition);
			_contextMenu.PlacementRectangle = new Rect(pt, new Size());
			_contextMenu.Visibility = Visibility.Visible;
			//	Show(diagram, pt);
		}

		void diagram_NodeClicked(object sender, NodeEventArgs e)
		{
			if (e.MouseButton != MouseButton.Right)
				return;

			diagram.Selection.Clear();
			e.Node.Selected = true;
			
			Point pt = diagramView.DiagramToView(e.MousePosition);
			_contextMenu.PlacementRectangle = new Rect(pt, new Size());
			_contextMenu.Visibility = Visibility.Visible;
		}

		ContextMenu _contextMenu;

		void diagram_NodeActivated(object sender, NodeEventArgs e)
		{
			_selected = new NodeProps();
			_selected.Text = e.Node.Text;
			_selected.Brush = e.Node.Brush as SolidColorBrush;

			_propertyGrid.SelectedObject = _selected;
		}

		void _propertyGrid_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			if (diagram.Selection.Nodes.Count == 0)
				return;

			DiagramNode b = diagram.Selection.Nodes[0] as DiagramNode;
			if (b == null)
				return;
			
			
			// Create undo record
			ChangeItemCmd cmd =
				new ChangeItemCmd(b, "Property change");

			b.Text = _selected.Text;
			b.Brush = _selected.Brush;
			b.Selected = false;

			cmd.Execute();
			b.Selected = true;
		}

		void mITOptions_Click(object sender, RoutedEventArgs e)
		{
			OptionsDialog dlg = new OptionsDialog();

			dlg.ShowGrid = diagram.ShowGrid;
			dlg.BackBrush = diagram.BackBrush as SolidColorBrush;
			dlg.NodeBrush = GetStyleValue(
				diagram.ShapeNodeStyle, ShapeNode.BrushProperty) as SolidColorBrush;
			dlg.ConnectorBrush = GetStyleValue(
				diagram.DiagramLinkStyle, DiagramLink.BrushProperty) as SolidColorBrush;
			dlg.AnchorBrush = _anchorBrush;

			dlg.ShowAnchors = diagram.ShowAnchors != ShowAnchors.Never;
			switch (_anchorStyle)
			{
				case MarkStyle.Circle:
					dlg.AnchorStyle = 0;
					break;
				case MarkStyle.Rectangle:
					dlg.AnchorStyle = 1;
					break;
				case MarkStyle.X:
					dlg.AnchorStyle = 2;
					break;
				default:
					dlg.AnchorStyle = 0;
					break;
			}

			if (dlg.ShowDialog() == true)
			{
				diagram.ShowGrid = dlg.ShowGrid;
				diagram.BackBrush = (SolidColorBrush)dlg.BackBrush;

				var shapeNodeStyle = new Style(typeof(ShapeNode), originalShapeNodeStyle);
				shapeNodeStyle.Setters.Add(new Setter(ShapeNode.BrushProperty, dlg.NodeBrush));
				diagram.ShapeNodeStyle = shapeNodeStyle;

				var diagramLinkStyle = new Style(typeof(DiagramLink), originalDiagramLinkStyle);
				diagramLinkStyle.Setters.Add(new Setter(DiagramLink.BrushProperty, dlg.ConnectorBrush));
				diagram.DiagramLinkStyle = diagramLinkStyle;

				_anchorBrush = (SolidColorBrush)dlg.AnchorBrush;

				diagram.ShowAnchors = dlg.ShowAnchors ?
					ShowAnchors.Auto : ShowAnchors.Never;
				switch (dlg.AnchorStyle)
				{
					case 0:
						_anchorStyle = MarkStyle.Circle;
						break;
					case 1:
						_anchorStyle = MarkStyle.Rectangle;
						break;
					case 2:
						_anchorStyle = MarkStyle.X;
						break;
					default:
						_anchorStyle = MarkStyle.Circle;
						break;
				}
			}
		}

		object GetStyleValue(Style style, DependencyProperty property)
		{
			foreach (Setter setter in style.Setters)
			{
				if (setter.Property == property)
					return setter.Value;
			}

			return null;
		}

		void diagram_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(DraggedItem)))
			{
				e.Effects = DragDropEffects.Copy;
			}
			else
			{
				e.Effects = DragDropEffects.None;
			}
		}

		void diagram_Drop(object sender, DragEventArgs e)
		{
			AnchorPattern ap = null;

			if (e.Data.GetDataPresent(typeof(DraggedItem)))
			{
				DiagramNode node = diagram.Nodes[diagram.Nodes.Count - 1];
				if (node is ShapeNode)
				{
					var p = diagram.AlignPointToGrid(node.Bounds.Location);
					node.Bounds = new Rect(p.X - 15, p.Y - 15, 30, 30);
					foreach (Node n in _nodes)
					{
						if (n.ShapeId.Equals(((ShapeNode)node).Shape.Id))
						{
							ap = n.AnchorPattern;
							break;
						}
					}
				}
				else if (node is TableNode)
				{
					var table = (TableNode)node;
					node.Bounds = new Rect(node.Bounds.Left - 25, node.Bounds.Top - 20, 50, 40);
					if (table.RowCount == 2)
						ap = _nodes[_nodes.Length - 3].AnchorPattern;
					else
						ap = _nodes[_nodes.Length - 2].AnchorPattern;
					table.ConnectionStyle = TableConnectionStyle.Table;
					table.CellTextStyle.FontSize = 4;
					foreach (TableNode.Row row in table.Rows)
						row.Height = 8;
				}
				else if (node is ContainerNode)
				{
					ap = _nodes[_nodes.Length - 1].AnchorPattern;
					node.Bounds = new Rect(node.Bounds.Left - 25, node.Bounds.Top - 20, 50, 40);
				}

				foreach (AnchorPoint point in ap.Points)
				{
					point.MarkStyle = _anchorStyle;
					point.Brush = _anchorBrush;
				}
				node.AnchorPattern = ap;
			}
		}

		class NodeProps
		{
			[Category("Properties")]
			[Description("The text displayed within the node.")]
			public string Text
			{
				get { return _text; }
				set { _text = value; }
			}

			[Category("Properties")]
			[Description("The interior color of the node.")]
			public Brush Brush
			{
				get { return _brush; }
				set { _brush = value; }
			}

			string _text;
			Brush _brush;
		}


		class Node
		{
			public Node(AnchorPattern anchor,
				string shapeId)
			{
				_anchor = anchor;
				_template = shapeId;
			}

			public AnchorPattern AnchorPattern
			{
				get { return _anchor; }
			}

			public string ShapeId
			{
				get { return _template; }
			}

			AnchorPattern _anchor;
			string _template;
		}

		class Connector
		{
			public Connector(Shape head, string name)
			{
				_head = head;
				_name = name;
			}

			public Shape Head
			{
				get { return _head; }
			}

			public string Name
			{
				get { return _name; }
			}

			Shape _head;
			string _name;
		}

		void _connectorTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (_connectorTypeCombo.SelectedIndex)
			{

				case 0:
					diagram.LinkShape = LinkShape.Polyline;
					break;
				case 1:
					diagram.LinkShape = LinkShape.Bezier;
					break;
				case 2:
					diagram.LinkShape = LinkShape.Cascading;
					break;
			}
		}

		void _connectorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int si = _connectorList.SelectedIndex;
			if (si < 0 || si >= _connectors.Length)
				return;

			diagram.LinkHeadShape = _connectors[si].Head;
		}


		SolidColorBrush _anchorBrush = Brushes.Red;
		MarkStyle _anchorStyle = MarkStyle.Circle;

		Style originalShapeNodeStyle;
		Style originalDiagramLinkStyle;
	}
}