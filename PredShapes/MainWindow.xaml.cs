//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

using Shape = MindFusion.Diagramming.Wpf.Shape;


namespace MindFusion.Diagramming.Wpf.Samples.CS.PredShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            diagram.SelectAfterCreate = false;

            // set colors
            diagram.BackBrush = new SolidColorBrush(Colors.Azure);

			Style shapeStyle = new Style();
			shapeStyle.Setters.Add(new Setter(ShapeNode.BrushProperty,
				new LinearGradientBrush(
					Color.FromArgb(100, 255, 255, 255),
					Color.FromArgb(255, 0, 128, 192), 45)));
			shapeStyle.Setters.Add(new Setter(ShapeNode.EffectsSourceProperty,
				new List<NodeEffect>(new NodeEffect[]
				{
					new GlassEffect()
				})));
			shapeStyle.Setters.Add(new Setter(ShapeNode.FontSizeProperty, 10.5));
			diagram.ShapeNodeStyle = shapeStyle;

            int i = 0;
			double hsize = 85;
			double vsize = 93;
            int perLine = 8;

            // enum all predefined shapes
            foreach (Shape shape in Shape.Shapes)
            {
				// skip some arrowhead shapes that aren't that useful as node shapes
				if (shape.Outline == null) continue;
				if (shape == ArrowHeads.RevWithCirc) continue;
				if (shape == ArrowHeads.DoubleArrow) continue;

                // create a node for this shape
                ShapeNode node = diagram.Factory.CreateShapeNode(
					(i % perLine) * (hsize + 20) + 8,
					(i / perLine) * (vsize + 60) + 15,
                    hsize, vsize, shape);
            	node.ToolTip = shape.Id;
				node.Stroke = new SolidColorBrush(Colors.Black);

                // attach text below the box
                var labelText = shape.Id.StartsWith("Bpmn") ?
					"Bpmn\n" + shape.Id.Substring(4) : shape.Id;

                var label = new NodeLabel(node, labelText);
                label.SetEdgePosition(
                    2,      // bottom edge
                    0, 20); // offset
                node.AddLabel(label);

                i = i + 1;
            }

            diagram.ResizeToFitItems(4, true);
        }
    }
}
