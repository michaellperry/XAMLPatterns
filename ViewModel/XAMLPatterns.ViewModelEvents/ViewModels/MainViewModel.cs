using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XAMLPatterns.ViewModelEvents.Events;

namespace XAMLPatterns.ViewModelEvents.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public event Action<object, DialogPromptArgs> DialogPrompt;

        private int _count;

        public int Count
        {
            get { return _count; }
            set
            {
                if (value == _count)
                    return;

                RaisePropertyChanging(() => this.Count);
                _count = value;
                RaisePropertyChanged(() => this.Count);
            }
        }

        public ICommand Increment
        {
            get
            {
                return new RelayCommand(delegate
                {
                    DialogPromptArgs args = new DialogPromptArgs();
                    args.Message = "Should I increment the count?";

                    if (DialogPrompt != null)
                        DialogPrompt(this, args);

                    if (args.Confirmed)
                    {
                        Count++;
                    }
                });
            }
        }
    }
}
