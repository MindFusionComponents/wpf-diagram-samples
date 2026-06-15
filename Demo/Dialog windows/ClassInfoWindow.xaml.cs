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
	/// Interaction logic for ClassInfoWindow.xaml
	/// </summary>
	public partial class ClassInfoWindow : Window
	{
		public ClassInfoWindow()
		{
			InitializeComponent();
		}

		private bool cycleProtect = false;
		private TableNode editedClass;

		public TableNode EditedClass
		{
			set
			{
				editedClass = value;

				// Fill the info
				tBxName.Text = editedClass.Caption;

				DiagramLinkCollection inc = editedClass.IncomingLinks;
				if (inc != null)
				{
					foreach (DiagramLink a in inc)
					{
						if (a.Origin is TableNode)
							lBxBase.Items.Add((a.Origin as TableNode).Caption);
					}
				}

				DiagramLinkCollection outg = editedClass.OutgoingLinks;
				if (outg != null)
				{
					foreach (DiagramLink a in outg)
					{
						if (a.Destination is TableNode)
							lBxDerived.Items.Add((a.Destination as TableNode).Caption);
					}
				}

				int header = 0;
				for (int i = 0; i < editedClass.RowCount; i++)
				{
					if (editedClass.Rows[i].Header)
					{
						header++;
						continue;
					}

					if (header == 1)
						lBxMethods.Items.Add(editedClass[1, i].Text);
					else
						lBxProperty.Items.Add(editedClass[1, i].Text);
				}

				if (lBxMethods.Items.Count > 0)
				{
					lBxMethods.SelectedIndex = 0;
					tBxMethodEdit.Text = (string)lBxMethods.Items[0];
				}

				if (lBxProperty.Items.Count > 0)
				{
				}
			}
		}

		private void btnOk_Click(object sender, RoutedEventArgs e)
		{
			// Save changes
			if (editedClass != null)
			{
				editedClass.Caption = tBxName.Text;

				int rows = lBxMethods.Items.Count + lBxProperty.Items.Count + 2;
				int index = 0;

				editedClass.RedimTable(0, 0);
				editedClass.RedimTable(2, rows);

				editedClass[0, index].ColumnSpan = 2;
				editedClass[0, index].Text = "<b>Methods</b>";
				editedClass[0, index].TextAlignment = TextAlignment.Left;
				editedClass.Rows[index].Header = true;
				index++;

				editedClass.Columns[0].Width = editedClass.RowHeight;

				foreach (string method in lBxMethods.Items)
				{
					editedClass[0, index].ImageAlign = ImageAlign.Center;
					editedClass[1, index].Text = method;
					editedClass[1, index].TextAlignment = TextAlignment.Left;
					index++;
				}

				editedClass[0, index].ColumnSpan = 2;
				editedClass[0, index].Text = "<b>Properties</b>";
				editedClass[0, index].TextAlignment = TextAlignment.Left;
				editedClass.Rows[index].Header = true;
				index++;

				foreach (string property in lBxProperty.Items)
				{
					editedClass[0, index].ImageAlign = ImageAlign.Center;
					editedClass[1, index].Text = property;
					editedClass[1, index].TextAlignment = TextAlignment.Left;
					index++;
				}
			}

			DialogResult = true;
			Close();
		}

		private void btnCancel_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			Close();
		}

		private void lBxMethods_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!cycleProtect && lBxMethods.SelectedIndex >= 0)
			{
				cycleProtect = true;
				tBxMethodEdit.Text = (string)lBxMethods.SelectedItem;
				cycleProtect = false;
			}
		}

		private void tBxMethodEdit_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!cycleProtect && lBxMethods.SelectedIndex >= 0)
			{
				cycleProtect = true;
				int selectedIndex = lBxMethods.SelectedIndex;
				lBxMethods.Items[selectedIndex] = tBxMethodEdit.Text;
				lBxMethods.SelectedIndex = selectedIndex;
				cycleProtect = false;
			}
		}

		private void btnAddMethod_Click(object sender, RoutedEventArgs e)
		{
			lBxMethods.Items.Add("method(...)");
			lBxMethods.SelectedIndex = lBxMethods.Items.Count - 1;
		}

		private void btnRemoveMethod_Click(object sender, RoutedEventArgs e)
		{
			int osi;
			if ((osi = lBxMethods.SelectedIndex) >= 0)
			{
				lBxMethods.Items.RemoveAt(lBxMethods.SelectedIndex);
				if (osi < lBxMethods.SelectedIndex)
					lBxMethods.SelectedIndex = osi;
			}
		}

		private void btnUpMethod_Click(object sender, RoutedEventArgs e)
		{
			if (lBxMethods.SelectedIndex > 0)
			{
				int ind = lBxMethods.SelectedIndex;
				lBxMethods.UnselectAll();
				string s = (string)lBxMethods.Items[ind];
				lBxMethods.Items[ind] = (string)lBxMethods.Items[ind - 1];
				lBxMethods.Items[ind - 1] = s;
				lBxMethods.SelectedIndex = ind - 1;
			}
		}

		private void btnDownMethod_Click(object sender, RoutedEventArgs e)
		{
			if (lBxMethods.SelectedIndex < lBxMethods.Items.Count - 1)
			{
				int ind = lBxMethods.SelectedIndex;
				lBxMethods.UnselectAll();
				string s = (string)lBxMethods.Items[ind];
				lBxMethods.Items[ind] = lBxMethods.Items[ind + 1];
				lBxMethods.Items[ind + 1] = s;
				lBxMethods.SelectedIndex = ind + 1;
			}
		}

		private void lBxProperty_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!cycleProtect && lBxProperty.SelectedIndex >= 0)
			{
				cycleProtect = true;
				tBxPropertyEdit.Text = (string)lBxProperty.SelectedItem;
				cycleProtect = false;
			}
		}

		private void tBxPropertyEdit_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!cycleProtect && lBxProperty.SelectedIndex >= 0)
			{
				cycleProtect = true;
				int selectedIndex = lBxProperty.SelectedIndex;
				lBxProperty.Items[selectedIndex] = tBxPropertyEdit.Text;
				lBxProperty.SelectedIndex = selectedIndex;
				cycleProtect = false;
			}
		}

		private void btnAddProperty_Click(object sender, RoutedEventArgs e)
		{
			lBxProperty.Items.Add("property");
			lBxProperty.SelectedIndex = lBxProperty.Items.Count - 1;
		}

		private void btnDownProperty_Click(object sender, RoutedEventArgs e)
		{
			if (lBxProperty.SelectedIndex < lBxProperty.Items.Count - 1)
			{
				int ind = lBxProperty.SelectedIndex;
				string s = (string)lBxProperty.Items[ind];
				lBxProperty.Items[ind] = lBxProperty.Items[ind + 1];
				lBxProperty.Items[ind + 1] = s;
				lBxProperty.SelectedIndex++;
			}
		}

		private void btnUpProperty_Click(object sender, RoutedEventArgs e)
		{
			if (lBxProperty.SelectedIndex > 0)
			{
				int ind = lBxProperty.SelectedIndex;
				string s = (string)lBxProperty.Items[ind];
				lBxProperty.Items[ind] = lBxProperty.Items[ind - 1];
				lBxProperty.Items[ind - 1] = s;
				lBxProperty.SelectedIndex--;
			}
		}

		private void btnRemoveProperty_Click(object sender, RoutedEventArgs e)
		{
			int osi;
			if ((osi = lBxProperty.SelectedIndex) >= 0)
			{
				lBxProperty.Items.RemoveAt(lBxProperty.SelectedIndex);
				if (osi < lBxProperty.SelectedIndex)
					lBxProperty.SelectedIndex = osi;
			}

		}
	}
}
