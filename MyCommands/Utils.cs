using System;

namespace MyCommands
    {
    public class Utils
        {
        /// <summary>
        /// Validates username according to the specified rules
        /// </summary>
        /// <param name="username">The username to validate</param>
        /// <returns>True if valid, false otherwise</returns>
        public static bool IsValidUsername(string username)
            {
            // Check if username is null or empty
            if (string.IsNullOrEmpty(username))
                return false;

            // Check if username contains space characters
            if (username.Contains(" "))
                return false;

            // Check if username contains any uppercase letters
            foreach (char c in username)
                {
                if (char.IsUpper(c))
                    return false;
                }

            return true;
            }

        /// <summary>
        /// Validates password according to the specified rules
        /// </summary>
        /// <param name="password">The password to validate</param>
        /// <returns>True if valid, false otherwise</returns>
        public static bool IsValidPassword(string password)
            {
            // Check if password is null or empty
            if (string.IsNullOrEmpty(password))
                return false;

            // Check if password contains space characters
            if (password.Contains(" "))
                return false;

            // Check if password length is greater than 4 characters
            if (password.Length <= 4)
                return false;

            return true;
            }

        /// <summary>
        /// Validates both username and password
        /// </summary>
        /// <param name="username">The username to validate</param>
        /// <param name="password">The password to validate</param>
        /// <returns>True if both are valid, false otherwise</returns>
        public static bool ValidateCredentials(string username, string password)
            {
            return IsValidUsername(username) && IsValidPassword(password);
            }

        /// <summary>
        /// Gets detailed validation errors for username
        /// </summary>
        /// <param name="username">The username to validate</param>
        /// <returns>String with error messages, or empty string if valid</returns>
        public static string GetUsernameValidationErrors(string username)
            {
            var errors = new List<string>();

            if (string.IsNullOrEmpty(username))
                errors.Add("Username cannot be empty");

            if (!string.IsNullOrEmpty(username))
                {
                if (username.Contains(" "))
                    errors.Add("Username cannot contain spaces");

                foreach (char c in username)
                    {
                    if (char.IsUpper(c))
                        {
                        errors.Add("Username cannot contain uppercase letters");
                        break;
                        }
                    }
                }

            return string.Join(", ", errors);
            }

        /// <summary>
        /// Gets detailed validation errors for password
        /// </summary>
        /// <param name="password">The password to validate</param>
        /// <returns>String with error messages, or empty string if valid</returns>
        public static string GetPasswordValidationErrors(string password)
            {
            var errors = new List<string>();

            if (string.IsNullOrEmpty(password))
                errors.Add("Password cannot be empty");

            if (!string.IsNullOrEmpty(password))
                {
                if (password.Contains(" "))
                    errors.Add("Password cannot contain spaces");

                if (password.Length <= 4)
                    errors.Add("Password must be longer than 4 characters");
                }

            return string.Join(", ", errors);
            }
        }
    }