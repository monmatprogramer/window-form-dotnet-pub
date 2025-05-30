namespace window_form_dotnet
    {
    partial class LoginForm
        {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            pnlMainContainer = new Panel();
            pnlLoginCard = new Panel();
            pnlLinksContainer = new Panel();
            lnkForgotPassword = new LinkLabel();
            lblRegisterPrompt = new Label();
            lnkRegister = new LinkLabel();
            pnlButtonContainer = new Panel();
            btnCancel = new Button();
            btnLogin = new Button();
            pnlPasswordContainer = new Panel();
            btnTogglePassword = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            pnlUsernameContainer = new Panel();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            pnlMainContainer.SuspendLayout();
            pnlLoginCard.SuspendLayout();
            pnlLinksContainer.SuspendLayout();
            pnlButtonContainer.SuspendLayout();
            pnlPasswordContainer.SuspendLayout();
            pnlUsernameContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.BackColor = Color.FromArgb(240, 242, 247);
            pnlMainContainer.Controls.Add(pnlLoginCard);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 0);
            pnlMainContainer.Margin = new Padding(3, 4, 3, 4);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Padding = new Padding(57, 67, 57, 67);
            pnlMainContainer.Size = new Size(700, 867);
            pnlMainContainer.TabIndex = 0;
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.White;
            pnlLoginCard.Controls.Add(pnlLinksContainer);
            pnlLoginCard.Controls.Add(pnlButtonContainer);
            pnlLoginCard.Controls.Add(pnlPasswordContainer);
            pnlLoginCard.Controls.Add(pnlUsernameContainer);
            pnlLoginCard.Controls.Add(lblSubtitle);
            pnlLoginCard.Controls.Add(lblWelcome);
            pnlLoginCard.Dock = DockStyle.Fill;
            pnlLoginCard.Location = new Point(57, 67);
            pnlLoginCard.Margin = new Padding(3, 4, 3, 4);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Padding = new Padding(46, 53, 46, 53);
            pnlLoginCard.Size = new Size(586, 733);
            pnlLoginCard.TabIndex = 0;
            // 
            // pnlLinksContainer
            // 
            pnlLinksContainer.Controls.Add(lnkForgotPassword);
            pnlLinksContainer.Controls.Add(lblRegisterPrompt);
            pnlLinksContainer.Controls.Add(lnkRegister);
            pnlLinksContainer.Location = new Point(101, 535);
            pnlLinksContainer.Margin = new Padding(3, 4, 3, 4);
            pnlLinksContainer.Name = "pnlLinksContainer";
            pnlLinksContainer.Size = new Size(366, 167);
            pnlLinksContainer.TabIndex = 5;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.FromArgb(45, 105, 230);
            lnkForgotPassword.Font = new Font("Segoe UI", 9F);
            lnkForgotPassword.LinkColor = Color.FromArgb(64, 123, 255);
            lnkForgotPassword.Location = new Point(0, 27);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(366, 33);
            lnkForgotPassword.TabIndex = 6;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot your password?";
            lnkForgotPassword.TextAlign = ContentAlignment.MiddleCenter;
            lnkForgotPassword.LinkClicked += LnkForgotPassword_LinkClicked;
            // 
            // lblRegisterPrompt
            // 
            lblRegisterPrompt.Font = new Font("Segoe UI", 9F);
            lblRegisterPrompt.ForeColor = Color.FromArgb(128, 128, 128);
            lblRegisterPrompt.Location = new Point(0, 101);
            lblRegisterPrompt.Name = "lblRegisterPrompt";
            lblRegisterPrompt.Size = new Size(366, 33);
            lblRegisterPrompt.TabIndex = 7;
            lblRegisterPrompt.Text = "Don't have an account?";
            lblRegisterPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(45, 105, 230);
            lnkRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lnkRegister.LinkColor = Color.FromArgb(64, 123, 255);
            lnkRegister.Location = new Point(0, 134);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(366, 33);
            lnkRegister.TabIndex = 8;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Create an account";
            lnkRegister.TextAlign = ContentAlignment.MiddleCenter;
            lnkRegister.LinkClicked += LnkRegister_LinkClicked;
            // 
            // pnlButtonContainer
            // 
            pnlButtonContainer.Controls.Add(btnCancel);
            pnlButtonContainer.Controls.Add(btnLogin);
            pnlButtonContainer.Location = new Point(101, 357);
            pnlButtonContainer.Margin = new Padding(3, 4, 3, 4);
            pnlButtonContainer.Name = "pnlButtonContainer";
            pnlButtonContainer.Size = new Size(366, 151);
            pnlButtonContainer.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(143, 107);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 123, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(0, 27);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(366, 53);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "SIGN IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            btnLogin.MouseEnter += Button_MouseEnter;
            btnLogin.MouseLeave += Button_MouseLeave;
            // 
            // pnlPasswordContainer
            // 
            pnlPasswordContainer.Controls.Add(btnTogglePassword);
            pnlPasswordContainer.Controls.Add(txtPassword);
            pnlPasswordContainer.Controls.Add(lblPassword);
            pnlPasswordContainer.Location = new Point(101, 251);
            pnlPasswordContainer.Margin = new Padding(3, 4, 3, 4);
            pnlPasswordContainer.Name = "pnlPasswordContainer";
            pnlPasswordContainer.Size = new Size(366, 98);
            pnlPasswordContainer.TabIndex = 3;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = Color.Transparent;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Font = new Font("Segoe UI", 9F);
            btnTogglePassword.ForeColor = Color.FromArgb(128, 128, 128);
            btnTogglePassword.Location = new Point(326, 40);
            btnTogglePassword.Margin = new Padding(3, 4, 3, 4);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(40, 40);
            btnTogglePassword.TabIndex = 3;
            btnTogglePassword.Text = "👁";
            btnTogglePassword.UseVisualStyleBackColor = false;
            btnTogglePassword.Click += BtnTogglePassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(51, 51, 51);
            txtPassword.Location = new Point(0, 47);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(320, 25);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(64, 123, 255);
            lblPassword.Location = new Point(0, 13);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(366, 33);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "PASSWORD";
            lblPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlUsernameContainer
            // 
            pnlUsernameContainer.Controls.Add(txtUsername);
            pnlUsernameContainer.Controls.Add(lblUsername);
            pnlUsernameContainer.Location = new Point(101, 147);
            pnlUsernameContainer.Margin = new Padding(3, 4, 3, 4);
            pnlUsernameContainer.Name = "pnlUsernameContainer";
            pnlUsernameContainer.Size = new Size(366, 96);
            pnlUsernameContainer.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(51, 51, 51);
            txtUsername.Location = new Point(0, 47);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(366, 25);
            txtUsername.TabIndex = 1;
            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(64, 123, 255);
            lblUsername.Location = new Point(0, 13);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(366, 33);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "USERNAME";
            lblUsername.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(128, 128, 128);
            lblSubtitle.Location = new Point(101, 115);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(366, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Please sign in to your account";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(51, 51, 51);
            lblWelcome.Location = new Point(101, 67);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(366, 48);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 247);
            ClientSize = new Size(700, 867);
            Controls.Add(pnlMainContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Your App";
            Load += LoginForm_Load;
            pnlMainContainer.ResumeLayout(false);
            pnlLoginCard.ResumeLayout(false);
            pnlLinksContainer.ResumeLayout(false);
            pnlButtonContainer.ResumeLayout(false);
            pnlPasswordContainer.ResumeLayout(false);
            pnlPasswordContainer.PerformLayout();
            pnlUsernameContainer.ResumeLayout(false);
            pnlUsernameContainer.PerformLayout();
            ResumeLayout(false);

            }
        // Add the missing event handler method for Button_MouseEnter
        private void Button_MouseEnter(object sender, EventArgs e)
            {
            // Add logic for when the mouse enters the button, if needed.
            // For example, you can change the button's background color:
            if (sender is Button button)
                {
                button.BackColor = Color.FromArgb(45, 105, 230); // Example hover color
                }
            }

        // Add the missing event handler method for Button_MouseLeave
        private void Button_MouseLeave(object sender, EventArgs e)
            {
            // Add logic for when the mouse leaves the button, if needed.
            // For example, you can reset the button's background color:
            if (sender is Button button)
                {
                button.BackColor = Color.FromArgb(64, 123, 255); // Original color
                }
            }
        #endregion

        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlLoginCard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlUsernameContainer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlPasswordContainer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlLinksContainer;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblRegisterPrompt;
        }
    }