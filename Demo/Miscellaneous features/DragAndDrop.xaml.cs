//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
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


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for DragAndDrop.xaml
	/// </summary>
	public partial class DragAndDrop : Page
	{
		public DragAndDrop()
		{
			InitializeComponent();
		}

		private void DemoPage_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"Drag and drop.xml");

			diagram.ClearAll();
			//SetWorldFont();
			diagram.BackBrush = Brushes.White;
			ShapeNode b = diagram.Factory.CreateShapeNode(10, 10, 384, 76.8);
			b.Transparent = true;
			b.Brush = Brushes.White;
			b.Text = "Drag an image or listbox items over the document area";
			b.TextBrush = Brushes.Black;
			b.FontFamily = new FontFamily("Times New Roman");
			b.FontSize = 16;
			b.Locked = true;
		}
	}
}
