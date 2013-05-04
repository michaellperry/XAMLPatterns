using System.Collections.Generic;
using System.Linq;

namespace XAMLPatterns.ViewModelFirst.Models
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
                    Id = 6,
                    Title = "Opening Remarks",
                    Kind = Session.SessionKind.Common
                },
                new Session
                {
                    Id = 1,
                    Speaker = "Brian Sullivan",
                    Title = "Real-Time Web Programming with SignalR",
                    Kind = Session.SessionKind.Breakout
                },
                new Session
                {
                    Id = 2,
                    Speaker = "Caleb Jenkins",
                    Title = "Coding Naked - TDD on the Edge",
                    Kind = Session.SessionKind.Breakout
                },
                new Session
                {
                    Id = 3,
                    Speaker = "Casey Watson",
                    Title = "Building Massively Scalable Applications with Windows Azure",
                    Kind = Session.SessionKind.Breakout
                },
                new Session
                {
                    Id = 7,
                    Title = "Lunch",
                    Kind = Session.SessionKind.Common
                },
                new Session
                {
                    Id = 4,
                    Speaker = "Eric Sowell",
                    Title = "Touchy Browser Applications",
                    Kind = Session.SessionKind.Breakout
                },
                new Session
                {
                    Id = 5,
                    Speaker = "Latish Sehgal",
                    Title = "The .NET Ninja's Toolbelt",
                    Kind = Session.SessionKind.Breakout
                },
                new Session
                {
                    Id = 8,
                    Title = "Prizes",
                    Kind = Session.SessionKind.Common
                }
            };
        }

        public List<Session> GetSessions()
        {
            return _sessions;
        }

        public Session LoadSession(int sessionId)
        {
            return _sessions.FirstOrDefault(s => s.Id == sessionId);
        }
    }
}
