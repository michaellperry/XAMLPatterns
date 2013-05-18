using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace XAMLPatterns.RelayCommandPattern.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private bool _agree;
        private RelayCommand _installCommand;

        public MainViewModel()
        {
            _installCommand = new RelayCommand(
                () => Install(),
                () => Agree);
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
            System.Diagnostics.Debug.WriteLine("Installing...");
        }
    }
}
