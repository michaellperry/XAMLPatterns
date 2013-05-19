using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace XAMLPatterns.AttachedBehaviors.ViewModels
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
        }

        public ICommand IncrementCommand
        {
            get { return _incrementCommand; }
        }

        private void Increment()
        {
            _counter++;
            RaisePropertyChanged(() => Counter);
        }
    }
}
