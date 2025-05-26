using System;
using System.Windows.Forms;

namespace window_form_dotnet
    {
    internal static class Program
        {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            {
            // Enable application visual styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
                {
                // Initialize database on startup
                var dbConnection = window_form_dotnet.Model.data.DatabaseConnection.Instance;

                // Start with login form
                Application.Run(new LoginForm());
                }
            catch (Exception ex)
                {
                MessageBox.Show($"Application startup error: {ex.Message}",
                              "Startup Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                }
            }
        }
    }