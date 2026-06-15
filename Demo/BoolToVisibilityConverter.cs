using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	public class BoolToVisibilityConverter : IValueConverter
	{
		/// <summary>
		/// IValueConverter.Convert implementation.
		/// </summary>
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (parameter is string)
			{
				string s = (string)parameter;
				bool b = (bool)value;
				if (s == "true")
					return b ? Visibility.Visible : Visibility.Collapsed;
				else
					return b ? Visibility.Collapsed : Visibility.Visible;
			}
			else
			{
				bool b = (bool)value;
				return b ? Visibility.Visible : Visibility.Collapsed;
			}
		}

		/// <summary>
		/// IValueConverter.ConvertBack implementation.
		/// </summary>
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}