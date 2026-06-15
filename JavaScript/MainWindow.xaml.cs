//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Antlr.Runtime;
using Microsoft.Win32;
using MindFusion.Diagramming.Wpf.Layout;


namespace MindFusion.Diagramming.Wpf.Samples.CS.JavaScript
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();

			dialog.Filter = "JavaScript Files (*.js)|*.js|All Files|*.*||";
			if (dialog.ShowDialog() == true)
			{
				try
				{
					using (StreamReader r = new StreamReader(dialog.FileName))
						tbCode.Text = r.ReadToEnd();
				}
				catch (IOException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnParse_Click(object sender, RoutedEventArgs e)
		{
			ANTLRReaderStream rs = new ANTLRReaderStream(new StringReader(tbCode.Text));
			JavaScriptLexer lexer = new JavaScriptLexer(rs);
			CommonTokenStream tokens = new CommonTokenStream(lexer);
			JavaScriptParser parser = new JavaScriptParser(tokens);

			Logger logger = new Logger(parser);
			SyntaxTreeBuilder syntaxTreeBuilder = new SyntaxTreeBuilder(parser, syntaxTree);
			FlowchartBuilder flowchartBuilder = new FlowchartBuilder(parser, flowchart);

			try
			{
				parser.program();
			}
			catch (InvalidOperationException)
			{
				MessageBox.Show("Failed to parse input.");
			}
			catch
			{
				MessageBox.Show("Failed to parse input.");
			}

			TreeLayout layout = new TreeLayout();
			layout.Arrange(syntaxTree);
			syntaxTree.ResizeToFitItems(10);

			FlowchartLayout l = new FlowchartLayout();
			l.Orientation = MindFusion.Diagramming.Wpf.Layout.Orientation.Vertical;
			l.Arrange(flowchart);
			flowchart.ResizeToFitItems(10);
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			if (File.Exists("QuickSort.js"))
			{
				using (StreamReader reader = new StreamReader("QuickSort.js"))
				{
					tbCode.Text = reader.ReadToEnd();
					tbCode.Select(0, 0);
				}
			}
		}
	}
}