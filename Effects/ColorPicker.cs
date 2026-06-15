//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Effects
{
	public class ColorPicker : Control
	{
		static ColorPicker()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPicker),
				new FrameworkPropertyMetadata(typeof(ColorPicker)));
		}

		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			popup = GetTemplateChild("popup") as Popup;
			alpha = GetTemplateChild("alpha") as Slider;
			red = GetTemplateChild("red") as Slider;
			green = GetTemplateChild("green") as Slider;
			blue = GetTemplateChild("blue") as Slider;

			if (alpha != null)
				alpha.ValueChanged += OnAlphaChanged;
			if (red != null)
				red.ValueChanged += OnRedChanged;
			if (green != null)
				green.ValueChanged += OnGreenChanged;
			if (blue != null)
				blue.ValueChanged += OnBlueChanged;
		}

		private void OnAlphaChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			Color color = SelectedColor;
			color.A = (byte)e.NewValue;
			SelectedColor = color;
			RaiseSelectedColorChanged();
		}

		private void OnRedChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			Color color = SelectedColor;
			color.R = (byte)e.NewValue;
			SelectedColor = color;
			RaiseSelectedColorChanged();
		}

		private void OnGreenChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			Color color = SelectedColor;
			color.G = (byte)e.NewValue;
			SelectedColor = color;
			RaiseSelectedColorChanged();
		}

		private void OnBlueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			Color color = SelectedColor;
			color.B = (byte)e.NewValue;
			SelectedColor = color;
			RaiseSelectedColorChanged();
		}

		protected override void OnMouseUp(System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseUp(e);

			if (!IsEnabled)
				return;

			alpha.Value = SelectedColor.A;
			red.Value = SelectedColor.R;
			green.Value = SelectedColor.G;
			blue.Value = SelectedColor.B;
			popup.IsOpen = true;
		}

		private void RaiseSelectedColorChanged()
		{
			RoutedEventArgs args = new RoutedEventArgs(ColorPicker.SelectedColorChangedEvent);
			OnSelectedColorChanged(args);
		}

		protected virtual void OnSelectedColorChanged(RoutedEventArgs e)
		{
			RaiseEvent(e);
		}


		public Color SelectedColor
		{
			get { return (Color)GetValue(SelectedColorProperty); }
			set { SetValue(SelectedColorProperty, value); }
		}

		public static readonly DependencyProperty SelectedColorProperty =
			DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorPicker));


		// Create a custom routed event by first registering a RoutedEventID 
		// This event uses the bubbling routing strategy 
		public static readonly RoutedEvent SelectedColorChangedEvent = EventManager.RegisterRoutedEvent(
			"SelectedColorChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ColorPicker));

		public event RoutedEventHandler SelectedColorChanged
		{
			add { AddHandler(SelectedColorChangedEvent, value); }
			remove { RemoveHandler(SelectedColorChangedEvent, value); }
		}


		private Popup popup;
		private Slider alpha;
		private Slider red;
		private Slider green;
		private Slider blue;
	}

	public class ColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is Color)
				return new SolidColorBrush((Color)value);

			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

	public class VisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				bool bvalue = (bool)value;
				if (parameter != null)
				{
					if (parameter.ToString() == "!")
						bvalue = !bvalue;
				}

				if (bvalue)
					return Visibility.Visible;
				else
					return Visibility.Collapsed;
			}

			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
