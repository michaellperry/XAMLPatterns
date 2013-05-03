using XAMLPatterns.SelectionModel.Models;
using XAMLPatterns.SelectionModel.SelectionModels;

namespace XAMLPatterns.SelectionModel.ViewModels
{
    public class SessionViewModel
    {
        private readonly ConferenceService _conferenceService;
        private readonly SessionSelectionModel _sessionSelection;

        public SessionViewModel(
            ConferenceService conferenceService,
            SessionSelectionModel sessionSelection)
        {
            _conferenceService = conferenceService;
            _sessionSelection = sessionSelection;
        }

        public string Title
        {
            get
            {
                if (_sessionSelection.SelectedSession == null)
                    return null;

                return _sessionSelection.SelectedSession.Title;
            }
            set
            {
                if (_sessionSelection.SelectedSession == null)
                    return;

                _sessionSelection.SelectedSession.Title = value;
            }
        }

        public string Speaker
        {
            get
            {
                if (_sessionSelection.SelectedSession == null)
                    return null;

                return _sessionSelection.SelectedSession.Speaker;
            }
            set
            {
                if (_sessionSelection.SelectedSession == null)
                    return;

                _sessionSelection.SelectedSession.Speaker = value;
            }
        }
    }
}
