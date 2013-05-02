using GalaSoft.MvvmLight;
using XAMLPatterns.MessageBus.Models;

namespace XAMLPatterns.MessageBus.ViewModels
{
    public class SessionViewModel : ViewModelBase
    {
        private Session _selectedSession;
        private string _speaker;
        private string _title;

        public string Speaker
        {
            get { return _speaker; }
            set
            {
                if (value == _speaker)
                    return;

                RaisePropertyChanging(() => this.Speaker);
                _speaker = value;
                RaisePropertyChanged(() => this.Speaker);
                if (_selectedSession != null)
                    _selectedSession.Speaker = value;
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value == _title)
                    return;

                RaisePropertyChanging(() => this.Title);
                _title = value;
                RaisePropertyChanged(() => this.Title);
                if (_selectedSession != null)
                    _selectedSession.Title = value;
            }
        }
    }
}
