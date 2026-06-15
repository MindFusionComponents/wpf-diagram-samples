//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Fishbone
{
	public class AspectNode : DiagramNode
	{
		public AspectNode(CauseNode causeNode)
		{
			this.causeNode = causeNode;

			Stroke = Brushes.Blue;
			StrokeThickness = 3;
		}

		public override Rect GetRepaintRect(bool includeConnected)
		{
			Rect baseRect = base.GetRepaintRect(includeConnected);
			baseRect.Inflate(2, 2);
			return baseRect;
		}

		public override void Draw(DrawingContext graphics, MindFusion.Diagramming.Wpf.RenderOptions options)
		{
			int code = (int)'a' + Math.Max(0, (ZIndex == 0 ? Parent.Items.Count : ZIndex) - 1);
			char c = (char)(code);
			Point p1 = Bounds.Location;
			p1.X += Bounds.Width / 2;

			Point p2 = p1;
			p2.Y += Bounds.Height;

			graphics.PushTransform(new TranslateTransform(-p1.X, -p1.Y));

			// draw the aspect line
			graphics.DrawLine(new Pen(Stroke, StrokeThickness), p1, p2);

			// find the intersection point with the cause line
			double m = (causeNode.P2.Y - causeNode.P1.Y) / (causeNode.P2.X - causeNode.P1.X);
			double b = causeNode.P2.Y - m * causeNode.P2.X;
			double yP = m * p1.X + b;

			// draw the label
			if (Math.Abs(p1.Y - yP) > Math.Abs(p2.Y - yP))
			{
				graphics.DrawText(
				new FormattedText(c.ToString(), CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
					new Typeface(new FontFamily("Trebuchet MS"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal),
					12, Brushes.Blue),
				new Point(p1.X - 3, p1.Y - 15));
			}
			else
			{
				graphics.DrawText(
				new FormattedText(c.ToString(), CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
					new Typeface(new FontFamily("Trebuchet MS"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal),
					12, Brushes.Blue),
				new Point(p2.X - 3, p2.Y));
			}

			graphics.Pop();
		}

		protected override void StartCreate(Point org)
		{
			base.StartCreate(org);
			start = org;
		}

		protected override void UpdateCreate(Point current)
		{
			base.UpdateCreate(current);

			double dy = start.Y - current.Y;
			Bounds = new Rect(new Point(start.X - 0.5, start.Y), new Point(start.X + 0.5, start.Y - dy));
		}

		protected override bool AllowCreate(Point current, InteractionState ist)
		{
			return true;
		}

		protected override void CompleteCreate(Point end)
		{
			base.CompleteCreate(end);
			AttachTo(causeNode, AttachToNode.TopLeft);
			causeNode.SubordinateGroup.AutoDeleteItems = true;
		}


		CauseNode causeNode;
		Point start;
	}
}
