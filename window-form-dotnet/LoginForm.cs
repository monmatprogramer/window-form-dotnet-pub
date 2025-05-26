using System;
using System.Drawing;
using System.Windows.Forms;

namespace window_form_dotnet
    {
    public partial class LoginForm : Form
        {
        private bool isPasswordVisible = false;

        public LoginForm()
            {
            InitializeComponent();
            InitializeFormStyle();
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
                // Add your login logic here
                MessageBox.Show($"Login attempt for user: {txtUsername.Text}",
                              "Login",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                // Example: Close form on successful login
                // this.DialogResult = DialogResult.OK;
                // this.Close();
                }
            }

        private void BtnCancel_Click(object sender, EventArgs e)
            {
            // Close the form or clear fields
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            }

        // Link click events
        private void LnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            // Handle forgot password functionality
            MessageBox.Show("Forgot password functionality would open here.",
                          "Forgot Password",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

            // Example: Open forgot password form
            // ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            // forgotForm.ShowDialog();
            }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            // Handle registration functionality
            MessageBox.Show("Registration form would open here.",
                          "Register",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

            // Example: Open registration form
            // RegisterForm registerForm = new RegisterForm();
            // registerForm.ShowDialog();
            }

        // Input validation
        private bool ValidateLogin()
            {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                MessageBox.Show("Please enter your username.",
                              "Validation Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
                }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                MessageBox.Show("Please enter your password.",
                              "Validation Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
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

        private void pnlLoginCard_Paint(object sender, PaintEventArgs e)
            {

            }
        }
    }