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
	/// Interaction logic for TourForm.xaml
	/// </summary>
	public partial class TourForm : Window
	{
		private Diagram _theChart;
		private ShapeNode _theBox;

		public TourForm()
		{
			InitializeComponent();
		}

		private void btnEnd_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		public Diagram TheChart
		{
			set
			{
				_theChart = value;

				// Initialize controls
				if (_theChart.Selection.Nodes.Count > 0)
				{
					_theBox = _theChart.Selection.Nodes[0] as ShapeNode;
					SetOptions(_theBox);
				}
			}
		}

		private void SetOptions(ShapeNode b)
		{
			descEdit.Text = b.PlainText;
			optionsList.Items.Clear();

			if (b.OutgoingLinks == null)
				return;

			foreach (DiagramLink a in b.OutgoingLinks)
				optionsList.Items.Add(a.Text);
		}

		private void optionsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			int i = optionsList.SelectedIndex;
			if (i >= 0)
			{
				DiagramLink a = _theBox.OutgoingLinks[i];
				_theBox = (ShapeNode)a.Destination;
				SetOptions(_theBox);
			}
		}
	}
}
