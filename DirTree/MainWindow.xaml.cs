//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.IO;
using System.Windows;

using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.DirTree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			dirDiagram.ShowAnchors = ShowAnchors.Never;
			folderAnchors = new AnchorPattern(new[]
          		{
          			new AnchorPoint(10, 100, false, true),
					new AnchorPoint(0, 50, true, false)
          		},
				"FolderAnchors");

			// set folder-like polygonal shape as default for nodes
			byte[] folderShape = { 0, 0, 40, 0, 55, 20, 100, 20, 100, 100, 0, 100 };
			dirDiagram.DefaultShape = new Shape(folderShape);

			// allow hierarchical expand/collapse
			dirDiagram.NodesExpandable = true;

			// all arrows should start with vertical segment
			dirDiagram.LinkCascadeOrientation = Orientation.Vertical;
			dirDiagram.LinkHeadShape = ArrowHeads.None;

			dirDiagram.ExpandButtonPosition = ExpandButtonPosition.OuterUpperLeft;

			// read some directories
			BuildTree();
		}

		int height = 0;
		AnchorPattern folderAnchors;

		private void BuildTree()
		{
			// create a box that will be a root in our hierarchy
			ShapeNode root = new ShapeNode(dirDiagram);
			root.AnchorPattern = folderAnchors;
			root.Bounds = new Rect(23.04, 23.04, 99.84, 46.08);
			root.Text = "root";
			dirDiagram.Nodes.Add(root);

			height = 20;

			// read directories of all drives
			string[] drives = Environment.GetLogicalDrives();

			int skip = 0;
			if (drives.Length >= 2)
			{
				if (drives[0][0] == 'A') skip++;
				if (drives[1][0] == 'B') skip++;
			}

			DirectoryInfo[] di = new DirectoryInfo[drives.Length - skip];
			for (int i = 0; i < di.GetLength(0); ++i)
			{
				di[i] = new DirectoryInfo(drives[i + skip]);
			}
			BuildSubDirs(root, di, 1);

			LayoutTree();

			// after the whole tree is built adjust the document extents
			// to be as big as needed
			dirDiagram.ResizeToFitItems(5, true);
		}

		private void LayoutTree()
		{
			TreeLayout tl = new TreeLayout();

			tl.Root = null; // automatically select root
			tl.Type = TreeLayoutType.Cascading;
			tl.Direction = TreeLayoutDirections.LeftToRight;
			tl.LinkStyle = TreeLayoutLinkType.Cascading2;
			tl.LevelDistance = -40;
			tl.NodeDistance = 15;
			tl.KeepRootPosition = true;
			tl.ReversedLinks = false;
			tl.Anchoring = Anchoring.Keep;

			tl.Arrange(dirDiagram);
		}

		private void BuildSubDirs(ShapeNode root, DirectoryInfo[] dirs, int level)
		{
			foreach (DirectoryInfo dir in dirs)
			{
				// create a node for the subfolder
				ShapeNode folder = dirDiagram.Factory.CreateShapeNode(6 + level * 76.8, height, 99.84, 46.08);
				folder.AnchorPattern = folderAnchors;
				folder.Text = dir.Name;
				folder.Tag = dir; // associate dir-info with box
				dirDiagram.Nodes.Add(folder);

				// link the subfolder with its parent
				DiagramLink link = new DiagramLink(dirDiagram, root, folder);
				link.SegmentCount = 2;
				link.Shape = LinkShape.Cascading;
				dirDiagram.Links.Add(link);

				// vertical offset for next folders
				height += 14;
				if (level > 2) continue; // avoid deep recursion
				DirectoryInfo[] subDirs;
				try
				{
					// build subtrees recursively
					subDirs = dir.GetDirectories();
					BuildSubDirs(folder, subDirs, level + 1);
				}
				catch
				{
				}
			}
		}

		private void OnTreeCollapsed(object sender, NodeEventArgs e)
		{
			LayoutTree();
		}

		private void OnTreeExpanded(object sender, NodeEventArgs e)
		{
			LayoutTree();
		}
	}
}