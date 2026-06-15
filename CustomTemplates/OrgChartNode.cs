//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Media;

using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

using MindFusion.Diagramming.Wpf;
using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.CustomTemplates
{
	public class OrgChartNode : TemplatedNode
	{
		static OrgChartNode()
		{
			DefaultStyleKeyProperty.OverrideMetadata(
				typeof(OrgChartNode), new FrameworkPropertyMetadata(typeof(OrgChartNode)));

			Images = new List<ImageSource>(new ImageSource[]
			{
				new BitmapImage(new Uri("Images/011.png", UriKind.Relative)),
				new BitmapImage(new Uri("Images/012.png", UriKind.Relative)),
				new BitmapImage(new Uri("Images/019.png", UriKind.Relative)),
				new BitmapImage(new Uri("Images/020.png", UriKind.Relative)),
				new BitmapImage(new Uri("Images/026.png", UriKind.Relative)),
				new BitmapImage(new Uri("Images/051.png", UriKind.Relative)),
				new BitmapImage(new Uri("Images/057.png", UriKind.Relative)),
				new BitmapImage(new Uri("Images/058.png", UriKind.Relative)),
			});

			Titles = new List<string>(new string[]
			{
				"Support",
				"Public Relations",
				"CEO",
				"Delivery",
				"Research",
				"Management",
				"Development",
				"Consulting",
			});

			Fills = new List<Brush>(new Brush[]
			{
				new LinearGradientBrush(Colors.White, Colors.PaleGoldenrod, new Point(0, 0), new Point(0, 1)),
				new LinearGradientBrush(Colors.White, Colors.PaleGreen, new Point(0, 0), new Point(0, 1)),
				new LinearGradientBrush(Colors.White, Colors.PaleTurquoise, new Point(0, 0), new Point(0, 1)),
				new LinearGradientBrush(Colors.White, Colors.PaleVioletRed, new Point(0, 0), new Point(0, 1)),
				new LinearGradientBrush(Colors.White, Colors.PapayaWhip, new Point(0, 0), new Point(0, 1)),
				new LinearGradientBrush(Colors.White, Colors.PeachPuff, new Point(0, 0), new Point(0, 1)),
				new LinearGradientBrush(Colors.White, Colors.Peru, new Point(0, 0), new Point(0, 1)),
				new LinearGradientBrush(Colors.White, Colors.Pink, new Point(0, 0), new Point(0, 1)),
			});
		}

		public OrgChartNode()
		{
			Init();
		}

		public OrgChartNode(Diagram parent)
			: base(parent)
		{
			Init();
		}

		void Init()
		{
			FullName = FullNamePlaceholder;
			Text = TextPlaceholder;

			Stroke = Brushes.Gray;
			StrokeThickness = 5;
			Index = 0;

			HandlesStyle = HandlesStyle.HatchHandles3;
		}

		protected override FrameworkElement CreateRenderer(
			bool activeView, bool lightweight)
		{
			var renderer = base.CreateRenderer(activeView, lightweight);
			renderer.AddHandler(
				Button.ClickEvent, new RoutedEventHandler(OnClick));
			return renderer;
		}

		void OnClick(object sender, RoutedEventArgs e)
		{
			Button button = e.OriginalSource as Button;
			switch (button.Name)
			{
				case "PreviousImageButton":
					if (Index != -1)
						Index = (Index - 1 + Images.Count) % Images.Count;
					break;

				case "NextImageButton":
					if (Index != -1)
						Index = (Index + 1 + Images.Count) % Images.Count;
					break;

				case "AddSubordinateButton":
					{
						if (Parent == null)
							return;

						OrgChartNode newNode = new OrgChartNode(Parent);
						newNode.Bounds = new Rect(Bounds.Left + 50, Bounds.Bottom + 50, 300, 160);
						Parent.Nodes.Add(newNode);

						Parent.Factory.CreateDiagramLink(this, newNode);

						int rootCount = 0;
						foreach (DiagramNode node in Parent.Nodes)
						{
							if (node.IncomingLinks.Count == 0)
								rootCount++;
						}

						// Run a tree layout on this branch
						TreeLayout layout = new TreeLayout();
						layout.Type = TreeLayoutType.Centered;
						layout.LinkStyle = TreeLayoutLinkType.Cascading3;
						layout.Direction = TreeLayoutDirections.TopToBottom;
						if (rootCount <= 1)
							layout.KeepRootPosition = true;
						else
							layout.KeepRootPosition = false;
						layout.LevelDistance = 40;
						layout.Arrange(Parent);

						Rect nodeBounds = Rect.Empty;
						foreach (DiagramNode node in Parent.Nodes)
						{
							if (nodeBounds.IsEmpty)
								nodeBounds = node.Bounds;
							else
								nodeBounds = Rect.Union(nodeBounds, node.Bounds);
						}

						Rect documentBounds = Parent.Bounds;
						const float Threshold = 5;
						if (nodeBounds.Left < documentBounds.Left + Threshold)
						{
							documentBounds.Width = (documentBounds.Right - nodeBounds.X + Threshold);
							documentBounds.X = nodeBounds.X - Threshold;
						}
						if (nodeBounds.Top < documentBounds.Top + Threshold)
						{
							documentBounds.Height = (documentBounds.Bottom - nodeBounds.Y + Threshold);
							documentBounds.Y = nodeBounds.Y - Threshold;
						}
						if (nodeBounds.Right > documentBounds.Right + Threshold)
						{
							documentBounds.Width = nodeBounds.Right - documentBounds.X + Threshold;
						}
						if (nodeBounds.Bottom > documentBounds.Bottom + Threshold)
						{
							documentBounds.Height = nodeBounds.Bottom - documentBounds.Y + Threshold;
						}

						Parent.Bounds = documentBounds;
					}
					break;
			}
		}

		public int Index
		{
			get { return Images.IndexOf(Image); }
			set
			{
				if (value != -1)
				{
					Image = Images[value];
					Title = Titles[value];
					Brush = Fills[value];
				}
				else
				{
					Image = null;
				}

				InvalidateVisual();
			}
		}

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

		public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
			"Title", typeof(string), typeof(OrgChartNode), new PropertyMetadata(""));

		public string FullName
		{
			get { return (string)GetValue(FullNameProperty); }
			set { SetValue(FullNameProperty, value); }
		}

		public static readonly DependencyProperty FullNameProperty = DependencyProperty.Register(
			"FullName", typeof(string), typeof(OrgChartNode), new PropertyMetadata(""));

		public ImageSource Image
		{
			get { return (ImageSource)GetValue(ImageProperty); }
			set { SetValue(ImageProperty, value); }
		}

		public static readonly DependencyProperty ImageProperty = DependencyProperty.Register(
			"Image", typeof(ImageSource), typeof(OrgChartNode), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));


		private static List<ImageSource> Images;
		private static List<string> Titles;
		private static List<Brush> Fills;

		private const string FullNamePlaceholder = "<enter name>";
		private const string TextPlaceholder = "<enter description>";
	}
}
