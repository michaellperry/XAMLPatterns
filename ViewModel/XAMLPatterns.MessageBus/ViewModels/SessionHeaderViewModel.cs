using GalaSoft.MvvmLight;

namespace XAMLPatterns.MessageBus.ViewModels
{
    public class SessionHeaderViewModel : ViewModelBase
    {
        private string _name;

        public int Id { get; set; }

        public string Title
        {
            get { return _name; }
            set
            {
                if (value == _name)
                    return;

                RaisePropertyChanging(() => this.Title);
                _name = value;
                RaisePropertyChanged(() => this.Title);
            }
        }
    }
}
