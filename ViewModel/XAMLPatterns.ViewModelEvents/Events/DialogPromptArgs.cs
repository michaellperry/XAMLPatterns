using System;

namespace XAMLPatterns.ViewModelEvents.Events
{
    public class DialogPromptArgs
    {
        public string Message { get; set; }
        public bool Confirmed { get; set; }
    }
}
