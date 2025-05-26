using System;

namespace window_form_dotnet.Model
    {
    public class AuthenticationResult
        {
        public bool IsAuthenticated { get; set; }
        public string Message { get; set; }
        public User User { get; set; }
        public Exception Error { get; set; }

        public AuthenticationResult()
            {
            IsAuthenticated = false;
            }

        public AuthenticationResult(bool isAuthenticated, string message)
            {
            IsAuthenticated = isAuthenticated;
            Message = message;
            }

        public AuthenticationResult(bool isAuthenticated, string message, User user) : this(isAuthenticated, message)
            {
            User = user;
            }

        public AuthenticationResult(Exception error)
            {
            IsAuthenticated = false;
            Error = error;
            Message = error.Message;
            }
        }
    }