using System.Diagnostics;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XAMLPatterns.RelayCommandPattern.Commands;

namespace XAMLPatterns.RelayCommandPattern.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _location;
        private bool _agree;
        private InstallCommand _installCommand;

        public MainViewModel()
        {
            _installCommand = new InstallCommand(this);
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
