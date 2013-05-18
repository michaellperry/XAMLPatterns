using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace XAMLPatterns.RelayCommandPattern.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _location;
        private bool _agree;
        private RelayCommand _installCommand;

        public MainViewModel()
        {
            _installCommand = new RelayCommand(
                () => Install(),
                () => _agree && !string.IsNullOrEmpty(_location));
        }

        public string Location
        {
            get { return _location; }
            set
            {
                if (_location == value)
                    return;

                RaisePropertyChanging(() => Location);
                _location = value;
                RaisePropertyChanged(() => Location);

                _installCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Agree
        {
            get { return _agree; }
            set
            {
                if (value == _agree)
                    return;

                RaisePropertyChanging(() => Agree);
                _agree = value;
                RaisePropertyChanged(() => Agree);

                _installCommand.RaiseCanExecuteChanged();
            }
        }

        public ICommand InstallCommand
        {
            get { return _installCommand; }
        }

        private void Install()
        {
            System.Diagnostics.Debug.WriteLine("Installing...");
        }
    }
}
