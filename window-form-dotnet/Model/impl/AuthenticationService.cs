using System;
using window_form_dotnet.Common;
using window_form_dotnet.Model;
using window_form_dotnet.Model.dao;
using window_form_dotnet.Model.data;
using window_form_dotnet.Model.dto;

namespace window_form_dotnet.Model.impl
    {
    public class AuthenticationService
        {
        private readonly IUserDao _userDao;
        private readonly IAuthenticationDao _authDao;

        public AuthenticationService()
            {
            _userDao = new UserDataAccess();
            _authDao = new AuthenticationDataAccess();
            }

        public LoginResponse Login(LoginDto loginDto)
            {
            try
                {
                // Validate input
                string validationError = ValidationHelper.ValidateCredentials(loginDto.Username, loginDto.Password);
                if (!string.IsNullOrEmpty(validationError))
                    {
                    return new LoginResponse(false, validationError);
                    }

                // Authenticate user
                var authResult = _authDao.ValidateCredentials(loginDto.Username, loginDto.Password);

                if (!authResult.IsAuthenticated)
                    {
                    return new LoginResponse(false, authResult.Message);
                    }

                // Update last login date
                _userDao.UpdateLastLoginDate(authResult.User.Id, DateTime.Now);

                // Create user DTO (without sensitive data)
                var userDto = new UserDto(authResult.User);

                // Set session
                SessionManager.CurrentUser = userDto;

                return new LoginResponse(true, AppConstants.Messages.LOGIN_SUCCESS, userDto);
                }
            catch (Exception ex)
                {
                return new LoginResponse(false, $"{AppConstants.Messages.LOGIN_ERROR}: {ex.Message}");
                }
            }

        public bool Logout()
            {
            try
                {
                SessionManager.Logout();
                return true;
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool IsUserLoggedIn()
            {
            return SessionManager.IsLoggedIn;
            }

        public UserDto GetCurrentUser()
            {
            return SessionManager.CurrentUser;
            }

        public bool ChangePassword(int userId, string oldPassword, string newPassword)
            {
            try
                {
                return _authDao.ChangePassword(userId, oldPassword, newPassword);
                }
            catch (Exception)
                {
                return false;
                }
            }
        }
    }
