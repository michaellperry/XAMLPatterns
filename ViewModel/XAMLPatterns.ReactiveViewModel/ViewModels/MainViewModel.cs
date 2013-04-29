using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using XAMLPatterns.ReactiveViewModel.Services;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Diagnostics;

namespace XAMLPatterns.ReactiveViewModel.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        private readonly SearchService _searchService;

        private string _SearchTerm;
        private ObservableAsPropertyHelper<List<string>> _Matches;

        public MainViewModel()
        {
            _searchService = new SearchService();

            var searchTermChangeEvents = this
                .ObservableForProperty(x => x.SearchTerm);
            var searchTerms = searchTermChangeEvents
                .Value()
                .Throttle(TimeSpan.FromSeconds(0.5));
            var searchResults = searchTerms
                .SelectMany(searchTerm => _searchService.SearchAsync(searchTerm));
            var latestResults = searchTerms.CombineLatest(searchResults,
                (searchTerm, searchResult) => new { searchTerm, searchResult })
                .Where(c => c.searchResult.SearchTerm == c.searchTerm)
                .Select(c => c.searchResult);
            var matches = latestResults.Select(searchResult =>
                searchResult.Matches);
            _Matches = matches.ToProperty(this, x => x.Matches);

            searchTerms.Subscribe(t => Debug.WriteLine(t));
            //searchResults.Subscribe(r => r.ForEach(t => Debug.WriteLine(t)));
        }

        public string SearchTerm
        {
            get { return _SearchTerm; }
            set { this.RaiseAndSetIfChanged(x => x.SearchTerm, value); }
        }

        public List<string> Matches
        {
            get { return _Matches.Value; }
        }
    }
}
