using System;
using System.Windows;

namespace SimpleWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Simulate an operation that might throw an exception
                if (DateTime.Now.Second % 2 == 0)
                {
                    messageLabel.Content = "Button clicked successfully!";
                }
                else
                {
                    throw new Exception("An example error occurred.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                messageLabel.Content = "An error occurred. Please try again.";
            }
        }
    }
}