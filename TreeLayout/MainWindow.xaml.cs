//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

using MindFusion.Diagramming.Wpf.Layout;
using System.Windows.Media.Effects;


namespace MindFusion.Diagramming.Wpf.Samples.CS.TreeLayout
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			diagram.NodeEffects.Add(new GlassEffect());
		}

		MindFusion.Diagramming.Wpf.Layout.TreeLayout treeLayout;

		private void Rearrange()
		{
			if (treeLayout == null)
			{
				treeLayout = new MindFusion.Diagramming.Wpf.Layout.TreeLayout(rootNode,
					TreeLayoutType.Centered,
					false,
					TreeLayoutLinkType.Rounded,
					TreeLayoutDirections.TopToBottom,
					40, 20, true, new Size(10, 10));
			}

			treeLayout.Arrange(diagram);
		}

		private ShapeNode AddChild(DiagramNode node)
		{
			// create the new node and add it to the parent group
			// so its position is updated when the parent is moved
			var childNode = new ShapeNode(diagram)
        	{
				Bounds = new Rect(new Point(), NodeSize)
        	};
			childNode.Effect = new DropShadowEffect() { Opacity = 0.25 };
			diagram.Nodes.Add(childNode);
			childNode.AttachTo(node, AttachToNode.TopLeft);

			// link the parent node with the child
			var link = new DiagramLink(diagram, node, childNode);
			diagram.Links.Add(link);

			// update the counter
			uniqueId += 1;
			childNode.Tag = uniqueId;

			// rearrange the tree
			Rearrange();

			// select the new node
			diagram.Selection.Change(childNode);

			return childNode;
		}

		private ShapeNode rootNode;
		private ShapeNode currNode;

		private void OnImage1MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(image1, image1, DragDropEffects.Copy);
		}

		private void OnImage2MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(image2, image2, DragDropEffects.Copy);
		}

		private void diagram_DragOver(object sender, DragEventArgs e)
		{
			// we have the screen point of the mouse, but need it in document C.S.
			Point p = e.GetPosition(diagramView);
			Point pt = diagramView.ViewToDiagram(p);

			// allow drag and drop if there is a box
			ShapeNode box = diagram.GetNodeAt(pt) as ShapeNode;
			if (box != null)
				e.Effects = DragDropEffects.Copy;
			else
				e.Effects = DragDropEffects.None;
		}

		private void diagram_Drop(object sender, DragEventArgs e)
		{
			e.Handled = true;

			Point p = e.GetPosition(diagramView);
			Point pt = diagramView.ViewToDiagram(p);

			// allow drag and drop if there is a box
			var node = diagram.GetNodeAt(pt) as ShapeNode;
			if (node != null)
			{
				// add a child to the tree
				ShapeNode newNode = AddChild(node);
				newNode.TextAlignment = TextAlignment.Right;

				// show the node tag
				newNode.Text = "id: " + newNode.Tag;

				// if an image has been dropped
				if (e.Data.GetDataPresent(typeof(Image)))
				{
					// set as a node icon
					newNode.ImageAlign = ImageAlign.MiddleLeft;
					newNode.Image = ((Image)e.Data.GetData(typeof(Image))).Source;
				}
			}
		}

		private int uniqueId;

		private void diagram_NodeClicked(object sender, NodeEventArgs e)
		{
			// display context menu on right-click
			if (e.MouseButton == MindFusion.Diagramming.Wpf.MouseButton.Right)
			{
				currNode = e.Node as ShapeNode;
				
				// display context menu for the node
				ContextMenu cmNode = CreateNodeMenu();
				cmNode.Placement = System.Windows.Controls.Primitives.PlacementMode.Mouse;
				cmNode.IsOpen = true;
			}
		}

		private void diagram_NodeDeleting(object sender, NodeValidationEventArgs e)
		{
			if (e.Node == rootNode)
				e.Cancel = true;
		}

		private void diagram_NodeCreated(object sender, NodeEventArgs e)
		{
			Rect rc = e.Node.Bounds;
			diagram.Nodes.Remove(e.Node);

			ShapeNode child = AddChild(rootNode);
			child.Resize(rc.Width, rc.Height);
			child.Text = "right-click me!";
		}

		ContextMenu CreateNodeMenu()
		{
			ContextMenu cmNode = new ContextMenu();

			MenuItem miProperties = new MenuItem();
			miProperties.Header = "Add child";
			miProperties.Click += miProperties_Click;
			cmNode.Items.Add(miProperties);

			return cmNode;
		}

		void miProperties_Click(object sender, RoutedEventArgs e)
		{
			if (currNode != null)
				AddChild(currNode);
			currNode = null;
		}

		private void diagram_LinkModifying(object sender, LinkValidationEventArgs e)
		{
			e.Cancel = true;
		}

		private void diagram_LinkCreating(object sender, LinkValidationEventArgs e)
		{
			e.Cancel = true;
		}

		private void diagram_LinkSelecting(object sender, LinkValidationEventArgs e)
		{
			e.Cancel = true;
		}

		private void diagram_Loaded(object sender, RoutedEventArgs e)
		{
			// create the root of the tree
			rootNode = new ShapeNode(diagram);
			rootNode.Effect = new DropShadowEffect() { Opacity = 0.25 };
			rootNode.Bounds = new Rect(new Point(190, 60), NodeSize);
			rootNode.Text = "right-click me!";
			rootNode.Tag = 0;
			rootNode.Selected = true;
			diagram.Nodes.Add(rootNode);
		}

		private static readonly Size NodeSize = new Size(70, 40);
	}
}
