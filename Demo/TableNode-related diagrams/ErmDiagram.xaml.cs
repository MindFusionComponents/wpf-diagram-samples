//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for ErmDiagram.xaml
	/// </summary>
	public partial class ErmDiagram
	{
		public ErmDiagram()
		{
			InitializeComponent();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"ERM.xml");

			ermTimer = new DispatcherTimer();
			ermTimer.Interval = new TimeSpan(0, 0, 0, 40);
			ermTimer.Tick += OnTimerTick;
		}

		private void Page_Unloaded(object sender, RoutedEventArgs e)
		{
			ermTimer.Stop();
		}

		private DispatcherTimer ermTimer;
		private byte animSteps = 1;

		private void OnNodeClicked(object sender, NodeEventArgs e)
		{
			if (e.Node.Tag != null)
			{
				if (!(e.Node.Tag is int))
					return;

				if ((int)e.Node.Tag == 1)
				{
					if (e.Node.MasterGroup == null)
						return;

					// display an animated tooltip node
					var t = e.Node.MasterGroup.MainItem as TableNode;
					if (t == null)
						return;

					if (t.Tag == null)
						return;
					if (!(t.Tag is string))
						return;
					if ((string)t.Tag == "")
						return;

					Size sz = diagram.MeasureString((string)t.Tag, e.Node, 35);
					var b = diagram.FindNode(2) as ShapeNode;
					if (b != null)
					{
						Rect rc = b.Bounds;
						rc.Width = sz.Width + 8;
						rc.Height = sz.Height + 8;
						rc.X = t.Bounds.Right - sz.Width;
						rc.Y = t.Bounds.Bottom;

						b.Bounds = rc;
						b.Visible = true;
						b.Stroke = SystemColors.HighlightBrush;
						b.Brush = b.Stroke;
						b.TextBrush = SystemColors.HighlightTextBrush;
						b.Text = (string)t.Tag;

						diagram.Selection.Clear();
						animSteps = 1;
						ermTimer.Interval = new TimeSpan(0, 0, 0, 70);
						ermTimer.Start();

					}
				}
				else if ((int)e.Node.Tag == 2)
				{
					if (e.Node.MasterGroup == null)
						return;

					// display the table name and number of links
					var t = e.Node.MasterGroup.MainItem as TableNode;
					if (t == null)
						return;

					int ain = 0;
					int aout = 0;
					foreach (TableNode.Row r in t.Rows)
					{
						ain += r.IncomingLinks.Count;
						aout += r.OutgoingLinks.Count;
					}

					string msg = t.Caption + "\n\nIncoming links: " + ain + "\nOutgoing links: " + aout;
					MessageBox.Show(Application.Current.MainWindow, msg, "Summary");
				}
				else if ((int)e.Node.Tag == 3)
				{
					if (e.Node.MasterGroup == null)
						return;

					// delete the table
					if (MessageBox.Show("Are you sure you want to delete this entity?",
						"Confirm delete", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
						return;
					var t = e.Node.MasterGroup.MainItem as TableNode;
					if (t == null)
						return;
					while (t.SubordinateGroup.AttachedNodes.Count > 0)
						diagram.Nodes.Remove(t.SubordinateGroup.AttachedNodes[0]);
					diagram.Nodes.Remove(t);
				}
			}
		}

		void OnTimerTick(object sender, EventArgs e)
		{
			Color c = Color.FromArgb(255, SystemColors.HighlightColor.R,
				SystemColors.HighlightColor.G, SystemColors.HighlightColor.B);
			Color cText = Color.FromArgb(255, SystemColors.HighlightTextColor.R,
				SystemColors.HighlightTextColor.G, SystemColors.HighlightTextColor.B);

			var b = diagram.FindNode(2) as ShapeNode;
			if (b != null && animSteps < 20)
			{
				b.Visible = true;
				c.A = (byte)(animSteps * 12);
				b.Stroke = new SolidColorBrush(c);
				c.A = (byte)(animSteps * 6);
				b.Brush = new SolidColorBrush(c);
				cText.A = (byte)(animSteps * 12);
				b.TextBrush = new SolidColorBrush(cText);
			}

			animSteps++;
			if (animSteps == 40)
			{
				if (b != null)
				{
					b.Selected = true;
				}
				ermTimer.Stop();
			}
		}
	}
}
