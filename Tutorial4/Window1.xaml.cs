//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
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
using Microsoft.Win32;
using MindFusion.Diagramming.Wpf.Behaviors;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Tutorial4
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			// enable serialization of the custom class
			Diagram.RegisterItemClass(typeof(OrgChartNode), "my:OrgChartNode", 1);

			// enable drawing OrgChartNodes with the mouse
			diagramView.CustomBehavior = new LinkNodesBehavior<OrgChartNode>(
				diagramView, d => new OrgChartNode());

			diagram.UndoManager.UndoEnabled = true;
		}

		private void OnNodeCreated(object sender, NodeEventArgs e)
		{
			var node = e.Node as OrgChartNode;
			if (node != null && node.Image == null)
			{
				node.Image = new BitmapImage(new Uri("016.png", UriKind.Relative));
				node.Title = "new node";
				node.FullName = "new node";
				node.Text = "new node";
			}
		}

		private void btnSaveClick(object sender, RoutedEventArgs e)
		{
			var dlg = new SaveFileDialog();
			dlg.DefaultExt = "xml";
			if (dlg.ShowDialog() == true)
				diagram.SaveToXml(dlg.FileName);
		}

		private void btnLoadClick(object sender, RoutedEventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.DefaultExt = "xml";
			if (dlg.ShowDialog() == true)
				diagram.LoadFromXml(dlg.FileName);
		}

		private void btnUndoClick(object sender, RoutedEventArgs e)
		{
			diagram.UndoManager.Undo();
		}

		private void btnRedoClick(object sender, RoutedEventArgs e)
		{
			diagram.UndoManager.Redo();
		}
	}
}
