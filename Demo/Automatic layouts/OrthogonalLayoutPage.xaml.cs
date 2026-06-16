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
	/// Interaction logic for OrthogonalLayoutPage.xaml
	/// </summary>
	public partial class OrthogonalLayoutPage : Page
	{
		public OrthogonalLayoutPage()
		{
			InitializeComponent();
		}

		void Page_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"OrthogonalLayoutDiagram.xml");
		}
	}
}
