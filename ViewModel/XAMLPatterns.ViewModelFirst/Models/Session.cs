using System;

namespace XAMLPatterns.ViewModelFirst.Models
{
    public class Session
    {
        public enum SessionKind
        {
            Common,
            Breakout
        };

        public int Id { get; set; }
        public string Title { get; set; }
        public string Speaker { get; set; }
        public SessionKind Kind { get; set; }
    }
}
