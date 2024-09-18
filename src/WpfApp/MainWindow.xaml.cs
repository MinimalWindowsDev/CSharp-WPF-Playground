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

            // Add initial log message
            LogTextBox.Text = "System initialized. Ready for operation.\n";
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement search functionality here
            AddLogMessage("Search button clicked. Functionality to be implemented.");
        }

        private void OnOffToggle_Checked(object sender, RoutedEventArgs e)
        {
            // Implement ON/OFF toggle functionality here
            System.Windows.Controls.Primitives.ToggleButton toggleButton = sender as System.Windows.Controls.Primitives.ToggleButton;
            bool isOn = false;
            if (toggleButton != null)
            {
                isOn = toggleButton.IsChecked.HasValue && toggleButton.IsChecked.Value;
            }
            AddLogMessage("PLC turned " + (isOn ? "ON" : "OFF"));
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            // Add a sample log message
            AddLogMessage("Log button clicked. This is a sample log message.");
        }

        private void AddLogMessage(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            LogTextBox.Text += "[" + timestamp + "] " + message + "\n";
            LogTextBox.ScrollToEnd();
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