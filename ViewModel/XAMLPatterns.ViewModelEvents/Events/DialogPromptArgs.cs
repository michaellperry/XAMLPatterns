using System;

namespace XAMLPatterns.ViewModelEvents.Events
{
    public class DialogPromptArgs
    {
        public bool Confirmed { get; set; }
        public string Message { get; set; }
    }
}
