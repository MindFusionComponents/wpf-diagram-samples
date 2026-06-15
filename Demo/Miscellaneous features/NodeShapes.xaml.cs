//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
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


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for Node_shapes.xaml
	/// </summary>
	public partial class NodeShapes : Page
	{
		public NodeShapes()
		{
			InitializeComponent();

			//SetWorldFont();
			diagram.SelectAfterCreate = false;
			diagram.BackBrush = Brushes.Azure;

			Style shapeNodeStyle = new Style();
			shapeNodeStyle.Setters.Add(new Setter(ShapeNode.BrushProperty,
				new LinearGradientBrush(
					Color.FromArgb((byte)100, (byte)255, (byte)255, (byte)255),
					Color.FromArgb((byte)255, (byte)0, (byte)128, (byte)192), 45)));
			shapeNodeStyle.Setters.Add(new Setter(ShapeNode.FontFamilyProperty,
				new FontFamily("Tahoma")));
			shapeNodeStyle.Setters.Add(new Setter(ShapeNode.FontSizeProperty, 9.0));
			diagram.ShapeNodeStyle = shapeNodeStyle;

			int i = 0;
			const double hsize = 72.96;
			const double vsize = 72.96;
			const int perLine = 8;
			foreach (Shape tmpl in Shape.Shapes)
			{
				// skip some arrowhead shapes that aren't that useful as node shapes
				if (tmpl.Outline == null) continue;
				if (tmpl == ArrowHeads.RevWithCirc) continue;
				if (tmpl == ArrowHeads.DoubleArrow) continue;

				ShapeNode bb = diagram.Factory.CreateShapeNode((i % perLine) * (hsize + 19.2) + 7.68,
					(i / perLine) * (vsize + 57.6), hsize, vsize);
				bb.Shape = tmpl;

				bb.Stroke = Brushes.Black;

				Group g = diagram.Factory.CreateGroup(bb);
				bb = diagram.Factory.CreateShapeNode((i % perLine) * (hsize + 19.2) + 7.68,
					(i / perLine) * (vsize + 57.6) + vsize + 3.36, hsize, 15.72);
				bb.Text = tmpl.Id;
				bb.FontSize = 10;
				bb.Locked = true;
				bb.Transparent = true;
				bb.Shape = Shapes.Rectangle;
				bb.TextAlignment = TextAlignment.Center;
				bb.TextPadding = new Thickness(0);
				bb.ClipText = false;

				g.AttachToCorner(bb, 3);

				i++;
			}

			diagram.NodeEffects.Add(new GlassEffect());

			diagram.ResizeToFitItems(4, false);
		}
	}
}
