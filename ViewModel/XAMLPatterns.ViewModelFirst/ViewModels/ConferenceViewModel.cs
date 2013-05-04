using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using XAMLPatterns.ViewModelFirst.Models;
using XAMLPatterns.ViewModelFirst.Messages;
using System;

namespace XAMLPatterns.ViewModelFirst.ViewModels
{
    public class ConferenceViewModel : ViewModelBase
    {
        private readonly ConferenceService _conferenceService;
        private ObservableCollection<SessionHeaderViewModel> _sessions = new ObservableCollection<SessionHeaderViewModel>();
        private SessionHeaderViewModel _selectedSession = null;
        
        public ConferenceViewModel()
        {
            _conferenceService = new ConferenceService();

            foreach (var session in _conferenceService.GetSessions())
                _sessions.Add(new SessionHeaderViewModel
                {
                    Id = session.Id,
                    SessionKind = session.Kind,
                    Title = session.Title
                });
        }

        public IEnumerable<SessionHeaderViewModel> Sessions
        {
            get { return _sessions; }
        }

        public SessionHeaderViewModel SelectedSession
        {
            get { return _selectedSession; }

            set
            {
                if (_selectedSession == value)
                    return;

                RaisePropertyChanging(() => this.SelectedSession);
                _selectedSession = value;
                RaisePropertyChanged(() => this.SelectedSession);

                MessengerInstance.Send(new SessionSelected
                {
                    SessionId = value.Id
                });
            }
        }

        public SessionViewModel CreateSelectedSessionViewModel()
        {
            if (SelectedSession == null)
                return null;

            if (SelectedSession.SessionKind == Session.SessionKind.Common)
                return new CommonSessionViewModel(SelectedSession.Id);
            else
                return new BreakoutSessionViewModel(SelectedSession.Id);
        }
    }
}
