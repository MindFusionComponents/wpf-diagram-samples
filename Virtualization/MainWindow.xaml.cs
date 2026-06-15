//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Virtualization
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void OnLoaded(object sender, RoutedEventArgs e)
		{
			// set large enough Bounds to fit 100000 nodes
			diagram.Bounds = new Rect(0, 0, 40 + 20 * 100000, 1520);

			// this size is used when data items do not expose Width and Height properties
			diagram.DefaultNodeSize = new Size(42, 16);

			// do not display arrowheads
			diagram.LinkHeadShape = null;

			// enable two way binding
			diagram.BindingMode = BindingMode.TwoWay;

			// create data items when the user draws new nodes and links
			diagram.InstantiateNodeData = (node => new NodeData { Text = "new" });
			diagram.InstantiateLinkData = (link => new LinkData { Text = "new" });

			// allow editing items' text by double-click
			diagramView.AllowInplaceEdit = true;

			// create a collection of node data items
			var nodes = new ObservableCollection<NodeData>();
			for (int i = 0; i < 100000; ++i)
			{
				var node = new NodeData();
				node.X = 10 + i * 20;
				node.Y = 260 + 250 * Math.Sin(Math.PI * i / 22.5);
				node.Value = i;
				node.Text = i.ToString();
				nodes.Add(node);
			}

			// set the collection as data source
			diagram.NodesSource = nodes;

			// create a collection of link data items
			var links = new ObservableCollection<LinkData>();
			for (int i = 0; i < 50000 - 7; ++i)
			{
				var link = new LinkData();
				link.Origin = nodes[2 * i];
				link.Destination = nodes[2 * i + 13];
				link.Text = "";
				links.Add(link);
			}

			// set the collection as data source
			diagram.LinksSource = links;
		}

		private void OnNodeRealized(object sender, VirtualNodeEventArgs e)
		{
			var nodeData = (NodeData)e.DataItem;
			e.Node.Brush = new SolidColorBrush(
				Color.FromArgb(255, 0, (byte)(100 + nodeData.Value % 155), (byte)(nodeData.Value % 255)));
		}

		private void OnLinkRealized(object sender, VirtualLinkEventArgs e)
		{
			e.Link.ZIndex = 0;
		}
	}

	public class NodeData : INotifyPropertyChanged
	{
		private double x;
		public double X
		{
			get { return x; }
			set
			{
				if (x != value)
				{
					x = value;
					if (PropertyChanged != null)
						PropertyChanged(this, new PropertyChangedEventArgs("X"));
					//Debug.WriteLine("x: " + x);
				}
			}
		}

		private double y;
		public double Y
		{
			get { return y; }
			set
			{
				if (y != value)
				{
					y = value;
					if (PropertyChanged != null)
						PropertyChanged(this, new PropertyChangedEventArgs("Y"));
					//Debug.WriteLine("y: " + y);
				}
			}
		}

		private string text;
		public string Text
		{
			get { return text; }
			set
			{
				if (text != value)
				{
					text = value;
					if (PropertyChanged != null)
						PropertyChanged(this, new PropertyChangedEventArgs("Text"));
					//Debug.WriteLine("text: " + text);
				}
			}
		}

		public int Value { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;
	}

	public class LinkData : INotifyPropertyChanged
	{
		private NodeData origin;
		public NodeData Origin
		{
			get { return origin; }
			set
			{
				if (origin != value)
				{
					origin = value;
					if (PropertyChanged != null)
						PropertyChanged(this, new PropertyChangedEventArgs("Origin"));
				}
			}
		}

		private NodeData destination;
		public NodeData Destination
		{
			get { return destination; }
			set
			{
				if (destination != value)
				{
					destination = value;
					if (PropertyChanged != null)
						PropertyChanged(this, new PropertyChangedEventArgs("Destination"));
				}
			}
		}

		public string Text { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
