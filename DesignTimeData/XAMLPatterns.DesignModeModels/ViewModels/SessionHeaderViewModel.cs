using System;
using XAMLPatterns.DesignModeModels.Models;

namespace XAMLPatterns.DesignModeModels.ViewModels
{
    public class SessionHeaderViewModel
    {
        private readonly Session _session;

        public SessionHeaderViewModel(Session session)
        {
            _session = session;
        }

        public string Title
        {
            get { return _session.Title; }
        }

        public string Speaker
        {
            get { return _session.Speaker.Name; }
        }

        public DateTime Time
        {
            get { return _session.Time; }
        }

        public string Room
        {
            get { return "Room: " + _session.Room.Name; }
        }
    }
}
