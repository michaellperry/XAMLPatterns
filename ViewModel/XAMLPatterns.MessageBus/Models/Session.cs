using GalaSoft.MvvmLight;

namespace XAMLPatterns.MessageBus.Models
{
    public class Session : ObservableObject
    {
        private string _speaker;
        private string _title;

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
            }
        }

        public string Speaker
        {
            get
            {
                return _speaker;
            }
            set
            {
                if (value == _speaker)
                    return;

                RaisePropertyChanging(() => this.Speaker);
                _speaker = value;
                RaisePropertyChanged(() => this.Speaker);
            }
        }
    }
}
