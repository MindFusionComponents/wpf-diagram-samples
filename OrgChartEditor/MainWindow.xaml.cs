//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.OrgChartEditor
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			diagram.LinkHeadShape = ArrowHeads.Triangle;
			diagram.DiagramLinkStyle = new Style();
			diagram.DiagramLinkStyle.Setters.Add(new Setter(DiagramItem.BrushProperty, Brushes.Black));
			diagram.LinkHeadShapeSize = 12;
			diagram.LinkShape = LinkShape.Cascading;
			diagram.RoundedLinks = true;
			diagram.RoundedLinksRadius = 10;
			diagram.LinkSegments = 3;
			diagramView.Behavior = Behavior.Modify;
			diagramView.AllowInplaceEdit = false;
            diagramView.InplaceEditAcceptOnEnter = true;
			diagramView.InplaceEditCancelOnEsc = true;

			NodeId = -1;

            Tree = new TreeLayout
            {
                Anchoring = Anchoring.Reassign,
                Type = TreeLayoutType.Centered,
                LinkStyle = TreeLayoutLinkType.Cascading3,
                Direction = TreeLayoutDirections.TopToBottom,
                KeepRootPosition = false,
                LevelDistance = 40
            };

            HierarchyMap = new Dictionary<TableNode, int>();

            Fills = new List<Brush>(new Brush[]
            {
                new LinearGradientBrush(Colors.White, Colors.PaleGoldenrod, new Point(0, 0), new Point(0, 1)),
                new LinearGradientBrush(Colors.White, Colors.PaleGreen, new Point(0, 0), new Point(0, 1)),
                new LinearGradientBrush(Colors.White, Colors.PaleTurquoise, new Point(0, 0), new Point(0, 1)),
                new LinearGradientBrush(Colors.White, Colors.PaleVioletRed, new Point(0, 0), new Point(0, 1)),
                new LinearGradientBrush(Colors.White, Colors.PapayaWhip, new Point(0, 0), new Point(0, 1)),
                new LinearGradientBrush(Colors.White, Colors.PeachPuff, new Point(0, 0), new Point(0, 1)),
                new LinearGradientBrush(Colors.White, Colors.Peru, new Point(0, 0), new Point(0, 1)),
                new LinearGradientBrush(Colors.White, Colors.Pink, new Point(0, 0), new Point(0, 1)),
            });

			diagram.Clicked += OnDiagramClicked;
			diagram.NodeClicked += OnDiagramNodeClicked;
			diagram.CellClicked += OnTableCellClicked;
			diagram.NodeDeleted += OnDiagramNodeDeleted;
            diagram.LinkDeleted += (sender, e) => SetNodeHierarchy(e.Link.Destination as TableNode, 0);
            diagram.NodeModified += OnDiagramNodeModified;
            diagram.NodeStartModifying += OnDiagramNodeStartModifying;
            diagram.CellTextEdited += OnDiagramCellTextEdited;
            diagram.LeaveInplaceEditMode += (s, e) => editEnded = DateTime.Now;
		}

        int NextNodeId()
        {
            return ++NodeId;
        }

        void RearrangeTreeLayout()
        {
            diagram.ArrangeAnimated(Tree,
                500, Animations.AnimationType.Linear, Animations.EasingType.EaseIn);
        }

        TableNode CreateTableNode(string caption = "<TITLE>", string name = "<NAME>", string comment = "<COMMENT>")
        {
            TableNode node = new TableNode
            {
                Bounds = new Rect(0, 0, 260, 100),
                Shape = SimpleShape.RoundedRectangle,
                ColumnCount = 3,
                RowCount = 3,
                ConnectionStyle = TableConnectionStyle.Table,
                AnchorPattern = AnchorPattern.TopInBottomOut,
                Brush = new LinearGradientBrush(Colors.White, Colors.PaleTurquoise, new Point(0, 0), new Point(0, 1)),
                Stroke = Brushes.Black,
                CellFrameStyle = CellFrameStyle.None,
                HandlesStyle = HandlesStyle.HatchHandles3,
                TextAlignment = TextAlignment.Center,
                TextPadding = new Thickness(1),
            };

            node[0, 0].RowSpan = 3;
            node[0, 0].Text = "<Image>";
            node[0, 0].Image = (ImageSource)Application.Current.Resources["image1"];
            node[1, 0].Text = "Name:";
            node[1, 1].Text = "ID:";
            node[1, 2].Text = "Comment:";
            node[2, 1].Text = NextNodeId().ToString();

            node.Text = caption;
            node[2, 0].Text = name;
            node[2, 2].Text = comment;

            node.ResizeToFitText(false);
            node[0, 0].Text = "";

            diagram.Nodes.Add(node);

            return node;
        }

        void SetNodeHierarchy(TableNode node, int hierarchy)
        {
            if (HierarchyMap.ContainsKey(node) && HierarchyMap[node] == hierarchy)
                return;
            HierarchyMap[node] = hierarchy;
            SetNodeColor(node);
            foreach (DiagramLink link in node.GetAllOutgoingLinks())
                SetNodeHierarchy(link.Destination as TableNode, node);
        }

        void SetNodeHierarchy(TableNode node, TableNode bossNode)
        {
            int hierarchy;
            if (HierarchyMap.TryGetValue(bossNode, out hierarchy))
                SetNodeHierarchy(node, hierarchy + 1);
            else
                SetNodeHierarchy(node, 0);
        }

        void SetNodeColor(TableNode node)
        {
            node.Brush = HierarchyMap[node] < 7 ? Fills[HierarchyMap[node] % 8] : Fills[7];
        }

        bool AfterEdit()
        {
			var editCheck = DateTime.Now - editEnded;
            return editCheck.TotalMilliseconds < 500;
		}

		void OnDiagramClicked(object sedner, DiagramEventArgs e)
        {
            if (AfterEdit()) return;

            var editCheck = DateTime.Now - editEnded;
            if (editCheck.TotalMilliseconds < 500)
                return;

			TableNode newNode = CreateTableNode();
			newNode.Bounds = new Rect(
                e.MousePosition.X, e.MousePosition.Y, 260, 100);
			SetNodeHierarchy(newNode, 0);
			RearrangeTreeLayout();
		}

		void OnDiagramNodeClicked(object sedner, NodeEventArgs e)
        {
			if (AfterEdit()) return;

			if (e.MouseButton == MouseButton.Left)
            {
				var node = e.Node as TableNode;
				diagramView.BeginEdit(node);
			}

			if (e.MouseButton == MouseButton.Right)
			{
				var parentNode = e.Node as TableNode;
                if (parentNode != null)
                {
                    TableNode newNode = CreateTableNode();
                    newNode.Bounds = parentNode.Bounds;

                    diagram.Factory.CreateDiagramLink(parentNode, -1, newNode, -1);
                    SetNodeHierarchy(newNode, parentNode);

                    RearrangeTreeLayout();
                }
			}
		}

		void OnTableCellClicked(object sedner, CellEventArgs e)
		{
			if (AfterEdit()) return;

			if (e.MouseButton == MouseButton.Left)
			{
				var node = e.Table;
				int row = e.Row;
				int col = e.Column;
				if (col == 0)
				{
					OpenFileDialog ofd = new OpenFileDialog
					{
						Title = "Select a picture",
						Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
							"JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
							"Portable Network Graphic (*.png)|*.png"
					};
					if (ofd.ShowDialog() == true)
					{
						node[col, row].Image = new BitmapImage(new Uri(ofd.FileName));
						node[col, row].Text = string.Empty;
						node.ResizeToFitImage();
						RearrangeTreeLayout();
					}
				}
				else if (col == 2 && row != 1)
					diagramView.BeginEdit(node[col, row]);
			}

			if (e.MouseButton == MouseButton.Right)
			{
				var parentNode = e.Table;
				var newNode = CreateTableNode();
				newNode.Bounds = parentNode.Bounds;

				diagram.Factory.CreateDiagramLink(parentNode, -1, newNode, -1);
				SetNodeHierarchy(newNode, parentNode);

				RearrangeTreeLayout();
			}
		}

		void OnDiagramNodeDeleted(object sender, NodeEventArgs e)
        {
            HierarchyMap.Remove(e.Node as TableNode);
            RearrangeTreeLayout();
        }

        void OnDiagramNodeModified(object sender, NodeEventArgs e)
        {
            TableNode node = e.Node as TableNode;
            if (e.AdjustmentHandle == AdjustmentHandles.Move && node.GetAllIncomingLinks().Count == 0)
            {
                DiagramNodeCollection nodesAtPoint = diagram.GetNodesAt(e.MousePosition);
                if (nodesAtPoint.Count > 1)
                {
                    foreach (DiagramNode diagramNode in nodesAtPoint)
                    {
                        var bossNode = diagramNode as TableNode;
                        if (bossNode != null && bossNode != node)
                        {
                            diagram.Factory.CreateDiagramLink(bossNode, -1, node, -1);
                            SetNodeHierarchy(node, bossNode);
                            RearrangeTreeLayout();
                            break;
                        }
                    }
                }
            }
        }

        void OnDiagramNodeStartModifying(object sender, NodeEventArgs e)
        {
            diagramView.EndEdit(true);
        }

        void OnDiagramCellTextEdited(object sender, EditCellTextEventArgs e)
        {
            double imageWidth = e.Table.Columns[0].Width;
			e.Table.ResizeToFitText(false);
            e.Table.Columns[0].Width = imageWidth;
            var r = e.Table.Bounds;
            e.Table.Resize(imageWidth + r.Width, r.Height);

			RearrangeTreeLayout();
        }

        void OnWindowLoaded(object sender, RoutedEventArgs e)
		{
            TableNode node1 = CreateTableNode("CEO", "John Smith", "The CEO of this great company");
            node1[0, 0].Image = (ImageSource)Application.Current.Resources["image2"];
            TableNode node2 = CreateTableNode("CTO", "Bob Smith", "A great person!");
            node2[0, 0].Image = (ImageSource)Application.Current.Resources["image3"];
            TableNode node3 = CreateTableNode("HR", "Mary Johnson", "Human Relations Manager");
            node3[0, 0].Image = (ImageSource)Application.Current.Resources["image4"];
            TableNode node4 = CreateTableNode("PR", "Diana Brandson", string.Empty);
            TableNode node5 = CreateTableNode("Media", "Dave Lu", string.Empty);
            node5[0, 0].Image = (ImageSource)Application.Current.Resources["image5"];

            diagram.Factory.CreateDiagramLink(node1, -1, node2, -1);
			diagram.Factory.CreateDiagramLink(node1, -1, node3, -1);
			diagram.Factory.CreateDiagramLink(node1, -1, node4, -1);
			diagram.Factory.CreateDiagramLink(node4, -1, node5, -1);

            SetNodeHierarchy(node1, 0);
            SetNodeHierarchy(node2, 1);
            SetNodeHierarchy(node3, 1);
            SetNodeHierarchy(node4, 1);
            SetNodeHierarchy(node5, 2);

            RearrangeTreeLayout();
        }

        void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            diagramView.ZoomFactor = e.NewValue;
        }

        int NodeId;
        TreeLayout Tree { get; set; }
        Dictionary<TableNode, int> HierarchyMap { get; set; }
        List<Brush> Fills { get; set; }

        DateTime editEnded = DateTime.Now;
    }
}
