using System;
using System.Drawing;
using System.Windows.Forms;
using window_form_dotnet.Common;
using window_form_dotnet.Model.dto;
using window_form_dotnet.Model.impl;
using window_form_dotnet.UI.Controls;
using window_form_dotnet.UI.Helpers;
using window_form_dotnet.UI.Dialogs;

namespace window_form_dotnet
    {
    public partial class RegisterForm : Form
        {
        private readonly UserService _userService;
        private readonly AuthenticationService _authService;

        private bool isPasswordVisible = false;
        private bool isConfirmPasswordVisible = false;

        public RegisterForm()
            {
            InitializeComponent();
            InitializeFormStyle();
            InitializeModernButtons();
            _userService = new UserService();
            _authService = new AuthenticationService();
            }

        private void InitializeFormStyle()
            {
            // Apply modern rounded corners effect to main card panel
            this.Paint += (s, e) => DrawRoundedCard();

            // Set form properties for modern appearance
            this.Font = new Font("Segoe UI", 9F);

            // Add subtle shadow effect to register card
            ApplyCardShadow();

            // Apply text box styles
            ApplyTextBoxStyles();
            }

        private void InitializeModernButtons()
            {
            // Remove old buttons from the button container
            pnlButtonContainer.Controls.Clear();

            // Customize designer-generated register button
            BtnRegister.Size = new Size(366, 50);
            BtnRegister.Location = new Point(0, 15);
            BtnRegister.FlatAppearance.BorderSize = 0;
            BtnRegister.FlatStyle = FlatStyle.Flat;
            BtnRegister.BackColor = Color.FromArgb(40, 167, 69);
            BtnRegister.ForeColor = Color.White;
            BtnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnRegister.Text = "CREATE ACCOUNT";
            BtnRegister.Click += BtnRegister_Click;

            // Customize designer-generated cancel button
            BtnCancel.Size = new Size(100, 35);
            BtnCancel.Location = new Point(133, 75);
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.BackColor = Color.Gray;
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Text = "Cancel";
           // BtnCancel.Click += BtnCancel_Click;

            // Ensure buttons are added to the container (handled by designer)
            }

        private void DrawRoundedCard()
            {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 12;
            Rectangle cardRect = new Rectangle(
                pnlRegisterCard.Location.X - 2,
                pnlRegisterCard.Location.Y - 2,
                pnlRegisterCard.Width + 4,
                pnlRegisterCard.Height + 4
            );

            path.AddArc(cardRect.X, cardRect.Y, radius, radius, 180, 90);
            path.AddArc(cardRect.X + cardRect.Width - radius, cardRect.Y, radius, radius, 270, 90);
            path.AddArc(cardRect.X + cardRect.Width - radius, cardRect.Y + cardRect.Height - radius, radius, radius, 0, 90);
            path.AddArc(cardRect.X, cardRect.Y + cardRect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            pnlRegisterCard.Region = new Region(path);
            }

        private void ApplyCardShadow()
            {
            pnlRegisterCard.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
                    {
                    Rectangle borderRect = new Rectangle(0, 0, pnlRegisterCard.Width - 1, pnlRegisterCard.Height - 1);
                    e.Graphics.DrawRectangle(borderPen, borderRect);
                    }
            };
            }

        private void ApplyTextBoxStyles()
            {
            txtUsername.Paint += (s, e) => DrawTextBoxUnderline(txtUsername, e);
            txtEmail.Paint += (s, e) => DrawTextBoxUnderline(txtEmail, e);
            txtFullName.Paint += (s, e) => DrawTextBoxUnderline(txtFullName, e);
            txtPassword.Paint += (s, e) => DrawTextBoxUnderline(txtPassword, e);
            txtConfirmPassword.Paint += (s, e) => DrawTextBoxUnderline(txtConfirmPassword, e);
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

        private void RegisterForm_Load(object sender, EventArgs e)
            {
            txtUsername.Focus();
            SetupRoleComboBox();
            }

        private void SetupRoleComboBox()
            {
            cmbRole.Items.Clear();
            cmbRole.Items.Add(AppConstants.UserRoles.USER);
            cmbRole.Items.Add(AppConstants.UserRoles.MODERATOR);
            cmbRole.Items.Add(AppConstants.UserRoles.ADMIN);
            cmbRole.SelectedIndex = 0;
            }

        private void TextBox_Enter(object sender, EventArgs e)
            {
            if (sender is TextBox textBox)
                {
                textBox.Invalidate();
                }
            }

        private void TextBox_Leave(object sender, EventArgs e)
            {
            if (sender is TextBox textBox)
                {
                textBox.Invalidate();
                ValidateField(textBox);
                }
            }

        private void ValidateField(TextBox textBox)
            {
            string errorMessage = "";

            switch (textBox.Name)
                {
                case "txtUsername":
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                        {
                        if (!ValidationHelper.IsValidUsername(textBox.Text))
                            {
                            errorMessage = "Username must be 3-20 characters (letters, numbers, underscore only)";
                            }
                        else if (!_userService.IsUsernameAvailable(textBox.Text))
                            {
                            errorMessage = "Username already exists";
                            }
                        }
                    break;

                case "txtEmail":
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                        {
                        if (!IsValidEmail(textBox.Text))
                            {
                            errorMessage = "Please enter a valid email address";
                            }
                        else if (!_userService.IsEmailAvailable(textBox.Text))
                            {
                            errorMessage = "Email already registered";
                            }
                        }
                    break;

                case "txtPassword":
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                        {
                        if (!ValidationHelper.IsValidPassword(textBox.Text))
                            {
                            errorMessage = "Password must be at least 6 characters";
                            }
                        }
                    break;

                case "txtConfirmPassword":
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                        {
                        if (textBox.Text != txtPassword.Text)
                            {
                            errorMessage = "Passwords do not match";
                            }
                        }
                    break;
                }

            if (!string.IsNullOrEmpty(errorMessage))
                {
                ShowFieldError(textBox, errorMessage);
                }
            else
                {
                ClearFieldError(textBox);
                }
            }

        private void ShowFieldError(TextBox textBox, string message)
            {
            string errorLabelName = $"lbl{textBox.Name}Error";
            Label errorLabel = Controls.Find(errorLabelName, true).FirstOrDefault() as Label;

            if (errorLabel == null)
                {
                errorLabel = new Label
                    {
                    Name = errorLabelName,
                    ForeColor = Color.FromArgb(220, 53, 69),
                    Font = new Font("Segoe UI", 8F),
                    AutoSize = true,
                    Location = new Point(textBox.Location.X, textBox.Location.Y + textBox.Height + 2)
                    };
                textBox.Parent.Controls.Add(errorLabel);
                }

            errorLabel.Text = message;
            errorLabel.Visible = true;
            }

        private void ClearFieldError(TextBox textBox)
            {
            string errorLabelName = $"lbl{textBox.Name}Error";
            Label errorLabel = Controls.Find(errorLabelName, true).FirstOrDefault() as Label;
            if (errorLabel != null)
                {
                errorLabel.Visible = false;
                }
            }

        private void BtnTogglePassword_Click(object sender, EventArgs e)
            {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            btnTogglePassword.Text = isPasswordVisible ? "🙈" : "👁";
            }

        private void BtnToggleConfirmPassword_Click(object sender, EventArgs e)
            {
            isConfirmPasswordVisible = !isConfirmPasswordVisible;
            txtConfirmPassword.UseSystemPasswordChar = !isConfirmPasswordVisible;
            btnToggleConfirmPassword.Text = isConfirmPasswordVisible ? "🙈" : "👁";
            }

        private void BtnRegister_Click(object sender, EventArgs e)
            {
            if (ValidateForm())
                {
                PerformRegistration();
                }
            }

        private bool ValidateForm()
            {
            ClearAllErrors();

            bool isValid = true;
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                ShowFieldError(txtUsername, "Username is required");
                isValid = false;
                }
            else if (!ValidationHelper.IsValidUsername(txtUsername.Text))
                {
                ShowFieldError(txtUsername, "Username must be 3-20 characters (letters, numbers, underscore only)");
                isValid = false;
                }
            else if (!_userService.IsUsernameAvailable(txtUsername.Text))
                {
                ShowFieldError(txtUsername, "Username already exists");
                isValid = false;
                }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                ShowFieldError(txtEmail, "Email is required");
                isValid = false;
                }
            else if (!IsValidEmail(txtEmail.Text))
                {
                ShowFieldError(txtEmail, "Please enter a valid email address");
                isValid = false;
                }
            else if (!_userService.IsEmailAvailable(txtEmail.Text))
                {
                ShowFieldError(txtEmail, "Email already registered");
                isValid = false;
                }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                ShowFieldError(txtFullName, "Full name is required");
                isValid = false;
                }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                ShowFieldError(txtPassword, "Password is required");
                isValid = false;
                }
            else if (!ValidationHelper.IsValidPassword(txtPassword.Text))
                {
                ShowFieldError(txtPassword, "Password must be at least 6 characters");
                isValid = false;
                }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                ShowFieldError(txtConfirmPassword, "Please confirm your password");
                isValid = false;
                }
            else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                ShowFieldError(txtConfirmPassword, "Passwords do not match");
                isValid = false;
                }

            if (cmbRole.SelectedIndex == -1)
                {
                errorMessage = "Please select a role";
                isValid = false;
                }

            if (!isValid && !string.IsNullOrEmpty(errorMessage))
                {
                ModernMessageDialog.ShowError(errorMessage, "Validation Error");
                }

            return isValid;
            }

        private void ClearAllErrors()
            {
            foreach (Control control in pnlRegisterCard.Controls)
                {
                if (control is Label && control.Name.EndsWith("Error"))
                    {
                    control.Visible = false;
                    }
                }
            }

        private void PerformRegistration()
            {
            try
                {
                SetRegistrationInProgress(true);

                bool success = _userService.CreateUser(
                    txtUsername.Text.Trim(),
                    txtPassword.Text,
                    txtEmail.Text.Trim(),
                    txtFullName.Text.Trim(),
                    cmbRole.SelectedItem?.ToString()
                );

                if (success)
                    {
                    ModernMessageDialog.ShowSuccess(
                        "Registration successful! You can now login with your credentials.",
                        "Registration Complete"
                    );
                    AutoLoginUser();
                    }
                else
                    {
                    ModernMessageDialog.ShowError(
                        "Registration failed. Please check your information and try again.",
                        "Registration Failed"
                    );
                    }
                }
            catch (Exception ex)
                {
                ModernMessageDialog.ShowError(
                    $"An error occurred during registration: {ex.Message}",
                    "Registration Error"
                );
                }
            finally
                {
                SetRegistrationInProgress(false);
                }
            }

        private void AutoLoginUser()
            {
            var loginDto = new LoginDto(txtUsername.Text, txtPassword.Text);
            var loginResponse = _authService.Login(loginDto);

            if (loginResponse.IsSuccess)
                {
                var dashboardForm = new DashboardForm(txtUsername.Text, cmbRole.SelectedItem?.ToString() ?? "User");
                dashboardForm.Show();
                this.Hide();
                }
            else
                {
                //TODO: onsider showing a message dialog for login failure
                //ReturnToLogin();
                }
            }

        //private void ReturnToLogin()
        //    {
        //    var loginForm = new LoginForm();
        //    loginForm.SetUsername(txtUsername.Text);
        //    loginForm.Show();
        //    this.Close();
        //    }

        //private void BtnCancel_Click(object sender, EventArgs e)
        //    {
        //    ReturnToLogin();
        //    }

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            //ReturnToLogin();
            }

        private bool IsValidEmail(string email)
            {
            try
                {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
                }
            catch
                {
                return false;
                }
            }

        public void SetRegistrationInProgress(bool inProgress)
            {
            txtUsername.Enabled = !inProgress;
            txtEmail.Enabled = !inProgress;
            txtFullName.Enabled = !inProgress;
            txtPassword.Enabled = !inProgress;
            txtConfirmPassword.Enabled = !inProgress;
            cmbRole.Enabled = !inProgress;
            BtnRegister.Enabled = !inProgress;
            btnTogglePassword.Enabled = !inProgress;
            btnToggleConfirmPassword.Enabled = !inProgress;

            if (inProgress)
                {
                BtnRegister.Text = "CREATING ACCOUNT...";
                this.Cursor = Cursors.WaitCursor;
                }
            else
                {
                BtnRegister.Text = "CREATE ACCOUNT";
                this.Cursor = Cursors.Default;
                }
            }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
            if (keyData == Keys.Enter)
                {
                BtnRegister_Click(this, EventArgs.Empty);
                return true;
                }
            return base.ProcessCmdKey(ref msg, keyData);
            }

        protected override void OnFormClosing(FormClosingEventArgs e)
            {
            if (e.CloseReason == CloseReason.UserClosing)
                {
                //ReturnToLogin();
                var result = MessageBox.Show("Are you sure you want to exit the application?",
                                   "Confirm Exit",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    {
                    e.Cancel = true;
                    return;
                    }
                
                //open login form
                var loginForm = new LoginForm();
                loginForm.Show();
                //close this form
                this.Close();
                //ReturnToLogin();
                //Application.Exit(); // Ensure application exits properly

                }
            base.OnFormClosing(e);
            }

        
        }
    }