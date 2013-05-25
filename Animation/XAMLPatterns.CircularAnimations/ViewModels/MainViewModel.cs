using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace XAMLPatterns.CircularAnimations.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private CompassPoint _direction = CompassPoint.North;
        private ICommand _north;
        private ICommand _south;
        private ICommand _east;
        private ICommand _west;

        public MainViewModel()
        {
            _north = new RelayCommand(() => Direction = CompassPoint.North);
            _south = new RelayCommand(() => Direction = CompassPoint.South);
            _east  = new RelayCommand(() => Direction = CompassPoint.East);
            _west  = new RelayCommand(() => Direction = CompassPoint.West);
        }

        public CompassPoint Direction
        {
            get { return _direction; }
            set
            {
                if (value == _direction)
                    return;

                RaisePropertyChanging(() => Direction);
                _direction = value;
                RaisePropertyChanged(() => Direction);
            }
        }

        public ICommand North { get { return _north; } }
        public ICommand South { get { return _south; } }
        public ICommand East  { get { return _east; } }
        public ICommand West  { get { return _west; } }
    }
}
