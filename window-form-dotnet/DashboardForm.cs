using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_form_dotnet
    {
    public partial class DashboardForm : Form
        {
        public DashboardForm()
            {
            InitializeComponent();
            }
        // Add the missing event handler method for the FormClosing event
        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
            {
            // Add logic here to handle the form closing event, if needed.
            // For example, you can prompt the user to confirm exiting the application:
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                {
                e.Cancel = true; // Cancel the form closing
                }
            }
        // Add the missing DashboardForm_Load method to handle the Load event.
        private void DashboardForm_Load(object sender, EventArgs e)
            {
            // Add any initialization logic here if needed.
            lblWelcome.Text = "Welcome back, user!"; // Example logic to update the welcome message.
            }
        // Add the missing BtnLogout_Click event handler to resolve the CS1061 error.
        private void BtnLogout_Click(object sender, EventArgs e)
            {
            // Add logic for logout functionality here.
            // For example, you might want to close the form or redirect to a login screen.
            MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            }
        }
    }
