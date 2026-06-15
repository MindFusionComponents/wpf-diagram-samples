//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Media;

using MindFusion.Diagramming.Wpf;


namespace MindFusion.Diagramming.Wpf.Samples.CS.JavaScript
{
	static class Notation
	{
		public static ShapeNode CreateStartTerminatorNode(this Diagram diagram, string text)
		{
			ShapeNode node = diagram.Factory.CreateShapeNode(0, 0, 114, 37);
			node.Shape = Shapes.RoundRect;
			node.Brush = CreateGradientBrush(Colors.Green);
			node.FontStyle = FontStyles.Oblique;
			node.Text = text;
			node.ToolTip = text;
			node.TextWrapping = TextWrapping.NoWrap;

			return node;
		}

		public static ShapeNode CreateEndTerminatorNode(this Diagram diagram, string text)
		{
			ShapeNode node = diagram.Factory.CreateShapeNode(0, 0, 114, 37);
			node.Shape = Shapes.RoundRect;
			node.Brush = CreateGradientBrush(Colors.Red);
			node.FontStyle = FontStyles.Oblique;
			node.Text = text;
			node.ToolTip = text;
			node.TextWrapping = TextWrapping.NoWrap;

			return node;
		}

		public static ShapeNode CreateConnectorNode(this Diagram diagram, string text)
		{
			ShapeNode node = diagram.Factory.CreateShapeNode(0, 0, 19, 19);
			node.Shape = Shapes.Ellipse;
			node.Brush = CreateGradientBrush(Colors.White);
			node.Text = text;
			node.ToolTip = text;
			node.TextWrapping = TextWrapping.NoWrap;

			return node;
		}

		public static ShapeNode CreateProcessNode(this Diagram diagram, string text)
		{
			ShapeNode node = diagram.Factory.CreateShapeNode(0, 0, 114, 37);
			node.Shape = Shapes.Rectangle;
			node.Brush = CreateGradientBrush(Colors.LightSteelBlue);
			node.Text = text;
			node.ToolTip = text;
			node.TextWrapping = TextWrapping.NoWrap;

			return node;
		}

		public static ShapeNode CreateDecisionNode(this Diagram diagram, string text)
		{
			ShapeNode node = diagram.Factory.CreateShapeNode(0, 0, 114, 37);
			node.Shape = Shapes.Decision;
			node.Brush = CreateGradientBrush(Colors.Yellow);
			node.Text = text;
			node.ToolTip = text;
			node.TextWrapping = TextWrapping.NoWrap;

			return node;
		}

		public static ShapeNode CreateLoopNode(this Diagram diagram, string text)
		{
			ShapeNode node = diagram.Factory.CreateShapeNode(0, 0, 114, 37);
			node.Shape = Shapes.BeginLoop;
			node.Brush = CreateGradientBrush(Colors.Goldenrod);
			node.Text = text;
			node.ToolTip = text;
			node.TextWrapping = TextWrapping.NoWrap;

			return node;
		}

		public static ShapeNode CreateEndLoopNode(this Diagram diagram, string text)
		{
			ShapeNode node = diagram.Factory.CreateShapeNode(0, 0, 114, 37);
			node.Shape = Shapes.EndLoop;
			node.Brush = CreateGradientBrush(Colors.Goldenrod);
			node.Text = text;
			node.ToolTip = text;
			node.TextWrapping = TextWrapping.NoWrap;

			return node;
		}


		private static LinearGradientBrush CreateGradientBrush(Color color)
		{
			return new LinearGradientBrush(
				new GradientStopCollection() {
					new GradientStop(color, 0),
					new GradientStop(Colors.White, 0.5),
					new GradientStop(color, 1) },
				90);
		}
	}
}