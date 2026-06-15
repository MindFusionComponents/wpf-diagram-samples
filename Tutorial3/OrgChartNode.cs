//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Windows;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Tutorial3
{
	public class OrgChartNode : TemplatedNode
	{
		static OrgChartNode()
		{
			DefaultStyleKeyProperty.OverrideMetadata(
				typeof(OrgChartNode), new FrameworkPropertyMetadata(typeof(OrgChartNode)));
		}

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

		public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
			"Title",
			typeof(string),
			typeof(OrgChartNode),
			new PropertyMetadata(""));

		public string FullName
		{
			get { return (string)GetValue(FullNameProperty); }
			set { SetValue(FullNameProperty, value); }
		}

		public static readonly DependencyProperty FullNameProperty = DependencyProperty.Register(
			"FullName",
			typeof(string),
			typeof(OrgChartNode),
			new PropertyMetadata(""));

		public ImageSource Image
		{
			get { return (ImageSource)GetValue(ImageProperty); }
			set { SetValue(ImageProperty, value); }
		}

		public static readonly DependencyProperty ImageProperty = DependencyProperty.Register(
			"Image",
			typeof(ImageSource),
			typeof(OrgChartNode),
			new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
	}
}
