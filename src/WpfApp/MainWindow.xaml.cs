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
            messageLabel.Content = "Button clicked!";
        }
    }
}