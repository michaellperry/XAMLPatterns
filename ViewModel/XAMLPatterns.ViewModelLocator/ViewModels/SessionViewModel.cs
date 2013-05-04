using GalaSoft.MvvmLight;
using XAMLPatterns.ViewModelLocator.Messages;
using XAMLPatterns.ViewModelLocator.Models;

namespace XAMLPatterns.ViewModelLocator.ViewModels
{
    public class SessionViewModel : ViewModelBase
    {
        private IConferenceService _conferenceService;
        private int _id;
        private string _speaker;
        private string _title;

        public SessionViewModel(IConferenceService conferenceService)
        {
            _conferenceService = conferenceService;

            MessengerInstance.Register<SessionSelected>(this, message =>
            {
                var session = _conferenceService.LoadSession(message.SessionId);
                _id = message.SessionId;
                Speaker = session.Speaker;
                Title = session.Title;
            });
        }

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

                MessengerInstance.Send(new SessionTitleChanged
                {
                    SessionId = _id,
                    NewTitle = value
                });
            }
        }
    }
}
