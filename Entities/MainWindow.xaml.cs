//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Collections;

using MessageBox = System.Windows.MessageBox;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Entities
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			for (int i = 0; i < 5; i++)
				generalImageList[i] = new BitmapImage(new Uri(@"pack://application:,,,/Entities;component/Files/" + i + ".png"));
			ermTimer = new DispatcherTimer();
			ermTimer.Tick += ermTimer_Tick;
			ShapeNode tooltip = diagram.Factory.CreateShapeNode(0, 0, 5, 5);
			tooltip.Locked = true;
			tooltip.Brush = Brushes.Transparent;
			tooltip.Stroke = Brushes.Transparent;
			tooltip.TextBrush = Brushes.Transparent;
			tooltip.Tag = 5;
			tooltip.Shape = Shapes.Rectangle;
		}

		void ermTimer_Tick(object sender, EventArgs e)
		{
			Color c = Color.FromArgb(0, SystemColors.HighlightColor.R,
				SystemColors.HighlightColor.G, SystemColors.HighlightColor.B);
			Color cText = Color.FromArgb(0, SystemColors.HighlightTextColor.R,
							SystemColors.HighlightTextColor.G, SystemColors.HighlightTextColor.B);

			ShapeNode b = diagram.FindNode(5) as ShapeNode;
			b.Visible = true;
			if (b != null && animSteps < 20)
			{
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
					b.TextBrush = b.Brush = b.Stroke = Brushes.Transparent;
				}
				ermTimer.Stop();
			}
		}

		private void ButtonClick(object sender, RoutedEventArgs e)
		{
			AddEntityWindow form = new AddEntityWindow();

			if (form.ShowDialog() != true)
				return;

			double rh = diagram.TableRowHeight;
			double th = diagram.TableCaptionHeight;
			double totalh = th + 4 * rh;
			TableNode t = diagram.Factory.CreateTableNode(5, 5, 30 + 6 * rh, totalh);
			t.TextAlignment = TextAlignment.Center;

			t.Caption = form.EntityName;
			t.Tag = form.EntityDescription;

			// Create the help button
			Rect rc = t.Bounds;
			ShapeNode btn = diagram.Factory.CreateShapeNode(rc.Left + 7,
				rc.Bottom - rh, rh, rh);
			btn.Transparent = true;
			btn.Image = generalImageList[2];
			btn.ImageAlign = ImageAlign.Stretch;
			btn.AttachTo(t, AttachToNode.BottomLeft);
			btn.Locked = true;
			btn.Tag = 1;

			btn = diagram.Factory.CreateShapeNode(rc.Left + 7 + rh,
				rc.Bottom - rh, rh, rh);
			btn.Transparent = true;
			btn.Image = generalImageList[3];
			btn.ImageAlign = ImageAlign.Stretch;
			btn.AttachTo(t, AttachToNode.BottomLeft);
			btn.Locked = true;
			btn.Tag = 2;

			btn = diagram.Factory.CreateShapeNode(rc.Right - 7 - rh,
				rc.Bottom - rh, rh, rh);
			btn.Transparent = true;
			btn.Image = generalImageList[4];
			btn.ImageAlign = ImageAlign.Stretch;
			btn.AttachTo(t, AttachToNode.BottomLeft);
			btn.Locked = true;
			btn.Tag = 3;

			SolidColorBrush tbrush =
				new SolidColorBrush(Colors.LightBlue);

			LinearGradientBrush cbrush =
				new LinearGradientBrush(
					Colors.LightBlue, Colors.Black, 90);

			t.CaptionBackBrush = cbrush;
			t.Brush = tbrush;

			t.RowCount = 3;
			t.ColumnCount = 4;

			t.Scrollable = false;
			t.EnabledHandles = AdjustmentHandles.Move;
			t.CellFrameStyle = CellFrameStyle.None;
			t.HandlesStyle = HandlesStyle.HatchHandles3;
			t.Columns[0].Width = rh;
			t.Columns[1].Width = 57;
			t.Columns[2].Width = 57;
			t.Columns[3].Width = rh;
			t.Shape = SimpleShape.RoundedRectangle;
			t.CaptionBrush = Brushes.White;

			AnchorPoint ptin = new AnchorPoint(50d, 50d, true, false, Brushes.Red, 0);
			AnchorPoint ptout = new AnchorPoint(45d, 50d, false, true, Brushes.Red, 3);
			ArrayList al = new ArrayList();

			for (int i = 0; i < 3; i++)
			{
				al.Clear();
				if (form.GetInput(i) != null)
				{
					t[0, i].ImageAlign = ImageAlign.Center;
					t[0, i].Image = generalImageList[0];
					t[1, i].Text = form.GetInput(i);
					al.Add(ptin.Clone());
				}
				if (form.GetOutput(i) != null)
				{
					t[3, i].ImageAlign = ImageAlign.MiddleRight;
					t[3, i].Image = generalImageList[1];
					t[2, i].Text = form.GetOutput(i);
					t[2, i].TextAlignment = TextAlignment.Right;
					al.Add(ptout.Clone());
				}
				t.Rows[i].AnchorPattern = new AnchorPattern(
					(AnchorPoint[])al.ToArray(typeof(AnchorPoint)));
			}
		}

		private BitmapSource[] generalImageList = new BitmapSource[5];

		private void diagram_NodeClicked(object sender, NodeEventArgs e)
		{
			if (e.Node.Tag != null)
                {
                    if (!(e.Node.Tag is int))
                        return;

                    if ((int)e.Node.Tag == 1)
                    {
                        if (e.Node.MasterGroup == null)
                            return;

                        // Display info box
						TableNode t = e.Node.MasterGroup.MainItem as TableNode;
						if (t == null)
							return;

                        if (t.Tag == null)
                            return;
                        if (!(t.Tag is string))
                            return;
                        if ((string)t.Tag == "")
                            return;

						Size sz = diagram.MeasureString((string)t.Tag, e.Node, (int)(6 * diagram.TableRowHeight));
                        ShapeNode b = diagram.FindNode(5) as ShapeNode;
                        if (b != null)
                        {
                            Rect rc = b.Bounds;
                            rc.Width = sz.Width + 8;
							rc.Height = sz.Height + 10;
                            rc.X = t.Bounds.Right - sz.Width;
                            rc.Y = t.Bounds.Bottom;

                            b.Bounds = rc;
                            b.Text = (string)t.Tag;

                            diagram.Selection.Clear();
							animSteps = 1;
							ermTimer.Interval = TimeSpan.FromMilliseconds(70);
							ermTimer.Start();
                        }
                    }
                    else if ((int)e.Node.Tag == 2)
                    {
                        if (e.Node.MasterGroup == null)
                            return;

						TableNode t = e.Node.MasterGroup.MainItem as TableNode;
						if (t == null)
							return;

                        int ain = 0;
                        int aout = 0;
                        foreach (TableNode.Row r in t.Rows)
                        {
                            ain += r.IncomingLinks.Count;
                            aout += r.OutgoingLinks.Count;
                        }

                        string msg = t.Caption + "\n\nIncoming links: " + ain.ToString() +
                            "\nOutgoing links: " + aout.ToString();
                        MessageBox.Show(this, msg, "Summary");
                    }
                    else if ((int)e.Node.Tag == 3)
                    {
                        if (e.Node.MasterGroup == null)
                            return;

                        if (MessageBox.Show("Are you sure you want to delete this entity?",
                            "Confirm delete", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                            return;
						TableNode t = e.Node.MasterGroup.MainItem as TableNode;
						if (t == null)
							return;
                        while (t.SubordinateGroup.AttachedNodes.Count > 0)
                            diagram.Nodes.Remove(t.SubordinateGroup.AttachedNodes[0]);
                        diagram.Nodes.Remove(t);
                    }
                }
            }

		private DispatcherTimer ermTimer;
		private byte animSteps = 1;
	}
}
