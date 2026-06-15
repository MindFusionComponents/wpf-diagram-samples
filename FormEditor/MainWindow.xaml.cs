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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MindFusion.Diagramming.Wpf.Samples.CS.FormEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            form.MeasureUnit = GraphicsUnit.Point;
        }

        void Window_Loaded(object sender, RoutedEventArgs e)
        {
            palette.SelectedIndex = 0;

            form.BackBrush = Brushes.LightGray;

			formView.Behavior = Behavior.Custom;
            form.CustomNodeType = typeof(Button);
        }

        void form_NodeCreated(object sender, NodeEventArgs e)
        {
            var node = e.Node as ControlNode;
            if (node != null)
            {
                if (form.CustomNodeType == typeof(Button))
                {
                    Button button = (Button)node.Control;
                    button.FontSize = 11;
                    button.Padding = new Thickness(0.5);
                    button.Content = "Button" + form.Nodes.Count.ToString();
                }
            }
		}

        void palette_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (palette.SelectedIndex)
            {
                case 0:
                    form.CustomNodeType = typeof(Button);
                    return;
                case 1:
                    form.CustomNodeType = typeof(TextBox);
                    return;
                case 2:
                    form.CustomNodeType = typeof(Label);
                    return;
            }
        }

        void form_NodeActivated(object sender, NodeEventArgs e)
        {
			var node = e.Node as ControlNode;
			if (node != null)
				propGrid.SelectedObject = node.Control;
        }

        void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog();

            if (sfd.ShowDialog() == true)
                form.SaveToXml(sfd.FileName);
        }

        void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();

			if (ofd.ShowDialog() == true)
			{
				try
				{
					form.LoadFromXml(ofd.FileName);
				}
				catch
				{
					MessageBox.Show("Invalid file format.");
				}
			}
        }

        void form_InitializeNode(object sender, NodeEventArgs e)
        {
            var node = e.Node as ControlNode;
            if (node != null)
            {
                TextBox tbox = node.Control as TextBox;
                if (tbox != null)
                {
                    tbox.FontSize = 11;
                    tbox.Padding = new Thickness(0.5);
                    tbox.TextWrapping = TextWrapping.Wrap;
				}

                Label label = node.Control as Label;
                if (label != null)
                {
                    label.FontSize = 11;
                    label.Content = "Label";
                    label.Padding = new Thickness(0.5);
                }
            }
        }
    }
}
