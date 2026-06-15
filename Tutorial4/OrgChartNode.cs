//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Windows;
using System.Windows.Media;
using System.Xml;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Tutorial4
{
	public class OrgChartNode : TemplatedNode
	{
		static OrgChartNode()
		{
			DefaultStyleKeyProperty.OverrideMetadata(
				typeof(OrgChartNode), new FrameworkPropertyMetadata(typeof(OrgChartNode)));
		}

		public OrgChartNode()
		{
		}

		// Required for creating nodes by dragging them from the NodeListView
		public OrgChartNode(OrgChartNode prototype) : base(prototype)
		{
			Title = prototype.Title;
			FullName = prototype.FullName;
			Image = prototype.Image;
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

		// serialization support for custom properties

		protected override void SaveToXml(XmlElement xmlElement, XmlPersistContext context)
		{
			base.SaveToXml(xmlElement, context);
			context.WriteString(Title, "Title", xmlElement);
			context.WriteString(FullName, "FullName", xmlElement);
			context.WriteImage(Image, "Image", xmlElement);
		}

		protected override void LoadFromXml(XmlElement xmlElement, XmlPersistContext context)
		{
			base.LoadFromXml(xmlElement, context);
			Title = context.ReadString("Title", xmlElement);
			FullName = context.ReadString("FullName", xmlElement);
			Image = context.ReadImage("Image", xmlElement);
		}

		// undo and redo support

		protected override DiagramItemProperties CreateProperties()
		{
			return new OrgChartNodeProperties();
		}

		protected override void SaveProperties(DiagramItemProperties props)
		{
			base.SaveProperties(props);

			var state = (OrgChartNodeProperties)props;
			state.Title = Title;
			state.FullName = FullName;
			state.Image = Image;
		}

		protected override void RestoreProperties(DiagramItemProperties props)
		{
			base.RestoreProperties(props);

			var state = (OrgChartNodeProperties)props;
			Title = state.Title;
			FullName = state.FullName;
			Image = state.Image;
		}
	}
}
