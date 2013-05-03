﻿using System.Collections.Generic;
using System.Linq;
using XAMLPatterns.SelectionModel.Models;
using XAMLPatterns.SelectionModel.SelectionModels;

namespace XAMLPatterns.SelectionModel.ViewModels
{
    public class ConferenceViewModel
    {
        private readonly ConferenceService _conferenceService;
        private readonly SessionSelectionModel _sessionSelection;
        
        public ConferenceViewModel(
            ConferenceService conferenceService,
            SessionSelectionModel sessionSelection)
        {
            _conferenceService = conferenceService;
            _sessionSelection = sessionSelection;
        }

        public IEnumerable<SessionHeaderViewModel> Sessions
        {
            get
            {
                return _conferenceService.GetSessions()
                    .Select(s => new SessionHeaderViewModel(s));
            }
        }

        public SessionHeaderViewModel SelectedSession
        {
            get
            {
                if (_sessionSelection.SelectedSession == null)
                    return null;

                return new SessionHeaderViewModel(_sessionSelection.SelectedSession);
            }
            set
            {
                _sessionSelection.SelectedSession = value == null
                    ? null
                    : value.Session;
            }
        }
    }
}
