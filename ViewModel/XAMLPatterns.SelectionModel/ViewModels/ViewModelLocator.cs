using UpdateControls.XAML;
using XAMLPatterns.SelectionModel.Models;
using XAMLPatterns.SelectionModel.SelectionModels;

namespace XAMLPatterns.SelectionModel.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private ConferenceService _conferenceService;
        private SessionSelectionModel _sessionSelection;

        public ViewModelLocator()
        {
            _conferenceService = new ConferenceService();
            _sessionSelection = new SessionSelectionModel();
        }

        public object Conference
        {
            get
            {
                return ViewModel(() => new ConferenceViewModel(
                    _conferenceService, _sessionSelection));
            }
        }

        public object Session
        {
            get
            {
                return ViewModel(() => new SessionViewModel(
                    _conferenceService, _sessionSelection));
            }
        }
    }
}
