using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using XAMLPatterns.ShadowTypes.Models;

namespace XAMLPatterns.ShadowTypes.ViewModels
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
