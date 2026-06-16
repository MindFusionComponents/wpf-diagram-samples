//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Controls;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for OneWayLayoutPage.xaml
	/// </summary>
	public partial class OneWayLayoutPage : Page
	{
		public OneWayLayoutPage()
		{
			InitializeComponent();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"OneWayLayout.xml");
		}
	}
}
