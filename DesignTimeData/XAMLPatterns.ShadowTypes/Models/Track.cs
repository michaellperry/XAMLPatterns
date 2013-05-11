using System.Collections.Generic;
using UpdateControls.Collections;
using UpdateControls.Fields;

namespace XAMLPatterns.ShadowTypes.Models
{
    public class Track
    {
        private Independent<string> _name = new Independent<string>();
        private IndependentList<Session> _sessions = new IndependentList<Session>();

        public string Name
        {
            get { return _name; }
            set { _name.Value = value; }
        }

        public IEnumerable<Session> Sessions
        {
            get { return _sessions; }
        }

        public void AddSession(Session session)
        {
            _sessions.Add(session);
        }
    }
}
