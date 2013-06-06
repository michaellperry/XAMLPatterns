using System;
using XAMLPatterns.SelectionModel.Models;

namespace XAMLPatterns.SelectionModel.ViewModels
{
    public class SessionHeaderViewModel
    {
        private readonly Session _session;

        public SessionHeaderViewModel(Session session)
        {
            _session = session;
        }

        public Session Session
        {
            get { return _session; }
        }

        public string Title
        {
            get { return _session.Title; }
        }

        //
        // XAML Patterns (4.6):
        //
        // The header view model must implement Equals and
        // GetHashCode so that the selected item appears as
        // equal to one of the items in the list.
        //
        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            SessionHeaderViewModel that = obj as SessionHeaderViewModel;
            if (that == null)
                return false;
            return Object.Equals(this._session, that._session);
        }

        public override int GetHashCode()
        {
            return _session.GetHashCode();
        }
    }
}
