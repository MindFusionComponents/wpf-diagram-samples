//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Xml;
using System.Windows.Media.Effects;
using System.IO;
using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.TreeMap
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			brushes = new SolidColorBrush[]
			{
				new SolidColorBrush(Color.FromArgb(0xFF, 0xD4, 0x4E, 0x4E)),
				new SolidColorBrush(Color.FromArgb(0xFF, 0xF4, 0x4F, 0x4F)),
				new SolidColorBrush(Color.FromArgb(0xFF, 0xF7, 0x94, 0x1D)),
				new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0x00)),
				new SolidColorBrush(Color.FromArgb(0xFF, 0xFC, 0xF6, 0xA2)),
				new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF)),
			};

			diagramView.Behavior = Behavior.SelectOnly;
			diagram.DefaultShape = Shapes.Rectangle;
			diagram.ContainersFoldable = false;
			diagram.ContainerCaptionHeight = 18;
			diagram.Bounds = new Rect(0, 0, 900, 540);

			CreateTreeMap(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
		}

		private void selectFolder_Click(object sender, RoutedEventArgs e)
		{
			var dialog = new System.Windows.Forms.FolderBrowserDialog();
			dialog.SelectedPath = path.Text;
			if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				return;

			CreateTreeMap(dialog.SelectedPath);
		}

		private void CreateTreeMap(string folder)
		{
			path.Text = folder;

			diagram.ClearAll();
			DirTree(new DirectoryInfo(folder), 0);

			var layout = new TreeMapLayout();
			layout.Padding = 0;
			layout.ContainerPadding = 4;
			layout.LayoutArea = new Rect(0, 0, 900, 540);
			layout.Arrange(diagram);

			// Remove the text of smaller nodes
			foreach (var node in diagram.Nodes)
			{
				var shape = node as ShapeNode;
				if (shape == null)
					continue;

				if (node.Bounds.Width < 25 || node.Bounds.Height < 25)
				{
					shape.ToolTip = shape.Text;
					shape.Text = "";
				}
			}
		}

		private ContainerNode DirTree(DirectoryInfo dir, int depth)
		{
			var ctrNode = new ContainerNode(diagram);
			ctrNode.CaptionBackBrush = Brushes.Black;
			ctrNode.CaptionBrush = Brushes.White;
			diagram.Nodes.Add(ctrNode);
			ctrNode.Caption = dir.Name;
			ctrNode.TextVerticalAlignment = AlignmentY.Center;
			ctrNode.Brush = brushes[Math.Min(brushes.Length - 1, depth)];
			var files = dir.GetFiles();
			foreach (var file in files)
			{
				var node = diagram.Factory.CreateShapeNode(10, 10, 10, 10);
				node.Brush = brushes[Math.Min(brushes.Length - 1, depth)];
				if (file.Length > 0)
					node.Weight = file.Length;
				node.Text = file.Name;
				ctrNode.Add(node);
			}
			var dirs = dir.GetDirectories();
			foreach (var subdir in dirs)
			{
				if (subdir.GetFiles().Length == 0)
					continue;
				ctrNode.Add(DirTree(subdir, depth + 1));
			}

			return ctrNode;
		}


		private Brush[] brushes;
	}
}
