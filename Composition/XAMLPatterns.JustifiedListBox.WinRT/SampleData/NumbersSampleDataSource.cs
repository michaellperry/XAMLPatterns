using System.Collections.Generic;

namespace XAMLPatterns.JustifiedListBox.WPF.SampleData
{
    public class NumbersSampleDataSource
    {
        private IEnumerable<string> _numbers = new List<string>
        {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six"
        };

        public IEnumerable<string> Numbers
        {
            get { return _numbers; }
        }
    }
}
