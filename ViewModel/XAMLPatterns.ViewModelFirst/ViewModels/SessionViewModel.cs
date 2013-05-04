using GalaSoft.MvvmLight;
using XAMLPatterns.ViewModelFirst.Messages;
using XAMLPatterns.ViewModelFirst.Models;
using System;

namespace XAMLPatterns.ViewModelFirst.ViewModels
{
    public abstract class SessionViewModel : ViewModelBase
    {
        private readonly ConferenceService _conferenceService;
        private readonly int _id;

        protected string _speaker;
        protected string _title;

        public SessionViewModel(int sessionId)
        {
            _conferenceService = new ConferenceService();
            _id = sessionId;

            var session = _conferenceService.LoadSession(_id);
            _speaker = session.Speaker;
            _title = session.Title;
        }

        public int Id
        {
            get { return _id; }
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
