using System;
using System.Text.RegularExpressions;

namespace window_form_dotnet.Common
    {
    public static class ValidationHelper
        {
        public static bool IsValidUsername(string username)
            {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            // Username should be 3-20 characters, alphanumeric and underscore
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_]{3,20}$");
            }

        public static bool IsValidPassword(string password)
            {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            // Password should be at least 6 characters
            return password.Length >= 6;
            }

        public static string ValidateCredentials(string username, string password)
            {
            if (!IsValidUsername(username))
                return "Username must be 3-20 characters long and contain only letters, numbers, and underscores.";

            if (!IsValidPassword(password))
                return "Password must be at least 6 characters long.";

            return null; // Valid
            }
        }
    }