//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Win32;


namespace MindFusion.Diagramming.Wpf.Samples.CS.TabbedView
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Style style = new Style();
			style.Setters.Add(new Setter(Diagram.BackgroundProperty, Brushes.White));

			Style nodeStyle = new Style();
			nodeStyle.Setters.Add(new Setter(ShapeNode.BrushProperty,
				new LinearGradientBrush(Colors.White, Color.FromArgb(255, 219, 231, 240), 90)));

			Style linkStyle = new Style();
			linkStyle.Setters.Add(new Setter(DiagramLink.BrushProperty, Brushes.Black));

			theme = new Theme();
			theme.RegisterStyle(typeof(DiagramPage), style);
			theme.RegisterStyle(typeof(ShapeNode), nodeStyle);
			theme.RegisterStyle(typeof(DiagramLink), linkStyle);

			linkShape = new Shape(
				new ElementTemplate[]
				{
					new LineTemplate(20, 100, 50, 0),
					new LineTemplate(50, 0, 80, 100),
					new LineTemplate(80, 100, 20, 100)
				},
				FillRule.EvenOdd, "myShape");

			tabbedDiagramView.CurrentPage = tabbedDiagramView.Document.Pages[0];
			tabbedDiagramView.Document.PrintOptions.HeaderFormat = "%T, Page %GP";
			SetupPage(tabbedDiagramView.CurrentPage);
		}

		private void SetupPage(DiagramPage page)
		{
			page.Theme = theme;
			page.ShowGrid = true;
			page.GridStyle = GridStyle.Points;
			page.DefaultShape = Shapes.Rectangle;
			page.RouteLinks = true;
			page.RoundedLinks = true;
			page.RoundedLinksRadius = 5;
			page.LinkHeadShape = linkShape;
			page.LinkHeadShapeSize = 10;
		}

		private void OnShowTabsChanged(object sender, EventArgs e)
		{
			tabbedDiagramView.ShowTabs = !radioNever.IsChecked.Value;
			if (!radioNever.IsChecked.Value)
			{
				if (radioLeft.IsChecked.Value)
					tabbedDiagramView.TabAlignment = Dock.Left;
				else if (radioTop.IsChecked.Value)
					tabbedDiagramView.TabAlignment = Dock.Top;
				else if (radioRight.IsChecked.Value)
					tabbedDiagramView.TabAlignment = Dock.Right;
				else if (radioBottom.IsChecked.Value)
					tabbedDiagramView.TabAlignment = Dock.Bottom;
			}
		}

		private void openMenuItem_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "XML Files|*.xml|All Files|*.*||";
			if (dialog.ShowDialog(this) == true)
			{
				tabbedDiagramView.Document.LoadFromXml(dialog.FileName);

				foreach (DiagramPage page in tabbedDiagramView.Document.Pages)
					SetupPage(page);
			}
		}

		private void saveMenuItem_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "XML Files|*.xml|All Files|*.*||";
			if (dialog.ShowDialog(this) == true)
				tabbedDiagramView.Document.SaveToXml(dialog.FileName);
		}

		private void printPreviewMenuItem_Click(object sender, RoutedEventArgs e)
		{
			tabbedDiagramView.Document.PrintPreview();
		}

		private void printMenuItem_Click(object sender, RoutedEventArgs e)
		{
			tabbedDiagramView.Document.Print();
		}

		private void exitMenuItem_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void tabbedDiagramView_PageAdded(object sender, DiagramPageEventArgs e)
		{
			SetupPage(e.DiagramPage);
		}

		private void tabbedDiagramView_PageRemoving(object sender, DiagramPageValidationEventArgs e)
		{
			if (tabbedDiagramView.Document.Pages.Count == 1)
			{
				MessageBox.Show("The last page cannot be removed.", "Removing page",
					MessageBoxButton.OK, MessageBoxImage.Warning);
				e.Cancel = true;
			}
		}


		private Theme theme;
		private Shape linkShape;
	}
}
