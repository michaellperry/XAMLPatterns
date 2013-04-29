using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace XAMLPatterns.StatefulViewModel.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
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
