//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Provides various conversions.
	/// </summary>
	internal class Convert
	{
		/// <summary>
		/// Converts polar coordinates to the corresponding
		/// Cartesian coordinates, using the specified point as
		/// a center of the coordinate system.
		/// </summary>
		public static void PolarToCartesian(Point coordCenter,
			double a, double r, ref Point cartesian)
		{
			if (r == 0)
			{
				cartesian = coordCenter;
				return;
			}

			cartesian.X = (double)(coordCenter.X + Math.Cos(a * Math.PI / 180) * r);
			cartesian.Y = (double)(coordCenter.Y - Math.Sin(a * Math.PI / 180) * r);
		}

		/// <summary>
		/// Converts Cartesian coordinates to the corresponding
		/// polar coordinates, using the specified point as
		/// a center of the coordinate system.
		/// </summary>
		public static void CartesianToPolar(Point coordCenter,
			Point cartesian, ref double a, ref double r)
		{
			if (coordCenter == cartesian)
			{
				a = 0;
				r = 0;
				return;
			}

			double dx = cartesian.X - coordCenter.X;
			double dy = cartesian.Y - coordCenter.Y;
			r = (double)(Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2)));

			a = (double)(Math.Atan(-dy / dx) * 180 / Math.PI);
			if (dx < 0) a += 180;
		}
	}
}
