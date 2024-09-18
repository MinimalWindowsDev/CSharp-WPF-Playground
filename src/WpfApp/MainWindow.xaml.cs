using System;
using System.Windows;
using System.Collections.ObjectModel;

namespace SimpleWPFApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<IOItem> IOItems { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            IOItems = new ObservableCollection<IOItem>();
            // Add some sample data
            IOItems.Add(new IOItem { Device = "Device1", Label = "Input1", Address = "0x001", IO = "Input", Value = "0" });
            IOItems.Add(new IOItem { Device = "Device2", Label = "Output1", Address = "0x002", IO = "Output", Value = "1" });
            DataContext = this;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement search functionality here
            MessageBox.Show("Search functionality to be implemented.");
        }

        private void OnOffToggle_Checked(object sender, RoutedEventArgs e)
        {
            // Implement ON/OFF toggle functionality here
            MessageBox.Show("PLC " + (((System.Windows.Controls.Primitives.ToggleButton)sender).IsChecked == true ? "ON" : "OFF"));
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement log functionality here
            MessageBox.Show("Log functionality to be implemented.");
        }
    }

    public class IOItem
    {
        public string Device { get; set; }
        public string Label { get; set; }
        public string Address { get; set; }
        public string IO { get; set; }
        public string Value { get; set; }
    }
}