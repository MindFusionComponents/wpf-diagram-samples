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
using System.Windows.Shapes;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for AddTableWindow.xaml
	/// </summary>
	public partial class AddTableWindow : Window
	{
		public AddTableWindow()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
			Close();
		}

		private void btnCancel_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			Close();
		}

		public string TableName
		{
			get { return tBxTableName.Text; }
			set { tBxTableName.Text = value; }
		}
	}
}
