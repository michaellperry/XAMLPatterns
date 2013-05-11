using System.Collections.Generic;
using System.Linq;
using XAMLPatterns.DesignModeModels.Models;

namespace XAMLPatterns.DesignModeModels.ViewModels
{
    public class TrackViewModel
    {
        private readonly Track _track;

        public TrackViewModel(Track track)
        {
            _track = track;
        }

        public string Name
        {
            get { return _track.Name; }
        }

        public IEnumerable<SessionHeaderViewModel> Sessions
        {
            get
            {
                return
                    from s in _track.Sessions
                    select new SessionHeaderViewModel(s);
            }
        }
    }
}
