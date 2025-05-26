// Model/data/UserDataAccess.cs - MySQL Version
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using window_form_dotnet.Model;
using window_form_dotnet.Model.dao;

namespace window_form_dotnet.Model.data
    {
    public class UserDataAccess : IUserDao
        {
        private readonly DatabaseConnection _dbConnection;

        public UserDataAccess()
            {
            _dbConnection = DatabaseConnection.Instance;
            }

        public User GetUserById(int id)
            {
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Id = @id";
                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@id", id);
                        using (var reader = command.ExecuteReader())
                            {
                            if (reader.Read())
                                {
                                return MapReaderToUser(reader);
                                }
                            }
                        }
                    }
                }
            catch (Exception)
                {
                // Log exception
                }
            return null;
            }

        public User GetUserByUsername(string username)
            {
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Username = @username";
                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@username", username);
                        using (var reader = command.ExecuteReader())
                            {
                            if (reader.Read())
                                {
                                return MapReaderToUser(reader);
                                }
                            }
                        }
                    }
                }
            catch (Exception)
                {
                // Log exception
                }
            return null;
            }

        public User GetUserByEmail(string email)
            {
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Email = @email";
                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@email", email);
                        using (var reader = command.ExecuteReader())
                            {
                            if (reader.Read())
                                {
                                return MapReaderToUser(reader);
                                }
                            }
                        }
                    }
                }
            catch (Exception)
                {
                // Log exception
                }
            return null;
            }

        public List<User> GetAllUsers()
            {
            var users = new List<User>();
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = "SELECT * FROM Users ORDER BY Username";
                    using (var command = new MySqlCommand(query, connection))
                        {
                        using (var reader = command.ExecuteReader())
                            {
                            while (reader.Read())
                                {
                                users.Add(MapReaderToUser(reader));
                                }
                            }
                        }
                    }
                }
            catch (Exception)
                {
                // Log exception
                }
            return users;
            }

        public bool InsertUser(User user)
            {
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = @"
                        INSERT INTO Users (Username, PasswordHash, Email, FullName, Role, IsActive, CreatedDate)
                        VALUES (@username, @password, @email, @fullname, @role, @active, @created)";

                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@username", user.Username);
                        command.Parameters.AddWithValue("@password", user.PasswordHash);
                        command.Parameters.AddWithValue("@email", user.Email);
                        command.Parameters.AddWithValue("@fullname", user.FullName);
                        command.Parameters.AddWithValue("@role", user.Role);
                        command.Parameters.AddWithValue("@active", user.IsActive);
                        command.Parameters.AddWithValue("@created", user.CreatedDate);

                        return command.ExecuteNonQuery() > 0;
                        }
                    }
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool UpdateUser(User user)
            {
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = @"
                        UPDATE Users SET 
                            Username = @username,
                            Email = @email,
                            FullName = @fullname,
                            Role = @role,
                            IsActive = @active
                        WHERE Id = @id";

                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@username", user.Username);
                        command.Parameters.AddWithValue("@email", user.Email);
                        command.Parameters.AddWithValue("@fullname", user.FullName);
                        command.Parameters.AddWithValue("@role", user.Role);
                        command.Parameters.AddWithValue("@active", user.IsActive);
                        command.Parameters.AddWithValue("@id", user.Id);

                        return command.ExecuteNonQuery() > 0;
                        }
                    }
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
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = "DELETE FROM Users WHERE Id = @id";
                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@id", id);
                        return command.ExecuteNonQuery() > 0;
                        }
                    }
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool UpdateLastLoginDate(int userId, DateTime loginDate)
            {
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = "UPDATE Users SET LastLoginDate = @loginDate WHERE Id = @id";
                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@loginDate", loginDate);
                        command.Parameters.AddWithValue("@id", userId);
                        return command.ExecuteNonQuery() > 0;
                        }
                    }
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool IsUsernameExists(string username)
            {
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@username", username);
                        return Convert.ToInt32(command.ExecuteScalar()) > 0;
                        }
                    }
                }
            catch (Exception)
                {
                return false;
                }
            }

        public bool IsEmailExists(string email)
            {
            try
                {
                using (var connection = _dbConnection.GetConnection())
                    {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @email";
                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@email", email);
                        return Convert.ToInt32(command.ExecuteScalar()) > 0;
                        }
                    }
                }
            catch (Exception)
                {
                return false;
                }
            }

        private User MapReaderToUser(MySqlDataReader reader)
            {
            return new User
                {
                Id = reader.GetInt32("Id"),
                Username = reader.GetString("Username"),
                PasswordHash = reader.GetString("PasswordHash"),
                Email = reader.IsDBNull("Email") ? null : reader.GetString("Email"),
                FullName = reader.IsDBNull("FullName") ? null : reader.GetString("FullName"),
                Role = reader.GetString("Role"),
                IsActive = reader.GetBoolean("IsActive"),
                CreatedDate = reader.GetDateTime("CreatedDate"),
                LastLoginDate = reader.IsDBNull("LastLoginDate") ? null : reader.GetDateTime("LastLoginDate")
                };
            }
        }
    }