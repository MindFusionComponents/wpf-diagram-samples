//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

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
using System.Windows.Media.Effects;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for OwnerDrawObjects.xaml
	/// </summary>
	public partial class OwnerDrawnObjects : Page
	{
		public OwnerDrawnObjects()
		{
			InitializeComponent();
		}

		private void DemoPage_Loaded(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"Owner-draw objects.xml");

			foreach (DiagramNode n in diagram.Nodes)
			{
				ShapeNode node = (ShapeNode)n;
				if (node.CustomDraw == CustomDraw.Full)
				{
					if (node.Shape == Shapes.Ellipse)
						continue;

					DropShadowBitmapEffect shadowEffect = new DropShadowBitmapEffect();
					shadowEffect.Color = Color.FromArgb(150, 30, 30, 30);
					shadowEffect.Softness = 0;
					shadowEffect.ShadowDepth = 10;
					shadowEffect.Direction = -45;
					node.BitmapEffect = shadowEffect;
				}
			}
		}
	}
}
