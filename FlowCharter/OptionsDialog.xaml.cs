//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
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


namespace MindFusion.Diagramming.Wpf.Samples.CS.FlowCharter
{
	/// <summary>
	/// Interaction logic for OptionsDialog.xaml
	/// </summary>
	public partial class OptionsDialog : Window
	{
		public OptionsDialog()
		{
			InitializeComponent();
		}

		private void _okBtn_Click(object sender, RoutedEventArgs e)
		{
			if (!NewColors())
				return;

			DialogResult = true;
			Close();
		}

		private void _cancelBtn_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			Close();
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			AnchorStyle = 0;
			UpdateAnchorStyle();
		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{
			AnchorStyle = 1;
			UpdateAnchorStyle();
		}

		private void button3_Click(object sender, RoutedEventArgs e)
		{
			AnchorStyle = 2;
			UpdateAnchorStyle();
		}

		private void UpdateAnchorStyle()
		{
			_circleBtn.IsEnabled = !(AnchorStyle == 0);
			_rectBtn.IsEnabled = !(AnchorStyle == 1);
			_xBtn.IsEnabled = !(AnchorStyle == 2);
		}

		private bool NewColors()
		{
			TextBox err = null;
			try
			{
				byte r, g, b;
				
				err = bBR;
				r = Byte.Parse(bBR.Text);
				err = bBR;
				g = Byte.Parse(bBG.Text);
				err = bBR;
				b = Byte.Parse(bBB.Text);

				_backBrush = new SolidColorBrush(Color.FromRgb(r, g, b));

				err = nBR;
				r = Byte.Parse(nBR.Text);
				err = nBG;
				g = Byte.Parse(nBG.Text);
				err = nBB;
				b = Byte.Parse(nBB.Text);
				_nodeBrush = new SolidColorBrush(Color.FromRgb(r, g, b));

				err = cBR;
				r = Byte.Parse(cBR.Text);
				err = cBR;
				g = Byte.Parse(cBG.Text);
				err = cBR;
				b = Byte.Parse(cBB.Text);
				_connectorBrush = new SolidColorBrush(Color.FromRgb(r, g, b));

				err = aBR;
				r = Byte.Parse(aBR.Text);
				err = aBR;
				g = Byte.Parse(aBG.Text);
				err = aBR;
				b = Byte.Parse(aBB.Text);

				_anchorBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
			}
			catch (Exception exp)
			{
				MessageBox.Show("Error! " + exp.Message);
				err.SelectAll();
				return false;
			}

			return true;
		}

		public bool ShowGrid
		{
			get { return (bool)_showGridCheck.IsChecked; }
			set { _showGrid = value; }
		}
		public SolidColorBrush BackBrush
		{
			get { return _backBrush; }
			set { _backBrush = value; }
		}
		public SolidColorBrush NodeBrush
		{
			get { return _nodeBrush; }
			set { _nodeBrush = value; }
		}
		public SolidColorBrush ConnectorBrush
		{
			get { return _connectorBrush; }
			set { _connectorBrush = value; }
		}

		public bool ShowAnchors
		{
			get { return (bool)_showAnchorsCheck.IsChecked; }
			set { _showAnchors = value; }
		}
		public SolidColorBrush AnchorBrush
		{
			get { return _anchorBrush; }
			set { _anchorBrush = value; }
		}
		public int AnchorStyle
		{
			get { return _anchorStyle; }
			set { _anchorStyle = value; }
		}

		private bool _showGrid;
		private SolidColorBrush _backBrush;
		private SolidColorBrush _nodeBrush;
		private SolidColorBrush _connectorBrush;

		private bool _showAnchors;
		private SolidColorBrush _anchorBrush;
		private int _anchorStyle;

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			_showGridCheck.IsChecked = _showGrid;
			bBR.Text = _backBrush.Color.R.ToString();
			bBG.Text = _backBrush.Color.G.ToString();
			bBB.Text = _backBrush.Color.B.ToString();

			nBR.Text = _nodeBrush.Color.R.ToString();
			nBG.Text = _nodeBrush.Color.G.ToString();
			nBB.Text = _nodeBrush.Color.B.ToString();

			cBR.Text = _connectorBrush.Color.R.ToString();
			cBG.Text = _connectorBrush.Color.G.ToString();
			cBB.Text = _connectorBrush.Color.B.ToString();

			aBR.Text = _anchorBrush.Color.R.ToString();
			aBG.Text = _anchorBrush.Color.G.ToString();
			aBB.Text = _anchorBrush.Color.B.ToString();
			
			_showAnchorsCheck.IsChecked = _showAnchors;
			UpdateAnchorStyle();
		}
	}
}
