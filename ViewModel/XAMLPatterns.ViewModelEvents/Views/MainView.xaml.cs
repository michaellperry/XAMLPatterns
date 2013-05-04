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
            ViewModel.DialogPrompt += DialogPrompt;
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            ViewModel.DialogPrompt -= DialogPrompt;
        }

        void DialogPrompt(object sender, DialogPromptArgs args)
        {
            if (MessageBox.Show(
                args.Message,
                "View Services",
                MessageBoxButton.YesNo) ==
                MessageBoxResult.Yes)
            {
                args.Confirmed = true;
            }
        }

        private MainViewModel ViewModel
        {
            get { return (MainViewModel)DataContext; }
        }
    }
}
