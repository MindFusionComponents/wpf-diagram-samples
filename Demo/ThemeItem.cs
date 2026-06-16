//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
//

namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	public class ThemeItem
	{
		public ThemeItem()
		{
		}

		public ThemeItem(string name, string theme)
		{
			this.name = name;
			this.theme = theme;
		}

		public override string ToString()
		{
			return name;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Theme
		{
			get { return theme; }
			set { theme = value; }
		}


		private string name;
		private string theme;
	}
}