using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XAMLPatterns.MessageBus.Models;

namespace XAMLPatterns.MessageBus.Messages
{
    public class SessionSelected
    {
        public Session Session { get; set; }
    }
}
