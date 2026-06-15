//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

using MouseButton = MindFusion.Diagramming.Wpf.MouseButton;
using System.Windows.Media.Animation;


namespace MindFusion.Diagramming.Wpf.Samples.CS.SiteMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            siteMap.Bounds = new Rect(0, 0, 2000, 2000);
			siteMap.DefaultShape = Shapes.Rectangle;

            startNewSite();
        }

        private void miNew_Click(object sender, RoutedEventArgs e)
        {
            siteMap.ClearAll();
            startNewSite();
        }

        private void miSave_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveDlg = new Microsoft.Win32.SaveFileDialog();
            if (saveDlg.ShowDialog() == true)
                siteMap.SaveToXml(saveDlg.FileName);
        }

        void siteMap_SerializeTag(object sender, SerializeTagEventArgs e)
        {
            object tag = e.Tag;
            if (tag is PageProps)
            {
                PageProps props = (PageProps)e.Tag;

                e.Context.WriteString(props.title, "Title", e.Representation);
                e.Context.WriteString(props.file, "File", e.Representation);
                e.Context.WriteString(props.img1Path, "Img1Path", e.Representation);
                e.Context.WriteString(props.img2Path, "Img2Path", e.Representation);
                e.Context.WriteString(props.inf.ToString(), "Inf", e.Representation);

				e.Handled = true;
			}
        }

        private void miLoad_Click(object sender, RoutedEventArgs e)
        {
			try
			{
				Microsoft.Win32.OpenFileDialog openDlg = new Microsoft.Win32.OpenFileDialog();
				if (openDlg.ShowDialog() == true)
				{
					try
					{
						siteMap.LoadFromXml(openDlg.FileName);
					}
					catch
					{
						MessageBox.Show("Invalid file format.");
						return;
					}
				}

				// find the home page
				foreach (DiagramNode node in siteMap.Nodes)
				{
					PageProps props = node.Tag as PageProps;
					if (props == null)
					{
						props = new PageProps();
						node.Tag = props;
					}
					if (props.inf == -1 && node is ShapeNode)
					{
						rootNode = node as ShapeNode; // this is it
						break;
					}
				}
			}
			catch (System.IO.FileLoadException)
			{
				MessageBox.Show(this, "Invalid file format");
			}
			catch (XmlException)
			{
				MessageBox.Show(this, "Invalid file format");
			}
        }

        void siteMap_DeserializeTag(object sender, SerializeTagEventArgs e)
        {
            XmlElement tag = e.Representation;
            if ("Tag".Equals(tag.Name) && tag.ChildNodes.Count > 0)
            {
                PageProps props = new PageProps();

                props.title = e.Context.ReadString("Title", tag);
                props.file = e.Context.ReadString("File", tag);
                props.img1Path = e.Context.ReadString("Img1Path", tag);
                props.img2Path = e.Context.ReadString("Img2Path", tag);
                props.inf = e.Context.ReadInt("Inf", tag);

                e.Tag = props;
				e.Handled = true;
			}
        }

        private void miGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (rootNode.OutgoingLinks.Count == 0)
            {
                MessageBox.Show("There are not links from the start page!");
                return;
            }

            files.Clear();
            generateHtml(rootNode);

            // display the generated html files
            foreach (string file in files.Keys)
            {
                PageViewForm form = new PageViewForm();
                form.txHtml.Text = files[file];
				form.Title = file;
                form.Show();
            }
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void startNewSite()
        {
            // create the home page properties
            PageProps props = new PageProps();
            props.title = "Home";
            props.file = "index.html";
            props.inf = -1;

            // create a node and associate it with the home page
            rootNode = new ShapeNode(siteMap);
            rootNode.Bounds = new Rect(40, 40, 80, 55);
            rootNode.Text = "Home";
            rootNode.Tag = props;
            siteMap.Nodes.Add(rootNode);

            // deselect the node; it gets selected because AutoSelect is turned on
            siteMap.Selection.Clear();

            fileNum = 1;
        }

        // display 'property page' for a node
        private void setPageProps(ShapeNode node)
        {
            PagePropsForm form = new PagePropsForm();
			form.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            // get the page attributes
            PageProps props = (PageProps)node.Tag;

            // fill the form fields
            form.txTitle.Text = props.title;
            form.txFileName.Text = props.file;
            form.txImage1.Text = props.img1Path;
            form.txImage2.Text = props.img2Path;

            form.Owner = this;
            form.ShowDialog();

            // get info from form fields
            node.Text = form.txTitle.Text;
            props.title = form.txTitle.Text;
            props.file = form.txFileName.Text;
            props.img1Path = form.txImage1.Text;
            props.img2Path = form.txImage2.Text;

            node.InvalidateVisual();
        }

        // generate HTML code for a page
        private void generateHtml(ShapeNode root)
        {
            PageProps props = (PageProps)root.Tag;

            // if not generated yet ...
            if (files[props.file] == null)
            {
                string html = "";
                html += "<HTML>\r\n";
                html += "<HEAD>\r\n";
                html += "<TITLE>" + props.title + "</TITLE>\r\n";
                html += "</HEAD>\r\n\r\n";

                html += "<BODY>\r\n\r\n";

                // add link to the parent page
                if (root.IncomingLinks.Count > 0)
                {
                    PageProps parentProps =
                        (PageProps)root.IncomingLinks[0].Origin.Tag;
                    html += "<A HREF=\"" + parentProps.file + "\">Level up: ";
                    html += parentProps.title + "</A><BR>\r\n";
                }

                // add link to all child pages
                foreach (DiagramLink link in root.OutgoingLinks)
                {
                    PageProps linkProps =
                        (PageProps)link.Destination.Tag;
                    html += "<A HREF=\"" + linkProps.file + "\">Level down: ";
                    html += linkProps.title + "</A><BR>\r\n";
                }

                html += "\r\n</BODY>\r\n";
                html += "</HTML>\r\n";

                // save the generated HTML
                files.Add(props.file, html);

                // call recursively for all children
                foreach (DiagramLink link in root.OutgoingLinks)
                {
                    generateHtml((ShapeNode)link.Destination);
                }
            }
        }

        private void siteMap_LinkCreated(object sender, MindFusion.Diagramming.Wpf.LinkEventArgs e)
        {
            if (e.Link.Destination is DummyNode)
            {
                Point pt = e.Link.EndPoint;
                ShapeNode newNode = new ShapeNode(siteMap);
                newNode.Bounds = new Rect(pt.X - 40, pt.Y - 28, 80, 55);
				newNode.Opacity = 0;
                siteMap.Nodes.Add(newNode);

                e.Link.Destination = newNode;

				var animation = new DoubleAnimation(1, new Duration(TimeSpan.FromSeconds(0.4)));
				animation.Completed += (s1, e1) =>
					{
						OnNodeCreated(newNode);
					};
				newNode.BeginAnimation(ShapeNode.OpacityProperty, animation);
			}
        }

        private void siteMap_NodeClicked(object sender, MindFusion.Diagramming.Wpf.NodeEventArgs e)
        {
            // we handle only right-clicks
            if (e.MouseButton != MouseButton.Right)
                return;

			if (!(e.Node is ShapeNode))
				return;

            // save the node reference
            currentNode = e.Node as ShapeNode;

            // display context menu for the node
            ContextMenu cmNode = createNodeMenu();
            cmNode.Placement = System.Windows.Controls.Primitives.PlacementMode.Mouse;
            cmNode.IsOpen = true;
        }

        ContextMenu createNodeMenu()
        {
            ContextMenu cmNode = new ContextMenu();

            MenuItem miProperties = new MenuItem();
            miProperties.Header = "Properties";
            miProperties.Click += new RoutedEventHandler(miProperties_Click);
            cmNode.Items.Add(miProperties);

            MenuItem miDelete = new MenuItem();
            miDelete.Header = "Delete";
            miDelete.Click += new RoutedEventHandler(miDelete_Click);
            cmNode.Items.Add(miDelete);

            MenuItem miView = new MenuItem();
            miView.Header = "View";
            miView.Click += new RoutedEventHandler(miView_Click);
            cmNode.Items.Add(miView);

            return cmNode;
        }

        void miView_Click(object sender, RoutedEventArgs e)
        {
            PageProps props = (PageProps)currentNode.Tag;
            Process.Start(
                "iexplore.exe", props.file);
        }

        void miDelete_Click(object sender, RoutedEventArgs e)
        {
            PageProps props = (PageProps)currentNode.Tag;
            if (props.inf == -1)
                MessageBox.Show(this, "Home page cannot be deleted!");
            else
                siteMap.Nodes.Remove(currentNode);
        }

        void miProperties_Click(object sender, RoutedEventArgs e)
        {
            setPageProps(currentNode);
        }

        private void siteMap_NodeCreated(object sender, MindFusion.Diagramming.Wpf.NodeEventArgs e)
        {
            OnNodeCreated(e.Node as ShapeNode);
        }

        private void siteMap_NodeDeleting(object sender, MindFusion.Diagramming.Wpf.NodeValidationEventArgs e)
        {
            // get the associated page
            PageProps props = (PageProps)e.Node.Tag;

            // if that is the homepage ...
            if (props.inf == -1)
            {
                // ... do not delete it
                e.Cancel = true;
                MessageBox.Show(this, "Home page cannot be deleted!");
            }
        }

        private void OnNodeCreated(ShapeNode node)
        {
            // create page object for the new node
            PageProps props = new PageProps();
            props.file = "file" + fileNum.ToString() + ".html";
            props.title = "Page " + fileNum.ToString();
            node.Tag = props;

            // display the properties
            setPageProps(node);

            fileNum++;
        }

        ShapeNode rootNode = null;
        ShapeNode currentNode = null;

        // generated HTML files are stored here
        StringDictionary files = new StringDictionary();

        // page counter
        int fileNum = 1;
    }

    // objects of this type will be associated with nodes as tags.
    // as the class is marked as serializable, its objects will be saved
    // together with the associated nodes
	[Serializable]
    internal class PageProps
    {
        internal string title = "New page";
        internal string file = "";
        internal string img1Path = "";
        internal string img2Path = "";
        internal int inf = 0;
    }
}