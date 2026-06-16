//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
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
	/// Interaction logic for LaneDiagram.xaml
	/// </summary>
	public partial class LaneDiagram : Page
	{
		public LaneDiagram()
		{
			InitializeComponent();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"LaneDiagram.xml");
		}

		void diagram_NodeCreated(object sender, NodeEventArgs e)
		{
			// Restrict movement
			e.Node.EnabledHandles = AdjustmentHandles.ResizeMiddleLeft | AdjustmentHandles.ResizeMiddleRight | AdjustmentHandles.Move;
			e.Node.Constraints.MoveDirection = DirectionConstraint.Horizontal;
		}
	}
}
