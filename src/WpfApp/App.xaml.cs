using System;
using System.Windows;
using System.Windows.Threading;

namespace SimpleWPFApp
{
    public partial class App : Application
    {
        public App()
        {
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception occurred: " + e.Exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception occurred: " + ((Exception)e.ExceptionObject).Message, "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}