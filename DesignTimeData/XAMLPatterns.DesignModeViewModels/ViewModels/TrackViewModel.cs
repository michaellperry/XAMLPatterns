using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLPatterns.DesignModeViewModels.ViewModels
{
    public class TrackViewModel
    {
        public string Name { get; set; }
        public List<SessionHeaderViewModel> Sessions { get; set; }
    }
}
