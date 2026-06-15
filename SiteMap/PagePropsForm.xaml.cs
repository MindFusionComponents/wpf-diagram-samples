//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Windows;


namespace MindFusion.Diagramming.Wpf.Samples.CS.SiteMap
{
    /// <summary>
    /// Interaction logic for PagePropsForm.xaml
    /// </summary>
    public partial class PagePropsForm : Window
    {
        public PagePropsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
