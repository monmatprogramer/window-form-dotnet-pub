namespace window_form_dotnet.Common
    {
    // Renamed the class to avoid conflict with another 'Constants' class in the same namespace
    public static class AppConstants
        {
        public static class Messages
            {
            public const string LOGIN_SUCCESS = "Login successful!";
            public const string LOGIN_FAILED = "Invalid username or password.";
            public const string LOGIN_ERROR = "An error occurred during login. Please try again.";
            public const string VALIDATION_ERROR = "Please check your input and try again.";
            public const string SESSION_EXPIRED = "Your session has expired. Please login again.";
            }

        public static class UserRoles
            {
            public const string ADMIN = "Admin";
            public const string USER = "User";
            public const string MODERATOR = "Moderator";
            }

        public static class DatabaseConfig
            {
            // MySQL Database Configuration
            public const string SERVER = "localhost";
            public const string PORT = "3306";
            public const string DATABASE_NAME = "loginapp_db";
            public const string USERNAME = "root";
            public const string PASSWORD = "monmat_1995@2024"; // Change this to your MySQL password

            // Full connection string with database
            public const string CONNECTION_STRING =
                $"Server={SERVER};Port={PORT};Database={DATABASE_NAME};Uid={USERNAME};Pwd={PASSWORD};CharSet=utf8mb4;SslMode=None;";

            // Server connection string without database (for creating database)
            public const string SERVER_CONNECTION_STRING =
                $"Server={SERVER};Port={PORT};Uid={USERNAME};Pwd={PASSWORD};SslMode=None;";

            public const string USERS_TABLE = "Users";
            public const string SESSIONS_TABLE = "Sessions";

            // Connection timeout and other settings
            public const int CONNECTION_TIMEOUT = 30;
            public const int COMMAND_TIMEOUT = 60;
            }

        // Alternative configuration for different environments
        public static class DatabaseConfigDev
            {
            public const string SERVER = "localhost";
            public const string PORT = "3306";
            public const string DATABASE_NAME = "loginapp_dev_db";
            public const string USERNAME = "dev_user";
            public const string PASSWORD = "dev_password";

            public const string CONNECTION_STRING =
                $"Server={SERVER};Port={PORT};Database={DATABASE_NAME};Uid={USERNAME};Pwd={PASSWORD};CharSet=utf8mb4;SslMode=None;";
            }

        public static class DatabaseConfigProduction
            {
            public const string SERVER = "production-server.com";
            public const string PORT = "3306";
            public const string DATABASE_NAME = "loginapp_prod_db";
            public const string USERNAME = "prod_user";
            public const string PASSWORD = "secure_production_password";

            public const string CONNECTION_STRING =
                $"Server={SERVER};Port={PORT};Database={DATABASE_NAME};Uid={USERNAME};Pwd={PASSWORD};CharSet=utf8mb4;SslMode=Preferred;";
            }
        }
    }