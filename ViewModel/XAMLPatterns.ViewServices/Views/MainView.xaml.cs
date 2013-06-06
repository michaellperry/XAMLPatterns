using System.Windows;
using System.Windows.Controls;
using XAMLPatterns.ViewModelServices.ViewModels;
using XAMLPatterns.ViewServices.Services;

namespace XAMLPatterns.ViewServices.Views
{
    public partial class MainView : UserControl, IDialogService
    {
        public MainView()
        {
            InitializeComponent();
        }

        public bool Prompt(string message)
        {
            return MessageBox.Show(
                message,
                "View Services",
                MessageBoxButton.YesNo) ==
                MessageBoxResult.Yes;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //
            // XAML Patterns (4.9):
            //
            // Register as providing the dialog service with the IoC container
            // through the view model locator.
            //
            ViewModelLocator.Current.Register<IDialogService>(this);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            //
            // XAML Patterns (4.9):
            //
            // Clean up after yourself.
            //
            ViewModelLocator.Current.Unregister<IDialogService>();
        }
    }
}
