using System;
using System.Linq;
using System.Threading.Tasks;

namespace XAMLPatterns.ReactiveViewModel.Services
{
    public class SearchService
    {
        private Random _random = new Random();

        public async Task<SearchResult> SearchAsync(string searchTerm)
        {
            await Task.Delay(_random.Next(3000));
            return new SearchResult
            {
                SearchTerm = searchTerm,
                Matches = Enumerable.Range(1, 30)
                    .Select(n => String.Format("{0}{1}", searchTerm, n))
                    .ToList()
            };
        }
    }
}
