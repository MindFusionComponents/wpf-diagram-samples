//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Entities
{
    /// <summary>
    /// Interaction logic for AddEntityWindow.xaml
    /// </summary>
    public partial class AddEntityWindow : Window
    {
        public AddEntityWindow()
        {
            InitializeComponent();

            OnCheck(null, null);
            OnRadio(null, null);
        }

        private string name;
        private string description;
        private string[] input;
        private string[] output;

        public string EntityName
        {
            get { return name; }
        }
        public string EntityDescription
        {
            get { return description; }
        }
        public string GetInput(int index) { return input[index]; }
        public string GetOutput(int index) { return output[index]; }


        private void OnCheck(object sender, RoutedEventArgs e)
        {
            if (row1Edit == null || row2Edit == null || row2Edit == null)
                return;

            row1Edit.IsReadOnly = !(bool)row1Check.IsChecked;
            row2Edit.IsReadOnly = !(bool)row2Check.IsChecked;
            row3Edit.IsReadOnly = !(bool)row3Check.IsChecked;
        }

        private void OnRadio(object sender, RoutedEventArgs e)
        {
            if (row1OEdit == null || row2OEdit == null || row2OEdit == null)
                return;

            row1OEdit.IsReadOnly = !(bool)row1Radio.IsChecked;
            row2OEdit.IsReadOnly = !(bool)row2Radio.IsChecked;
            row3OEdit.IsReadOnly = !(bool)row3Radio.IsChecked;
            
            row1OEdit.IsEnabled = (bool)row1Radio.IsChecked;
            row2OEdit.IsEnabled = (bool)row2Radio.IsChecked;
            row3OEdit.IsEnabled = (bool)row3Radio.IsChecked;
        }

        private void OnAddBtn(object sender, RoutedEventArgs e)
        {
            name = null;
            description = null;
            input = new string[3] { null, null, null };
            output = new string[3] { null, null, null };

            name = txBName.Text;
            description = txBDescription.Text;
            if ((bool)row1Check.IsChecked)
                input[0] = row1Edit.Text;
            if ((bool)row2Check.IsChecked)
                input[1] = row2Edit.Text;
            if ((bool)row3Check.IsChecked)
                input[2] = row3Edit.Text;
            if ((bool)row1Radio.IsChecked)
                output[0] = row1OEdit.Text;
            else if ((bool)row2Radio.IsChecked)
                output[1] = row2OEdit.Text;
            else if ((bool)row3Radio.IsChecked)
                output[2] = row3OEdit.Text;

            DialogResult = true;
            Close();
        }
    }
}
