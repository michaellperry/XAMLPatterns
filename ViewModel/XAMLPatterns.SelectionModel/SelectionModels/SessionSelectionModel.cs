using UpdateControls.Fields;
using XAMLPatterns.SelectionModel.Models;

namespace XAMLPatterns.SelectionModel.SelectionModels
{
    public class SessionSelectionModel
    {
        //
        // XAML Patterns (4.6):
        //
        // The selection model is independent, because
        // the user can change it.
        //
        private Independent<Session> _selectedSession = new Independent<Session>();

        public Session SelectedSession
        {
            get { return _selectedSession; }
            set { _selectedSession.Value = value; }
        }
    }
}
