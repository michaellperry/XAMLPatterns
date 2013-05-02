using System.Collections.Generic;

namespace XAMLPatterns.MessageBus.Models
{
    public class ConferenceService
    {
        private List<Session> _sessions;

        public ConferenceService()
        {
            _sessions = new List<Session>
            {
                new Session
                {
                    Speaker = "Brian Sullivan",
                    Title = "Real-Time Web Programming with SignalR"
                },
                new Session
                {
                    Speaker = "Caleb Jenkins",
                    Title = "Coding Naked - TDD on the Edge"
                },
                new Session
                {
                    Speaker = "Casey Watson",
                    Title = "Building Massively Scalable Applications with Windows Azure"
                },
                new Session
                {
                    Speaker = "Eric Sowell",
                    Title = "Touchy Browser Applications"
                },
                new Session
                {
                    Speaker = "Latish Sehgal",
                    Title = "The .NET Ninja's Toolbelt"
                }
            };
        }

        public List<Session> GetSessions()
        {
            return _sessions;
        }
    }
}
