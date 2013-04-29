using System.Collections.Generic;

namespace XAMLPatterns.ReactiveViewModel.Services
{
    public class SearchResult
    {
        public string SearchTerm { get; set; }
        public List<string> Matches { get; set; }
    }
}
