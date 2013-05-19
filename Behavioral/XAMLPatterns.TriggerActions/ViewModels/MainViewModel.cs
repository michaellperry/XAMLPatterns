using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace XAMLPatterns.TriggerActions.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private int _counter;
        private RelayCommand _incrementCommand;

        public MainViewModel()
        {
            _incrementCommand = new RelayCommand(
                () => Increment());
        }

        public int Counter
        {
            get { return _counter; }
            set
            {
                if (value == _counter)
                    return;

                RaisePropertyChanging(() => Counter);
                _counter = value;
                RaisePropertyChanged(() => Counter);
            }
        }

        public ICommand IncrementCommand
        {
            get { return _incrementCommand; }
        }

        private void Increment()
        {
            Counter++;
        }
    }
}
