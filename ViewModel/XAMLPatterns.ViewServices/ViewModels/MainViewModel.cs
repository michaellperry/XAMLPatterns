using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XAMLPatterns.ViewServices.Services;

namespace XAMLPatterns.ViewModelServices.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
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
                    //
                    // XAML Patterns (4.9):
                    //
                    // Get the dialog service from the IoC container through
                    // the view model locator.
                    //
                    var dialogService = ViewModelLocator.Current.GetInstance<IDialogService>();

                    if (dialogService.Prompt("Increment?"))
                    {
                        Count++;
                    }
                });
            }
        }
    }
}
