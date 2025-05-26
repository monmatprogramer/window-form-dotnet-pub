using System;
using window_form_dotnet.Model;

namespace window_form_dotnet.Model.dao
    {
    public interface ISessionDao
        {
        bool CreateSession(int userId, string sessionToken);
        bool ValidateSession(string sessionToken);
        bool ExtendSession(string sessionToken, TimeSpan extension);
        bool EndSession(string sessionToken);
        bool EndAllUserSessions(int userId);
        Session GetSessionByToken(string sessionToken);
        }
    }
