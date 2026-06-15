//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Controls;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Magnifier
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void radioNever_Checked(object sender, RoutedEventArgs e)
		{
			diagramView.MagnifierEnabled = false;
			diagramView.ModifierKeyActions.Alt = ModifierKeyAction.None;
			diagramView.RightButtonActions = MouseButtonActions.Cancel;
		}

		private void radioOnRightClick_Checked(object sender, RoutedEventArgs e)
		{
			diagramView.MagnifierEnabled = false;
			diagramView.ModifierKeyActions.Alt = ModifierKeyAction.None;
			diagramView.RightButtonActions = MouseButtonActions.Magnify;
		}

		private void radioOnAlt_Checked(object sender, RoutedEventArgs e)
		{
			diagramView.MagnifierEnabled = false;
			diagramView.ModifierKeyActions.Alt = ModifierKeyAction.Magnify;
			diagramView.RightButtonActions = MouseButtonActions.Cancel;
		}

		private void radioAlways_Checked(object sender, RoutedEventArgs e)
		{
			diagramView.MagnifierEnabled = true;
			diagramView.ModifierKeyActions.Alt = ModifierKeyAction.None;
			diagramView.RightButtonActions = MouseButtonActions.Cancel;
		}

		private void radioDefault_Checked(object sender, RoutedEventArgs e)
		{
			Application.Current.Resources.MergedDictionaries.Clear();
			diagram.MagnifierStyle = null;
		}

		private void radioCustom_Checked(object sender, RoutedEventArgs e)
		{
			string path = "Magnifier.xaml";
			Uri uri = new Uri(path, UriKind.Relative);
			ResourceDictionary d = Application.LoadComponent(uri) as ResourceDictionary;
			Application.Current.Resources.MergedDictionaries.Clear();
			Application.Current.Resources.MergedDictionaries.Add(d);
			diagram.MagnifierStyle = d["Magnifier"] as System.Windows.Style;
		}

		private void sliderSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			diagram.MagnifierWidth = sliderSize.Value;
			diagram.MagnifierHeight = sliderSize.Value;
		}

		private void sliderZoom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			diagram.MagnifierFactor = sliderZoom.Value;
		}
	}
}
