using System;
using System.ComponentModel;
using System.Windows.Input;
using XAMLPatterns.RelayCommandPattern.ViewModels;
using System.Diagnostics;

namespace XAMLPatterns.RelayCommandPattern.Commands
{
    public class InstallCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public InstallCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine("Installing...");
        }

        public bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_viewModel.Location) && _viewModel.Agree;
        }

        public event EventHandler CanExecuteChanged;

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Location" || e.PropertyName == "Agree")
                if (CanExecuteChanged != null)
                    CanExecuteChanged(this, new EventArgs());
        }
    }
}
