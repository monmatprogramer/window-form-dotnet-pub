// Model/data/DatabaseConnection.cs - MySQL Version
using System;
using MySql.Data.MySqlClient;
using window_form_dotnet.Common;

namespace window_form_dotnet.Model.data
    {
    public class DatabaseConnection
        {
        private static DatabaseConnection? _instance;
        private readonly string _connectionString;

        private DatabaseConnection()
            {
            _connectionString = AppConstants.DatabaseConfig.CONNECTION_STRING;
            InitializeDatabase();
            }

        public static DatabaseConnection Instance
            {
            get
                {
                if (_instance == null)
                    _instance = new DatabaseConnection();
                return _instance;
                }
            }

        public MySqlConnection GetConnection()
            {
            return new MySqlConnection(_connectionString);
            }

        private void InitializeDatabase()
            {
            try
                {
                // First, create database if it doesn't exist
                CreateDatabaseIfNotExists();

                using (var connection = GetConnection())
                    {
                    connection.Open();
                    CreateTables(connection);
                    SeedDefaultData(connection);
                    }
                }
            catch (Exception ex)
                {
                throw new Exception($"Failed to initialize database: {ex.Message}", ex);
                }
            }

        private void CreateDatabaseIfNotExists()
            {
            try
                {
                // Create connection without database name to create the database
                string serverConnectionString = AppConstants.DatabaseConfig.SERVER_CONNECTION_STRING;
                using (var connection = new MySqlConnection(serverConnectionString))
                    {
                    connection.Open();
                    string createDbQuery = $"CREATE DATABASE IF NOT EXISTS `{AppConstants.DatabaseConfig.DATABASE_NAME}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;";
                    using (var command = new MySqlCommand(createDbQuery, connection))
                        {
                        command.ExecuteNonQuery();
                        }
                    }
                }
            catch (Exception ex)
                {
                throw new Exception($"Failed to create database: {ex.Message}", ex);
                }
            }

        private void CreateTables(MySqlConnection connection)
            {
            string createUsersTable = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    Username VARCHAR(50) UNIQUE NOT NULL,
                    PasswordHash VARCHAR(255) NOT NULL,
                    Email VARCHAR(100) UNIQUE,
                    FullName VARCHAR(100),
                    Role VARCHAR(20) NOT NULL DEFAULT 'User',
                    IsActive BOOLEAN NOT NULL DEFAULT TRUE,
                    CreatedDate DATETIME NOT NULL,
                    LastLoginDate DATETIME NULL,
                    INDEX idx_username (Username),
                    INDEX idx_email (Email),
                    INDEX idx_active (IsActive)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;";

            string createSessionsTable = @"
                CREATE TABLE IF NOT EXISTS Sessions (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    UserId INT NOT NULL,
                    SessionToken VARCHAR(255) UNIQUE NOT NULL,
                    CreatedDate DATETIME NOT NULL,
                    ExpiryDate DATETIME NOT NULL,
                    IsActive BOOLEAN NOT NULL DEFAULT TRUE,
                    IpAddress VARCHAR(45),
                    UserAgent TEXT,
                    INDEX idx_session_token (SessionToken),
                    INDEX idx_user_id (UserId),
                    INDEX idx_expiry (ExpiryDate),
                    FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;";

            using (var command = new MySqlCommand(createUsersTable, connection))
                {
                command.ExecuteNonQuery();
                }

            using (var command = new MySqlCommand(createSessionsTable, connection))
                {
                command.ExecuteNonQuery();
                }
            }

        private void SeedDefaultData(MySqlConnection connection)
            {
            // Check if default user already exists
            string checkUser = "SELECT COUNT(*) FROM Users WHERE Username = @username";
            using (var command = new MySqlCommand(checkUser, connection))
                {
                command.Parameters.AddWithValue("@username", "monmat");
                int userCount = Convert.ToInt32(command.ExecuteScalar());

                if (userCount == 0)
                    {
                    // Create default user: monmat / 12345678
                    string hashedPassword = PasswordHelper.HashPassword("12345678");
                    string insertUser = @"
                        INSERT INTO Users (Username, PasswordHash, Email, FullName, Role, CreatedDate)
                        VALUES (@username, @password, @email, @fullname, @role, @created)";

                    using (var insertCommand = new MySqlCommand(insertUser, connection))
                        {
                        insertCommand.Parameters.AddWithValue("@username", "monmat");
                        insertCommand.Parameters.AddWithValue("@password", hashedPassword);
                        insertCommand.Parameters.AddWithValue("@email", "monmat@example.com");
                        insertCommand.Parameters.AddWithValue("@fullname", "Mon Mat");
                        insertCommand.Parameters.AddWithValue("@role", AppConstants.UserRoles.ADMIN);
                        insertCommand.Parameters.AddWithValue("@created", DateTime.Now);
                        insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }

        // Method to test database connection
        public bool TestConnection()
            {
            try
                {
                using (var connection = GetConnection())
                    {
                    connection.Open();
                    return true;
                    }
                }
            catch (Exception)
                {
                return false;
                }
            }

        // Method to get database version
        public string GetDatabaseVersion()
            {
            try
                {
                using (var connection = GetConnection())
                    {
                    connection.Open();
                    using (var command = new MySqlCommand("SELECT VERSION()", connection))
                        {
                        return command.ExecuteScalar()?.ToString() ?? "Unknown";
                        }
                    }
                }
            catch (Exception)
                {
                return "Error";
                }
            }
        }
    }