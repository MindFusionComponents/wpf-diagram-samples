//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using Microsoft.Win32;


namespace MindFusion.Diagramming.Wpf.Samples.CS.IconNodes
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			// Enable serialization of IconNode instances
			Diagram.RegisterItemClass(typeof(IconNode), "IconNode", 1);

			// Let users draw IconNode objects
			diagram.CustomNodeType = typeof(IconNode);
			diagramView.Behavior = MindFusion.Diagramming.Wpf.Behavior.Custom;

			// Show some info about this sample
			ShapeNode info = new ShapeNode();
			info.Bounds = new Rect(5, 5, 70 * 4, 30 * 4);
			info.Text = "This example shows how to create a custom node class that " +
				"exposes some new properties in addition to the ones defined by " +
				"DiagramNode and implements its own drawing logic. Click on the " +
				"drawing surface or draw with the mouse to create instances of " +
				"the custom IconNode class.";
			info.PolygonalTextLayout = true;
			info.Brush = Brushes.White;
			info.Locked = true;
			info.FontFamily = new FontFamily("Arial");
			info.FontSize = 12;
			info.ResizeToFitText(FitSize.KeepRatio);
			info.Transparent = true;
			diagram.Nodes.Add(info);
		}

		private void diagram_NodeDoubleClicked(object sender, NodeEventArgs e)
		{
			IconNode iconNode = e.Node as IconNode;
			if (iconNode != null)
			{
				index += 1;
				if (index > 2)
					index = 0;
				if (index == 0)
					iconNode.Icon = (ImageSource)Application.Current.Resources["image1"];
				else if (index == 1)
					iconNode.Icon = (ImageSource)Application.Current.Resources["image2"];
				else
					iconNode.Icon = (ImageSource)Application.Current.Resources["image3"];

				iconNode.Repaint(true);
			}
		}

		private void diagram_Clicked(object sender, DiagramEventArgs e)
		{
			IconNode iconNode = new IconNode(diagram);
			diagram.Nodes.Add(iconNode);
			iconNode.Brush = Brushes.Red;
			iconNode.Move(e.MousePosition.X, e.MousePosition.Y);
		}

		private void OnSaveClick(object sender, RoutedEventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.DefaultExt = "fc";
			if (dialog.ShowDialog() == true)
				diagram.SaveToXml(dialog.FileName);
		}

		private void OnLoadClick(object sender, RoutedEventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.DefaultExt = "fc";
				if (dialog.ShowDialog() == true)
					diagram.LoadFromXml(dialog.FileName);
			}
			catch (FormatException)
			{
				MessageBox.Show("Not a MindFusion.Diagramming file!");
			}
		}

		int index;
	}
}
