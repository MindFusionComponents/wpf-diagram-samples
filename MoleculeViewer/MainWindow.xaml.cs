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
using System.Collections;
using System.Windows.Media.Media3D;

namespace MoleculeViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Diagram diagram;
        private Brush linkBrush;
        private Brush tickLinkBrush;

        private double linkThickness;
        private double tickLinkThickness;

        ArrayList linkers;
        Queue<Linker> queue;
        Queue<Linker> linkedNodes;

        public MainWindow()
        {
            InitializeComponent();


            diagram = new Diagram();
            view3D.Diagram = diagram;
            view3D.Scale = 1000;
            view3D.RotationAngle = 0;
            view3D.NodeThickness = 0;
            view3D.LinkScalingMode = ScalingMode.None;

            linkBrush = new SolidColorBrush(Colors.DarkSlateBlue);
            tickLinkBrush = new SolidColorBrush(Colors.ForestGreen);



            linkThickness = 2;
            tickLinkThickness = 4;

            linkers = new ArrayList();
            queue = new Queue<Linker>();
            linkedNodes = new Queue<Linker>();


            view3D.Lights.Clear();
            view3D.Lights.Add(new AmbientLight());
        }

        private void SetRotationCenter(Point3D[] positions)
        {
            DoubleCollection xCol = new DoubleCollection();
            DoubleCollection yCol = new DoubleCollection();
            DoubleCollection zCol = new DoubleCollection();
            for (int i = 0; i < positions.Length; i++)
            {
                xCol.Add(positions[i].X);
                yCol.Add(positions[i].Y);
                zCol.Add(positions[i].Z);
            }
        }

        private void LoadEthane()
        {
            Point3D[] positions = new Point3D[] {
                new Point3D(0, 0, 0),
                new Point3D(-18, 29.8, 2.93),
                new Point3D(-18, -12.33, -27.34),
                new Point3D(-18, -17.51, 24.35),
                new Point3D(30, 0, 0),
                new Point3D(38, -29.8, -2.93),
                new Point3D(38, 12.33, 27.34),
                new Point3D(38, 17.511, -24.35),
            };

            ShapeNode zNode = null;
            ShapeNode cNode = null;

            Brush brush1 = NodeBrush(new Size(60, 60), true);
            Brush brush2 = NodeBrush(new Size(45, 45), false);

            for (int i = 0; i < positions.Length; i++)
            {
                if (i % 4 == 0)
                {
                    if (i == 0)
                    {
                        cNode = CreateShapeNode(positions[i], new Rect(0, 0, 60, 60), brush1, "C");
                        zNode = cNode;
                    }
                    else
                    {
                        zNode = CreateShapeNode(positions[i], new Rect(0, 0, 60, 60), brush1, "C");
                        CreateDiagramLink(cNode, zNode, tickLinkBrush, tickLinkThickness);
                        cNode = zNode;
                    }
                }
                else
                {
                    zNode = CreateShapeNode(positions[i], new Rect(0, 0, 45, 45), brush2, "H" + i);
                    CreateDiagramLink(cNode, zNode, linkBrush, linkThickness);
                }
            }
        }

        private void LoadBenzene()
        {
            ShapeNode zNode;
            Point3D[] positions = new Point3D[] {		
				new Point3D(3, 33,0),
				new Point3D(5, 63,0),
				new Point3D(30, 13,0),
				new Point3D(53, 32,0),
				new Point3D(27, -19,0),
				new Point3D(48, -41,0),				
				new Point3D(-3, -33,0),
				new Point3D(-5, -63,0),
				new Point3D(-30, -13,0),
				new Point3D(-53, -32,0),
				new Point3D(-27, 19,0),
				new Point3D(-48, 41,0),
			};


            DiagramNode buffNodeC = null;
            DiagramNode firstNode = null;

            Brush brush1 = NodeBrush(new Size(60, 60), true);
            Brush brush2 = NodeBrush(new Size(60, 60), false);

            bool isTwoLinks = false;
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    zNode = CreateShapeNode(positions[i], new Rect(0, 0, 60, 60), brush1, "C");
                    if (buffNodeC != null)
                    {
                        if (isTwoLinks)
                            CreateDiagramLink(buffNodeC, zNode, linkBrush, linkThickness);
                        else
                            CreateDiagramLink(buffNodeC, zNode, tickLinkBrush, tickLinkThickness);

                        buffNodeC = zNode;
                        isTwoLinks = !isTwoLinks;
                    }
                    else
                    {
                        buffNodeC = zNode;
                        firstNode = zNode;
                    }
                }
                else
                {
                    zNode = CreateShapeNode(positions[i], new Rect(0, 0, 60, 60), brush2, "H");
                    CreateDiagramLink(buffNodeC, zNode, linkBrush, linkThickness);
                }
            }

            CreateDiagramLink(buffNodeC, firstNode, linkBrush, linkThickness);
        }

        private void LoadBuckminsterfullerene()
        {
            Point3D[] positions = new Point3D[] {		
				new Point3D(36.795, 0.00000000, 99.435),
				new Point3D(11.37, 34.992, 99.435),
				new Point3D(-29.766, 21.627, 99.435),
				new Point3D(-29.766, -21.627, 99.435),
				new Point3D(11.37, -34.992, 99.435),
				new Point3D(102.252, 21.627, 17.844),
				new Point3D(83.853, 34.992, 54.639),
				new Point3D(72.483, 0.00000000, 77.379),
				new Point3D(83.853, -34.992, 54.639),
				new Point3D(102.252, -21.627, 17.844),
				new Point3D(11.028, 103.929, 17.844),
				new Point3D(-7.368, 90.564, 54.639),
				new Point3D(22.398, 68.937, 77.379),
				new Point3D(59.193, 68.937, 54.639),
				new Point3D(52.167, 90.564, 17.844),
				new Point3D(-95.436, 42.606, 17.844),
				new Point3D(-88.407, 20.979, 54.639),
				new Point3D(-58.641, 42.606, 77.379),
				new Point3D(-47.271, 77.598, 54.639),
				new Point3D(-70.011, 77.598, 17.844),//20
				new Point3D(-70.011, -77.598, 17.844),
				new Point3D(-47.271, -77.598, 54.639),
				new Point3D(-58.641, -42.606, 77.379),
				new Point3D(-88.407, -20.979, 54.639),
				new Point3D(-95.436, -42.606, 17.844),
				new Point3D(52.167, -90.564, 17.844),
				new Point3D(59.193, -68.937, 54.639),
				new Point3D(22.398, -68.937, 77.379),
				new Point3D(-7.368, -90.564, 54.639),
				new Point3D(11.028, -103.929, 17.844),
				new Point3D(29.766, 21.627, -99.435),
				new Point3D(-11.37, 34.992, -99.435),
				new Point3D(-36.795, 0.00000000, -99.435),
				new Point3D(-11.37, -34.992, -99.435),
				new Point3D(29.766, -21.627, -99.435),
				new Point3D(70.011, 77.598, -17.844),
				new Point3D(47.271, 77.598, -54.639),
				new Point3D(58.641, 42.606, -77.379),
				new Point3D(88.407, 20.979, -54.639),
				new Point3D(95.436, 42.606, -17.844),//40
				new Point3D(-52.167, 90.564, -17.844),
				new Point3D(-59.193, 68.937, -54.639),
				new Point3D(-22.398, 68.937, -77.379),
				new Point3D(7.368, 90.564, -54.639),
				new Point3D(-11.028, 103.929, -17.844),
				new Point3D(-102.252, -21.627, -17.844),
				new Point3D(-83.853, -34.992, -54.639),
				new Point3D(-72.483, 0.00000000, -77.379),
				new Point3D(-83.853, 34.992, -54.639),
				new Point3D(-102.252, 21.627, -17.844),
				new Point3D(-11.028, -103.929, -17.844),
				new Point3D(7.368, -90.564, -54.639),
				new Point3D(-22.398, -68.937, -77.379),
				new Point3D(-59.193, -68.937, -54.639),
				new Point3D(-52.167, -90.564, -17.844),
				new Point3D(95.436, -42.606, -17.844),
				new Point3D(88.407, -20.979, -54.639),
				new Point3D(58.641, -42.606, -77.379),
				new Point3D(47.271, -77.598, -54.639),
				new Point3D(70.011, -77.598, -17.844)//60
			};

            // create the nodes
            ShapeNode zNode = null;
            Brush brush = NodeBrush(new Size(45, 45), false);
            for (int i = 0; i < positions.Length; i++)
            {
                zNode = CreateShapeNode(positions[i], new Rect(0, 0, 45, 45), brush, "C");
                zNode.Tag = true;

                Linker linker = new Linker(zNode);
                linkers.Add(linker);
                if (queue.Count == 0)
                    queue.Enqueue(linker);
            }

            SetLinks();
            queue.Clear();
            linkedNodes.Clear();
            linkers.Clear();
        }

        private void SetLinks()
        {
            while (queue.Count != 0)
            {
                Linker linker = queue.Dequeue();
                linkedNodes.Enqueue(linker);
                ShapeNode node = linker.CurrentNode;

                double[] dists = new double[4];
                Linker[] lks = new Linker[4];
                for (int j = 0; j < dists.Length; j++)
                {
                    dists[j] = -1;
                    lks[j] = null;
                }

                int n = 0;

                // find the smallest distances
                for (int ii = 0; ii < linkers.Count; ii++)
                {
                    Linker lk = (Linker)linkers[ii];
                    ShapeNode nd = lk.CurrentNode;
                    if (node.Equals(nd))
                        continue;

                    // calculate the distance between the lks
                    double d = CalcDistance(DiagramView3D.GetPosition3D(node), DiagramView3D.GetPosition3D(nd));

                    // sorting by distance
                    if (n >= dists.Length)
                    {
                        dists[dists.Length - 1] = d;
                        lks[dists.Length - 1] = lk;
                        Sort(dists, lks);
                    }
                    else
                    {
                        for (int m = 0; m < dists.Length; m++, n++)
                            if (dists[m] == -1)
                            {
                                dists[m] = d;
                                lks[m] = lk;
                                Sort(dists, lks);
                                n++;
                                break;
                            }
                    }
                }

                // set the node's links
                for (int ii = 0; ii < dists.Length - 1; ii++)
                {
                    if (lks[ii].Counter == 3 || linkedNodes.Contains(lks[ii]))
                        continue;

                    if (linker.DoubleLink == null && lks[ii].DoubleLink == null)
                    {
                        CreateDiagramLink(node, lks[ii].CurrentNode, tickLinkBrush, tickLinkThickness);

                        linker.DoubleLink = lks[ii].CurrentNode;
                        lks[ii].DoubleLink = node;
                    }
                    else
                    {
                        CreateDiagramLink(node, lks[ii].CurrentNode, linkBrush, linkThickness);

                        linker.SingleLink(lks[ii].CurrentNode);
                        lks[ii].SingleLink(linker.CurrentNode);
                    }

                    if (!queue.Contains(lks[ii]))
                        queue.Enqueue(lks[ii]);
                }
            }
        }

        // Bubble sort
        private void Sort(double[] dist, Linker[] lks)
        {
            for (int i = 0; i < dist.Length - 1; i++)
            {
                for (int j = 0; j < dist.Length - 1 - i; j++)
                {
                    if (dist[j + 1] < dist[j])
                    {
                        double tmpD = dist[j];
                        dist[j] = dist[j + 1];
                        dist[j + 1] = tmpD;

                        Linker tmpL = lks[j];
                        lks[j] = lks[j + 1];
                        lks[j + 1] = tmpL;
                    }
                }
            }
        }

        private double CalcDistance(Point3D src, Point3D dst)
        {
            double x = Math.Abs(src.X - dst.X);
            double y = Math.Abs(src.Y - dst.Y);
            double z = Math.Abs(src.Z - dst.Z);

            return Math.Sqrt(x * x + y * y + z * z);
        }

        private ShapeNode CreateShapeNode(Point3D position, Rect bounds, Brush brush, string text)
        {
            return CreateShapeNode(position, bounds, brush, text, false);
        }

        private ShapeNode CreateShapeNode(Point3D position, Rect bounds, Brush brush, string text, bool stroked)
        {
            double coef = 3;
            Point3D p = new Point3D(position.X * coef, position.Y * coef, position.Z * coef);
            ShapeNode node = new ShapeNode()
            {
                Shape = Shapes.Ellipse,
                Brush = brush,
                StrokeThickness = stroked ? 1 : 0,
                Bounds = bounds,
                Text = text,
                TextAlignment = TextAlignment.Center,
                TextVerticalAlignment = AlignmentY.Center,
            };
            node.Text = "";
            DiagramView3D.SetPosition3D(node, p);
            diagram.Items.Add(node);
            return node;
        }

        private DiagramLink CreateDiagramLink(DiagramNode origin, DiagramNode destination, Brush stroke, double strokeThickness)
        {
            DiagramLink link = new DiagramLink()
            {
                Stroke = stroke,
                StrokeThickness = strokeThickness,
            };

            link.Origin = origin;
            link.Destination = destination;
            diagram.Items.Add(link);

            return link;
        }

        private VisualBrush NodeBrush(Size size, bool dark)
        {
            Color lightColor = new Color();
            Color darkColor = new Color();
            Color borderColor = new Color();
            if (!dark)
            {
                lightColor = Colors.LightSteelBlue;
                darkColor = Colors.DarkSlateBlue;
                borderColor = Colors.LightSteelBlue;
            }
            else
            {
                lightColor = Colors.LightGreen;
                darkColor = Colors.ForestGreen;
                borderColor = Colors.LightGreen;
            }



            Grid g = new Grid();
            RadialGradientBrush radialBrush = new RadialGradientBrush()
            {
                GradientOrigin = new Point(0.5, 1),
                Center = new Point(0.5, 1),
                RadiusX = 1.2,
                RadiusY = 1.2,
            };

            GradientStop stop1 = new GradientStop() { Offset = 0.2, Color = lightColor };
            GradientStop stop2 = new GradientStop() { Offset = 0.5, Color = darkColor };
            radialBrush.GradientStops.Add(stop1);
            radialBrush.GradientStops.Add(stop2);


            Ellipse ellipse = new Ellipse()
            {
                Fill = radialBrush,
                Width = size.Width,
                Height = size.Height,
            };
            g.Children.Add(ellipse);



            RadialGradientBrush shadowBrush = new RadialGradientBrush();
            GradientStop shadow1 = new GradientStop() { Offset = 0.85, Color = Color.FromArgb(0, 0, 0, 0) };
            GradientStop shadow2 = new GradientStop() { Offset = 1, Color = Color.FromArgb(255, 0, 0, 0) };
            shadowBrush.GradientStops.Add(shadow1);
            shadowBrush.GradientStops.Add(shadow2);

            Ellipse shadowEllipse = new Ellipse()
            {
                StrokeThickness = 2,
                Fill = shadowBrush,
                Stroke = new SolidColorBrush(borderColor),
                Width = size.Width,
                Height = size.Height,
            };
            g.Children.Add(shadowEllipse);



            LinearGradientBrush glowBrush = new LinearGradientBrush();
            glowBrush.StartPoint = new Point(0, 0);
            glowBrush.EndPoint = new Point(0, 1);
            GradientStop glow1 = new GradientStop() { Offset = 0, Color = Color.FromArgb(255, 255, 255, 255) };
            GradientStop glow2 = new GradientStop() { Offset = 0.7, Color = Color.FromArgb(0, 255, 255, 255) };
            glowBrush.GradientStops.Add(glow1);
            glowBrush.GradientStops.Add(glow2);

            Ellipse glowEllipse = new Ellipse()
            {
                Margin = new Thickness(0, 2, 0, 0),
                Fill = glowBrush,
                Stroke = null,
                Width = size.Width * 0.7,
                Height = size.Height * 0.6,
                VerticalAlignment = System.Windows.VerticalAlignment.Top,
            };

            g.Children.Add(glowEllipse);

            VisualBrush brush = new VisualBrush();
            brush.Visual = g;
            return brush;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = diagram.Items.Count - 1; i >= 0; i--)
                diagram.Items.Remove(diagram.Items[i]);

            Button button = sender as Button;
            if (button.Name == "Ethane")
            {
                view3D.Scale = 800;               
                LoadEthane();
            }
            if (button.Name == "Benzene")
            {
                view3D.Scale = 1000;                
                LoadBenzene();
            }
            if (button.Name == "Buckminsterfullerene")
            {
                view3D.Scale = 1500;                
                LoadBuckminsterfullerene();
            }          
        }
    }
}
