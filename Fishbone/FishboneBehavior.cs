//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;

using MindFusion.Diagramming.Wpf.Behaviors;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Fishbone
{
	public class FishboneBehavior : BehaviorBase
	{
		public FishboneBehavior(DiagramView view, DiagramNode backbone)
			: base(view)
		{
			this.backbone = backbone;
		}

		public override InteractionState StartDraw(Point point)
		{
			CauseNode cause = Diagram.GetNodeAt(point, 3) as CauseNode;
			if (cause != null)
			{
				Point handle = (cause.Bounds.Y < backbone.Bounds.Y) ? cause.P2 : cause.P1;
				if (Math.Abs(handle.X - point.X) <= 6 && Math.Abs(handle.Y - point.Y) <= 6)
					return new InteractionState(cause, new NodeAdjustmentHandle(NodeHandleType.Move), MindFusion.Diagramming.Wpf.Action.Modify);

				if (CanDrawAspectAt(point))
				{
					AspectNode node = new AspectNode(cause);
					return new InteractionState(node, new NodeAdjustmentHandle(NodeHandleType.ResizeBottomRight), MindFusion.Diagramming.Wpf.Action.Create);
				}
			}

			if (backbone.Bounds.Contains(point))
			{
				CauseNode node = new CauseNode(backbone);
				return new InteractionState(node, new NodeAdjustmentHandle(NodeHandleType.ResizeBottomRight), MindFusion.Diagramming.Wpf.Action.Create);
			}

			return null;
		}

		public override CursorHint SetMouseCursor(Point point, out bool startInteraction)
		{
			CauseNode cause = Diagram.GetNodeAt(point, 3) as CauseNode;
			if (cause != null)
			{
				Point handle = (cause.Bounds.Y < backbone.Bounds.Y) ? cause.P2 : cause.P1;
				if (Math.Abs(handle.X - point.X) <= 6 && Math.Abs(handle.Y - point.Y) <= 6)
				{
					startInteraction = true;
					return CursorHint.Move;
				}
			}

			if (backbone.Bounds.Contains(point) ||
				CanDrawAspectAt(point))
			{
				startInteraction = true;
				return CursorHint.DrawLink;
			}

			startInteraction = false;
			return CursorHint.Pointer;
		}

		private bool CanDrawAspectAt(Point point)
		{
			CauseNode cause = Diagram.GetNodeAt(point) as CauseNode;
			if (cause != null)
			{
				if (cause.Bounds.Y < backbone.Bounds.Y)
				{
					// above the backbone
					Point c = cause.Bounds.Location;
					double dx = point.X - c.X;
					double dy = point.Y - c.Y;

					if (Math.Abs(dx - dy) < 3)
						return true;
				}
				else
				{
					// below the backbone
					Point c = cause.Bounds.Location;
					c.X = cause.Bounds.Right;
					double dx = point.X - c.X;
					double dy = -(point.Y - c.Y);

					if (Math.Abs(dx - dy) < 3)
						return true;
				}
			}
			return false;
		}

		private DiagramNode backbone;
	}
}
