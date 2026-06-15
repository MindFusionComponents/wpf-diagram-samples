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
	/// Interaction logic for FormPreservation.xaml
	/// </summary>
	public partial class FormPreservation : Page
	{
		public FormPreservation()
		{
			InitializeComponent();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"FormPreservation.xml");

			foreach (DiagramNode node in diagram.Nodes)
			{
				ShapeNode b = node as ShapeNode;
				if (b == null)
					continue;

				b.Locked = false;
			}
		}
	}
}
