using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MindFusion.Diagramming.Wpf;
using System.Windows.Threading;

namespace SpringLayout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MindFusion.Diagramming.Wpf.Layout.SpringLayout layout;
        Diagram diagram = new Diagram();
        DispatcherTimer timer = new DispatcherTimer();
        private int currentIteration;

        public MainWindow()
        {
            InitializeComponent();

            layout = new MindFusion.Diagramming.Wpf.Layout.SpringLayout();
            layout.Layout3D = true;           
           
            view3D.Diagram = diagram;
            view3D.NodeThickness = 0;           
            view3D.Scale = 800;
            view3D.LinkScalingMode = ScalingMode.None;
            
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromTicks(40);

            for (int i = 0; i < 50; ++i)
            {
                ShapeNode node = new ShapeNode();
                node.StrokeThickness = 2;
                node.Bounds = new Rect(0, 0, 45, 45);
                node.Shape = Shapes.Ellipse;
                node.Text = i.ToString();
                node.TextVerticalAlignment = AlignmentY.Center;
                node.TextAlignment = TextAlignment.Center;
                node.Brush = new LinearGradientBrush(Colors.White, i % 2 == 0 ?
                    Colors.LightSkyBlue : Colors.LightSeaGreen, 0);
                diagram.Items.Add(node);
            }

            int nc = diagram.Nodes.Count;
            for (int i = 0; i < 50; ++i)
            {
                DiagramLink link = new DiagramLink();
                link.Origin = diagram.Nodes[i];
                link.Destination = diagram.Nodes[(i + 1) % nc];
                diagram.Items.Add(link);

                DiagramLink link2 = new DiagramLink();
                link2.Origin = diagram.Nodes[i];
                link2.Destination = diagram.Nodes[(i + 2) % nc];
                diagram.Items.Add(link2);
            }

            view3D.LinkThickness = 2;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            view3D.BeginInit();
            layout.Iterate(currentIteration, ++currentIteration);
            view3D.EndInit();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == "button1")
            {
                if (!timer.IsEnabled)
                {
                    layout.BeginArrange(diagram, null);
                    timer.IsEnabled = true;
                    currentIteration = 0;
                }
            }
            else
            {
                if (timer.IsEnabled)
                {
                    layout.EndArrange();
                    timer.IsEnabled = false;
                }
            }      
        }
    }
}
