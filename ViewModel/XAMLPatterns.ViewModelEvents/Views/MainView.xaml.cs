using System.Windows;
using System.Windows.Controls;
using XAMLPatterns.ViewModelEvents.Events;
using XAMLPatterns.ViewModelEvents.ViewModels;

namespace XAMLPatterns.ViewModelEvents.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.DialogPrompt += ViewModel_DialogPrompt;
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            ViewModel.DialogPrompt -= ViewModel_DialogPrompt;
        }

        void ViewModel_DialogPrompt(object sender, DialogPromptArgs args)
        {
            args.Confirmed = Prompt(args.Message);
        }

        private bool Prompt(string message)
        {
            return MessageBox.Show(
                message,
                "View Services",
                MessageBoxButton.YesNo) ==
                MessageBoxResult.Yes;
        }

        private MainViewModel ViewModel
        {
            get { return (MainViewModel)DataContext; }
        }
    }
}
