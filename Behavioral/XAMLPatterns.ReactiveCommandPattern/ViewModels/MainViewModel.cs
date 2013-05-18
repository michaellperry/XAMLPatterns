﻿using System;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Xaml;

namespace XAMLPatterns.ReactiveCommandPattern.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public string _Location;
        public bool _Agree;
        private ReactiveCommand _installCommand;

        public MainViewModel()
        {
            var locationStream = this
                .ObservableForProperty(_ => _.Location)
                .Value();
            var agreeStream = this
                .ObservableForProperty(_ => _.Agree)
                .Value();
            var canInstall = locationStream.CombineLatest(agreeStream,
                (location, agree) => !string.IsNullOrEmpty(location) && agree);

            _installCommand = new ReactiveCommand(
                canExecute: canInstall,
                initialCondition: false);
            _installCommand.Subscribe(x => Install());
        }

        public string Location
        {
            get { return _Location; }
            set { this.RaiseAndSetIfChanged(_ => _.Location, value); }
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
