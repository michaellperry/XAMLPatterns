using GalaSoft.MvvmLight;
using XAMLPatterns.ViewModelLocator.Messages;

namespace XAMLPatterns.ViewModelLocator.ViewModels
{
    public class SessionHeaderViewModel : ViewModelBase
    {
        private string _name;

        public SessionHeaderViewModel()
        {
            MessengerInstance.Register<SessionTitleChanged>(this, message =>
            {
                if (Id == message.SessionId)
                    Title = message.NewTitle;
            });
        }

        public int Id { get; set; }

        public string Title
        {
            get { return _name; }
            set
            {
                if (value == _name)
                    return;

                _name = value;
                RaisePropertyChanged(() => this.Title);
            }
        }
    }
}
