//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Effects
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			// Create effects
			glassEffect = new GlassEffect();
			aeroEffect = new AeroEffect();

			// Preview shapes
			int i = 0;
			const double size = 75;
			const double margin = 10;
			const int perLine = 7;
			foreach (Shape shape in Shape.Shapes)
			{
				if (shape.IsArrowhead)
					continue;
				// BPMN shapes don't add variety
				if (shape.Id.StartsWith("bpmn", StringComparison.InvariantCultureIgnoreCase))
					continue;

				ShapeNode node = diagram.Factory.CreateShapeNode((i % perLine) * (size + margin) + 4,
					(i / perLine) * (size + margin) + 4, size, size);
				node.Shape = shape;
				i++;
			}
			diagram.ResizeToFitItems(4, false);

			// Presets
			defaultPreset = new Preset();
			defaultPreset.Name = "(Default)";
			defaultPreset.UseGlassEffect = false;
			defaultPreset.GlassEffectType = GlassEffectType.Type1;
			defaultPreset.UsePenAsGlow = false;
			defaultPreset.GlowColor = Colors.White;
			defaultPreset.ReflectionColor = Colors.White;
			defaultPreset.UseAeroEffect = false;
			defaultPreset.Opacity = 0.4;
			defaultPreset.InnerOutlineColor = Colors.White;
			defaultPreset.ShadeColor = Colors.Black;
			defaultPreset.UseEmbossEffect = false;
			defaultPreset.UseSmoothShadowEffect = false;
			defaultPreset.DiagramBackground = Colors.White;
			defaultPreset.ShapeBorder = Colors.DarkSlateGray;
			defaultPreset.ShapeBackground1 = Colors.LightSteelBlue;
			defaultPreset.UseShapeBackground2 = false;
			defaultPreset.ShapeBackground2 = Colors.White;
			ApplyPreset(defaultPreset);

			Preset preset = new Preset();
			preset.Name = "Glass (Default Colors)";
			preset.UseGlassEffect = true;
			preset.GlassEffectType = GlassEffectType.Type1;
			preset.UsePenAsGlow = false;
			preset.GlowColor = Colors.White;
			preset.ReflectionColor = Colors.White;
			preset.UseAeroEffect = false;
			preset.Opacity = 0.4;
			preset.InnerOutlineColor = Colors.White;
			preset.ShadeColor = Colors.Black;
			preset.UseEmbossEffect = false;
			preset.UseSmoothShadowEffect = false;
			preset.DiagramBackground = Colors.White;
			preset.ShapeBorder = Colors.DarkSlateGray;
			preset.ShapeBackground1 = Colors.LightSteelBlue;
			preset.UseShapeBackground2 = false;
			preset.ShapeBackground2 = Colors.White;
			AddToList(preset);

			preset = new Preset();
			preset.Name = "Glass & Aero (Orange Background)";
			preset.UseGlassEffect = true;
			preset.GlassEffectType = GlassEffectType.Type2;
			preset.UsePenAsGlow = false;
			preset.GlowColor = Colors.White;
			preset.ReflectionColor = Colors.White;
			preset.UseAeroEffect = true;
			preset.Opacity = 0.2;
			preset.InnerOutlineColor = Colors.White;
			preset.ShadeColor = Colors.Black;
			preset.UseEmbossEffect = false;
			preset.UseSmoothShadowEffect = false;
			preset.DiagramBackground = Colors.Orange;
			preset.ShapeBorder = Colors.DarkSlateGray;
			preset.ShapeBackground1 = Colors.LightSteelBlue;
			preset.UseShapeBackground2 = false;
			preset.ShapeBackground2 = Colors.White;
			AddToList(preset);

			preset = new Preset();
			preset.Name = "Metalic";
			preset.UseGlassEffect = true;
			preset.GlassEffectType = GlassEffectType.Type2;
			preset.UsePenAsGlow = true;
			preset.GlowColor = Colors.White;
			preset.ReflectionColor = Colors.White;
			preset.UseAeroEffect = true;
			preset.Opacity = 0.5;
			preset.InnerOutlineColor = Colors.White;
			preset.ShadeColor = Colors.Black;
			preset.UseEmbossEffect = false;
			preset.UseSmoothShadowEffect = false;
			preset.DiagramBackground = Color.FromArgb(0xFF, 0xC0, 0xC0, 0xC0);
			preset.ShapeBorder = Colors.DarkSlateGray;
			preset.ShapeBackground1 = Colors.LightSteelBlue;
			preset.UseShapeBackground2 = false;
			preset.ShapeBackground2 = Colors.White;
			AddToList(preset);

			preset = new Preset();
			preset.Name = "Neon Glow";
			preset.UseGlassEffect = true;
			preset.GlassEffectType = GlassEffectType.Type2;
			preset.UsePenAsGlow = true;
			preset.GlowColor = Colors.White;
			preset.ReflectionColor = Colors.White;
			preset.UseAeroEffect = true;
			preset.Opacity = 0;
			preset.InnerOutlineColor = Colors.Black;
			preset.ShadeColor = Color.FromArgb(0xFF, 0x80, 0xFF, 0xFF);
			preset.UseEmbossEffect = false;
			preset.UseSmoothShadowEffect = false;
			preset.DiagramBackground = Colors.Black;
			preset.ShapeBorder = Color.FromArgb(0xFF, 0x80, 0xFF, 0xFF);
			preset.ShapeBackground1 = Colors.Black;
			preset.UseShapeBackground2 = false;
			preset.ShapeBackground2 = Colors.White;
			AddToList(preset);

			preset = new Preset();
			preset.Name = "Gray glass";
			preset.UseGlassEffect = true;
			preset.GlassEffectType = GlassEffectType.Type3;
			preset.UsePenAsGlow = false;
			preset.GlowColor = Colors.White;
			preset.ReflectionColor = Colors.White;
			preset.UseAeroEffect = true;
			preset.Opacity = 0.4;
			preset.InnerOutlineColor = Colors.White;
			preset.ShadeColor = Colors.Black;
			preset.UseEmbossEffect = false;
			preset.UseSmoothShadowEffect = false;
			preset.DiagramBackground = Colors.Gray;
			preset.ShapeBorder = Colors.Black;
			preset.ShapeBackground1 = Colors.LightCyan;
			preset.UseShapeBackground2 = true;
			preset.ShapeBackground2 = Color.FromArgb(0xFF, 0xA8, 0xBF, 0xBF);
			AddToList(preset);

			preset = new Preset();
			preset.Name = "Brown";
			preset.UseGlassEffect = true;
			preset.GlassEffectType = GlassEffectType.Type1;
			preset.UsePenAsGlow = false;
			preset.GlowColor = Colors.White;
			preset.ReflectionColor = Colors.White;
			preset.UseAeroEffect = false;
			preset.Opacity = 0.4;
			preset.InnerOutlineColor = Colors.White;
			preset.ShadeColor = Colors.Black;
			preset.UseEmbossEffect = false;
			preset.UseSmoothShadowEffect = true;
			preset.DiagramBackground = Colors.PaleGoldenrod;
			preset.ShapeBorder = Colors.Black;
			preset.ShapeBackground1 = Color.FromArgb(0x80, 0x90, 0x30, 0x20);
			preset.UseShapeBackground2 = false;
			preset.ShapeBackground2 = Colors.White;
			AddToList(preset);

			preset = new Preset();
			preset.Name = "Bright Red";
			preset.UseGlassEffect = true;
			preset.GlassEffectType = GlassEffectType.Type4;
			preset.UsePenAsGlow = false;
			preset.GlowColor = Colors.Black;
			preset.ReflectionColor = Colors.White;
			preset.UseAeroEffect = false;
			preset.Opacity = 0.4;
			preset.InnerOutlineColor = Colors.White;
			preset.ShadeColor = Colors.Black;
			preset.UseEmbossEffect = false;
			preset.UseSmoothShadowEffect = false;
			preset.DiagramBackground = Colors.White;
			preset.ShapeBorder = Color.FromArgb(0xFF, 0x8E, 0x8F, 0x8F);
			preset.ShapeBackground1 = Colors.Red;
			preset.UseShapeBackground2 = false;
			preset.ShapeBackground2 = Colors.White;
			AddToList(preset);

			backgroundColor.SelectedColorChanged += backgroundColor_SelectedColorChanged;
			shapesBorderColor.SelectedColorChanged += shapesBorderColor_SelectedColorChanged;
			shapesBackgroundColor.SelectedColorChanged += shapesBackgroundColor_SelectedColorChanged;
			shapesBackground2Color.SelectedColorChanged += shapesBackground2Color_SelectedColorChanged;
			glowColor.SelectedColorChanged += glowColor_SelectedColorChanged;
			reflectionColor.SelectedColorChanged += reflectionColor_SelectedColorChanged;
			innerOutlineColor.SelectedColorChanged += innerOutlineColor_SelectedColorChanged;
			shadeColor.SelectedColorChanged += shadeColor_SelectedColorChanged;
		}

		private void AddToList(Preset preset)
		{
			presetsList.Items.Add(preset);
		}

		private void presetsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ApplyPreset(presetsList.SelectedItem as Preset);
		}

		private void glassEffectCheck_Click(object sender, RoutedEventArgs e)
		{
			if (glassEffectCheck.IsChecked == true)
			{
				if (!diagram.NodeEffects.Contains(glassEffect))
					diagram.NodeEffects.Add(glassEffect);
			}
			else
			{
				if (diagram.NodeEffects.Contains(glassEffect))
					diagram.NodeEffects.Remove(glassEffect);
			}
		}

		private void glassTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			glassEffect.Type = (GlassEffectType)glassTypeCombo.SelectedIndex;
		}

		private void usePenAsGlowCheck_Click(object sender, RoutedEventArgs e)
		{
			glassEffect.UsePenAsGlow = usePenAsGlowCheck.IsChecked == true;
		}

		private void glowColor_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			glassEffect.GlowColor = glowColor.SelectedColor;
		}

		private void reflectionColor_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			glassEffect.ReflectionColor = reflectionColor.SelectedColor;
		}

		private void aeroEffectCheck_Click(object sender, RoutedEventArgs e)
		{
			if (aeroEffectCheck.IsChecked == true)
			{
				if (!diagram.NodeEffects.Contains(aeroEffect))
					diagram.NodeEffects.Add(aeroEffect);
			}
			else
			{
				if (diagram.NodeEffects.Contains(aeroEffect))
					diagram.NodeEffects.Remove(aeroEffect);
			}
		}

		private void aeroOpacity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			aeroEffect.Opacity = aeroOpacity.Value;
		}

		private void innerOutlineColor_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			aeroEffect.InnerOutlineColor = innerOutlineColor.SelectedColor;
		}

		private void shadeColor_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			aeroEffect.ShadeColor = shadeColor.SelectedColor;
		}

		private void backgroundColor_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			diagram.BackBrush = new SolidColorBrush(backgroundColor.SelectedColor);
		}

		private void shapesBorderColor_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			UpdateShapeStyle();
		}

		private void shapesBackgroundColor_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			UpdateShapeStyle();
		}

		private void gradientCheck_Click(object sender, RoutedEventArgs e)
		{
			UpdateShapeStyle();
		}

		private void shapesBackground2Color_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			UpdateShapeStyle();
		}

		private void UpdateShapeStyle()
		{
			var stroke = new SolidColorBrush(shapesBorderColor.SelectedColor);

			Brush brush = null;
			if (!gradientCheck.IsChecked == true)
			{
				brush = new SolidColorBrush(shapesBackgroundColor.SelectedColor);
			}
			else
			{
				brush = new LinearGradientBrush(
					shapesBackgroundColor.SelectedColor, shapesBackground2Color.SelectedColor, 90);
			}

			Style shapeNodeStyle = new Style();
			shapeNodeStyle.Setters.Add(new Setter(ShapeNode.BrushProperty, brush));
			shapeNodeStyle.Setters.Add(new Setter(ShapeNode.StrokeProperty, stroke));
			diagram.ShapeNodeStyle = shapeNodeStyle;
		}

		private void ApplyPreset(Preset preset)
		{
			glassEffectCheck.IsChecked = preset.UseGlassEffect;
			glassTypeCombo.SelectedIndex = (int)preset.GlassEffectType;
			usePenAsGlowCheck.IsChecked = preset.UsePenAsGlow;
			glowColor.SelectedColor = preset.GlowColor;
			reflectionColor.SelectedColor = preset.ReflectionColor;

			aeroEffectCheck.IsChecked = preset.UseAeroEffect;
			aeroOpacity.Value = preset.Opacity;
			shadeColor.SelectedColor = preset.ShadeColor;
			innerOutlineColor.SelectedColor = preset.InnerOutlineColor;

			backgroundColor.SelectedColor = preset.DiagramBackground;
			shapesBorderColor.SelectedColor = preset.ShapeBorder;
			shapesBackgroundColor.SelectedColor = preset.ShapeBackground1;
			gradientCheck.IsChecked = preset.UseShapeBackground2;
			shapesBackground2Color.SelectedColor = preset.ShapeBackground2;

			glassEffectCheck_Click(null, null);
			glassTypeCombo_SelectionChanged(null, null);
			usePenAsGlowCheck_Click(null, null);
			glowColor_SelectedColorChanged(null, null);
			reflectionColor_SelectedColorChanged(null, null);
			aeroEffectCheck_Click(null, null);
			aeroOpacity_ValueChanged(null, null);
			shadeColor_SelectedColorChanged(null, null);
			innerOutlineColor_SelectedColorChanged(null, null);
			backgroundColor_SelectedColorChanged(null, null);
			UpdateShapeStyle();
		}


		private GlassEffect glassEffect;
		private AeroEffect aeroEffect;
		private Preset defaultPreset;

		private class Preset
		{
			public string PublicName
			{
				get { return Name; }
				set { Name = value; }
			}

			public string Name;

			// Glass
			public bool UseGlassEffect;
			public GlassEffectType GlassEffectType;
			public bool UsePenAsGlow;
			public Color GlowColor;
			public Color ReflectionColor;

			// Aero
			public bool UseAeroEffect;
			public double Opacity;
			public Color InnerOutlineColor;
			public Color ShadeColor;

			// Emboss
			public bool UseEmbossEffect;

			// Shadow
			public bool UseSmoothShadowEffect;

			// Misc
			public Color DiagramBackground;
			public Color ShapeBorder;
			public Color ShapeBackground1;
			public bool UseShapeBackground2;
			public Color ShapeBackground2;
		}
	}
}
