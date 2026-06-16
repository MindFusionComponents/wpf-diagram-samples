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
	/// Interaction logic for AddPersonWindow.xaml
	/// </summary>
	public partial class AddPersonWindow : Window
	{
		public AddPersonWindow()
		{
			InitializeComponent();
		}

		public string PersonName
		{
			get
			{
				return tBxNameEdit.Text;
			}
		}

		public string PersonDates
		{
			get
			{
				return tBxBirthDeathEdit.Text;
			}
		}

		public BitmapSource PersonImage
		{
			get
			{
				return bitmapSource;
			}
		}

		private void pictureBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
		}
		BitmapSource bitmapSource;

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
			Close();
		}

		private void btnBrowse_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

			if (openFileDialog.ShowDialog() == true)
			{
				Uri imageUri = new Uri(openFileDialog.FileName);
				bitmapSource = new BitmapImage(imageUri);
				pictureBox.Source = bitmapSource;
			}
		}
	}
}
