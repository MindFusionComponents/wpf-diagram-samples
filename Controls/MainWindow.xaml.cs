//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

using MindFusion.Diagramming.Wpf;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            

            int index = 0;
            for (int i = 0; i < 50; i++)
            {
                ShapeNode node = new ShapeNode();
                node.Bounds = new Rect(0, 0, 30, 30);
                node.Shape = MindFusion.Diagramming.Wpf.Shape.Shapes[i];
                node.Margin = new Thickness(2, 2, 5, 2);

                NodeListView.SetLabel(node, MindFusion.Diagramming.Wpf.Shape.Shapes[i].Id);
                nodeListView.Items.Add(node);
                index += 1;
            }

			overview.TrackingRectPen = new Pen(Brushes.Red, 3);
        }

        private void nodeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShapeNode node = (sender as NodeListView).SelectedItem as ShapeNode;
            diagram.DefaultShape = node.Shape;
        }       

        private void diagram_Drop(object sender, DragEventArgs e)
        {
            ShapeNode node = diagram.Items[diagram.Items.Count - 1] as ShapeNode;
            node.Bounds = new Rect(node.Bounds.Left, node.Bounds.Top, 75, 75);
        }
    }
}
