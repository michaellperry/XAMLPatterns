using System.Collections.Generic;

namespace XAMLPatterns.SampleData.ViewModels
{
    public class TrackViewModel
    {
        public string Name { get; set; }
        public List<SessionHeaderViewModel> Sessions { get; set; }
    }
}
