using System;
using System.Windows.Forms;

namespace window_form_dotnet
    {
    internal static class Program
        {
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
                {
                // Test database connection before starting
                var dbConnection = window_form_dotnet.Model.data.DatabaseConnection.Instance;

                if (!dbConnection.TestConnection())
                    {
                    MessageBox.Show("Failed to connect to MySQL database.\n\n" +
                                  "Please check:\n" +
                                  "- MySQL server is running\n" +
                                  "- Connection settings in Constants.cs\n" +
                                  "- Username and password are correct",
                                  "Database Connection Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                    }

                // Show database info
                string dbVersion = dbConnection.GetDatabaseVersion();
                Console.WriteLine($"Connected to MySQL version: {dbVersion}");

                // Start application
                Application.Run(new LoginForm());
                }
            catch (Exception ex)
                {
                MessageBox.Show($"Application startup error: {ex.Message}\n\n" +
                              "This might be a database connection issue.\n" +
                              "Please check your MySQL server and connection settings.",
                              "Startup Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                }
            }
        }
    }