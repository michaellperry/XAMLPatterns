using System.Diagnostics;
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
            //
            // XAML Patterns (6.2):
            //
            // Create a relay command, and give it delegates to call
            // on execute and to determine if it can execute.
            //
            _installCommand = new RelayCommand(
                () => Install(),
                () => !string.IsNullOrEmpty(Location) && Agree);
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

                //
                // XAML Patterns (6.2):
                //
                // The install command depends upon the location.
                //
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

                //
                // XAML Patterns (6.2):
                //
                // The install command depends upon agreement.
                //
                _installCommand.RaiseCanExecuteChanged();
            }
        }

        public ICommand InstallCommand
        {
            get { return _installCommand; }
        }

        private void Install()
        {
            Debug.WriteLine("Installing...");
        }
    }
}
