//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.InteractiveTable
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			ShapeNode info = new ShapeNode(diagram);
			info.Bounds = new Rect(15, 15, 320, 100);
			info.Brush = new SolidColorBrush(Colors.White);
			info.Text = "This sample shows how to select table cell values from a combo box. " +
				"Draw a table here and click on its cells to display the combo box.";
			info.Locked = true;
			info.Transparent = true;
			diagram.Nodes.Add(info);
		}

		void OnCreateEditControl(object sender, InPlaceEditEventArgs e)
		{
			ComboBox comboBox = new ComboBox();
			for (int i = 1; i <= 5; i++)
				comboBox.Items.Add($"Option {i}");

			var cell = e.Item as TableNode.Cell;
			if (cell != null)
			{
				comboBox.Background = new SolidColorBrush(
					Color.FromRgb(224, 233, 233));
				e.EditControl = comboBox;

				comboBox.SelectedItem = cell.Text;
			}
		}

		void OnDestroyEditControl(object sender, InPlaceEditEventArgs e)
		{
			var comboBox = (ComboBox)e.EditControl;
			if (comboBox.SelectedItem != null)
				e.Item.SetEditedText(comboBox.SelectedItem.ToString());
		}

		void OnNodeCreated(object sender, NodeEventArgs e)
		{
			var table = e.Node as TableNode;
			if (table != null)
			{
				table.Brush = new LinearGradientBrush(
					Color.FromRgb(224, 233, 233), Color.FromRgb(90, 121, 165), 30);
				table.CaptionBrush = new SolidColorBrush(Color.FromRgb(0, 52, 102));
				table.TextBrush = new SolidColorBrush(Colors.White);
				table.TextPadding = new Thickness(5, 2, 5, 2);
				table.TextVerticalAlignment = AlignmentY.Center;
				table.CellTextStyle.TextVerticalAlignment = AlignmentY.Center;
				table.ColumnWidth = table.Bounds.Width - 1;
				table.Columns[0].ColumnStyle = ColumnStyle.AutoWidth;
			}
		}

		void OnCellClicked(object sender, CellEventArgs e)
		{
			diagramView.BeginEdit(e.Cell);
		}
	}
}
