//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
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

using Orientation = MindFusion.Diagramming.Wpf.Orientation;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;


namespace MindFusion.Diagramming.Wpf.Samples.CS.WorkflowDesigner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Form

        public MainWindow()
        {
            InitializeComponent();

			diagramView.Drop += new DragEventHandler(Diagram_Drop);
			diagramView.DragOver += new DragEventHandler(Diagram_DragOver);

			diagramView.InplaceEditAcceptOnEnter = true;
            //diagram.DelKeyAction = DelKeyAction.None;

            diagram.LinkHeadShape = ArrowHeads.Triangle;
            diagram.LinkHeadShapeSize = 3;

			Style linkStyle = new Style();
			linkStyle.Setters.Add(new Setter(DiagramLink.BrushProperty, Brushes.LightGray));
			diagram.DiagramLinkStyle = linkStyle;

			GlassEffect effect = new GlassEffect();
			effect.Type = GlassEffectType.Type4;
			effect.GlowColor = Colors.Black;
			diagram.NodeEffects.Add(effect);

            NewWorkflow();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            diagram.ClearAll();

            NewWorkflow();
        }

        private void btnLayout_Click(object sender, RoutedEventArgs e)
        {
            LayoutDiagram();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == true)
            {
                diagram.SaveToXml(saveFileDialog.FileName);
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
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

        #endregion

        #region Fields

        Rect defaultPosition = new Rect(0, 0, 140, 80);
        Rect smallSize = new Rect(0, 0, 20, 20);
        object dragItem = null;
        Point dragStartPoint = new Point();

        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        #endregion

        #region Cosntants

        // layout traits keys
        private const string WorkflowItemId = "WF";
        private const string PairStart = "PS";
        private const string PairEnd = "PE";
        private const string Connector = "CN";

        // size constants
        private double LevelDistance = 104;

        #endregion

        #region Drag and drop

        private void palette_MouseDown(object sender, MouseButtonEventArgs e)
        {
            dragStartPoint = new Point(e.GetPosition(palette).X, e.GetPosition(palette).Y);
            dragItem = null;
        }

        private void palette_MouseMove(object sender, MouseEventArgs e)
        {
            if (palette.SelectedIndex == -1 || e.LeftButton == MouseButtonState.Released)
                return;

            Point mousePos = e.GetPosition(palette);

            dragItem = ((ListBoxItem)palette.Items[palette.SelectedIndex]).Content;

            if (Math.Abs(dragStartPoint.X - mousePos.X) > 10 ||//SystemParameters.DragSize.Width ||
                Math.Abs(dragStartPoint.Y - mousePos.Y) > 10)//SystemInformation.DragSize.Height)
            {
                DragDrop.DoDragDrop(palette, dragItem, DragDropEffects.Copy);
            }
        }

        private void Diagram_Drop(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.None;

            DiagramLink link = LinkFromDragEvent(e);
            if (link != null && (bool)link.Tag)
            {
                e.Effects = DragDropEffects.Copy;

                string type = e.Data.GetData(typeof(string)).ToString();
                switch (type)
                {
                    case "Activity":
                        CreateActivity(link);
                        break;
                    case "IfElse":
                        CreateIfElse(link);
                        break;
                    case "While":
                        CreateWhile(link);
                        break;
                }
            }
        }

        private void Diagram_DragOver(object sender, DragEventArgs e)
        {
            DiagramLink link = LinkFromDragEvent(e);
            if (link != null && (bool)link.Tag)
                e.Effects = DragDropEffects.Copy;
            else
                e.Effects = DragDropEffects.None;
        }

        private DiagramLink LinkFromDragEvent(DragEventArgs e)
        {
            // DragEventArgs gives us the screen coordinates of a point
            // so convert them to the diagram logical coordinate system
            Point viewPoint = e.GetPosition(diagramView);
            Point diagramPoint = diagramView.ViewToDiagram(viewPoint);

            return diagram.GetLinkAt(diagramPoint, 6);
        }

        #endregion

        #region Workflow creation

        private void NewWorkflow()
        {
            diagram.Tag = 0;
            diagram.ClearAll();

            ShapeNode start = diagram.Factory.CreateShapeNode(defaultPosition, Shapes.Start);
            start.Text = "Start";
            start.Brush = Brushes.LightGreen;
            start.LayoutTraits[WorkflowItemId] = "Start";
            start.LayoutTraits[PairStart] = diagram.Tag;

            ShapeNode stop = diagram.Factory.CreateShapeNode(defaultPosition, Shapes.Terminator);
            stop.Text = "Stop";
            stop.Brush = Brushes.Red;
            stop.LayoutTraits[PairEnd] = diagram.Tag;

            CreateLink(start, stop, true, "ControlFlow");

			diagramView.Behavior = Behavior.Modify;

            LayoutDiagram();
            diagram.Tag = (int)diagram.Tag + 1;
        }

        private void CreateActivity(DiagramLink link)
        {
            ShapeNode origin = link.Origin as ShapeNode;
            ShapeNode dest = link.Destination as ShapeNode;

            string oldLogicID = link.LayoutTraits[Connector].ToString();
            diagram.Links.Remove(link);

            ShapeNode newActivity = diagram.Factory.CreateShapeNode(defaultPosition, Shapes.Process);
            newActivity.LayoutTraits[WorkflowItemId] = "Activity";

            CreateLink(origin, newActivity, true, oldLogicID);
            CreateLink(newActivity, dest, true, "ControlFlow");

            LayoutDiagram();

			diagramView.BeginEdit(newActivity);
        }

        private void CreateIfElse(DiagramLink link)
        {
            ShapeNode origin = link.Origin as ShapeNode;
            ShapeNode dest = link.Destination as ShapeNode;

            string oldLogicID = link.LayoutTraits[Connector].ToString();
            diagram.Links.Remove(link);

            ShapeNode decision = diagram.Factory.CreateShapeNode(defaultPosition, Shapes.Decision);
            decision.Text = "Condition";
            decision.LayoutTraits[WorkflowItemId] = "IfElse";
            decision.LayoutTraits[PairStart] = diagram.Tag;

            ShapeNode endIf = diagram.Factory.CreateShapeNode(smallSize, Shapes.Ellipse);
            endIf.Text = "";
            endIf.LayoutTraits[PairEnd] = diagram.Tag;

            CreateLink(origin, decision, true, oldLogicID);
            CreateLink(decision, endIf, true, "Yes");
            CreateLink(decision, endIf, true, "No");
            CreateLink(endIf, dest, true, "ControlFlow");

            LayoutDiagram();
            diagram.Tag = (int)diagram.Tag + 1;
        }

        private void CreateWhile(DiagramLink link)
        {
            ShapeNode origin = link.Origin as ShapeNode;
            ShapeNode dest = link.Destination as ShapeNode;

            string oldLogicID = link.LayoutTraits[Connector].ToString();
            diagram.Links.Remove(link);

            ShapeNode loopStart = diagram.Factory.CreateShapeNode(defaultPosition, Shapes.BeginLoop);
            loopStart.LayoutTraits[WorkflowItemId] = "While";
            loopStart.Text = "while";
            loopStart.LayoutTraits[PairStart] = diagram.Tag;

            ShapeNode loopEnd = diagram.Factory.CreateShapeNode(defaultPosition, Shapes.EndLoop);
            loopEnd.Text = "end while";
            loopEnd.LayoutTraits[PairEnd] = diagram.Tag;

            CreateLink(origin, loopStart, true, oldLogicID);
            CreateLink(loopStart, loopEnd, true, "ControlFlow");
            CreateLink(loopEnd, dest, true, "ControlFlow");

            DiagramLink backLink = CreateLink(loopEnd, loopStart, false, "While");
            backLink.IgnoreLayout = true;

            LayoutDiagram();
            diagram.Tag = (int)diagram.Tag + 1;
        }

        private DiagramLink CreateLink(ShapeNode n1, ShapeNode n2,
            bool acceptActivities, string logicID)
        {
            DiagramLink link = diagram.Factory.CreateDiagramLink(n1, n2);
            link.Tag = acceptActivities;
            if (acceptActivities)
                link.Text = "drop here";

            link.LayoutTraits[Connector] = logicID;

            return link;
        }

        #endregion

        #region Workflow layout

        private void LayoutDiagram()
        {
			diagramView.EndEdit(true);

			try
			{
				LayoutBranch(diagram.Nodes[0], 0);
				diagram.ResizeToFitItems(40);
			}
			catch
			{
				MessageBox.Show("The diagram is not valid.");
			}
        }

        private void LayoutBranch(DiagramNode node, int branchEnd)
        {
            if (node.LayoutTraits[PairEnd] != null &&
                (int)node.LayoutTraits[PairEnd] == branchEnd)
                return;

            DiagramNode continueFrom = null;

            int endMarker = node.LayoutTraits[PairStart] == null ?
                branchEnd : (int)node.LayoutTraits[PairStart];

            if ("IfElse".Equals(node.LayoutTraits[WorkflowItemId]))
            {
                DiagramLink trueLink = GetOutLink(node, "Yes");
                DiagramLink falseLink = GetOutLink(node, "No");
                continueFrom = GetPairEnd(endMarker);

                // layout the "true" branch at the left side under the decision node
                if (trueLink.Destination != continueFrom)
                {
                    double rightWidth = GetRightWidth(trueLink.Destination, endMarker);
                    DiagramNode branchStart = trueLink.Destination;
                    branchStart.Bounds = new Rect(node.Bounds.Left +
                        node.Bounds.Width / 2 - rightWidth - branchStart.Bounds.Width / 2 - 20,
                        node.Bounds.Bottom + LevelDistance, branchStart.Bounds.Width, branchStart.Bounds.Height);
                    LayoutBranch(branchStart, endMarker);
                }

                // layout the "false" branch at the right side under the decision node
                if (falseLink.Destination != continueFrom)
                {
                    double leftWidth = GetLeftWidth(falseLink.Destination, endMarker);
                    DiagramNode branchStart = falseLink.Destination;
                    branchStart.Bounds = new Rect(node.Bounds.Right -
                        node.Bounds.Width / 2 + leftWidth - branchStart.Bounds.Width / 2 + 20,
                        node.Bounds.Bottom + LevelDistance, branchStart.Bounds.Width, branchStart.Bounds.Height);
                    LayoutBranch(branchStart, endMarker);
                }

                // continue the layout below the longer branch
                Rect bb = continueFrom.Bounds;
                DiagramNode e1 = continueFrom.IncomingLinks[0].Origin;
                DiagramNode e2 = continueFrom.IncomingLinks[1].Origin;
                continueFrom.Bounds = new Rect(
                    node.Bounds.Left + node.Bounds.Width / 2 - bb.Width / 2,
                    Math.Max(e1.Bounds.Bottom, e2.Bounds.Bottom) + LevelDistance,
                    bb.Width, bb.Height);

                // bend the "true" link
                if (trueLink.Destination != continueFrom)
                    BendLinkLeftDown(trueLink);
                else
                    BendLinkLeftDownRight(trueLink);

                // bend the "false" link
                if (falseLink.Destination != continueFrom)
                    BendLinkRightDown(falseLink);
                else
                    BendLinkRightDownLeft(falseLink);

                // bend the branch ending links
                for (int l = 0; l < 2; ++l)
                {
                    if (continueFrom.IncomingLinks[l].Origin != node)
                    {
                        DiagramLink link = continueFrom.IncomingLinks[l];
                        BendLinkDownLOR(link);
                    }
                }
            }
            else if ("Activity".Equals(node.LayoutTraits[WorkflowItemId]) ||
                "Start".Equals(node.LayoutTraits[WorkflowItemId]) ||
                node.LayoutTraits[WorkflowItemId] == null)
            {
                continueFrom = GetOutLink(node, "ControlFlow").Destination;
                Rect bb = continueFrom.Bounds;
                continueFrom.Bounds = new Rect(
                    node.Bounds.Left + node.Bounds.Width / 2 - bb.Width / 2,
                    node.Bounds.Bottom + LevelDistance,
                    bb.Width, bb.Height);

                DiagramLink link = GetOutLink(node, "ControlFlow");
                SetLinkStraight(link);
            }
            else if ("While".Equals(node.LayoutTraits[WorkflowItemId]))
            {
                DiagramNode branchStart = GetOutLink(node, "ControlFlow").Destination;
                Rect bb = branchStart.Bounds;
                branchStart.Bounds = new Rect(
                    node.Bounds.Left + node.Bounds.Width / 2 - bb.Width / 2,
                    node.Bounds.Bottom + LevelDistance,
                    bb.Width, bb.Height);
                LayoutBranch(branchStart, endMarker);

                DiagramLink link = GetOutLink(node, "ControlFlow");
                SetLinkStraight(link);

                double rightWidth = GetRightWidth(branchStart, endMarker);
                continueFrom = GetPairEnd(endMarker);

                DiagramLink backLink = GetOutLink(continueFrom, "While");
                BendBackLink(backLink, rightWidth);
            }

            if (continueFrom != null)
                LayoutBranch(continueFrom, branchEnd);
        }

        private DiagramNode GetPairEnd(int pairId)
        {
            foreach (DiagramNode node in diagram.Nodes)
            {
                if (node.LayoutTraits[PairEnd] != null &&
                    (int)node.LayoutTraits[PairEnd] == pairId)
                    return node;
            }

            return null;
        }

        private DiagramLink GetOutLink(DiagramNode node, string id)
        {
            foreach (DiagramLink link in node.OutgoingLinks)
            {
                if (link.LayoutTraits[Connector] is string &&
                    (string)link.LayoutTraits[Connector] == id)
                    return link;
            }

            return null;
        }

        // should merge the next 3 methods into a single one,
        // and calculate the width according to a parameter

        private double GetBranchWidth(DiagramNode node, int branchEnd)
        {
            double branchWidth = node.Bounds.Width;
            if (node.LayoutTraits[PairEnd] != null &&
                (int)node.LayoutTraits[PairEnd] == branchEnd)
                return branchWidth;

            int endMarker = node.LayoutTraits[PairStart] == null ? branchEnd : (int)node.LayoutTraits[PairStart];

            if ("IfElse".Equals(node.LayoutTraits[WorkflowItemId]))
            {
                DiagramLink trueLink = GetOutLink(node, "Yes");
                DiagramLink falseLink = GetOutLink(node, "No");
                branchWidth = Math.Max(node.Bounds.Width, 40 +
                    GetBranchWidth(trueLink.Destination, endMarker) +
                        GetBranchWidth(falseLink.Destination, endMarker)) + 40;
            }
            else if ("Activity".Equals(node.LayoutTraits[WorkflowItemId]) ||
                node.LayoutTraits[WorkflowItemId] == null)
            {
                branchWidth = Math.Max(node.Bounds.Width,
                    GetBranchWidth(GetOutLink(node, "ControlFlow").Destination, endMarker));
            }
            else if ("While".Equals(node.LayoutTraits[WorkflowItemId]))
            {
                branchWidth = 20 + Math.Max(node.Bounds.Width,
                    GetBranchWidth(GetOutLink(node, "ControlFlow").Destination, endMarker));
            }

            if (node.LayoutTraits[PairStart] != null)
            {
                int branchEndIdx = (int)node.LayoutTraits[PairStart];
                if (branchEndIdx != branchEnd)
                {
                    branchWidth = Math.Max(branchWidth,
                        GetBranchWidth(GetPairEnd(branchEndIdx), branchEnd));
                }
            }

            return branchWidth;
        }

        private double GetLeftWidth(DiagramNode node, int branchEnd)
        {
            double branchWidth = node.Bounds.Width / 2;
            if (node.LayoutTraits[PairEnd] != null &&
                (int)node.LayoutTraits[PairEnd] == branchEnd)
                return branchWidth;

            int endMarker = node.LayoutTraits[PairStart] == null ? branchEnd : (int)node.LayoutTraits[PairStart];

            if ("IfElse".Equals(node.LayoutTraits[WorkflowItemId]))
            {
                DiagramLink trueLink = GetOutLink(node, "Yes");
                branchWidth = Math.Max(node.Bounds.Width / 2, 20 +
                    GetBranchWidth(trueLink.Destination, endMarker)) + 20;
            }
            else if ("Activity".Equals(node.LayoutTraits[WorkflowItemId]) ||
                node.LayoutTraits[WorkflowItemId] == null)
            {
                branchWidth = Math.Max(node.Bounds.Width / 2,
                    GetLeftWidth(GetOutLink(node, "ControlFlow").Destination, endMarker));
            }
            else if ("While".Equals(node.LayoutTraits[WorkflowItemId]))
            {
                branchWidth = Math.Max(node.Bounds.Width / 2,
                    GetLeftWidth(GetOutLink(node, "ControlFlow").Destination, endMarker));
            }

            if (node.LayoutTraits[PairStart] != null)
            {
                int branchEndIdx = (int)node.LayoutTraits[PairStart];
                if (branchEndIdx != branchEnd)
                {
                    branchWidth = Math.Max(branchWidth,
                        GetLeftWidth(GetPairEnd(branchEndIdx), branchEnd));
                }
            }

            return branchWidth;
        }

        private double GetRightWidth(DiagramNode node, int branchEnd)
        {
            double branchWidth = node.Bounds.Width / 2;
            if (node.LayoutTraits[PairEnd] != null &&
                (int)node.LayoutTraits[PairEnd] == branchEnd)
                return branchWidth;

            int endMarker = node.LayoutTraits[PairStart] == null ? branchEnd : (int)node.LayoutTraits[PairStart];

            if ("IfElse".Equals(node.LayoutTraits[WorkflowItemId]))
            {
                DiagramLink falseLink = GetOutLink(node, "No");
                branchWidth = Math.Max(node.Bounds.Width / 2, 20 +
                    GetBranchWidth(falseLink.Destination, endMarker)) + 20;
            }
            else if ("Activity".Equals(node.LayoutTraits[WorkflowItemId]) ||
                node.LayoutTraits[WorkflowItemId] == null)
            {
                branchWidth = Math.Max(node.Bounds.Width / 2,
                    GetRightWidth(GetOutLink(node, "ControlFlow").Destination, endMarker));
            }
            else if ("While".Equals(node.LayoutTraits[WorkflowItemId]))
            {
                branchWidth = 5 + Math.Max(node.Bounds.Width / 2,
                    GetRightWidth(GetOutLink(node, "ControlFlow").Destination, endMarker));
            }

            if (node.LayoutTraits[PairStart] != null)
            {
                int branchEndIdx = (int)node.LayoutTraits[PairStart];
                if (branchEndIdx != branchEnd)
                {
                    branchWidth = Math.Max(branchWidth,
                        GetRightWidth(GetPairEnd(branchEndIdx), branchEnd));
                }
            }

            return branchWidth;
        }

        private Point GetLeftMiddle(DiagramNode node)
        {
            return new Point(
                node.Bounds.Left, node.Bounds.Top + node.Bounds.Height / 2);
        }

        private Point GetRightMiddle(DiagramNode node)
        {
            return new Point(
                node.Bounds.Right, node.Bounds.Top + node.Bounds.Height / 2);
        }

        private Point GetTopMiddle(DiagramNode node)
        {
            return new Point(
                node.Bounds.Left + node.Bounds.Width / 2, node.Bounds.Top);
        }

        private Point GetBottomMiddle(DiagramNode node)
        {
            return new Point(
                node.Bounds.Left + node.Bounds.Width / 2, node.Bounds.Bottom);
        }

        private void BendLinkLeftDown(DiagramLink link)
        {
            link.CascadeOrientation = Orientation.Horizontal;
            link.Shape = LinkShape.Cascading;
            link.SegmentCount = 2;
            Point pt1 = GetLeftMiddle(link.Origin);
            Point pt2 = GetTopMiddle(link.Destination);
            link.ControlPoints[0] = pt1;
            link.ControlPoints[1] = new Point(pt2.X, pt1.Y);
            link.ControlPoints[2] = pt2;
            link.UpdateFromPoints();
        }

        private void BendLinkLeftDownRight(DiagramLink link)
        {
            link.CascadeOrientation = Orientation.Horizontal;
			link.Shape = LinkShape.Cascading;
            link.SegmentCount = 3;
            Point pt1 = GetLeftMiddle(link.Origin);
            Point pt2 = GetLeftMiddle(link.Destination);
            link.ControlPoints[0] = pt1;
            link.ControlPoints[1] = new Point(pt1.X - 10, pt1.Y);
            link.ControlPoints[2] = new Point(pt1.X - 10, pt2.Y);
            link.ControlPoints[3] = pt2;
            link.UpdateFromPoints();
        }

        private void BendLinkRightDown(DiagramLink link)
        {
            link.CascadeOrientation = Orientation.Horizontal;
			link.Shape = LinkShape.Cascading;
            link.SegmentCount = 2;
            Point pt1 = GetRightMiddle(link.Origin);
            Point pt2 = GetTopMiddle(link.Destination);
            link.ControlPoints[0] = pt1;
            link.ControlPoints[1] = new Point(pt2.X, pt1.Y);
            link.ControlPoints[2] = pt2;
            link.UpdateFromPoints();
        }

        private void BendLinkRightDownLeft(DiagramLink link)
        {
            link.CascadeOrientation = Orientation.Horizontal;
			link.Shape = LinkShape.Cascading;
            link.SegmentCount = 3;
            Point pt1 = GetRightMiddle(link.Origin);
            Point pt2 = GetRightMiddle(link.Destination);
            link.ControlPoints[0] = pt1;
            link.ControlPoints[1] = new Point(pt1.X + 20, pt1.Y);
            link.ControlPoints[2] = new Point(pt1.X + 20, pt2.Y);
            link.ControlPoints[3] = pt2;
            link.UpdateFromPoints();
        }

        private void BendLinkDownLOR(DiagramLink link)
        {
            link.CascadeOrientation = Orientation.Vertical;
			link.Shape = LinkShape.Cascading;
            link.SegmentCount = 2;
            Point pt1 = GetBottomMiddle(link.Origin);
            Point pt2 = pt1.X > GetBottomMiddle(link.Destination).X ?
                GetRightMiddle(link.Destination) : GetLeftMiddle(link.Destination);
            link.ControlPoints[0] = pt1;
            link.ControlPoints[1] = new Point(pt1.X, pt2.Y);
            link.ControlPoints[2] = pt2;
            link.UpdateFromPoints();
        }

        private void BendBackLink(DiagramLink link, double offset)
        {
            link.CascadeOrientation = Orientation.Horizontal;
			link.Shape = LinkShape.Cascading;
            link.SegmentCount = 3;
            Point pt1 = GetRightMiddle(link.Origin);
            Point pt2 = GetRightMiddle(link.Destination);
            double m = GetBottomMiddle(link.Destination).X;
            link.ControlPoints[0] = pt1;
            link.ControlPoints[1] = new Point(m + offset + 20, pt1.Y);
            link.ControlPoints[2] = new Point(m + offset + 20, pt2.Y);
            link.ControlPoints[3] = pt2;
            link.UpdateFromPoints();
        }

        private void SetLinkStraight(DiagramLink link)
        {
			link.Shape = LinkShape.Polyline;
            link.SegmentCount = 1;
            link.ControlPoints[0] = GetBottomMiddle(link.Origin);
            link.ControlPoints[1] = GetTopMiddle(link.Destination);
            link.UpdateFromPoints();
        }

        #endregion
    }
}
