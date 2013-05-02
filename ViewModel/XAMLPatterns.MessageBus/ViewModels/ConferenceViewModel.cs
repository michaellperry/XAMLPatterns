using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using XAMLPatterns.MessageBus.Messages;
using XAMLPatterns.MessageBus.Models;

namespace XAMLPatterns.MessageBus.ViewModels
{
    public class ConferenceViewModel : ViewModelBase
    {
        private readonly ConferenceService _conferenceService;
        private ObservableCollection<Session> _sessions = new ObservableCollection<Session>();
        private Session _selectedSession = null;
        
        public ConferenceViewModel()
        {
            _conferenceService = new ConferenceService();

            foreach (var session in _conferenceService.GetSessions())
                _sessions.Add(session);
        }

        public IEnumerable<Session> Sessions
        {
            get { return _sessions; }
        }

        public Session SelectedSession
        {
            get { return _selectedSession; }

            set
            {
                if (_selectedSession == value)
                    return;

                RaisePropertyChanging(() => this.SelectedSession);
                _selectedSession = value;
                RaisePropertyChanged(() => this.SelectedSession);

                this.MessengerInstance.Send(new SessionSelected { Session = value });
            }
        }
    }
}
