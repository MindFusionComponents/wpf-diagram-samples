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


namespace MindFusion.Diagramming.Wpf.Samples.CS.Ternary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            diagram.DefaultShape = Shapes.Ellipse;

			ShapeNode b1 = diagram.Factory.CreateShapeNode(40, 40, 135, 60);
			ShapeNode b2 = diagram.Factory.CreateShapeNode(385, 40, 135, 60);

            DiagramLink link = diagram.Factory.CreateDiagramLink(b1, b2);

			ShapeNode b3 = diagram.Factory.CreateShapeNode(195, 270, 135, 60);
			b3.Text = "Draw a new link from here to the link above.";
        }

        private void diagram_LinkCreated(object sender, LinkEventArgs e)
        {
            DiagramLink a = e.Link;
            // if not connected to a real node
            if (a.Destination is DummyNode)
            {
                Point endPt = a.EndPoint;
                a.Locked = true; // so we can exclude it from the search
                DiagramLink trg = diagram.GetLinkAt(endPt, 6, true);
                if (trg != null)
                {
                    DiagramNode n1 = trg.Origin;
                    DiagramNode n2 = trg.Destination;
                    DiagramNode n3 = a.Origin;

                    ShapeNode connector = diagram.Factory.CreateShapeNode(
						endPt.X - 9.6, endPt.Y - 9.6, 19.2, 19.2);
                    connector.Shape = Shapes.Decision;

                    diagram.Factory.CreateDiagramLink(connector, n1);
                    diagram.Factory.CreateDiagramLink(connector, n2);
                    diagram.Factory.CreateDiagramLink(connector, n3);

                    diagram.Links.Remove(trg);

                    // setup the connector box
                    diagram.Selection.Clear();
                    connector.Selected = true;
                    connector.HandlesStyle = HandlesStyle.MoveOnly;
                    connector.Brush = Brushes.Khaki;
                }

                diagram.Links.Remove(a);
            }
        }

        private void diagram_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point pt = e.GetPosition(diagram);
                DiagramLink link = diagram.GetLinkAt(pt, 6, true);
                diagram.AllowLinkCursor = link == null ? Cursors.No : Cursors.Hand;
            }
        }
    }
}