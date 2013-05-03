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
