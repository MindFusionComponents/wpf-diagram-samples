//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Xml;


namespace MindFusion.Diagramming.Wpf.Samples.CS.IconNodes
{
	public class IconNode : DiagramNode
	{
		static IconNode()
		{
			defaultIcon = (ImageSource)Application.Current.Resources["image1"];
		}

		public IconNode(Diagram diagram)
			: base(diagram)
		{
			this.diagram = diagram;
			icon = defaultIcon;
			label = "Label";

			Bounds = new Rect(Bounds.Location, CalculateSize());
		}

		public override void Draw(DrawingContext graphics, RenderOptions options)
		{
			Size imageSize = new Size(icon.Width, icon.Height);
			Size textSize = Parent.MeasureString(label, this, short.MaxValue);

			// draw the icon centered at the top
			graphics.DrawImage(icon, new Rect(
				(Bounds.Width - imageSize.Width) / 2, 0, imageSize.Width, imageSize.Height));

			// draw label centered at the bottom
			graphics.DrawText(
				new FormattedText(
					label, CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
					new Typeface(FontFamily, FontStyle, FontWeight, FontStretches.Normal),
					FontSize, Brushes.Black),
				new Point((Bounds.Width - textSize.Width) / 2, imageSize.Height));
		}

		private Size CalculateSize()
		{
			Size imageSize = new Size(icon.Width, icon.Height);

			Size textSize = Parent.MeasureString(label, this, 10000);

			return new Size(
				Math.Max(imageSize.Width, textSize.Width),
				imageSize.Height + textSize.Height);
		}

		protected override void StartCreate(Point org)
		{
			base.StartCreate(org);
			Bounds = new Rect(org, CalculateSize());
		}

		protected override void UpdateCreate(Point current)
		{
			base.UpdateCreate(current);
			Bounds = new Rect(current, CalculateSize());
		}

		protected override bool AllowCreate(Point current, InteractionState ist)
		{
			// we don't care about minimum node size enforced by base since
			// IconNodes have a fixed size based on image and label dimensions.
			// override this method to prevent the stop cursor from appearing
			return true;
		}

		protected override void SaveToXml(XmlElement xmlElement, XmlPersistContext context)
		{
			base.SaveToXml(xmlElement, context);

			context.WriteImage(icon, "Icon", xmlElement);
			context.WriteString(label, "Label", xmlElement);
		}

		protected override void LoadFromXml(XmlElement xmlElement, XmlPersistContext context)
		{
			base.LoadFromXml(xmlElement, context);

			icon = context.ReadImage("Icon", xmlElement);
			label = context.ReadString("Label", xmlElement);
		}


		public ImageSource Icon
		{
			get { return icon; }
			set
			{
				icon = value;
				Bounds = new Rect(Bounds.Location, CalculateSize());
			}
		}

		public string Label
		{
			get { return label; }
			set
			{
				label = value;
				Bounds = new Rect(Bounds.Location, CalculateSize());
			}
		}


		private ImageSource icon;
		private string label;
		static private ImageSource defaultIcon;
		private Diagram diagram;
	}
}