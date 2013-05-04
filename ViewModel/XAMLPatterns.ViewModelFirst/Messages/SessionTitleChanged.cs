using System;

namespace XAMLPatterns.ViewModelFirst.Messages
{
    public class SessionTitleChanged
    {
        public int SessionId { get; set; }
        public string NewTitle { get; set; }
    }
}                                                                          
