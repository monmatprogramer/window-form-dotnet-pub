using System;
using System.Collections.Generic;
using window_form_dotnet.Model;

namespace window_form_dotnet.Model.dao
    {
    public interface IUserDao
        {
        User GetUserById(int id);
        User GetUserByUsername(string username);
        User GetUserByEmail(string email);
        List<User> GetAllUsers();
        bool InsertUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        bool UpdateLastLoginDate(int userId, DateTime loginDate);
        bool IsUsernameExists(string username);
        bool IsEmailExists(string email);
        }
    }