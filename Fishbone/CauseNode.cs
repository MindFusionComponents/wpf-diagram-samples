//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Fishbone
{
	public class CauseNode : DiagramNode
	{
		public CauseNode(DiagramNode backbone)
		{
			this.backbone = backbone;

			Stroke = Brushes.Red;
			StrokeThickness = 3;
			Brush = Brushes.Red;
			HandlesStyle = HandlesStyle.Invisible;
		}

		public override Rect GetRepaintRect(bool includeConnected)
		{
			Rect baseRect = base.GetRepaintRect(includeConnected);
			baseRect.Inflate(2, 2);
			return baseRect;
		}

		public override void Draw(DrawingContext graphics, MindFusion.Diagramming.Wpf.RenderOptions options)
		{
			int code = 'a' + Math.Max(0, (ZIndex == 0 ? Parent.Items.Count : ZIndex) - 1);
			char c = (char)(code);
			Point handle;

			Point p1 = P1;
			Point p2 = P2;

			graphics.PushTransform(new TranslateTransform(-Math.Min(p1.X, p2.X), -Math.Min(p1.Y, p2.Y)));

			// draw the label
			if (Bounds.Y < backbone.Bounds.Y)
			{
				graphics.DrawText(
					new FormattedText(c.ToString(), CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
						new Typeface(new FontFamily("Trebuchet MS"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal),
						12, Brushes.Blue),
					new Point(p1.X - 10, p1.Y - 10));
				handle = p2;
			}
			else
			{
				graphics.DrawText(
					new FormattedText(c.ToString(), CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
						new Typeface(new FontFamily("Trebuchet MS"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal),
						12, Brushes.Blue),
					new Point(p2.X - 10, p2.Y - 10));
				handle = p1;
			}

			// draw the cause line
			graphics.DrawLine(new Pen(Stroke, StrokeThickness), p1, p2);

			// draw the movement handle
			graphics.DrawEllipse(Brush, null, new Point(handle.X, handle.Y), 6, 6);

			graphics.Pop();
		}

		public override bool ContainsPoint(Point point, double threshold)
		{
			return Bounds.Contains(point) &&
				Utilities.DistToLineSegment(point, P1, P2) <= 5 + threshold;
		}

		public override bool ContainsPoint(Point point)
		{
			return Bounds.Contains(point) &&
				Utilities.DistToLineSegment(point, P1, P2) <= 5;
		}

		protected override void StartCreate(Point org)
		{
			base.StartCreate(org);
			start = org;
			start.Y = backbone.Bounds.Y + backbone.Bounds.Height / 2;
		}

		protected override void UpdateCreate(Point current)
		{
			base.UpdateCreate(current);

			double dy = start.Y - current.Y;

			if (dy < 0)
			{
				// below the backbone
				Bounds = new Rect(new Point(start.X + dy, start.Y), new Point(start.X, start.Y - dy));
			}
			else
			{
				// above the backbone
				Bounds = new Rect(new Point(start.X - dy, start.Y), new Point(start.X, start.Y - dy));
			}
		}

		/// <summary>
		/// The upper point.
		/// </summary>
		public Point P1
		{
			get
			{
				Point p1;

				if (Bounds.Y < backbone.Bounds.Y)
				{
					p1 = Bounds.Location;
				}
				else
				{
					p1 = Bounds.Location;
					p1.X += Bounds.Width;
				}

				return p1;
			}
		}

		/// <summary>
		/// Thr lower point.
		/// </summary>
		public Point P2
		{
			get
			{
				Point p2;

				if (Bounds.Y < backbone.Bounds.Y)
				{
					p2 = Bounds.Location;
					p2.X += Bounds.Width;
					p2.Y += Bounds.Height;
				}
				else
				{
					p2 = Bounds.Location;
					p2.Y += Bounds.Height;
				}

				return p2;
			}
		}


		internal DiagramNode backbone;
		private Point start;
	}
}
