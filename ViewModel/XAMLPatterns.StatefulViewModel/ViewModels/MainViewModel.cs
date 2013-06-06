using GalaSoft.MvvmLight;

namespace XAMLPatterns.StatefulViewModel.ViewModels
{
    //
    // XAML Patterns (4.2):
    //
    // Inherit a base class that implements INotifyPropertyChanged.
    //
    public class MainViewModel : ViewModelBase
    {
        //
        // XAML Patterns (4.2):
        //
        // Store state here, and not in the view or controls.
        //
        private string _name = "World";
        private string _greeting = "Hello";

        public string Name
        {
            get { return _name; }

            set
            {
                if (_name == value)
                    return;

                _name = value;
                RaisePropertyChanged(() => Name);
                //
                // XAML Patterns (4.2):
                //
                // The salutation depends upon the name, so
                // notify that it has changed, too.
                //
                RaisePropertyChanged(() => Salutation);
            }
        }

        public string Greeting
        {
            get { return _greeting; }

            set
            {
                if (_greeting == value)
                    return;

                _greeting = value;
                RaisePropertyChanged(() => Greeting);
                RaisePropertyChanged(() => Salutation);
            }
        }

        public string Salutation
        {
            get { return string.Format("{0}, {1}!", _greeting, _name); }
        }
    }
}
