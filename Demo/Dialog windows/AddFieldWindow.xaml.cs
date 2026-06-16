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
	/// Interaction logic for AddFieldWindow.xaml
	/// </summary>
	public partial class AddFieldWindow : Window
	{
		public AddFieldWindow()
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

		private static string[] shortTp =
		{
			"Text",
			"Num",
			"Date",
			"Auto",
			"Bool"
		};

		public string FieldTypeText
		{
			get
			{
				return shortTp[cmBxType.SelectedIndex];
			}
			set
			{
				cmBxType.SelectedIndex = -1;
				for (int i = 0; i < shortTp.Length; i++)
				{
					if (shortTp[i] == value)
					{
						cmBxType.SelectedIndex = i;
						break;
					}
				}
			}
		}

		public string FieldName
		{
			get { return tBxFieldName.Text; }
			set { tBxFieldName.Text = value; }
		}

		public int FieldType
		{
			get
			{
				return cmBxType.SelectedIndex;
			}
			set
			{
				cmBxType.SelectedIndex = value;
			}
		}
	}
}
