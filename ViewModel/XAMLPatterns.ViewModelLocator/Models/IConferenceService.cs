using System.Collections.Generic;

namespace XAMLPatterns.ViewModelLocator.Models
{
    public interface IConferenceService
    {
        List<Session> GetSessions();
        Session LoadSession(int sessionId);
    }
}
