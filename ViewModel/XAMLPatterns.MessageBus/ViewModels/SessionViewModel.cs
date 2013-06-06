using GalaSoft.MvvmLight;
using XAMLPatterns.MessageBus.Messages;
using XAMLPatterns.MessageBus.Models;

namespace XAMLPatterns.MessageBus.ViewModels
{
    public class SessionViewModel : ViewModelBase
    {
        private ConferenceService _conferenceService;
        private int _id;
        private string _speaker;
        private string _title;

        public SessionViewModel()
        {
            _conferenceService = new ConferenceService();

            //
            // XAML Patterns (4.5):
            //
            // When the SessionSelected message is received, load the session.
            //
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

                //
                // XAML Patterns (4.5):
                //
                // Send a SessionTitleChanged message to anybody listening.
                //
                MessengerInstance.Send(new SessionTitleChanged
                {
                    SessionId = _id,
                    NewTitle = value
                });
            }
        }
    }
}
