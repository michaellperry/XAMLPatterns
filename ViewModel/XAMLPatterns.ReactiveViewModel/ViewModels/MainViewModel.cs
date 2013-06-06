using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive.Linq;
using ReactiveUI;
using XAMLPatterns.ReactiveViewModel.Services;

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

            //
            // XAML Patterns (4.3):
            //
            // When the search term has not changed for half a second,
            // asynchronously perform the search. Take the result
            // for the latest search, and expose that as the Matches
            // property.
            //
            var searchTerms = this
                .ObservableForProperty(x => x.SearchTerm)
                .Value()
                .Throttle(TimeSpan.FromSeconds(0.5));
            var searchResults = searchTerms
                .SelectMany(searchTerm => _searchService.SearchAsync(searchTerm));
            var latestMatches = searchTerms
                .CombineLatest(searchResults,
                    (searchTerm, searchResult) =>
                        searchResult.SearchTerm != searchTerm
                            ? null
                            : searchResult.Matches)
                .Where(matches => matches != null);
            _Matches = latestMatches
                .ToProperty(this, x => x.Matches);

            searchTerms.Subscribe(x => Debug.WriteLine(x));
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
