using System.Diagnostics;
using System.Windows.Input;
using UpdateControls.XAML;
using XAMLPatterns.DependentCommand.Models;

namespace XAMLPatterns.DependentCommand.ViewModels
{
    public class MainViewModel
    {
        private readonly InstallationModel _installation;

        public MainViewModel(InstallationModel installation)
        {
            _installation = installation;
        }

        public string Location
        {
            get { return _installation.Location; }
            set { _installation.Location = value; }
        }

        public bool Agree
        {
            get { return _installation.Agree; }
            set { _installation.Agree = value; }
        }

        //
        // XAML Patterns (6.3):
        //
        // The install command will remember that Location and Agree
        // were used last time, and will fire CanExecuteChanged whenever
        // either one changes.
        //
        public ICommand InstallCommand
        {
            get
            {
                return MakeCommand
                    .When(() => !string.IsNullOrEmpty(Location)
                        && Agree)
                    .Do(() => Install());
            }
        }

        private void Install()
        {
            Debug.WriteLine("Installing...");
        }
    }
}
