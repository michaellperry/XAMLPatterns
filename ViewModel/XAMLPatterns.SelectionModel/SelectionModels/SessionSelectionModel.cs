using UpdateControls.Fields;
using XAMLPatterns.SelectionModel.Models;

namespace XAMLPatterns.SelectionModel.SelectionModels
{
    public class SessionSelectionModel
    {
        private Independent<Session> _selectedSession = new Independent<Session>();

        public Session SelectedSession
        {
            get { return _selectedSession; }
            set { _selectedSession.Value = value; }
        }
    }
}
