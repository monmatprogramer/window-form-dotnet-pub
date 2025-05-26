using System;
using window_form_dotnet.Model.dto;

namespace window_form_dotnet.Common
    {
    public static class SessionManager
        {
        private static UserDto _currentUser;
        private static DateTime _loginTime;

        public static UserDto CurrentUser
            {
            get => _currentUser;
            set
                {
                _currentUser = value;
                if (value != null)
                    {
                    _loginTime = DateTime.Now;
                    }
                }
            }

        public static bool IsLoggedIn => _currentUser != null;

        public static DateTime LoginTime => _loginTime;

        public static TimeSpan SessionDuration => DateTime.Now - _loginTime;

        public static void Logout()
            {
            _currentUser = null;
            _loginTime = default;
            }
        }
    }