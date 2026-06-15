//
// Copyright (c) 2026, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Threading;

using Microsoft.Win32;

using MindFusion.Diagramming.Wpf.Commands;
using MindFusion.Diagramming.Wpf.Layout;
using MindFusion.Layout;
using MindFusion.Svg;

using MessageBox = System.Windows.MessageBox;
using DragDropEffects = System.Windows.DragDropEffects;
using DataFormats = System.Windows.DataFormats;
using SystemTreeItem = System.Windows.Controls.TreeViewItem;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		#region Init

		public MainWindow()
		{
			InitializeComponent();

			string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
			appPath = System.IO.Path.GetDirectoryName(appPath);
			appPath += @"\";

			ApplicationPath = appPath;
			ResourcesPath = appPath + @"Resources\";

			InitImages();
			InitBrushes();

			texts = new List<String>();
			try
			{
				var sr = new StreamReader(
					File.OpenRead(appPath + @"texts.txt"),
					Encoding.ASCII);
				sr.BaseStream.Seek(0, SeekOrigin.Begin);
				string total = "";
				while (sr.Peek() > -1)
				{
					string s = sr.ReadLine();
					if (s == "")
					{
						if (total != "")
						{
							texts.Add(total);
							total = "";
						}
					}
					else
					{
						if (total == "")
							total += s;
						else
							total = total + "\r\n" + s;
					}
				}
				if (total != "")
					texts.Add(total);
				sr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// File dialogs
			openFileDialog = new OpenFileDialog();
			saveFileDialog = new SaveFileDialog();

			// Vessels
            vesselsTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
			vesselsTimer.Tick += vesselsTimer_Tick;

			btnNext_Click(null, null);

			string uri = @"pack://application:,,,/Demo;component/Files/Sources.xml";
			using (Stream stream = Application.GetResourceStream(new Uri(uri)).Stream)
			{
				_sources = XDocument.Load(new XmlTextReader(stream));
			}

			_tracePathTimer = new DispatcherTimer();
			_tracePathTimer.Tick += new EventHandler(OnTracePath);
            _tracePathTimer.Interval += new TimeSpan(0, 0, 0, 0, 150);

			PopulateTreeView();
			treeView.SelectedItemChanged += (s, e) =>
			{
				object obj = (treeView.SelectedItem as SystemTreeItem).Tag;
				if (obj != null)
				{
					selectedEntry = (int)obj;
					object selection = Activator.CreateInstance(pages[(int)obj]);
					frameContent.Navigate(selection);

					backButton.IsEnabled = selectedEntry > 0;
					nextButton.IsEnabled = selectedEntry < pages.Length - 1;
				}
			};

			InputBindings.Add(new KeyBinding(ApplicationCommands.NotACommand, new KeyGesture(Key.Back)));


			CopyVisioStencils();


			ShowsNavigationUI = false;

			//for (int i = 0; i < 20; i++)
			//{
			//    object page = Activator.CreateInstance(pages[i]);
			//    frameContent.Navigate(page);
			//    NavigationService.AddBackEntry(new MyCustomContentState(pages[i].Name, new TextBlock()));
			//}        
		}

		SystemTreeItem CreateTreeItem(string title)
		{
			var item = new SystemTreeItem();
			item.Header = title;
			treeView.Items.Add(item);
			return item;
		}

		private void PopulateTreeView()
		{
			CreateTreeItem("FlowChart Diagrams");
			CreateTreeItem("Special Nodes");
			CreateTreeItem("Tables");
			CreateTreeItem("Links");
			CreateTreeItem("Automatic Layouts");
			CreateTreeItem("Graph Management");
			CreateTreeItem("Miscellaneous");
			CreateTreeItem("Network Samples");

			var topLevelPages = new[] { pages.Length - 2, pages.Length - 1 };
			foreach (var i in topLevelPages)
				CreateTreeItem(pages[i].Name).Tag = i;

			foreach (SystemTreeItem item in treeView.Items)
			{
				if ((string)item.Header == "FlowChart Diagrams")
				{
					for (int i = 0; i < 7; i++)
					{
						var child = new SystemTreeItem();
						child.Header = pages[i].Name;
						child.Tag = i;
						item.Items.Add(child);
					}
				}
				if ((string)item.Header == "Special Nodes")
				{
					for (int i = 7; i < 11; i++)
					{
						var child = new SystemTreeItem();
						child.Header = pages[i].Name;
						child.Tag = i;
						item.Items.Add(child);
					}
				}
				if ((string)item.Header == "Tables")
				{
					for (int i = 11; i < 15; i++)
					{
						var child = new SystemTreeItem();
						child.Header = pages[i].Name;
						child.Tag = i;
						item.Items.Add(child);
					}
				}
				if ((string)item.Header == "Links")
				{
					for (int i = 15; i < 20; i++)
					{
						var child = new SystemTreeItem();
						child.Header = pages[i].Name;
						child.Tag = i;
						item.Items.Add(child);
					}
				}
				if ((string)item.Header == "Automatic Layouts")
				{
					for (int j = 0; j < 3; j++)
					{
						var childItem = new SystemTreeItem();
						if (j == 0)
						{
							childItem.Header = "Force-directed";
							for (int k = 20; k < 25; k++)
							{
								var child = new SystemTreeItem();
								child.Header = pages[k].Name;
								child.Tag = k;
								childItem.Items.Add(child);
							}
						}
						if (j == 1)
						{
							childItem.Header = "Structural";
							for (int k = 25; k < 28; k++)
							{
								var child = new SystemTreeItem();
								child.Header = pages[k].Name;
								child.Tag = k;
								childItem.Items.Add(child);
							}
						}
						if (j == 2)
						{
							childItem.Header = "Topological";
							for (int k = 28; k < 31; k++)
							{
								var child = new SystemTreeItem();
								child.Header = pages[k].Name;
								child.Tag = k;
								childItem.Items.Add(child);
							}
						}
						item.Items.Add(childItem);
					}
				}
				if ((string)item.Header == "Graph Management")
				{
					for (int i = 31; i < 33; i++)
					{
						var child = new SystemTreeItem();
						child.Header = pages[i].Name;
						child.Tag = i;
						item.Items.Add(child);
					}
				}
				if ((string)item.Header == "Miscellaneous")
				{
					for (int i = 33; i < 38; i++)
					{
						var child = new SystemTreeItem();
						child.Header = pages[i].Name;
						child.Tag = i;
						item.Items.Add(child);
					}
				}
				if ((string)item.Header == "Network Samples")
				{
					for (int i = 38; i < 40; i++)
					{
						var child = new SystemTreeItem();
						child.Header = pages[i].Name;
						child.Tag = i;
						item.Items.Add(child);
					}
				}
			}
		}

		private void mainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			// Overview
			overviewWindow = new OverviewWindow
			{
				RenderSize = new Size(250, 250),
				Owner = this,
				WindowStyle = WindowStyle.ToolWindow
			};

			overviewWindow.Loaded += new RoutedEventHandler(overviewWindow_Loaded);
			overviewWindow.Show();
		}

		void overviewWindow_Loaded(object sender, RoutedEventArgs e)
		{
			if (diagram != null)
				overviewWindow.overview.DiagramView = diagramView;
		}

		private void InitImages()
		{
			for (int i = 0; i < frameImageList.Length; i++)
				frameImageList[i] = new BitmapImage(new Uri(ResourcesPath + i + ".png"));

			for (int i = 0; i < 5; i++)
				generalImageList[i] = new BitmapImage(new Uri(ResourcesPath + "img" + i + ".png"));

			for (int i = 0; i < 2; i++)
				genderImages[i] = new BitmapImage(new Uri(ResourcesPath + @"gender" + i + ".png"));
		}

		private static void InitBrushes()
		{
			var backgroundSquare = new GeometryDrawing(Brushes.White, null,
				new RectangleGeometry(new Rect(0, 0, 1, 1)));

			var aGeometryGroup = new GeometryGroup();
			aGeometryGroup.Children.Add(new RectangleGeometry(new Rect(0, 0, 50, 50)));
			aGeometryGroup.Children.Add(new RectangleGeometry(new Rect(50, 50, 50, 50)));

			var checkerBrush = new LinearGradientBrush();
			checkerBrush.GradientStops.Add(new GradientStop(Colors.White, 0.0));
			checkerBrush.GradientStops.Add(new GradientStop(Colors.Gray, 1.0));

			var checkers = new GeometryDrawing(checkerBrush, null, aGeometryGroup);

			var checkersDrawingGroup = new DrawingGroup();
			checkersDrawingGroup.Children.Add(backgroundSquare);
			checkersDrawingGroup.Children.Add(checkers);

			var backBrush = new DrawingBrush
			{
				Drawing = checkersDrawingGroup,
				Viewport = new Rect(0, 0, 0.01, 0.01),
				TileMode = TileMode.Tile
			};

			DrawingBrush = backBrush;

			BitmapSource source = new BitmapImage(new Uri(ResourcesPath + @"backgroundImage.bmp"));
			var brush = new ImageBrush(source);
			ImageBrush = brush;

			var br = new SolidColorBrush(Color.FromArgb(255, 202, 202, 202));
			SolidBrush = br;

			var newBrush = new LinearGradientBrush(
				Color.FromArgb(255, 200, 200, 200), Color.FromArgb(255, 150, 150, 150), 45);
			GradientBrush = newBrush;

			br = new SolidColorBrush(Color.FromArgb(255, 242, 242, 242));
			SolidBrush2 = br;
		}

		#endregion

		#region Fields

		private List<String> texts;

		private Diagram diagram;
		private DiagramView diagramView;
		private int pageIndex = -1;

		private OpenFileDialog openFileDialog;
		private SaveFileDialog saveFileDialog;

		private static string TITLE = "MindFusion.Diagramming Demo - ";
		public static string ApplicationPath = "";
		public static string ResourcesPath = "";

		public static DrawingBrush DrawingBrush;
		public static ImageBrush ImageBrush;
		public static SolidColorBrush SolidBrush;
		public static SolidColorBrush SolidBrush2;
		public static LinearGradientBrush GradientBrush;

		private Random random = new Random();

		private double mm;

		private DispatcherTimer vesselsTimer = new DispatcherTimer();

		private BitmapSource[] frameImageList = new BitmapSource[9];
		private BitmapSource[] generalImageList = new BitmapSource[5];
		private BitmapSource[] genderImages = new BitmapSource[2];

		private OverviewWindow overviewWindow = null;

		private Type[] pages = new Type[] { 
            typeof(FlowChart),
            typeof(LaneDiagram),
            typeof(DialogueChart),
            typeof(HierarchyChart),
            typeof(ChemicalSynthesisTree),
            typeof(ClassificationChart),
            typeof(GenealogyTree),
            typeof(SvgNodes),
            typeof(TreeViewNodes),
			typeof(VisioNodes),
            typeof(Containers),
            typeof(ErmDiagram),            
            typeof(ClassHierarchyDiagram),
            typeof(DatabaseRelationshipDiagram),
            typeof(SpanningCells),
            typeof(Arrowheads),
            typeof(Routing),
            typeof(TextOrientation),
            typeof(FormPreservation),
            typeof(CustomDrawLinks),


            typeof(AnnealingLayoutPage),
            typeof(CircularLayoutPage),
            typeof(ClusteredLayoutPage),
            typeof(GridLayoutPage),
            typeof(SpringLayoutPage),

            typeof(TreeLayoutPage),
            typeof(BigRadialLayoutPage),    
            typeof(LayeredLayoutPage),

            typeof(OrthogonalLayoutPage),
            typeof(TopologicalLayoutPage),
			typeof(OneWayLayoutPage),

            typeof(BasicOperations),
            typeof(PathfindingPage),
			typeof(Themes),
            typeof(Rotation),
            typeof(Grouping),
            typeof(DragAndDrop),
            typeof(NodeShapes),
            typeof(ReadyDiagram),
            typeof(NetSample),
            typeof(VisualXMLSample),
            typeof(OverviewPage),
            };

		#endregion

		#region Navigation

		//private void 

		private void frameContent_Navigated(object sender, NavigationEventArgs e)
		{
			DetachEvents();
			// Stop timers
			vesselsTimer.Stop();

			Page page = (Page)e.Content;

			if (page == null)
				return;

			string title = (string)page.FindResource("StepTitle");
			pageIndex = (int)page.FindResource("StepIndex");
			diagram = page.FindName("diagram") as Diagram;
			diagramView = page.FindName("diagramView") as DiagramView;
			ruler = page.FindName("ruler") as Ruler;

			mm = Constants.GetMillimeter(diagram.MeasureUnit);

			if (overviewWindow != null)
				overviewWindow.overview.DiagramView = diagramView;

			UpdateTools(pageIndex);
			UpdateSourceCode();
			AttachEvents();
			this.Title = MainWindow.TITLE + title;
		}
		private Ruler ruler;
		private void btnNext_Click(object sender, RoutedEventArgs e)
		{
			if (frameContent.Content == null)
			{
				FlowChart page = new FlowChart();
				frameContent.Navigate(page);
				return;
			}

			Type t = frameContent.Content.GetType();

			for (int i = 0; i < pages.Length; i++)
			{
				if (t.Equals(pages[i]))
				{
					//btnNext.IsEnabled = i == pages.Length - 2;

					object obj = Activator.CreateInstance(pages[1 + i]);
					frameContent.Navigate(obj);
					break;
				}
			}
		}

		#endregion

		#region Update

		private void UpdateTools(int pageIndex)
		{
			Type t = frameContent.Content.GetType();
			//btnNext.IsEnabled = !t.Equals(pages[pages.Length - 1]);

			diagram.UndoManager.UndoEnabled = true;
			diagram.UndoManager.History.Capacity = 200;

			mainWindow.Title = "";

			pnlDialogueSample.Visibility = pageIndex == 1 ? Visibility.Visible : Visibility.Hidden;
			pnlGenealogyTree.Visibility = pageIndex == 4 ? Visibility.Visible : Visibility.Hidden;
			pnlERMDiagram.Visibility = pageIndex == 22 ? Visibility.Visible : Visibility.Hidden;
			pnlCustomDrawLink.Visibility = pageIndex == 34 ? Visibility.Visible : Visibility.Hidden;
			pnlTreeLayout.Visibility = pageIndex == 17 ? Visibility.Visible : Visibility.Hidden;
			pnlBigRadialLayout.Visibility = pageIndex == 21 ? Visibility.Visible : Visibility.Hidden;
			pnlSpringLayout.Visibility = pageIndex == 19 ? Visibility.Visible : Visibility.Hidden;
			pnlLayeredLayout.Visibility = pageIndex == 30 ? Visibility.Visible : Visibility.Hidden;
			pnlGridLayout.Visibility = pageIndex == 32 ? Visibility.Visible : Visibility.Hidden;
			pnlClusteredLayout.Visibility = pageIndex == 33 ? Visibility.Visible : Visibility.Hidden;
			pnlAnnealLayout.Visibility = pageIndex == 38 ? Visibility.Visible : Visibility.Hidden;
			pnlGraphManagement.Visibility = pageIndex == 11 ? Visibility.Visible : Visibility.Hidden;
			pnlDatabaseRelationship.Visibility = pageIndex == 6 ? Visibility.Visible : Visibility.Hidden;
			pnlSpanningCells.Visibility = pageIndex == 36 ? Visibility.Visible : Visibility.Hidden;
			pnlPathfinding.Visibility = pageIndex == 10 ? Visibility.Visible : Visibility.Hidden;
			pnlNetSample.Visibility = pageIndex == 8 ? Visibility.Visible : Visibility.Hidden;
			pnlVisualXmlSample.Visibility = pageIndex == 12 ? Visibility.Visible : Visibility.Hidden;
			pnlDragAndDrop.Visibility = pageIndex == 13 ? Visibility.Visible : Visibility.Hidden;
			pnlThemes.Visibility = pageIndex == 44 ? Visibility.Visible : Visibility.Hidden;
			pnlRotation.Visibility = pageIndex == 37 ? Visibility.Visible : Visibility.Hidden;
			pnlOrthogonalLayoutPanel.Visibility = pageIndex == 39 ? Visibility.Visible : Visibility.Hidden;
			pnlCircularLayout.Visibility = pageIndex == 40 ? Visibility.Visible : Visibility.Hidden;
            pnlSvgNodes.Visibility = pageIndex == 46 ? Visibility.Visible : Visibility.Hidden;
			pnlTreeViewNodes.Visibility = pageIndex == 41 ? Visibility.Visible : Visibility.Hidden;
			pnlTopologicalLayout.Visibility = pageIndex == 42 ? Visibility.Visible : Visibility.Hidden;
			pnlOnewayLayout.Visibility = pageIndex == 43 ? Visibility.Visible : Visibility.Hidden;
			pnlVisioNodes.Visibility = pageIndex == 45 ? Visibility.Visible : Visibility.Hidden;

			// Change the text in the infobox
			if (texts != null && pageIndex >= 0 && pageIndex < texts.Count)
				tBxInfo.Text = texts[pageIndex];
			else
				tBxInfo.Text = "";
		}

		private void UpdateSelectedObject()
		{
			if (diagram.ActiveItem != null)
			{

				if (diagram.Selection.Items.Count == 0)
				{
					wpfPropertyGrid.SelectedObject = diagram.ActiveItem;
					//propertyGrid.SelectedObject = new ObjectWrapper(diagram.ActiveItem);
				}
				else
				{
					//object[] objects =
					//    new object[diagram.Selection.Items.Count];

					//for (int i = 0; i < objects.Length; i++)
					//{
					//    objects[i] = new ObjectWrapper(diagram.Selection.Items[i]);
					//}
					//propertyGrid.SelectedObjects = objects;

					wpfPropertyGrid.SelectedObject = diagram.Selection.Items[0];
				}
			}
			else
			{
				//propertyGrid.SelectedObject = new ObjectWrapper(diagram);
				wpfPropertyGrid.SelectedObject = diagram;
			}
		}

		// Update diagram when the page is changed.
		private void AttachEvents()
		{
			diagram.AllowDrop = true;
			diagram.DocumentPlane.AllowDrop = true;
			//wpfPropertyGrid.SelectedObject = diagram;
			//propertyGrid.SelectedObject = new ObjectWrapper(diagram);            
			diagram.Clicked += diagram_Clicked;
			diagram.SelectionChanged += diagram_SelectionChanged;
			diagram.LinkDeactivated += diagram_LinkDeactivated;
			diagram.SerializeTag += diagram_SerializeTag;
			diagram.DeserializeTag += diagram_DeserializeTag;
			diagram.CellClicked += diagram_CellClicked;
			diagram.DrawLink += diagram_DrawLink;
			diagram.DrawNode += diagram_DrawNode;
			diagram.NodeClicked += diagram_NodeClicked;
			diagram.NodeDeleting += diagram_NodeDeleting;
			diagram.NodeDeleted += diagram_NodeDeleted;

			diagramView.DragOver += diagram_DragOver;
			diagramView.Drop += diagram_Drop;
		}

		private void DetachEvents()
		{
			if (diagram == null)
				return;

			diagram.Clicked -= diagram_Clicked;
			diagram.SelectionChanged -= diagram_SelectionChanged;
			diagram.LinkDeactivated -= diagram_LinkDeactivated;
			diagram.SerializeTag -= diagram_SerializeTag;
			diagram.DeserializeTag -= diagram_DeserializeTag;
			diagram.CellClicked -= diagram_CellClicked;
			diagram.DrawLink -= diagram_DrawLink;
			diagram.DrawNode -= diagram_DrawNode;
			diagram.NodeClicked -= diagram_NodeClicked;
			diagram.NodeDeleting -= diagram_NodeDeleting;
			diagram.NodeDeleted -= diagram_NodeDeleted;

			diagramView.DragOver -= diagram_DragOver;
			diagramView.Drop -= diagram_Drop;
		}

		/// <summary>
		/// Updates the sample source code.
		/// </summary>
		private void UpdateSourceCode()
		{
			if (_sources == null)
				return;

			string element = GetSourceCodeId();
			try
			{
				XElement sourceElement = _sources.Element("sources").Elements("source").Where(e => e.Attribute("id").Value == element).FirstOrDefault();
				if (sourceElement != null)
				{
					sourceCodeViewer.SourceCode = sourceElement.Value;
					if (cmBLanguage.SelectedIndex == 0)
						sourceCodeViewer.CodeLanguage = CodeLanguage.CSharp;
					else
						sourceCodeViewer.CodeLanguage = CodeLanguage.VisualBasic;
					sourceCodeViewer.ClearValue(SourceCodeViewer.ForegroundProperty);
				}
				else
				{
					sourceCodeViewer.SourceCode = "No source code available.";
					sourceCodeViewer.CodeLanguage = CodeLanguage.None;
					sourceCodeViewer.Foreground = Brushes.DimGray;
				}
			}
			catch
			{
			}
		}

		/// <summary>
		/// Returns the unique identifier of the currently displayed source code.
		/// </summary>
		private string GetSourceCodeId()
		{
			string abbreviation = "cs";

			if (cmBLanguage.SelectedIndex == 0)
				abbreviation = "cs";
			else
				abbreviation = "vb";

			return string.Format("{0}.{1}", frameContent.Content.ToString(), abbreviation);
		}

		/// <summary>
		/// Gets the currently selected sample code language.
		/// </summary>
		private CodeLanguage CurrentLanguage
		{
			get
			{
				if (cmBLanguage.SelectedIndex == 0)
					return CodeLanguage.CSharp;

				return CodeLanguage.VisualBasic;
			}
		}

		#endregion

		#region Diagram Events

		void diagram_CellClicked(object sender, CellEventArgs e)
		{
			TableNode table = e.Table;
			if (table != null)
			{
				Type t = frameContent.Content.GetType();

				if (t.Equals(typeof(ClassHierarchyDiagram))) // Class-hierarchy diagram
				{
					if (e.MouseButton == MindFusion.Diagramming.Wpf.MouseButton.Right) // right-click
					{
						// Show the class information dialog
						ClassInfoWindow frm = new ClassInfoWindow();

						frm.EditedClass = e.Table;

						if (frm.ShowDialog() == true)
						{
							Uri u1 = new Uri(MainWindow.ApplicationPath + @"\property.png");
							Uri u2 = new Uri(MainWindow.ApplicationPath + @"\method.png");

							BitmapImage img1 = new BitmapImage(u1);
							BitmapImage img2 = new BitmapImage(u2);

							// Distribute icons
							int header = 0;
							for (int i = 0; i < e.Table.RowCount; i++)
							{
								if (e.Table.Rows[i].Header)
								{
									header++;
									continue;
								}

								if (header == 1)
									e.Table[0, i].Image = img2;
								else
									e.Table[0, i].Image = img1;
							}
						}
					}
				}
				else if (t.Equals(typeof(DatabaseRelationshipDiagram)))
				{
				}
				else if (t.Equals(typeof(SpanningCells)))
				{
					if (e.MouseButton == MindFusion.Diagramming.Wpf.MouseButton.Left)
					{
						if (e.Column == 0)
						{
							if (e.Row == 0)
							{
								// Pick image
								OpenFileDialog dlg = new OpenFileDialog();

								dlg.Filter = "Images|*.jpg; *.bmp; *.png; *.gif|All files|*.*";
								dlg.Title = "Select image";

								if (dlg.ShowDialog(this) == true)
								{
									BitmapImage image;
									try
									{
										Uri uri = new Uri(dlg.FileName);
										image = new BitmapImage(uri);
									}
									catch
									{
										MessageBox.Show("Failed to load image.");
										return;
									}

									e.Table[0, 0].Image = image;
								}
							}
						}
						else if (e.Column == 1)
						{
							switch (e.Row)
							{
								case 0: // person
									MessageBox.Show("Personal data");
									break;

								case 1: // credit card
									MessageBox.Show("Bank account");
									break;

								case 2: // car
									MessageBox.Show("Property");
									break;
							}
						}
					}
				}
			}
		}

		void diagram_DrawNode(object sender, DrawNodeEventArgs e)
		{
			ShapeNode node = e.Node as ShapeNode;
			if (node != null)
			{
				if (e.Node.Bounds.Width == 0 ||
					e.Node.Bounds.Height == 0)
					return;

				if (frameContent.Content == null)
					return;

				Type t = frameContent.Content.GetType();
				Rect nRect = new Rect(e.Node.Bounds.Size);

				if (t.Equals(typeof(GenealogyTree)))
				{
					Point p0 = new Point(0, 0);
					Point p1 = new Point(1, 1);
					double pixel = Constants.GetPixel(diagram.MeasureUnit);

					Point pt1 = new Point(0, 0);
					Point pt2 = new Point(6, 22);
					Point ptf1 = pt1;
					Point ptf2 = pt2;
					double size6 = ptf2.X - ptf1.X; // 6 client units in doc units
					double size22 = ptf2.Y - ptf1.Y; // 22 client units in doc units
					double size34 = size22 + 2 * size6;
					size22 -= pixel;

					for (double f = nRect.Left; f < nRect.Right; f += size22 - pixel)
					{
						e.Graphics.DrawImage(frameImageList[1],
							new Rect(f, nRect.Top, frameImageList[1].Width, 19.2 * pixel));
						e.Graphics.DrawImage(frameImageList[5],
							new Rect(f, nRect.Bottom - pixel * 3.84, frameImageList[5].Width, 19.2 * pixel));
					}

					for (double f = nRect.Top; f < nRect.Bottom; f += size22 - pixel)
					{
						e.Graphics.DrawImage(frameImageList[3],
							new Rect(nRect.Left, f, 19.2 * pixel, frameImageList[3].Height));
						e.Graphics.DrawImage(frameImageList[7],
							new Rect(nRect.Right - pixel * 3.83, f, 19.2 * pixel, frameImageList[7].Height));
					}

					e.Graphics.DrawImage(frameImageList[0],
						new Rect(nRect.Left, nRect.Top, 19.2 * pixel, 19.2 * pixel));
					e.Graphics.DrawImage(frameImageList[2],
						new Rect(nRect.Right - pixel, nRect.Top, 19.2 * pixel, 19.2 * pixel));
					e.Graphics.DrawImage(frameImageList[4],
						new Rect(nRect.Right - pixel, nRect.Bottom - pixel, 19.2 * pixel, 19.2 * pixel));
					e.Graphics.DrawImage(frameImageList[6],
						new Rect(nRect.Left, nRect.Bottom - pixel, 19.2 * pixel, 19.2 * pixel));

					if (node.Tag != null)
					{
						if (node.Tag.ToString() == "male")
							e.Graphics.DrawImage(genderImages[0],
								new Rect(nRect.Right - 6 * mm, nRect.Bottom - 6 * mm, 6 * mm, 6 * mm));
						else
							e.Graphics.DrawImage(genderImages[1],
								new Rect(nRect.Right - 6 * mm, nRect.Bottom - 6 * mm, 6 * mm, 6 * mm));
					}
				}
				else if (t.Equals(typeof(CustomDrawLinks)))
				{
					// ShapeNode fill level is in its tag (0..100)
					double fillLevel = (double)node.Tag;

					// Draw the back
					Brush back = new SolidColorBrush(Color.FromArgb(125, 128, 128, 128));

					// Draw fill
					Brush fill = node.Brush.Clone();

					double h = nRect.Height * fillLevel / 100;
					Rect rc = node.Bounds;
					rc.Offset(-rc.Left, -rc.Top);

					Rect rcFilled = rc;
					rcFilled.Y = rc.Bottom - h;
					rcFilled.Height = h;

					e.Graphics.PushClip(node.GetRegion());

					e.Graphics.DrawRectangle(back, null, rc);
					e.Graphics.DrawRectangle(fill, null, rcFilled);

					e.Graphics.Pop();

					// Frame
					Pen frame = new Pen(Brushes.Black, node.StrokeThickness);
					e.Graphics.DrawEllipse(null, frame, Center(rc), rc.Width / 2, rc.Height / 2);
				}
			}
		}

		void diagram_DrawLink(object sender, DrawLinkEventArgs e)
		{
			if (frameContent.Content == null)
				return;

			Type t = frameContent.Content.GetType();

			if (t.Equals(typeof(CustomDrawLinks)))
			{
				Point a = e.Points[0];
				Point b = e.Points[e.Points.Count - 1];

				if (a.Equals(b))
				{
					// 0-length arrow, skip drawing
					return;
				}

				if (e.Link.Tag == null)
					return;

				// The fill color of the origin
				Color oc = e.Link.Origin == null ? Colors.White :
					BrushToColor(e.Link.Origin.Brush, Colors.White);

				// In order to display a rectangle instead of a simple line,
				// we need to find four points. For this purpose we
				// perform the following transformations
				double an = 0, r = 0;
				Point p1 = new Point();
				Point p2 = new Point();
				Point p3 = new Point();
				Point p4 = new Point();

				// Find two points around the origin control point
				Convert.CartesianToPolar(a, b, ref an, ref r);
				Convert.PolarToCartesian(a, an + 105, 3.2, ref p1);
				Convert.PolarToCartesian(a, an - 105, 3.2, ref p2);

				// At this point in 'r' we have the length of the arrow
				// expressed in the current graphics unit (millimeters by default),
				// and in 'an' we have the angle, between the arrow line and
				// one of the coordinate axis
				double length = r;
				double angle = an;

				// Find two points around the destination control point
				Convert.CartesianToPolar(b, a, ref an, ref r);
				Convert.PolarToCartesian(b, an + 105, 3.2, ref p3);
				Convert.PolarToCartesian(b, an - 105, 3.2, ref p4);

				Point[] pts = new Point[]
					{
						p1, p2, p4, p1
					};

				// Create the graphics path containing the arrow rectangle
				PathGeometry path = new PathGeometry();
				path.FillRule = FillRule.Nonzero;
				PathFigure pf = new PathFigure();
				pf.Segments.Add(new LineSegment(p1, true));
				pf.Segments.Add(new LineSegment(p2, true));
				pf.Segments.Add(new LineSegment(p3, true));
				pf.Segments.Add(new LineSegment(p4, true));
				pf.Segments.Add(new LineSegment(p1, true));
				path.Figures.Add(pf);

				// We have to calculate the progress bar
				double progress = (double)e.Link.Tag;
				double maxProgress = 100;

				// Solid fill the arrow with white color, or the color
				// of the destination box, if the arrow's type is gradient
				Brush solid = new SolidColorBrush(
					progress >= maxProgress ? oc : Colors.White);
				e.Graphics.DrawGeometry(solid, null, path);

				// The frame pen
				Pen frame = new Pen(e.Link.Stroke, e.Link.StrokeThickness);

				// Calculate the progress bar lenght
				double progLen = progress * length / maxProgress;

				// Now we have to find two points which
				// define the end of the progress bar
				// depending on the progress length
				Point pp1 = new Point();
				Point pp2 = new Point();
				Point pp = new Point();

				Convert.PolarToCartesian(a, angle, progLen, ref pp);
				Convert.PolarToCartesian(pp, angle - 105, 3.2, ref pp1);
				Convert.PolarToCartesian(pp, angle + 105, 3.2, ref pp2);

				// Create the graphics path containing the rectangle of
				// the progress bar
				PathGeometry ppath = new PathGeometry();
				ppath.FillRule = FillRule.Nonzero;
				PathFigure ppf = new PathFigure();
				ppf.Segments.Add(new LineSegment(pp1, true));
				ppf.Segments.Add(new LineSegment(pp2, true));
				ppf.Segments.Add(new LineSegment(p1, true));
				ppf.Segments.Add(new LineSegment(p2, true));
				ppf.Segments.Add(new LineSegment(pp1, true));
				ppath.Figures.Add(ppf);

				// Fill the path with the color of the origin box
				Brush brush = new SolidColorBrush(oc);
				e.Graphics.DrawGeometry(brush, null, ppath);

				// Frame the progress bar
				if (progress < maxProgress && (double)e.Link.Origin.Tag == 100)
					e.Graphics.DrawLine(frame, pp1, pp2);

				// Draw the arrow frame using the arrow's pen settings
				e.Graphics.DrawLine(frame, p1, p4);
				e.Graphics.DrawLine(frame, p2, p3);
			}
		}

		void diagram_DeserializeTag(object sender, SerializeTagEventArgs e)
		{
			string type, val;

			XmlText textNode = e.Representation.LastChild as XmlText;
			if (textNode != null)
			{
				string stringRep = textNode.Value;
				int pos = stringRep.IndexOf(";");

				if (pos == -1)
					return;

				type = stringRep.Substring(0, pos);
				val = stringRep.Substring(pos + 1);

				Type t = Type.GetType(type);
				object tag = null;
				if (t == typeof(string))
					tag = val;
				else if (t == typeof(int))
					tag = XmlConvert.ToInt32(val);
				else if (t == typeof(float))
					tag = XmlConvert.ToSingle(val);

				if (e.Object is Group)
					((Group)e.Object).Tag = tag;
				else
					((DiagramItem)e.Object).Tag = tag;
			}
		}

		void diagram_SerializeTag(object sender, SerializeTagEventArgs e)
		{
			object tag = null;

			if (e.Object is Group)
				tag = ((Group)e.Object).Tag;
			else if (!(e.Object is AnchorPoint) && e.Object is DiagramItem)
				tag = ((DiagramItem)e.Object).Tag;

			string stringRepresentation = "";
			if (tag != null)
			{
				stringRepresentation = tag.GetType().ToString();
				stringRepresentation += ";";
				stringRepresentation += tag.ToString();
			}

			XmlNode repNode = e.Context.XmlDocument.CreateTextNode(stringRepresentation);
			e.Representation.AppendChild(repNode);
		}

		void diagram_LinkDeactivated(object sender, LinkEventArgs e)
		{
			UpdateSelectedObject();
		}

		void diagram_SelectionChanged(object sender, EventArgs e)
		{
			Type t = frameContent.Content.GetType();
			if (t.Equals(typeof(ErmDiagram)))
			{
				ShapeNode node = diagram.FindNode(2) as ShapeNode;
				if (node != null)
					node.Visible = false;
			}

			UpdateSelectedObject();
		}

		void diagram_Clicked(object sender, DiagramEventArgs e)
		{
			UpdateSelectedObject();

			if (e.MouseButton == MindFusion.Diagramming.Wpf.MouseButton.Left && pageIndex == 8) // Net Sample
			{
				// Create the specified box
				Uri uri = new Uri(MainWindow.ResourcesPath + @"image" + cBxNetworkIcons.SelectedIndex + ".png");
				BitmapImage image = new BitmapImage(uri);
				if (image != null)
				{
					ShapeNode b = diagram.Factory.CreateShapeNode(
						e.MousePosition, new Size(1, 1));

					b.Image = image;
					b.ImageAlign = ImageAlign.TopLeft;
					b.ResizeToFitImage();
					b.Transparent = true;
					b.EnabledHandles = AdjustmentHandles.Move;
					if (chBxAttachText.IsChecked == true && tBxAttachText.Text != "")
					{
						ShapeNode bb = diagram.Factory.CreateShapeNode(
							e.MousePosition.X - 10, e.MousePosition.Y + b.Bounds.Height,
							b.Bounds.Width + 20, 15);
						bb.AttachTo(b, AttachToNode.BottomLeft);
						bb.Locked = true;
						bb.Brush = Brushes.Transparent;
						bb.Stroke = Brushes.Transparent;
						bb.Text = tBxAttachText.Text;
						bb.ResizeToFitText(FitSize.KeepRatio);
						Rect rc = bb.Bounds;
						rc.X = b.Bounds.X + b.Bounds.Width / 2 - rc.Width / 2;
						bb.Bounds = rc;
					}
				}
			}

			if (e.MouseButton == MindFusion.Diagramming.Wpf.MouseButton.Right &&
				frameContent.Content.GetType().Equals(typeof(NetSample)))
			{
				diagram.Selection.Clear();
			}

		}

		void diagram_Drop(object sender, System.Windows.DragEventArgs e)
		{
			e.Handled = true;
			Point viewPoint = e.GetPosition(diagramView);
			Point diagramPoint = diagramView.ViewToDiagram(viewPoint);

			if (e.Data.GetDataPresent(typeof(BitmapImage)))
			{
				ShapeNode b = diagram.Factory.CreateShapeNode(
					diagramPoint.X, diagramPoint.Y, 10, 10);
				b.Obstacle = true;
				b.EnabledHandles = AdjustmentHandles.All;
				b.RotateImage = true;
				b.Image = (BitmapSource)e.Data.GetData(typeof(BitmapImage));
				b.ResizeToFitImage();
				b.Transparent = true;
			}
			else if (e.Data.GetDataPresent(DataFormats.Text))
			{
				string s = (string)e.Data.GetData(DataFormats.Text);
				ShapeNode b = diagram.Factory.CreateShapeNode(
					diagramPoint.X, diagramPoint.Y, 120, 24);
				b.Text = s;
			}
			else if (e.Data.GetDataPresent(typeof(ImageDragData)))
			{
				ImageDragData data = e.Data.GetData(typeof(ImageDragData)) as ImageDragData;
				ShapeNode b = diagram.Factory.CreateShapeNode(
					diagramPoint.X - data.Size.Width / 2,
					diagramPoint.Y - data.Size.Height / 2,
					data.Size.Width, data.Size.Height);
				b.Image = (BitmapSource)data.Image.Source;
				b.ImageAlign = ImageAlign.Fit;
				b.Transparent = true;
				b.RotateImage = true;
				b.RotateText = true;
				b.Shape = Shapes.Rectangle;
				b.EnabledHandles = b.EnabledHandles | AdjustmentHandles.Rotate;
			}
		}

		void diagram_DragOver(object sender, System.Windows.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(BitmapImage)) ||
				e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effects = DragDropEffects.Copy;
			}
			else
			{
				if (e.Data.GetDataPresent(typeof(ImageDragData)))
					e.Effects = DragDropEffects.Copy;
				else
					e.Effects = DragDropEffects.None;
			}
		}

		void diagram_NodeClicked(object sender, NodeEventArgs e)
		{
			if (frameContent.Content == null)
				return;

			Type type = frameContent.Content.GetType();

			if (type.Equals(typeof(TreeViewNodes)))
			{
				TreeViewNode treeNode = e.Node as TreeViewNode;
				if (treeNode == null)
					return;

				// Hit-test the clicked item
				TreeViewItem item = treeNode.ItemFromPoint(e.MousePosition, true);

				if (e.MouseButton == MindFusion.Diagramming.Wpf.MouseButton.Right)
				{
					ContextMenu menu = new ContextMenu();

					MenuItem mItem = new MenuItem();
					mItem.Header = "Add...";
					mItem.Click += new RoutedEventHandler(
							delegate(object s, RoutedEventArgs ev)
							{
								AddTreeViewItemForm form = new AddTreeViewItemForm();
								if (form.ShowDialog() == true)
								{
									TreeViewItem child = new TreeViewItem();
									child.Height = 20;
									child.Label = form.ItemLabel;
									child.Image = form.ItemImage;
									child.LabelBrush = new SolidColorBrush(form.ItemColor);
									child.Tag = form.ItemImageIndex;
									if (item != null)
										item.Children.Add(child);
									else
										treeNode.RootItems.Add(child);
								}
							});
					menu.Items.Add(mItem);

					if (item != null)
					{
						MenuItem item2 = new MenuItem();
						item2.Header = "Delete...";
						item2.Click += new RoutedEventHandler(
							delegate(object s, RoutedEventArgs ev)
							{
								if (MessageBox.Show(this, string.Format("Are you sure you want to remove '{0}'?", item.Label),
									"Confirm Delete", MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
									return;

								CompositeCmd ccmd = diagram.UndoManager.StartComposite("Deleting");
								ChangeItemCmd cmd = new ChangeItemCmd(treeNode, "Deleting");
								//treeNode.DestroyItem(item);
								treeNode.RemoveItem(item);
								cmd.Execute();
								ccmd.Execute();
							});
						menu.Items.Add(item2);
					}
					menu.Width = 100;
					menu.Height = 60;
					menu.IsOpen = true;
					menu.Visibility = Visibility.Visible;
				}
			}
		}

		void diagram_NodeDeleting(object sender, NodeValidationEventArgs e)
		{
		}

		void diagram_NodeDeleted(object sender, NodeEventArgs e)
		{
			if (frameContent.Content == null)
				return;

			Type type = frameContent.Content.GetType();

			if (type.Equals(typeof(ErmDiagram)))
			{
				if (e.Node is TableNode)
				{
					TableNode t = e.Node as TableNode;
					if (t.SubordinateGroup != null)
					{
						while (t.SubordinateGroup.AttachedNodes.Count > 0)
							diagram.Nodes.Remove(t.SubordinateGroup.AttachedNodes[0]);
					}
				}
			}
		}

		#endregion

		#region Menu Events

		private void mClear_Click(object sender, RoutedEventArgs e)
		{
			diagram.ClearAll();
		}

		private void mOpen_Click(object sender, RoutedEventArgs e)
		{
			if (openFileDialog.ShowDialog() == true)
			{
				try
				{
					diagram.LoadFromXml(openFileDialog.FileName);
				}
				catch
				{
					MessageBox.Show("Invalid file format.");
				}
			}
		}

		private void mSave_Click(object sender, RoutedEventArgs e)
		{
			if (saveFileDialog.ShowDialog() == true)
			{
				diagram.SaveToXml(saveFileDialog.FileName);
			}
		}

		private void mPrint_Click(object sender, RoutedEventArgs e)
		{
			diagram.Print();
		}

		private void mPreview_Click(object sender, RoutedEventArgs e)
		{
			diagram.PrintPreview();
		}

		private void mExit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void mEdit_Click(object sender, RoutedEventArgs e)
		{
			mUndo.IsEnabled = diagram.UndoManager.History.NextUndo != null;
			mRedo.IsEnabled = diagram.UndoManager.History.NextRedo != null;
		}

		private void mUndo_Click(object sender, RoutedEventArgs e)
		{
			diagram.UndoManager.Undo();
		}

		private void mRedo_Click(object sender, RoutedEventArgs e)
		{
			diagram.UndoManager.Redo();
		}

		private void mCut_Click(object sender, RoutedEventArgs e)
		{
			diagram.CutToClipboard(false);
		}

		private void mCopy_Click(object sender, RoutedEventArgs e)
		{
			diagram.CopyToClipboard(false);
		}

		private void mPaste_Click(object sender, RoutedEventArgs e)
		{
			diagram.PasteFromClipboard(new Vector(10, 10));
		}

		private void mEdit_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
		{
			MessageBox.Show("rem me");
		}

		private void mainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			overviewWindow.Close();
			Process.GetCurrentProcess().Kill();
		}

		private void mDelete_Click(object sender, RoutedEventArgs e)
		{
			if (frameContent.Content == null)
				return;

			Type type = frameContent.Content.GetType();

			if (type.Equals(typeof(ErmDiagram)))
			{
				// Deletion of ERM tables (include attached buttons)
				if (diagram.Selection != null)
				{
					int i = 0;
					while (i < diagram.Selection.Nodes.Count)
					{
						DiagramNode node = diagram.Selection.Nodes[i];

						if (!(node is TableNode))
						{
							i++;
							continue;
						}

						TableNode t = node as TableNode;
						if (t == null)
							continue;
						while (t.SubordinateGroup.AttachedNodes.Count > 0)
							diagram.Nodes.Remove(t.SubordinateGroup.AttachedNodes[0]);
						diagram.Nodes.Remove(t);
					}

					while (diagram.Selection.Links.Count > 0)
						diagram.Links.Remove(diagram.Selection.Links[0]);
				}

				return;
			}

			if (diagram.Selection != null)
			{
				while (diagram.Selection.Nodes.Count > 0)
					diagram.Nodes.Remove(diagram.Selection.Nodes[0]);
				while (diagram.Selection.Links.Count > 0)
					diagram.Links.Remove(diagram.Selection.Links[0]);
			}
		}

		private void mGroup_Click(object sender, RoutedEventArgs e)
		{
			if (diagram.ActiveItem == null)
				return;

			Group gr = diagram.Factory.CreateGroup(diagram.ActiveItem);
			if (gr == null)
				return;

			if (diagram.ActiveItem is DiagramLink)
			{
				DiagramLink a = (DiagramLink)diagram.ActiveItem;
				int sgm = a.SegmentCount + 1, i = 0;
				foreach (DiagramNode co in diagram.Selection.Nodes)
				{
					if (co != diagram.ActiveItem)
						gr.AttachToLinkPoint(co, i++ % sgm);
				}
			}
			else
			{
				foreach (DiagramNode co in diagram.Selection.Nodes)
				{
					if (co != diagram.ActiveItem)
						gr.AttachToCorner(co, 0);
				}
			}
		}

		private void mUngroup_Click(object sender, RoutedEventArgs e)
		{
			if (diagram.ActiveItem == null)
				return;

			if (diagram.ActiveItem.SubordinateGroup == null)
				return;

			diagram.Groups.Remove(diagram.ActiveItem.SubordinateGroup);
		}

		private void mUnlockAll_Click(object sender, RoutedEventArgs e)
		{
			foreach (DiagramItem obj in diagram.Items)
				obj.Locked = false;
		}

		private void mRouteAll_Click(object sender, RoutedEventArgs e)
		{
			diagram.RouteAllLinks();
		}

		private void mOverview_Click(object sender, RoutedEventArgs e)
		{
			if (overviewWindow.Visibility == Visibility.Hidden)
				overviewWindow.Visibility = Visibility.Visible;
			else
				overviewWindow.Visibility = Visibility.Hidden;
		}

		private void mRuler_Click(object sender, RoutedEventArgs e)
		{
			if (ruler == null)
				return;

			if (ruler.HorizontalScaleVisible == Visibility.Visible)
				ruler.HorizontalScaleVisible = Visibility.Collapsed;
			else
				ruler.HorizontalScaleVisible = Visibility.Visible;

			if (ruler.VerticalScaleVisible == Visibility.Visible)
				ruler.VerticalScaleVisible = Visibility.Collapsed;
			else
				ruler.VerticalScaleVisible = Visibility.Visible;
		}

		private void mAbout_Click(object sender, RoutedEventArgs e)
		{
			AboutWindow window = new AboutWindow();

			window.Visibility = Visibility.Visible;
		}


		#endregion

		#region Action

		private void btnPurchase_Click(object sender, RoutedEventArgs e)
		{
			System.Diagnostics.Process.Start(MainWindow.ApplicationPath + "Purchase.htm");
		}

		private void takeATourBtn_Click(object sender, RoutedEventArgs e)
		{
			TourForm frm = new TourForm();

			frm.TheChart = diagram;
			frm.ShowDialog();
		}

		private void btnAddPerson_Click(object sender, RoutedEventArgs e)
		{
			AddPersonWindow frm = new AddPersonWindow();

			if (frm.ShowDialog() == true)
			{
				ShapeNode b = diagram.Factory.CreateShapeNode(10, 10, 76, 96);
				ShapeNode bb = diagram.Factory.CreateShapeNode(86, 10, 152, 96);

				bb.AttachTo(b, AttachToNode.TopRight);

				b.EnabledHandles = AdjustmentHandles.Move;
				b.Image = frm.PersonImage;
				b.ImageAlign = ImageAlign.Fit;

				bb.Locked = true;
				Uri uri = new Uri(MainWindow.ResourcesPath + @"backgroundImage.bmp");
				bb.Image = new BitmapImage(uri);
				bb.ImageAlign = ImageAlign.Stretch;
				bb.Text = frm.PersonName + "\n" + frm.PersonDates;
			}
		}

		private void btnTreeLayout_Click(object sender, RoutedEventArgs e)
		{
			DiagramNode co = null;

			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			if (selectedShapes.Count > 0)
				co = selectedShapes[0];

			double lsp = 10, isp = 10;
			try
			{
				lsp = Double.Parse(tbxTreeLevelSpace.Text);
			}
			catch
			{
				lsp = 10;
			}
			try
			{
				isp = Double.Parse(tBxTreeItemSpace.Text);
			}
			catch
			{
				isp = 10;
			}

			TreeLayoutDirections direction = TreeLayoutDirections.TopToBottom;
			switch (cBxTreeDirection.SelectedIndex)
			{

				case 0:
					direction = TreeLayoutDirections.TopToBottom;
					break;

				case 1:
					direction = TreeLayoutDirections.BottomToTop;
					break;

				case 2:
					direction = TreeLayoutDirections.LeftToRight;
					break;

				case 3:
					direction = TreeLayoutDirections.RightToLeft;
					break;

			}

			TreeLayout layout = new TreeLayout(co,
				(TreeLayoutType)cBxTreeType.SelectedIndex,
				false,
				(TreeLayoutLinkType)cBxTreeLink.SelectedIndex,
				direction,
				(double)lsp, (double)isp, co != null, new Size(10, 10), false);

			layout.KeepGroupLayout = (bool)chBxKeepGroups.IsChecked;
			layout.KeepRootPosition = (bool)chBxKeepRootPos.IsChecked;

			layout.Arrange(diagram);
		}

		private void btnRadialLayout_Click(object sender, RoutedEventArgs e)
		{
			int depth = 5;
			Cursor defCursor = diagram.Cursor;

			try
			{
				depth = int.Parse(tBxRadialDepth.Text);
			}
			catch
			{
				depth = 5;
			}

			diagram.ClearAll();

			// Enumerate c:
			try
			{
				EnumDirectoryInfo(new DirectoryInfo(@"c:\"), null, depth);
			}
			catch
			{
			}

			Cursor = System.Windows.Input.Cursors.Wait;
			diagram.Cursor = System.Windows.Input.Cursors.Wait;

			TreeLayout layout = new TreeLayout(
				null, TreeLayoutType.Radial, false,
				TreeLayoutLinkType.Straight, TreeLayoutDirections.TopToBottom,
				38, 0, false, new Size(19.2, 19.2), true);

			layout.Progress = new LayoutProgress(OnLayoutProgress);

			progress.Minimum = 0;
			progress.Value = 0;
			progress.Show();

			layout.Arrange(diagram);

			progress.Hide();

			diagram.ResizeToFitItems(5, false);
			if (diagram.Nodes.Count > 0)
				diagramView.BringIntoView(diagram.Nodes[0]);
			diagramView.ZoomToFit();

			diagram.Cursor = defCursor;
			Cursor = defCursor;
		}

		private void btnSpringLayout_Click(object sender, RoutedEventArgs e)
		{
			int iters = 100;
			double nodeDistance = 15f;

			try
			{
				iters = int.Parse(tBxSpringDepth.Text);
			}
			catch
			{
				iters = 100;
			}

			try
			{
				nodeDistance = double.Parse(tBxSpringNodeDist.Text);
			}
			catch
			{
				nodeDistance = 15f;
			}

			SpringLayout layout = new SpringLayout(iters, nodeDistance, true, true);
			layout.LayoutMethod = SpringLayoutMethod.Classic;
			layout.EnableClusters = false;

			layout.Progress = new LayoutProgress(OnLayoutProgress);
			if (diagram.ActiveItem is ShapeNode)
				layout.Root = diagram.ActiveItem as ShapeNode;

			progress.Minimum = 0;
			progress.Value = 0;
			progress.Show();

			layout.Arrange(diagram);

			progress.Hide();

			diagram.ResizeToFitItems(5, false);
		}

		private void btnLayeredLayout_Click(object sender, RoutedEventArgs e)
		{
			LayeredLayout layout = new LayeredLayout();

			float lsp = 10, nsp = 20;
			try
			{
				lsp = Single.Parse(tbxLayeredLevelSpace.Text);
			}
			catch
			{
				lsp = 10;
			}
			try
			{
				nsp = Single.Parse(tbxLayeredItemSpace.Text);
			}
			catch
			{
				nsp = 20;
			}

			layout.LayerDistance = lsp;
			layout.NodeDistance = nsp;
			//TODO: port margins
			layout.Margins = new Size(15, 15);
			layout.SplitLayers = true;
			layout.Orientation = ((bool)rBtnLayeredVert.IsChecked ?
				MindFusion.Diagramming.Wpf.Layout.Orientation.Vertical :
				MindFusion.Diagramming.Wpf.Layout.Orientation.Horizontal);
			layout.LinksCompactFactor = (bool)chBxLayeredCompact.IsChecked ? 0.65f : 1;
			layout.TimeLimit = 10000;

			layout.Progress = new LayoutProgress(OnLayoutProgress);
			if (diagram.ActiveItem is ShapeNode)
				layout.Root = diagram.ActiveItem as ShapeNode;

			layout.KeepGroupLayout = (bool)chBxLayeredKeepGroups.IsChecked;

			progress.Minimum = 0;
			progress.Value = 0;
			progress.Show();

			layout.Arrange(diagram);

			progress.Hide();

			diagram.ResizeToFitItems(5, false);
			diagramView.ZoomToFit();

			// Color arrows
			Hashtable map = new Hashtable();
			foreach (DiagramLink a in diagram.Links)
			{
				double x = 0;
				foreach (Point point in a.ControlPoints)
					x += point.X;

				x /= a.ControlPoints.Count;

				map[a] = x;
			}

			double minX = int.MaxValue;
			double maxX = int.MinValue;
			foreach (double x in map.Values)
			{
				minX = Math.Min(minX, x);
				maxX = Math.Max(maxX, x);
			}

			foreach (DiagramLink a in map.Keys)
			{
				double x = (double)map[a];

				byte r = (byte)(70 - ((x - minX) * 55 / (maxX - minX)));
				byte g = 0;
				byte b = (byte)(75 + ((x - minX) * 105 / (maxX - minX)));

				if (r < 0)
					r = 0;
				if (r > 255)
					r = 255;
				if (b < 0)
					b = 0;
				if (b > 255)
					b = 255;

				Color c = Color.FromArgb(255, r, g, b);

				a.Stroke = new SolidColorBrush(c);
				a.HeadStroke = new SolidColorBrush(c);
			}

			//here  diagram.Update(Update(false);
		}

		private void btnGridLayout_Click(object sender, RoutedEventArgs e)
		{
			GridLayout layout = new GridLayout();

			double size = 25;
			int iter = 1000;
			try
			{
				size = double.Parse(tBxGridNodeDist.Text);
			}
			catch
			{
				size = 25;
			}
			try
			{
				iter = int.Parse(tBxGridIter.Text);
			}
			catch
			{
				iter = 1000;
			}

			layout.GridSize = size;
			layout.Iterations = iter;
			layout.Margins = new Size(15, 15);

			layout.Progress = new LayoutProgress(OnLayoutProgress);
			if (diagram.ActiveItem is ShapeNode)
				layout.Root = diagram.ActiveItem as ShapeNode;

			layout.KeepGroupLayout = (bool)chBxGridKeepGroups.IsChecked;

			progress.Minimum = 0;
			progress.Value = 0;
			progress.Show();

			layout.Arrange(diagram);

			progress.Hide();

			diagram.ResizeToFitItems(5, false);
			diagramView.ZoomToFit();
		}

		private void btnClusteredLayout_Click(object sender, RoutedEventArgs e)
		{
			SpringLayout layout = new SpringLayout(500, 50, true, false);
			layout.LayoutMethod = SpringLayoutMethod.Classic;
			layout.EnableClusters = true;
			layout.RandomSeed = 5;
			layout.MinimizeCrossings = true;
			layout.Progress = new LayoutProgress(OnLayoutProgress);
			if (diagram.ActiveItem is ShapeNode)
				layout.Root = diagram.ActiveItem as ShapeNode;

			layout.Arrange(diagram);

			diagram.ResizeToFitItems(5, false);
		}

		private void btnLoadGraphA_Click(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"SpringLayout.xml");
			diagram.BackBrush = Brushes.AliceBlue;
		}

		private void btnLoadGraphB_Click(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"LayeredLayout.xml");
			diagram.BackBrush = Brushes.AliceBlue;
		}

		private void btnLoadGraphC_Click(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"GridLayout.xml");
			diagram.BackBrush = Brushes.AliceBlue;
		}

		private void btnLoadGraphD_Click(object sender, RoutedEventArgs e)
		{
			diagram.LoadFromXml(MainWindow.ApplicationPath + @"ClusteredLayout.xml");
			diagram.BackBrush = Brushes.AliceBlue;
		}

		private void btnAnnealLayout_Click(object sender, RoutedEventArgs e)
		{
			AnnealLayout layout = new AnnealLayout();
			layout.InitialTemperature = 200;
			layout.Stages = 30;
			layout.GatherStatistics = true;

			layout.Progress = new LayoutProgress(OnLayoutProgress);

			progress.Minimum = 0;
			progress.Value = 0;
			progress.Show();

			layout.Arrange(diagram);
			progress.Hide();

			diagram.ResizeToFitItems(5, false);

			if (layout.Statistics.EdgeCrossingsFound > 0)
			{
				layout.Randomize = false;
				layout.Arrange(diagram);
			}
		}

		private void btnOnewayLayout_Click(object sender, RoutedEventArgs e)
		{
			OneWayLayout layout = new OneWayLayout();
			if (rBtnOnewayVertical.IsChecked == true)
				layout.Orientation = MindFusion.Diagramming.Wpf.Layout.Orientation.Vertical;
			else
				layout.Orientation = MindFusion.Diagramming.Wpf.Layout.Orientation.Horizontal;
			layout.RoundedLinks = chBxOnewayRoundLinks.IsChecked == true;

			float nodeDistance = 20;
			if (float.TryParse(tBxOnewayNodeDistance.Text, out nodeDistance))
				layout.NodeDistance = nodeDistance;

			layout.Arrange(diagram);
			diagram.ResizeToFitItems(5, false);
		}

		private void btnOutgoing_Click(object sender, RoutedEventArgs e)
		{
			if (!CheckAndClear())
				return;

			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			ShapeNode bb = selectedShapes[0] as ShapeNode;
			foreach (DiagramLink aa in bb.OutgoingLinks)
			{
				aa.Stroke = Brushes.Blue;
				aa.StrokeThickness = 2;
				aa.StrokeDashStyle = new DashStyle(new double[] { 1, 2, 2 }, 2);
			}
		}

		private void btnIncoming_Click(object sender, RoutedEventArgs e)
		{
			if (!CheckAndClear())
				return;

			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			ShapeNode bb = selectedShapes[0] as ShapeNode;
			foreach (DiagramLink aa in bb.IncomingLinks)
			{
				aa.Stroke = Brushes.Blue;
				aa.StrokeThickness = 2;
				aa.StrokeDashStyle = new DashStyle(new double[] { 1, 2, 2 }, 2);
			}
		}

		private void btnFindChildren_Click(object sender, RoutedEventArgs e)
		{
			if (!CheckAndClear())
				return;

			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			ShapeNode bb = selectedShapes[0] as ShapeNode;
			foreach (DiagramLink aa in bb.OutgoingLinks)
			{
				ShapeNode bbb = aa.Destination as ShapeNode;
				if (bbb == null)
					continue;

				bbb.Stroke = Brushes.Blue;
				bbb.StrokeThickness = 2;
				bbb.StrokeDashStyle = new DashStyle(new double[] { 0, 3, 0 }, 2);
			}
		}

		private void btnFindParents_Click(object sender, RoutedEventArgs e)
		{
			if (!CheckAndClear())
				return;

			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			ShapeNode bb = selectedShapes[0] as ShapeNode;
			foreach (DiagramLink aa in bb.IncomingLinks)
			{
				ShapeNode bbb = aa.Origin as ShapeNode;
				if (bbb == null)
					continue;

				bbb.Stroke = Brushes.Blue;
				bbb.StrokeThickness = 2;
				bbb.StrokeDashStyle = new DashStyle(new double[] { 0, 3, 0 }, 2);
			}
		}

		private void btnSuccessors_Click(object sender, RoutedEventArgs e)
		{
			if (!CheckAndClear())
				return;

			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			ShapeNode bb = selectedShapes[0] as ShapeNode;
			DiagramNodeCollection visited = new DiagramNodeCollection();
			VisitSuccessors(bb, visited);

		}

		private void btnPredecessors_Click(object sender, RoutedEventArgs e)
		{
			if (!CheckAndClear())
				return;

			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			ShapeNode bb = selectedShapes[0] as ShapeNode;
			DiagramNodeCollection visited = new DiagramNodeCollection();
			VisitPredecessors(bb, visited);
		}

		private void btnAddTable_Click(object sender, RoutedEventArgs e)
		{
			AddTableWindow dlgWindow = new AddTableWindow();

			dlgWindow.Title = "TableNode";
			if (dlgWindow.ShowDialog() == true)
			{
				TableNode t = diagram.Factory.CreateTableNode(10, 10, 116, 126);
				t.Caption = dlgWindow.tBxTableName.Text;
				t.TextAlignment = TextAlignment.Center;
				t.TextVerticalAlignment = AlignmentY.Center;
				t.CellTextStyle.FontFamily = t.FontFamily;
				t.CellTextStyle.FontSize = t.FontSize;
				t.CellTextStyle.FontWeight = t.FontWeight;
			}
		}

		private void btnAddField_Click(object sender, RoutedEventArgs e)
		{
			TableNode t = null;
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				t = node as TableNode;
				if (t != null)
					break;
			}

			if (t == null)
			{
				MessageBox.Show(this, "Select the table to add the field to.");
				return;
			}

			AddFieldWindow form = new AddFieldWindow();

			form.FieldName = "Field";
			form.FieldType = 0;
			if (form.ShowDialog() == true)
			{
				int r = t.AddRow();
				t[0, r].Text = form.FieldTypeText;
				t[1, r].Text = form.FieldName;
			}
		}

		private void btnCreate_Click(object sender, RoutedEventArgs e)
		{
			// Create a spanned table
			TableNode t = diagram.Factory.CreateTableNode(20, 20, 184, 153);

			t.Brush = new SolidColorBrush(Color.FromArgb(0xFF, 0xE0, 0xE0, 0xE0));
			t.FontFamily = new FontFamily("Tahoma");
			t.FontSize = 15;
			t.FontWeight = FontWeights.Bold;
			t.CellTextStyle.FontFamily = t.FontFamily;
			t.CellTextStyle.FontSize = t.FontSize;
			t.CellTextStyle.FontWeight = t.FontWeight;
			t.RedimTable(2, 4);

			t.Columns[0].ColumnStyle = MindFusion.Diagramming.Wpf.ColumnStyle.AutoWidth;
			t.Columns[1].Width = 38;
			t.Columns[1].ColumnStyle = MindFusion.Diagramming.Wpf.ColumnStyle.FixedWidth;

			t[0, 0].RowSpan = 3;
			t[0, 3].ColumnSpan = 2;

			Uri uriDummy1 = new Uri(MainWindow.ApplicationPath + @"\dummy1.png");
			Uri uriDummy2 = new Uri(MainWindow.ApplicationPath + @"\dummy2.png");
			Uri uriDummy3 = new Uri(MainWindow.ApplicationPath + @"\dummy3.png");

			t[1, 0].Image = new BitmapImage(uriDummy1);
			t[1, 1].Image = new BitmapImage(uriDummy2);
			t[1, 2].Image = new BitmapImage(uriDummy3);
			t[1, 0].ImageAlign = ImageAlign.Center;
			t[1, 1].ImageAlign = ImageAlign.Center;
			t[1, 2].ImageAlign = ImageAlign.Center;

			t[0, 3].Text = "<double-click to edit>";
			t[0, 3].TextAlignment = TextAlignment.Center;
			t[0, 3].TextVerticalAlignment = AlignmentY.Center;
		}

		private void OnTracePath(object sender, EventArgs e)
		{
			if (_tracePath == null)
				return;

			double pixel = GraphicsUnit.Pixel.Convert(1, diagram.MeasureUnit);

			// Animate the path depending on the current step
			DiagramLink a;
			if (_tracePathStep >= 0 && _tracePathStep < _tracePath.Count)
			{
				a = _tracePath[_tracePathStep];
				a.Stroke = new SolidColorBrush(Color.FromRgb(0xFF, 0, 0));
				a.StrokeThickness = pixel * _tracePathDisp + pixel;
			}
			for (int i = _tracePathStep - 1; i >= _tracePathStep - _tracePathDisp; i--)
			{
				if (i >= 0 && i < _tracePath.Count)
				{
					a = _tracePath[i];

					int r = 0xFF * (_tracePathDisp - (_tracePathStep - i) + 1) / (_tracePathDisp + 1);
					a.Stroke = new SolidColorBrush(Color.FromRgb((byte)r, 0, 0));
					a.StrokeThickness = Math.Max(pixel, 1.5 - 0.3 * (_tracePathStep - i));
				}
			}
			int last = _tracePathStep - _tracePathDisp - 1;
			if (last >= 0 && last < _tracePath.Count)
			{
				a = _tracePath[last];
				a.Stroke = Brushes.Black;
				a.StrokeThickness = pixel;
			}

			// Check if the animation should stop
			if (_tracePathStep >= _tracePath.Count + _tracePathDisp)
				_tracePathTimer.Stop();

			_tracePathStep++;
		}

		private void btnTracePath_Click(object sender, RoutedEventArgs e)
		{
			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			if (selectedShapes.Count != 2)
			{
				MessageBox.Show(this, "Select exactly two nodes!");
				return;
			}

			double pixel = GraphicsUnit.Pixel.Convert(1, diagram.MeasureUnit);

			// Reset all arrows colors
			foreach (DiagramLink link in diagram.Links)
			{
				link.Stroke = Brushes.Black;
				link.StrokeThickness = pixel;
				link.HeadStroke = Brushes.Black;
				link.HeadStrokeThickness = pixel;
				link.Brush = Brushes.BlanchedAlmond;
			}

			PathFinder finder = new PathFinder(diagram);

			MindFusion.Diagramming.Wpf.Path path = finder.FindShortestPath(
				selectedShapes[0], selectedShapes[1]);
			if (path != null)
			{
				_tracePath = path.Links;

				// Trace the path
				_tracePathStep = 0;
				_tracePathTimer.Start();
			}
			else
				MessageBox.Show(this, "Path not found!");
		}

		private void btnFindAllPaths_Click(object sender, RoutedEventArgs e)
		{
			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			if (selectedShapes.Count != 2)
			{
				MessageBox.Show(this, "Select exactly two nodes!");
				return;
			}

			// Reset all arrows colors
			foreach (DiagramLink link in diagram.Links)
			{
				link.Stroke = Brushes.Black;
				link.Brush = Brushes.BlanchedAlmond;
			}

			PathFinder finder = new PathFinder(diagram);
			PathCollection paths = finder.FindAllPaths(
				selectedShapes[0], selectedShapes[1]);
			if (paths.Count > 0)
			{
				MessageBox.Show("Found a total of " + paths.Count.ToString() +
					" different paths.");

				// Color the paths
				foreach (MindFusion.Diagramming.Wpf.Path path in paths)
				{
					Color color = Color.FromArgb((byte)255, (byte)random.Next(250),
						(byte)random.Next(150), (byte)random.Next(150));
					Color fill = Color.FromArgb((byte)175, (byte)(color.R / 2),
						(byte)(color.G / 2), (byte)(color.B / 2));

					foreach (DiagramLink arrow in path.Links)
					{
						arrow.Stroke = new SolidColorBrush(color);
						arrow.StrokeThickness = mm / 2;
						arrow.Brush = new SolidColorBrush(fill);
					}
				}
			}
			else
			{
				MessageBox.Show(this, "No path found!");
			}
		}

		private void btnDetectCycle_Click(object sender, RoutedEventArgs e)
		{
			double pixel = GraphicsUnit.Pixel.Convert(1, diagram.MeasureUnit);
			// Reset all arrows colors
			foreach (DiagramLink link in diagram.Links)
			{
				link.Stroke = Brushes.Black;
				link.StrokeThickness = pixel;
				link.HeadStroke = Brushes.Black;
				link.HeadStrokeThickness = pixel;
				link.Brush = Brushes.BlanchedAlmond;
			}

			PathFinder finder = new PathFinder(diagram);
			MindFusion.Diagramming.Wpf.Path path = finder.FindCycle();
			if (path != null)
			{
				foreach (DiagramLink link in path.Links)
				{
					link.Stroke = Brushes.Red;
					link.StrokeThickness = 2 * pixel;
					link.HeadStroke = Brushes.Red;
					link.HeadStrokeThickness = 2 * pixel;
				}
			}
			else
			{
				MessageBox.Show("No cycle found within the graph!");
			}
		}

		private void btnFindCycle_Click(object sender, RoutedEventArgs e)
		{
			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}

			if (selectedShapes.Count != 1)
			{
				MessageBox.Show(this, "Select exactly one node!");
				return;
			}
			double pixel = GraphicsUnit.Pixel.Convert(1, diagram.MeasureUnit);
			// Reset all arrows colors
			foreach (DiagramLink link in diagram.Links)
			{
				link.Stroke = Brushes.Black;
				link.StrokeThickness = pixel;
				link.HeadStroke = Brushes.Black;
				link.HeadStrokeThickness = pixel;
				link.Brush = Brushes.BlanchedAlmond;
			}

			PathFinder finder = new PathFinder(diagram);
			MindFusion.Diagramming.Wpf.Path path = finder.FindCycle(
				selectedShapes[0]);
			if (path != null)
			{
				foreach (DiagramLink link in path.Links)
				{
					link.Stroke = Brushes.Red;
					link.StrokeThickness = 2 * pixel;
					link.HeadStroke = Brushes.Red;
					link.HeadStrokeThickness = 2 * pixel;
				}

			}
			else
			{
				MessageBox.Show("Cycle not found!");
			}
		}

		private void btnFindAllCycles_Click(object sender, RoutedEventArgs e)
		{
			double pixel = GraphicsUnit.Pixel.Convert(1, diagram.MeasureUnit);
			// Reset all arrows colors
			foreach (DiagramLink arrow in diagram.Links)
			{
				arrow.Stroke = Brushes.Black;
				arrow.StrokeThickness = pixel;
				arrow.HeadStroke = Brushes.Black;
				arrow.HeadStrokeThickness = pixel;
				arrow.Brush = Brushes.BlanchedAlmond;
			}

			PathFinder finder = new PathFinder(diagram);
			PathCollection cycles = finder.FindAllCycles();
			if (cycles.Count > 0)
			{
				MessageBox.Show("Found a total of " + cycles.Count.ToString() +
					" different cycles.");
				Random random = new Random();
				foreach (MindFusion.Diagramming.Wpf.Path path in cycles)
				{
					Brush brush = new SolidColorBrush(Color.FromRgb((byte)random.Next(250),
						(byte)random.Next(150), (byte)random.Next(150)));

					foreach (DiagramLink arrow in path.Links)
					{
						arrow.Stroke = brush;
						arrow.StrokeThickness = 2 * pixel;
						arrow.HeadStroke = brush;
						arrow.HeadStrokeThickness = 2 * pixel;
					}
				}
			}
			else
			{
				MessageBox.Show("No cycle found within the graph!");
			}
		}

		private void btnLoadXML_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openXMLFileDialog = new OpenFileDialog();

			if (openXMLFileDialog.ShowDialog() == true)
			{
				string xmlFile = openXMLFileDialog.FileName;
				LoadXML(xmlFile);
			}
		}

		private void btnLoadSample_Click(object sender, RoutedEventArgs e)
		{
			LoadXML(MainWindow.ApplicationPath + @"People.xml");
		}

		private void btnAnimation_Click(object sender, RoutedEventArgs e)
		{
			vesselsTimer.Start();
		}

		private void vesselsTimer_Tick(object sender, EventArgs e)
		{
			// Update vessels
			Type t = frameContent.Content.GetType();

			if (!t.Equals(typeof(CustomDrawLinks)))
				return;

			bool hasChanged = false;

			// For arrows in progress, increase progress
			foreach (DiagramLink a in diagram.Links)
			{
				double progress = (double)a.Tag;
				double ofill = (double)a.Origin.Tag;

				float maxProgress = 100;

				if ((progress < maxProgress && progress > 0) ||
					(progress == 0 && ofill == 100))
				{
					hasChanged = true;
					progress += (double)random.NextDouble();
				}

				if (progress > maxProgress)
					progress = maxProgress;

				a.Tag = progress;
				a.InvalidateVisual();
			}

			// For all boxes which are being filled
			foreach (DiagramNode node in diagram.Nodes)
			{
				ShapeNode box = node as ShapeNode;
				if (box == null)
					continue;

				double fill = (double)box.Tag;

				if (fill < 100)
				{
					foreach (DiagramLink a in box.IncomingLinks)
					{
						double progress = (double)a.Tag;
						if (progress >= 100 && fill < 100)
						{
							hasChanged = true;

							// This arrow fills the box
							Color arrowColor = BrushToColor(a.Origin.Brush, Colors.White);
							Color fillColor = BrushToColor(box.Brush, Colors.White);

							double step = 0.5f;

							// Modify the box color accordingly
							byte r = (byte)(fillColor.R * fill / (fill + step) +
								arrowColor.R * step / (fill + step));
							byte g = (byte)(fillColor.G * fill / (fill + step) +
								arrowColor.G * step / (fill + step));
							byte b = (byte)(fillColor.B * fill / (fill + step) +
								arrowColor.B * step / (fill + step));

							box.Brush = new SolidColorBrush(Color.FromArgb(255, r, g, b));

							fill += step;

							if (fill == 100)
								break;
						}
					}
				}

				box.Tag = fill;
			}

			if (!hasChanged)
			{
				vesselsTimer.Stop();
				MessageBox.Show("Boom!");
			}
		}

		private void dragAndDropImage_MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(dragAndDropImage, dragAndDropImage.Image, DragDropEffects.Copy);
		}

		private void lbDragTextOne_MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(lbDragTextOne, lbDragTextOne.Content.ToString(), DragDropEffects.Copy);
		}

		private void lbDragTextTwo_MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(lbDragTextTwo, lbDragTextTwo.Content.ToString(), DragDropEffects.Copy);
		}

		private void lbDragTextThree_MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(lbDragTextThree, lbDragTextThree.Content.ToString(), DragDropEffects.Copy);
		}

		private void btnCopySource_Click(object sender, RoutedEventArgs e)
		{
			string sourceCode = GetSampleCode();

			// Normalize line breaks
			sourceCode = Regex.Replace(sourceCode, @"\n|\r\n?", Environment.NewLine);

			if (sourceCode.Length > 0)
				Clipboard.SetDataObject(sourceCode, true);
		}

		private void btnErmDiagram_Click(object sender, RoutedEventArgs e)
		{
			AddEntityWindow form = new AddEntityWindow();

			if (form.ShowDialog() != true)
				return;


			double rh = diagram.TableRowHeight;
			double th = diagram.TableCaptionHeight;
			double totalh = th + 4 * rh;
			TableNode t = diagram.Factory.CreateTableNode(5, 5, 30 + 6 * rh, totalh);

			t.Caption = form.EntityName;
			t.Tag = form.EntityDescription;
			t.TextAlignment = TextAlignment.Center;
			t.TextVerticalAlignment = AlignmentY.Center;
			t.FontFamily = new FontFamily("Times New Roman");
			t.FontSize = 14;
			t.FontWeight = FontWeights.Bold;
			t.CellTextStyle.FontFamily = t.FontFamily;
			t.CellTextStyle.FontSize = t.FontSize;
			t.CellTextStyle.FontWeight = t.FontWeight;

			// Create the help button
			Rect rc = t.Bounds;
			ShapeNode btn = diagram.Factory.CreateShapeNode(rc.Left + 7,
				rc.Bottom - rh, rh, rh);
			btn.Transparent = true;
			btn.Image = generalImageList[2];
			btn.ImageAlign = ImageAlign.Stretch;
			btn.AttachTo(t, AttachToNode.BottomLeft);
			btn.Locked = true;
			btn.Tag = 1;

			btn = diagram.Factory.CreateShapeNode(rc.Left + 7 + rh,
				rc.Bottom - rh, rh, rh);
			btn.Transparent = true;
			btn.Image = generalImageList[3];
			btn.ImageAlign = ImageAlign.Stretch;
			btn.AttachTo(t, AttachToNode.BottomLeft);
			btn.Locked = true;
			btn.Tag = 2;

			btn = diagram.Factory.CreateShapeNode(rc.Right - 7 - rh,
				rc.Bottom - rh, rh, rh);
			btn.Transparent = true;
			btn.Image = generalImageList[4];
			btn.ImageAlign = ImageAlign.Stretch;
			btn.AttachTo(t, AttachToNode.BottomLeft);
			btn.Locked = true;
			btn.Tag = 3;

			SolidColorBrush tbrush =
				new SolidColorBrush(Colors.LightBlue);

			LinearGradientBrush cbrush =
				new LinearGradientBrush(
					Colors.LightBlue, Colors.Black, 90);

			t.CaptionBackBrush = cbrush;
			t.Brush = tbrush;

			t.RowCount = 3;
			t.ColumnCount = 4;

			t.Scrollable = false;
			t.EnabledHandles = AdjustmentHandles.Move;
			t.CellFrameStyle = CellFrameStyle.None;
			t.HandlesStyle = HandlesStyle.HatchHandles3;
			t.Columns[0].Width = rh;
			t.Columns[1].Width = 57.6;
			t.Columns[2].Width = 57.6;
			t.Columns[3].Width = rh;
			t.Shape = SimpleShape.RoundedRectangle;
			t.CaptionBrush = Brushes.White;

			AnchorPoint ptin = new AnchorPoint(50d, 50d, true, false, Brushes.Red, 0);
			AnchorPoint ptout = new AnchorPoint(45d, 50d, false, true, Brushes.Red, 3);
			ArrayList al = new ArrayList();

			for (int i = 0; i < 3; i++)
			{
				al.Clear();
				if (form.GetInput(i) != null)
				{
					t[0, i].ImageAlign = ImageAlign.Center;
					t[0, i].Image = generalImageList[0];
					t[1, i].Text = form.GetInput(i);
					al.Add(ptin.Clone());
				}
				if (form.GetOutput(i) != null)
				{
					t[3, i].ImageAlign = ImageAlign.MiddleRight;
					t[3, i].Image = generalImageList[1];
					t[2, i].Text = form.GetOutput(i);
					t[2, i].TextAlignment = TextAlignment.Right;
					al.Add(ptout.Clone());
				}
				t.Rows[i].AnchorPattern = new AnchorPattern(
					(AnchorPoint[])al.ToArray(typeof(AnchorPoint)));
			}
		}


		#endregion

		#region LayoutProcess

		private ProgressForm progress = new ProgressForm();

		private void OnLayoutProgress(int current, int total)
		{
			progress.Maximum = total;
			progress.Value = current;
			//            progress.Refresh();
		}

		#endregion

		#region Miscellaneous

		private Color BrushToColor(Brush brush, Color defaultColor)
		{
			if (brush != null)
			{
				SolidColorBrush solidBrush = brush as SolidColorBrush;
				if (solidBrush != null)
					return solidBrush.Color;
			}

			return defaultColor;
		}

		/// <summary>
		/// Approximate two color of gradient to get corresponded ACI
		/// </summary>
		/// <param name="cr1">Color 1 of gradient</param>
		/// <param name="cr2">Color 2 of gradient</param>
		/// <returns></returns>
		public static Color ApproxColors(Color cr1, Color cr2)
		{
			return Color.FromArgb(0, (byte)Math.Round((cr1.R + cr2.R) / 2f),
				(byte)Math.Round((cr1.G + cr2.G) / 2f),
				(byte)Math.Round((cr1.B + cr2.B) / 2f));
		}

		private void EnumDirectoryInfo(DirectoryInfo info, ShapeNode parent, int level)
		{
			if (level <= 0)
				return;

			ShapeNode b = diagram.Factory.CreateShapeNode(0, 0, 7.68, 7.68);
			b.ToolTip = info.Name;

			if (parent == null)
				b.Brush = new SolidColorBrush(Colors.Green);
			else
				b.Brush = new SolidColorBrush(Colors.DarkSalmon);

			if (parent != null)
				diagram.Factory.CreateDiagramLink(parent, b);

			int maxsubdirs = 100;
			if (info.Attributes != FileAttributes.System)
			{
				DirectoryInfo[] subDirs;
				try
				{
					// build subtrees recursively
					subDirs = info.GetDirectories();
					foreach (DirectoryInfo dirInfo in subDirs)
					{
						maxsubdirs--;
						if (maxsubdirs < 0)
							break;
						EnumDirectoryInfo(dirInfo, b, level - 1);
					}
				}
				catch
				{
				}
			}
		}

		private bool CheckAndClear()
		{
			DiagramNodeCollection selectedShapes = new DiagramNodeCollection();
			foreach (DiagramNode node in diagram.Selection.Nodes)
			{
				if (node is ShapeNode)
					selectedShapes.Add(node);
			}
			if (selectedShapes.Count == 0)
			{
				MessageBox.Show(this, "Select a box first!");
				return false;
			}

			foreach (DiagramItem item in diagram.Items)
			{
				item.Stroke = Brushes.Black;
				item.StrokeThickness = 0.25;
			}

			return true;
		}

		private void VisitSuccessors(ShapeNode b, DiagramNodeCollection visited)
		{
			ShapeNode bb;
			foreach (DiagramLink a in b.OutgoingLinks)
			{
				bb = a.Destination as ShapeNode;
				if (bb == null)
					continue;

				if (!Contains(visited, bb))
				{
					bb.Stroke = Brushes.Blue;
					bb.StrokeThickness = 2;
					bb.StrokeDashStyle = new DashStyle(new double[] { 0, 3, 0 }, 2);

					visited.Add(bb);
					VisitSuccessors(bb, visited);
				}
			}
		}

		private void VisitPredecessors(ShapeNode b, DiagramNodeCollection visited)
		{
			ShapeNode bb;
			foreach (DiagramLink a in b.IncomingLinks)
			{
				bb = a.Origin as ShapeNode;
				if (bb == null)
					continue;

				if (!Contains(visited, bb))
				{
					bb.Stroke = Brushes.Blue;
					bb.StrokeThickness = 2;
					bb.StrokeDashStyle = new DashStyle(new double[] { 0, 3, 0 }, 2);

					visited.Add(bb);
					VisitPredecessors(bb, visited);
				}
			}
		}

		private bool Contains(DiagramNodeCollection c, ShapeNode b)
		{
			foreach (ShapeNode bb in c)
				if (bb == b)
					return true;

			return false;
		}

		private void mainWindow_Closed(object sender, EventArgs e)
		{
			vesselsTimer.Stop();
			DetachEvents();
		}

		public static System.Windows.Point Center(Rect r)
		{
			return new System.Windows.Point((r.Left + r.Right) / 2, (r.Top + r.Bottom) / 2);
		}

		/// <summary>
		/// Returns the text of the current sample code.
		/// </summary>
		private string GetSampleCode()
		{
			return sourceCodeViewer.SourceCode;
		}

		private void cmBLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (sourceCodeViewer == null)
				return;

			UpdateSourceCode();
		}

		private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (tabControl.SelectedIndex == 1)
				UpdateSourceCode();
		}

		#endregion

		#region XML

		/// <summary>
		/// Load the specified XML file.
		/// </summary>
		/// <param name="path"></param>
		private void LoadXML(string path)
		{
			XmlDocument doc = new XmlDocument();

			try
			{
				doc.Load(path);

				diagram.ClearAll();
				diagram.BackBrush = Brushes.PaleTurquoise;
				diagram.LinkCascadeOrientation = MindFusion.Diagramming.Wpf.Orientation.Vertical;
				diagram.LinkShape = LinkShape.Cascading;
				diagram.LinkSegments = 2;

				foreach (XmlNode child in doc.ChildNodes)
					DrawXMLNode(null, child);

				ArrangeXml();
				diagram.ResizeToFitItems(5);
			}
			catch
			{
				MessageBox.Show("Unable to load the specified XML document!");
			}
		}

		private void DrawXMLNode(ShapeNode parent, XmlNode node)
		{
			if (node == null) return;
			if (node.Value == "") return;

			// Create the box for this node
			ShapeNode box = diagram.Factory.CreateShapeNode(0, 0, 100, 24);
			if (node.NodeType == XmlNodeType.Text)
			{
				box.Text = node.Value.ToString();
				box.Brush = Brushes.LightYellow;
			}
			else
			{
				box.Text = node.Name;
				box.Brush = Brushes.BurlyWood;
			}

			// Link this node with its parent
			if (parent != null)
				diagram.Factory.CreateDiagramLink(parent, box);

			// Draw the children
			foreach (XmlNode child in node.ChildNodes)
				DrawXMLNode(box, child);
		}

		private void ArrangeXml()
		{
			TreeLayout layout = new TreeLayout(
				null, TreeLayoutType.Cascading, false,
				TreeLayoutLinkType.Cascading2,
				TreeLayoutDirections.LeftToRight,
				-15, 10, false, new Size(15, 30), false);
			layout.Arrange(diagram);
		}

		#endregion

		#region Drag and drop

		private void OnPicture1MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture1, picture1.Image, DragDropEffects.Copy);
		}

		private void OnPicture2MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture2, picture2.Image, DragDropEffects.Copy);
		}

		private void OnPicture3MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture3, picture3.Image, DragDropEffects.Copy);
		}

		private void OnPicture4MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture4, picture4.Image, DragDropEffects.Copy);
		}

		private void OnPicture5MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture5, picture5.Image, DragDropEffects.Copy);
		}

		private void OnPicture6MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture6, picture6.Image, DragDropEffects.Copy);
		}

		private void OnPicture7MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture7, picture7.Image, DragDropEffects.Copy);
		}

		private void OnPicture8MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture8, picture8.Image, DragDropEffects.Copy);
		}

		private void OnPicture9MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture9, picture9.Image, DragDropEffects.Copy);
		}

		private void OnPicture10MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture10, picture10.Image, DragDropEffects.Copy);
		}

		private void OnPicture11MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture11, picture11.Image, DragDropEffects.Copy);
		}

		private void OnPicture12MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture12, picture12.Image, DragDropEffects.Copy);
		}

		private void OnPicture13MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture13, picture13.Image, DragDropEffects.Copy);
		}

		private void OnPicture14MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragDrop.DoDragDrop(picture14, picture14.Image, DragDropEffects.Copy);
		}

		#endregion

		private void btnOrthogonalLayout_Click(object sender, RoutedEventArgs e)
		{
			OrthogonalLayout(false, true);
		}

		private void OrthogonalLayout(bool directed, bool refine)
		{
			OrthogonalLayout ot = new OrthogonalLayout();

			MultipleGraphsPlacement mgp = MultipleGraphsPlacement.Horizontal;

			switch (cmBxOrthMultipleGraphPlacement.SelectedIndex)
			{
				case 0:
					mgp = MultipleGraphsPlacement.Horizontal; break;
				case 1:
					mgp = MultipleGraphsPlacement.MinimalArea; break;
				case 2:
					mgp = MultipleGraphsPlacement.Vertical; break;
			}

			bool isRef = cmBxOrtLRefine.SelectedIndex == 0;

			double marginX = 5;
			Double.TryParse(txBxOrthMarginX.Text, out marginX);
			marginX = marginX <= 0 ? 1 : marginX;
			txBxOrthMarginX.Text = marginX.ToString();

			double marginY = 5;
			Double.TryParse(txBxOrthMarginY.Text, out marginY);
			marginY = marginY <= 0 ? 1 : marginY;
			txBxOrthMarginY.Text = marginY.ToString();

			double padding = 15;
			Double.TryParse(txBxOrthPaddingX.Text, out padding);
			padding = padding <= 0 ? 1 : padding;
			txBxOrthPaddingX.Text = padding.ToString();

			ot.Padding = padding;
			ot.Margins = new Size(marginX, marginY);
			ot.MultipleGraphsPlacement = mgp;
			ot.Refine = isRef;

			ot.Arrange(diagram);
			diagram.ResizeToFitItems(10);
		}

		private void btnCircularLayout_Click(object sender, RoutedEventArgs e)
		{
			CircularLayout cl = new CircularLayout();

			MultipleGraphsPlacement mgp = MultipleGraphsPlacement.Horizontal;

			switch (cmBxOrthMultipleGraphPlacement.SelectedIndex)
			{
				case 0:
					mgp = MultipleGraphsPlacement.Horizontal; break;
				case 1:
					mgp = MultipleGraphsPlacement.MinimalArea; break;
				case 2:
					mgp = MultipleGraphsPlacement.Vertical; break;
			}

			double marginX = 5;
			Double.TryParse(txBxCirMarginX.Text, out marginX);
			marginX = marginX <= 0 ? 1 : marginX;
			txBxCirMarginX.Text = marginX.ToString();

			double marginY = 5;
			Double.TryParse(txBxCirMarginY.Text, out marginY);
			marginY = marginY <= 0 ? 1 : marginY;
			txBxCirMarginY.Text = marginY.ToString();

			double radius = 65;
			Double.TryParse(txBxCirRadius.Text, out radius);
			radius = radius <= 0 ? 1 : radius;
			txBxCirRadius.Text = radius.ToString();

			int siftingRounds = 1;
			Int32.TryParse(txBxCirSiftingRounds.Text, out siftingRounds);
			siftingRounds = siftingRounds <= 0 ? 1 : siftingRounds;
			txBxCirSiftingRounds.Text = siftingRounds.ToString();

			cl.Radius = radius;
			cl.Margins = new Size(marginX, marginY);
			cl.MultipleGraphsPlacement = mgp;
			cl.SiftingRounds = siftingRounds;

			cl.Arrange(diagram);
			diagram.ResizeToFitItems(15);
		}

        private void btnCreateSvgNode_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "SVG Files (*.svg)|*.svg|All Files|*.*||";

            if (dialog.ShowDialog(this) == true)
            {
                foreach (string fileName in dialog.FileNames)
                {
                    SvgNode node = new SvgNode(diagram);
                    SvgContent content = new SvgContent();
                    try
                    {
                        content.LoadImage(fileName, node.Bounds);
                    }
                    catch
                    {
                        MessageBox.Show(this, string.Format("Failed to load '{0}'.", fileName),
                            "MindFusion.Diagramming Demo", MessageBoxButton.OK);
                        continue;
                    }
                    node.Content = content;
                    node.Transparent = true;

                    diagram.Nodes.Add(node);
                }
            }
        }

        private void btnCreateTreeNode_Click(object sender, RoutedEventArgs e)
		{
			TreeViewNode node = new TreeViewNode(diagram);
			node.Bounds = new Rect(
				diagramView.ScrollX + 20, diagramView.ScrollY + 20, 120, 120);
			node.CaptionHeight = 18;
			node.TextAlignment = TextAlignment.Center;
			diagram.Nodes.Add(node);
		}

		private void btnLoadStencil_Click(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.InitialDirectory = VisioStencilRoot;
			dialog.Filter = "Visio Stencils (*.vsx)|*.vsx|All Files|*.*||";
			if (dialog.ShowDialog(this) == true)
				LoadVisioStencil(diagram, dialog.FileName);
		}

		private void btnTopoloicalLayout_Click(object sender, RoutedEventArgs e)
		{
			TopologicalLayout layout = new TopologicalLayout();
			layout.Direction = cmBxTopologicalDirection.SelectedIndex == 0 ?
				Direction.Straight : Direction.Reversed;
			layout.NodeDistance = 30;
			layout.Arrange(diagram);

			diagram.ResizeToFitItems(10);
		}

		private void listBoxThemes_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (diagram == null)
				return;

			if (listBoxThemes.SelectedItem == null)
				return;

			ThemeItem item = listBoxThemes.SelectedItem as ThemeItem;
			if (item.Theme != null)
			{
				using (Stream stream = Application.GetResourceStream(new Uri(item.Theme)).Stream)
				{
					if (stream != null)
					{
						using (StreamReader reader = new StreamReader(stream))
						{
							string themeContent = reader.ReadToEnd();
							Theme theme = new Theme();
							theme.LoadFromString(themeContent);
							diagram.Theme = theme;
						}
					}
				}
			}
			else
			{
				diagram.Theme = null;
			}
		}


		public static readonly DependencyProperty PropertyGridProperty = DependencyProperty.RegisterAttached(
			"PropertyGrid", typeof(object), typeof(MainWindow),
			new FrameworkPropertyMetadata(null));

		public static void SetPropertyGrid(Diagram diagram, object value)
		{
			if (diagram != null)
				diagram.SetValue(PropertyGridProperty, value);
		}

		public static object GetPropertyGrid(Diagram diagram)
		{
			if (diagram != null)
				return (object)diagram.GetValue(PropertyGridProperty);
			return null;
		}


		private DiagramLinkCollection _tracePath;
		private int _tracePathStep;
		private const int _tracePathDisp = 3;
		private DispatcherTimer _tracePathTimer;
		private XDocument _sources;
		private bool firstPass = true;

		private void frameContent_ContentRendered(object sender, EventArgs e)
		{
			if (firstPass)
			{
				firstPass = false;
				wpfPropertyGrid.SelectedObject = diagram;
				//diagramPropertyGrid.SelectedObject = diagram;
				backButton.IsEnabled = selectedEntry > 0;
				nextButton.IsEnabled = selectedEntry < pages.Length - 1;
			}
			diagramPropertyGrid.SelectedObject = null;
			diagramPropertyGrid.SelectedObject = diagram;
		}

		int selectedEntry = 0;

		private void OnNavigationButtonClick(object sender, RoutedEventArgs e)
		{
			if ((sender as Button).Name == "backButton")
			{
				if (selectedEntry > 0)
					selectedEntry -= 1;
			}
			else
			{
				if (selectedEntry < pages.Length - 1)
					selectedEntry += 1;
			}

			backButton.IsEnabled = selectedEntry > 0;
			nextButton.IsEnabled = selectedEntry < pages.Length - 1;
			SelectTreeItem(treeView.Items, pages[selectedEntry].Name);
		}

		private void SelectTreeItem(ItemCollection collection, string name)
		{
			foreach (SystemTreeItem item in collection)
			{
				if (item.HasItems)
					SelectTreeItem(item.Items, name);
				if ((string)item.Header == name)
				{
					item.IsSelected = true;
					var parent = item.Parent as SystemTreeItem;
					if (parent != null)
					{
						parent.IsExpanded = true;
						if (parent.Parent != null && parent.Parent is SystemTreeItem)
							(parent.Parent as SystemTreeItem).IsExpanded = true;
					}
					UpdateLayout();
					item.BringIntoView();
					break;
				}
			}
		}


		internal static void LoadVisioStencil(Diagram diagram, string stencilFile)
		{
			diagram.ClearAll();

			VisioStencil stencil = null;
			try
			{
				stencil = VisioStencil.LoadFromXml(stencilFile, CreateImage);
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Failed to load the stencil '{0}'.{1}Error: {2}",
					stencilFile, Environment.NewLine, ex.Message),
					"MindFusion.Diagramming Demo", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			int x = 15;
			int y = 15;
			foreach (var master in stencil.Masters)
			{
				var node = diagram.Factory.CreateVisioNode(x, y, 75, 75);
				node.Content = VisioContent.Create(stencil, master.UniversalName);
				node.ToolTip = master.UniversalName;

				var textNode = diagram.Factory.CreateShapeNode(x - 20, y + 75, 115, 20);
				textNode.Locked = true;
				textNode.Text = master.UniversalName;
				textNode.Transparent = true;
				textNode.AttachTo(node, AttachToNode.BottomLeft);

				x += 100;
				if (x > 700)
				{
					x = 15;
					y += 100;
				}
			}
		}

		private static ImageSource CreateImage(Stream stream)
		{
			var image = new Metafile(stream);

			const int size = 256;
			using (var bitmap = new System.Drawing.Bitmap(size, size, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
			{
				using (var graphics = System.Drawing.Graphics.FromImage(bitmap))
				{
					graphics.DrawImage(image, 0, 0, size, size);

					using (var memoryStream = new MemoryStream())
					{
						bitmap.Save(memoryStream, ImageFormat.Png);

						var result = new BitmapImage();
						result.BeginInit();
						result.StreamSource = memoryStream;
						result.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
						result.CacheOption = BitmapCacheOption.OnLoad;
						result.EndInit();

						return result;
					}
				}
			}
		}

		private void CopyVisioStencils()
		{
			var stencilFolder = VisioStencilRoot;
			if (Directory.Exists(stencilFolder))
				return;

			string sourceStencilFolder = null;
			var info = new DirectoryInfo(stencilFolder).Parent;
			while (info != null)
			{
				var checkFolder = System.IO.Path.Combine(info.FullName, @"Redistributable\VisioStencils");
				if (Directory.Exists(checkFolder))
				{
					sourceStencilFolder = checkFolder;
					break;
				}

				info = info.Parent;
			}

			if (sourceStencilFolder != null)
			{
				var source = new DirectoryInfo(sourceStencilFolder);
				Directory.CreateDirectory(stencilFolder);
				foreach (var file in source.GetFiles())
					file.CopyTo(System.IO.Path.Combine(stencilFolder, file.Name), true);
			}
		}


		/// <summary>
		/// Gets the directory containing the Visio stencils.
		/// </summary>
		internal static string VisioStencilRoot
		{
			get
			{
				if (visioStencilRoot == null)
					visioStencilRoot = System.IO.Path.Combine(ApplicationPath, "VisioStencils");

				return visioStencilRoot;
			}
		}


		private static string visioStencilRoot;
	}
}
