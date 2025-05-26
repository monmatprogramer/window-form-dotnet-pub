using System;
using System.Collections.Generic;
using System.Linq;
using window_form_dotnet.Common;
using window_form_dotnet.Model;
using window_form_dotnet.Model.dao;
using window_form_dotnet.Model.data;
using window_form_dotnet.Model.dto;

namespace window_form_dotnet.Model.impl
    {
    public class UserService
        {
        private readonly IUserDao _userDao;

        public UserService()
            {
            _userDao = new UserDataAccess();
            }

        public List<UserDto> GetAllUsers()
            {
            try
                {
                var users = _userDao.GetAllUsers();
                return users.Select(u => new UserDto(u)).ToList();
                }
            catch (Exception)
                {
                return new List<UserDto>();
                }
            }

        public UserDto GetUserById(int id)
            {
            try
                {
                var user = _userDao.GetUserById(id);
                return user != null ? new UserDto(user) : null;
                }
            catch (Exception)
                {
                return null;
                }
            }

        public UserDto GetUserByUsername(string username)
            {
            try
                {
                var user = _userDao.GetUserByUsername(username);
                return user != null ? new UserDto(user) : null;
                }
            catch (Exception)
                {
                return null;
                }
            }

        public bool CreateUser(string username, string password, string email, string fullName, string role = null)
            {
            try
                {
                // Validate input
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                    return false;

                // Check if username exists
                if (_userDao.IsUsernameExists(username))
                    return false;

                // Check if email exists (if provided)
                if (!string.IsNullOrWhiteSpace(email) && _userDao.IsEmailExists(email))
                    return false;

                // Create user
                var user = new User
                    {
                    Username = username,
                    PasswordHash = PasswordHelper.HashPassword(password),
                    Email = email,
                    FullName = fullName,
                    Role = role ?? AppConstants.UserRoles.USER,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                    };

                return _userDao.InsertUser(user);
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool UpdateUser(UserDto userDto)
            {
            try
                {
                var user = _userDao.GetUserById(userDto.Id);
                if (user == null)
                    return false;

                // Update user properties
                user.Username = userDto.Username;
                user.Email = userDto.Email;
                user.FullName = userDto.FullName;
                user.Role = userDto.Role;
                user.IsActive = userDto.IsActive;

                return _userDao.UpdateUser(user);
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool DeleteUser(int id)
            {
            try
                {
                return _userDao.DeleteUser(id);
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool IsUsernameAvailable(string username)
            {
            try
                {
                return !_userDao.IsUsernameExists(username);
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool IsEmailAvailable(string email)
            {
            try
                {
                return !string.IsNullOrWhiteSpace(email) && !_userDao.IsEmailExists(email);
                }
            catch (Exception)
                {
                return false;
                }
            }
        }
    }