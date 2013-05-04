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
            ViewModelLocator.Current.Register<IDialogService>(this);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.Current.Unregister<IDialogService>();
        }
    }
}
