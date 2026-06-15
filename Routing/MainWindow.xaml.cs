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

using Shape = MindFusion.Diagramming.Wpf.Shape;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Routing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

			Style shapeNodeStyle = new Style();
			shapeNodeStyle.Setters.Add(new Setter(ShapeNode.BrushProperty,
				new LinearGradientBrush(Color.FromRgb(195, 200, 255), Color.FromRgb(220, 240, 255), 86)));
			diagram.ShapeNodeStyle = shapeNodeStyle;
            
            int x, y;
            for (y = 0; y < 10; y++)
            {
                double xOffset = (y % 2) * 61.44;

                for (x = 0; x < 10; x++)
                {
                    ShapeNode node = new ShapeNode(diagram);
                    node.Bounds = new Rect(
						38.4 + xOffset, 38.4 + y * 122.88, (38.4 + (x % 2) * 38.4), 38.4);
                    diagram.Nodes.Add(node);

					xOffset = xOffset + 122.88;
					xOffset = xOffset + (x % 2) * 38.4;
                }
            }

            diagram.ResizeToFitItems(38.4);

            //route arrows while they are being created
            diagram.RoutingOptions.TriggerRerouting = RerouteLinks.WhileCreating | RerouteLinks.WhenModified;

            diagram.LinkRouter = new GridRouter();
            diagram.RouteLinks = true;
			diagram.LinkShape = LinkShape.Cascading;

            turnCostTrB.Value = diagram.RoutingOptions.TurnCost;
            turnCostLb.Text = "Turn cost: " + turnCostTrB.Value;

            crossingCostTrB.Value = diagram.RoutingOptions.CrossingCost;
            crossingCostLb.Text = "Crossing cost: " + crossingCostTrB.Value;

            lengthCostTrB.Value = diagram.RoutingOptions.LengthCost;
            lengthCostLb.Text = "Length cost: " + lengthCostTrB.Value;

            nodeVicCostTrB.Value = diagram.RoutingOptions.NodeVicinityCost;
            nodeVicCostLb.Text = "Node vicinity cost: " + nodeVicCostTrB.Value;

            nodeVicSizeTrB.Value = (byte)diagram.RoutingOptions.NodeVicinitySize;
            nodeVicSizeLb.Text = "Node vicinity size: " + nodeVicSizeTrB.Value;
        }

        private void turnCostTrB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            diagram.RoutingOptions.TurnCost = (byte)turnCostTrB.Value;
            turnCostLb.Text = "Turn cost: " + (byte)turnCostTrB.Value;
        }

        private void crossingCostTrB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            diagram.RoutingOptions.CrossingCost = (byte)crossingCostTrB.Value;
			crossingCostLb.Text = "Crossing cost: " + (byte)crossingCostTrB.Value;
        }

        private void lengthCostTrB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            diagram.RoutingOptions.LengthCost = (byte)lengthCostTrB.Value;
			lengthCostLb.Text = "Length cost: " + (byte)lengthCostTrB.Value;
        }

        private void nodeVicCostTrB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            diagram.RoutingOptions.NodeVicinityCost = (byte)nodeVicCostTrB.Value;
			nodeVicCostLb.Text = "Node vicinity cost: " + (byte)nodeVicCostTrB.Value;
        }

        private void nodeVicSizeTrB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            diagram.RoutingOptions.NodeVicinitySize = nodeVicSizeTrB.Value;
			nodeVicSizeLb.Text = "Node vicinity size: " + (byte)nodeVicSizeTrB.Value;
        }

        private void rerouteAllArrowsBtn_Click(object sender, RoutedEventArgs e)
        {
            diagram.RouteAllLinks();
        }
    }
}
