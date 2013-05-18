using System;
using System.Diagnostics;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Xaml;

namespace XAMLPatterns.ReactiveCommandPattern.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public bool _Agree;
        private ReactiveCommand _installCommand;

        public MainViewModel()
        {
            _installCommand = new ReactiveCommand(
                canExecute: this.ObservableForProperty(_ => _.Agree).Value(),
                initialCondition: false);
            _installCommand.Subscribe(x => Install());
        }

        public bool Agree
        {
            get { return _Agree; }
            set { this.RaiseAndSetIfChanged(_ => _.Agree, value); }
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
