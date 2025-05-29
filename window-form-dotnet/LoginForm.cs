using System;
using System.Drawing;
using System.Windows.Forms;
using window_form_dotnet.Common;
using window_form_dotnet.Model.dto;
using window_form_dotnet.Model.impl;

namespace window_form_dotnet
    {
    public partial class LoginForm : Form
        {
        private bool isPasswordVisible = false;
        private readonly AuthenticationService _authService;

        public LoginForm()
            {
            InitializeComponent();
            InitializeFormStyle();
            _authService = new AuthenticationService();
            }

        private void InitializeFormStyle()
            {
            // Apply modern rounded corners effect to main card panel
            this.Paint += (s, e) => DrawRoundedCard();

            // Set form properties for modern appearance
            this.Font = new Font("Segoe UI", 9F);

            // Add subtle shadow effect to login card
            ApplyCardShadow();
            }

        private void DrawRoundedCard()
            {
            // Add rounded corners to the login card
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 12;
            Rectangle cardRect = new Rectangle(
                pnlLoginCard.Location.X - 2,
                pnlLoginCard.Location.Y - 2,
                pnlLoginCard.Width + 4,
                pnlLoginCard.Height + 4
            );

            path.AddArc(cardRect.X, cardRect.Y, radius, radius, 180, 90);
            path.AddArc(cardRect.X + cardRect.Width - radius, cardRect.Y, radius, radius, 270, 90);
            path.AddArc(cardRect.X + cardRect.Width - radius, cardRect.Y + cardRect.Height - radius, radius, radius, 0, 90);
            path.AddArc(cardRect.X, cardRect.Y + cardRect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            pnlLoginCard.Region = new Region(path);
            }

        private void ApplyCardShadow()
            {
            // Create a subtle border effect for the card
            pnlLoginCard.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
                    {
                    Rectangle borderRect = new Rectangle(0, 0, pnlLoginCard.Width - 1, pnlLoginCard.Height - 1);
                    e.Graphics.DrawRectangle(borderPen, borderRect);
                    }
            };
            }

        private void LoginForm_Load(object sender, EventArgs e)
            {
            // Set initial focus to username field
            txtUsername.Focus();

            // Apply underline effect to text boxes
            ApplyTextBoxStyles();

            // Check if user is already logged in
            if (_authService.IsUserLoggedIn())
                {
                OpenDashboard();
                }
            }

        private void ApplyTextBoxStyles()
            {
            // Add underline effect to text boxes
            txtUsername.Paint += (s, e) => DrawTextBoxUnderline(txtUsername, e);
            txtPassword.Paint += (s, e) => DrawTextBoxUnderline(txtPassword, e);
            }

        private void DrawTextBoxUnderline(TextBox textBox, PaintEventArgs e)
            {
            Color underlineColor = textBox.Focused ?
                Color.FromArgb(64, 123, 255) :
                Color.FromArgb(220, 220, 220);

            using (Pen pen = new Pen(underlineColor, textBox.Focused ? 2 : 1))
                {
                e.Graphics.DrawLine(pen, 0, textBox.Height - 1, textBox.Width, textBox.Height - 1);
                }
            }

        // Text box focus effects
        private void TextBox_Enter(object sender, EventArgs e)
            {
            if (sender is TextBox textBox)
                {
                textBox.Invalidate(); // Trigger repaint for underline effect
                }
            }

        private void TextBox_Leave(object sender, EventArgs e)
            {
            if (sender is TextBox textBox)
                {
                textBox.Invalidate(); // Trigger repaint for underline effect
                }
            }

        // Password visibility toggle
        private void BtnTogglePassword_Click(object sender, EventArgs e)
            {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            btnTogglePassword.Text = isPasswordVisible ? "🙈" : "👁";
            }

        // Button hover effects
        private void Button_MouseEnter(object sender, EventArgs e)
            {
            if (sender == btnLogin)
                {
                btnLogin.BackColor = Color.FromArgb(45, 105, 230);
                }
            }

        private void Button_MouseLeave(object sender, EventArgs e)
            {
            if (sender == btnLogin)
                {
                btnLogin.BackColor = Color.FromArgb(64, 123, 255);
                }
            }

        // Button click events
        private void BtnLogin_Click(object sender, EventArgs e)
            {
            // Validate input fields
            if (ValidateLogin())
                {
                PerformLogin();
                }
            }

        private void PerformLogin()
            {
            try
                {
                // Set login in progress
                SetLoginInProgress(true);

                // Create login DTO
                var loginDto = new LoginDto(txtUsername.Text, txtPassword.Text);

                // Attempt login
                var loginResponse = _authService.Login(loginDto);

                if (loginResponse.IsSuccess)
                    {
                    // Login successful
                    MessageBox.Show(loginResponse.Message,
                                  "Login Successful",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    // Open dashboard
                    OpenDashboard();
                    }
                else
                    {
                    // Login failed
                    MessageBox.Show(loginResponse.Message,
                                  "Login Failed",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);

                    // Clear password field
                    txtPassword.Clear();
                    txtPassword.Focus();
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show($"An error occurred during login: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                }
            finally
                {
                SetLoginInProgress(false);
                }
            }

        private void OpenDashboard()
            {
            try
                {
                // Get the username from the login form
                string username = txtUsername.Text.Trim();

                // Determine user role/privilege (you can get this from your AuthenticationService)
                string userRole = DetermineUserRole(username);

                //Change dashboard form here
                //var dashboardForm = new DashboardForm();
                var dashboardForm = new DashboardForm(username, userRole);
                dashboardForm.Show();
                this.Hide();
                }
            catch (Exception ex)
                {
                MessageBox.Show($"Error opening dashboard: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                }
            }

        private void BtnCancel_Click(object sender, EventArgs e)
            {
            // Close the application
            Application.Exit();
            }

        // Link click events
        private void LnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            // Handle forgot password functionality
            MessageBox.Show("Forgot password functionality would open here.\n\nFor demo purposes:\nUsername: monmat\nPassword: 12345678",
                          "Forgot Password",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
            }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            // Handle registration functionality
            MessageBox.Show("Registration form would open here.\n\nFor demo purposes, use:\nUsername: monmat\nPassword: 12345678",
                          "Register",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
            }

        // Input validation
        private bool ValidateLogin()
            {
            string validationError = ValidationHelper.ValidateCredentials(txtUsername.Text, txtPassword.Text);

            if (!string.IsNullOrEmpty(validationError))
                {
                MessageBox.Show(validationError,
                              "Validation Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);

                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                    txtUsername.Focus();
                else
                    txtPassword.Focus();

                return false;
                }

            return true;
            }

        // Public properties for accessing form data
        public string Username => txtUsername.Text.Trim();
        public string Password => txtPassword.Text;

        // Method to clear form
        public void ClearForm()
            {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            }

        // Method to set username (useful for remember me functionality)
        public void SetUsername(string username)
            {
            txtUsername.Text = username;
            txtPassword.Focus();
            }

        // Enable/disable form controls during login process
        public void SetLoginInProgress(bool inProgress)
            {
            txtUsername.Enabled = !inProgress;
            txtPassword.Enabled = !inProgress;
            btnLogin.Enabled = !inProgress;
            btnTogglePassword.Enabled = !inProgress;

            if (inProgress)
                {
                btnLogin.Text = "SIGNING IN...";
                this.Cursor = Cursors.WaitCursor;
                }
            else
                {
                btnLogin.Text = "SIGN IN";
                this.Cursor = Cursors.Default;
                }
            }

        // Handle Enter key press for login
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
            if (keyData == Keys.Enter)
                {
                BtnLogin_Click(this, EventArgs.Empty);
                return true;
                }
            return base.ProcessCmdKey(ref msg, keyData);
            }

        // Override form closing to ensure proper cleanup
        protected override void OnFormClosing(FormClosingEventArgs e)
            {
            if (e.CloseReason == CloseReason.UserClosing)
                {
                Application.Exit();
                }
            base.OnFormClosing(e);
            }
        private string DetermineUserRole(string username)
            {
            // Placeholder implementation for determining user role
            // Replace this with actual logic to fetch user role based on the username
            if (username.ToLower() == "admin" || username.ToLower() == "monmat")
                {
                return "Administrator";
                }
            else
                {
                return "User";
                }
            }
        }
    }