using System;

namespace XAMLPatterns.MessageBus.Messages
{
    public class SessionTitleChanged
    {
        public int SessionId { get; set; }
        public string NewTitle { get; set; }
    }
}                                                                          
