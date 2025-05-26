using System;
using window_form_dotnet.Common;
using window_form_dotnet.Model;
using window_form_dotnet.Model.dao;
using window_form_dotnet.Model.data;

namespace window_form_dotnet.Model.impl
    {
    public class AuthenticationDataAccess : IAuthenticationDao
        {
        private readonly IUserDao _userDao;

        public AuthenticationDataAccess()
            {
            _userDao = new UserDataAccess();
            }

        public AuthenticationResult ValidateCredentials(string username, string password)
            {
            try
                {
                // Get user by username
                var user = _userDao.GetUserByUsername(username);

                if (user == null)
                    {
                    return new AuthenticationResult(false, "Invalid username or password.");
                    }

                if (!user.IsActive)
                    {
                    return new AuthenticationResult(false, "Account is inactive. Please contact administrator.");
                    }

                // Verify password
                if (!PasswordHelper.VerifyPassword(password, user.PasswordHash))
                    {
                    return new AuthenticationResult(false, "Invalid username or password.");
                    }

                return new AuthenticationResult(true, "Authentication successful.", user);
                }
            catch (Exception ex)
                {
                return new AuthenticationResult(ex);
                }
            }

        public bool ChangePassword(int userId, string oldPassword, string newPassword)
            {
            try
                {
                var user = _userDao.GetUserById(userId);
                if (user == null)
                    return false;

                // Verify old password
                if (!PasswordHelper.VerifyPassword(oldPassword, user.PasswordHash))
                    return false;

                // Update with new password
                user.PasswordHash = PasswordHelper.HashPassword(newPassword);
                return _userDao.UpdateUser(user);
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool ResetPassword(string username, string newPassword)
            {
            try
                {
                var user = _userDao.GetUserByUsername(username);
                if (user == null)
                    return false;

                user.PasswordHash = PasswordHelper.HashPassword(newPassword);
                return _userDao.UpdateUser(user);
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool LockUser(int userId)
            {
            try
                {
                var user = _userDao.GetUserById(userId);
                if (user == null)
                    return false;

                user.IsActive = false;
                return _userDao.UpdateUser(user);
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool UnlockUser(int userId)
            {
            try
                {
                var user = _userDao.GetUserById(userId);
                if (user == null)
                    return false;

                user.IsActive = true;
                return _userDao.UpdateUser(user);
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool IsUserLocked(int userId)
            {
            try
                {
                var user = _userDao.GetUserById(userId);
                return user != null && !user.IsActive;
                }
            catch (Exception)
                {
                return false;
                }
            }
        }
    }