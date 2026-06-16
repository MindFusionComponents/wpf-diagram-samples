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
using System.Windows.Shapes;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for ProgressForm.xaml
	/// </summary>
	public partial class ProgressForm : Window
	{
		public ProgressForm()
		{
			InitializeComponent();
		}

		public double Minimum
		{
			get { return progress.Minimum; }
			set { progress.Minimum = value; }
		}

		public double Maximum
		{
			get { return progress.Maximum; }
			set { progress.Maximum = value; }
		}

		public double Value
		{
			get { return progress.Value; }
			set { progress.Value = value; }
		}
	}
}
