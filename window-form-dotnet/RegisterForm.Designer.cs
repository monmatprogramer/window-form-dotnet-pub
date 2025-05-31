namespace window_form_dotnet
    {
    partial class RegisterForm
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
      


        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            pnlMainContainer = new Panel();
            pnlRegisterCard = new Panel();
            lnkLogin = new LinkLabel();
            pnlLinksContainer = new Panel();
            lblLoginPrompt = new Label();
            pnlButtonContainer = new Panel();
            BtnCancel = new window_form_dotnet.UI.Controls.ModernButton();
            BtnRegister = new window_form_dotnet.UI.Controls.ModernButton();
            pnlRoleContainer = new Panel();
            cmbRole = new ComboBox();
            lblRole = new Label();
            pnlConfirmPasswordContainer = new Panel();
            btnToggleConfirmPassword = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            pnlPasswordContainer = new Panel();
            btnTogglePassword = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            pnlFullNameContainer = new Panel();
            txtFullName = new TextBox();
            lblFullName = new Label();
            pnlEmailContainer = new Panel();
            txtEmail = new TextBox();
            lblEmail = new Label();
            pnlUsernameContainer = new Panel();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlMainContainer.SuspendLayout();
            pnlRegisterCard.SuspendLayout();
            pnlLinksContainer.SuspendLayout();
            pnlButtonContainer.SuspendLayout();
            pnlRoleContainer.SuspendLayout();
            pnlConfirmPasswordContainer.SuspendLayout();
            pnlPasswordContainer.SuspendLayout();
            pnlFullNameContainer.SuspendLayout();
            pnlEmailContainer.SuspendLayout();
            pnlUsernameContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.BackColor = Color.FromArgb(240, 242, 247);
            pnlMainContainer.Controls.Add(pnlRegisterCard);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 0);
            pnlMainContainer.Margin = new Padding(3, 4, 3, 4);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Padding = new Padding(57, 47, 57, 47);
            pnlMainContainer.Size = new Size(700, 1021);
            pnlMainContainer.TabIndex = 0;
            // 
            // pnlRegisterCard
            // 
            pnlRegisterCard.BackColor = Color.White;
            pnlRegisterCard.Controls.Add(lnkLogin);
            pnlRegisterCard.Controls.Add(pnlLinksContainer);
            pnlRegisterCard.Controls.Add(pnlButtonContainer);
            pnlRegisterCard.Controls.Add(pnlRoleContainer);
            pnlRegisterCard.Controls.Add(pnlConfirmPasswordContainer);
            pnlRegisterCard.Controls.Add(pnlPasswordContainer);
            pnlRegisterCard.Controls.Add(pnlFullNameContainer);
            pnlRegisterCard.Controls.Add(pnlEmailContainer);
            pnlRegisterCard.Controls.Add(pnlUsernameContainer);
            pnlRegisterCard.Controls.Add(lblSubtitle);
            pnlRegisterCard.Controls.Add(lblTitle);
            pnlRegisterCard.Dock = DockStyle.Fill;
            pnlRegisterCard.Location = new Point(57, 47);
            pnlRegisterCard.Margin = new Padding(3, 4, 3, 4);
            pnlRegisterCard.Name = "pnlRegisterCard";
            pnlRegisterCard.Padding = new Padding(46, 43, 46, 43);
            pnlRegisterCard.Size = new Size(586, 927);
            pnlRegisterCard.TabIndex = 0;
            // 
            // lnkLogin
            // 
            lnkLogin.ActiveLinkColor = Color.FromArgb(45, 105, 230);
            lnkLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lnkLogin.LinkColor = Color.FromArgb(64, 123, 255);
            lnkLogin.Location = new Point(107, 851);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(366, 33);
            lnkLogin.TabIndex = 1;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Sign in to your account";
            lnkLogin.TextAlign = ContentAlignment.MiddleCenter;
            lnkLogin.LinkClicked += LnkLogin_LinkClicked;
            // 
            // pnlLinksContainer
            // 
            pnlLinksContainer.Controls.Add(lblLoginPrompt);
            pnlLinksContainer.Location = new Point(110, 784);
            pnlLinksContainer.Margin = new Padding(3, 4, 3, 4);
            pnlLinksContainer.Name = "pnlLinksContainer";
            pnlLinksContainer.Size = new Size(366, 121);
            pnlLinksContainer.TabIndex = 9;
            // 
            // lblLoginPrompt
            // 
            lblLoginPrompt.Font = new Font("Segoe UI", 9F);
            lblLoginPrompt.ForeColor = Color.FromArgb(128, 128, 128);
            lblLoginPrompt.Location = new Point(3, 32);
            lblLoginPrompt.Name = "lblLoginPrompt";
            lblLoginPrompt.Size = new Size(366, 33);
            lblLoginPrompt.TabIndex = 0;
            lblLoginPrompt.Text = "Already have an account?";
            lblLoginPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlButtonContainer
            // 
            pnlButtonContainer.Controls.Add(BtnCancel);
            pnlButtonContainer.Controls.Add(BtnRegister);
            pnlButtonContainer.Location = new Point(110, 653);
            pnlButtonContainer.Margin = new Padding(3, 4, 3, 4);
            pnlButtonContainer.Name = "pnlButtonContainer";
            pnlButtonContainer.Size = new Size(366, 123);
            pnlButtonContainer.TabIndex = 8;
            // 
            // BtnCancel
            // 
            BtnCancel.AutoSize = true;
            BtnCancel.BackColor = Color.Black;
            BtnCancel.BaseColor = Color.DimGray;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.Black;
            BtnCancel.Location = new Point(84, 69);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(166, 39);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnRegister
            // 
            BtnRegister.FlatAppearance.BorderSize = 0;
            BtnRegister.FlatStyle = FlatStyle.Flat;
            BtnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnRegister.ForeColor = Color.White;
            BtnRegister.Location = new Point(6, 17);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(363, 46);
            BtnRegister.TabIndex = 0;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = true;
            // 
            // pnlRoleContainer
            // 
            pnlRoleContainer.Controls.Add(cmbRole);
            pnlRoleContainer.Controls.Add(lblRole);
            pnlRoleContainer.Location = new Point(110, 535);
            pnlRoleContainer.Margin = new Padding(3, 4, 3, 4);
            pnlRoleContainer.Name = "pnlRoleContainer";
            pnlRoleContainer.Size = new Size(366, 110);
            pnlRoleContainer.TabIndex = 7;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 11F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(0, 40);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(366, 33);
            cmbRole.TabIndex = 1;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(64, 123, 255);
            lblRole.Location = new Point(0, 10);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(366, 30);
            lblRole.TabIndex = 0;
            lblRole.Text = "ROLE";
            lblRole.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlConfirmPasswordContainer
            // 
            pnlConfirmPasswordContainer.Controls.Add(btnToggleConfirmPassword);
            pnlConfirmPasswordContainer.Controls.Add(txtConfirmPassword);
            pnlConfirmPasswordContainer.Controls.Add(lblConfirmPassword);
            pnlConfirmPasswordContainer.Location = new Point(110, 455);
            pnlConfirmPasswordContainer.Margin = new Padding(3, 4, 3, 4);
            pnlConfirmPasswordContainer.Name = "pnlConfirmPasswordContainer";
            pnlConfirmPasswordContainer.Size = new Size(366, 80);
            pnlConfirmPasswordContainer.TabIndex = 6;
            // 
            // btnToggleConfirmPassword
            // 
            btnToggleConfirmPassword.BackColor = Color.Transparent;
            btnToggleConfirmPassword.FlatAppearance.BorderSize = 0;
            btnToggleConfirmPassword.FlatStyle = FlatStyle.Flat;
            btnToggleConfirmPassword.Font = new Font("Segoe UI", 9F);
            btnToggleConfirmPassword.ForeColor = Color.FromArgb(128, 128, 128);
            btnToggleConfirmPassword.Location = new Point(326, 35);
            btnToggleConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            btnToggleConfirmPassword.Name = "btnToggleConfirmPassword";
            btnToggleConfirmPassword.Size = new Size(40, 40);
            btnToggleConfirmPassword.TabIndex = 2;
            btnToggleConfirmPassword.Text = "👁";
            btnToggleConfirmPassword.UseVisualStyleBackColor = false;
            btnToggleConfirmPassword.Click += BtnToggleConfirmPassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.ForeColor = Color.FromArgb(51, 51, 51);
            txtConfirmPassword.Location = new Point(0, 42);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm your password";
            txtConfirmPassword.Size = new Size(320, 25);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.Enter += TextBox_Enter;
            txtConfirmPassword.Leave += TextBox_Leave;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(64, 123, 255);
            lblConfirmPassword.Location = new Point(0, 10);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(366, 30);
            lblConfirmPassword.TabIndex = 0;
            lblConfirmPassword.Text = "CONFIRM PASSWORD";
            lblConfirmPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlPasswordContainer
            // 
            pnlPasswordContainer.Controls.Add(btnTogglePassword);
            pnlPasswordContainer.Controls.Add(txtPassword);
            pnlPasswordContainer.Controls.Add(lblPassword);
            pnlPasswordContainer.Location = new Point(110, 375);
            pnlPasswordContainer.Margin = new Padding(3, 4, 3, 4);
            pnlPasswordContainer.Name = "pnlPasswordContainer";
            pnlPasswordContainer.Size = new Size(366, 80);
            pnlPasswordContainer.TabIndex = 5;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = Color.Transparent;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Font = new Font("Segoe UI", 9F);
            btnTogglePassword.ForeColor = Color.FromArgb(128, 128, 128);
            btnTogglePassword.Location = new Point(326, 35);
            btnTogglePassword.Margin = new Padding(3, 4, 3, 4);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(40, 40);
            btnTogglePassword.TabIndex = 2;
            btnTogglePassword.Text = "👁";
            btnTogglePassword.UseVisualStyleBackColor = false;
            btnTogglePassword.Click += BtnTogglePassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(51, 51, 51);
            txtPassword.Location = new Point(0, 42);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(320, 25);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(64, 123, 255);
            lblPassword.Location = new Point(0, 10);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(366, 30);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "PASSWORD";
            lblPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlFullNameContainer
            // 
            pnlFullNameContainer.Controls.Add(txtFullName);
            pnlFullNameContainer.Controls.Add(lblFullName);
            pnlFullNameContainer.Location = new Point(110, 295);
            pnlFullNameContainer.Margin = new Padding(3, 4, 3, 4);
            pnlFullNameContainer.Name = "pnlFullNameContainer";
            pnlFullNameContainer.Size = new Size(366, 80);
            pnlFullNameContainer.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.ForeColor = Color.FromArgb(51, 51, 51);
            txtFullName.Location = new Point(0, 42);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.Size = new Size(366, 25);
            txtFullName.TabIndex = 1;
            txtFullName.Enter += TextBox_Enter;
            txtFullName.Leave += TextBox_Leave;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(64, 123, 255);
            lblFullName.Location = new Point(0, 10);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(366, 30);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "FULL NAME";
            lblFullName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlEmailContainer
            // 
            pnlEmailContainer.Controls.Add(txtEmail);
            pnlEmailContainer.Controls.Add(lblEmail);
            pnlEmailContainer.Location = new Point(110, 215);
            pnlEmailContainer.Margin = new Padding(3, 4, 3, 4);
            pnlEmailContainer.Name = "pnlEmailContainer";
            pnlEmailContainer.Size = new Size(366, 80);
            pnlEmailContainer.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.FromArgb(51, 51, 51);
            txtEmail.Location = new Point(0, 42);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.Size = new Size(366, 25);
            txtEmail.TabIndex = 1;
            txtEmail.Enter += TextBox_Enter;
            txtEmail.Leave += TextBox_Leave;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(64, 123, 255);
            lblEmail.Location = new Point(0, 10);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(366, 30);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "EMAIL";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlUsernameContainer
            // 
            pnlUsernameContainer.Controls.Add(txtUsername);
            pnlUsernameContainer.Controls.Add(lblUsername);
            pnlUsernameContainer.Location = new Point(110, 135);
            pnlUsernameContainer.Margin = new Padding(3, 4, 3, 4);
            pnlUsernameContainer.Name = "pnlUsernameContainer";
            pnlUsernameContainer.Size = new Size(366, 80);
            pnlUsernameContainer.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(51, 51, 51);
            txtUsername.Location = new Point(0, 42);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Choose a username";
            txtUsername.Size = new Size(366, 25);
            txtUsername.TabIndex = 1;
            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(64, 123, 255);
            lblUsername.Location = new Point(0, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(366, 30);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "USERNAME";
            lblUsername.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(128, 128, 128);
            lblSubtitle.Location = new Point(110, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(366, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Fill in the form to create your account";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitle.Location = new Point(110, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(366, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 247);
            ClientSize = new Size(700, 1021);
            Controls.Add(pnlMainContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register - Your App";
            Load += RegisterForm_Load;
            pnlMainContainer.ResumeLayout(false);
            pnlRegisterCard.ResumeLayout(false);
            pnlLinksContainer.ResumeLayout(false);
            pnlButtonContainer.ResumeLayout(false);
            pnlButtonContainer.PerformLayout();
            pnlRoleContainer.ResumeLayout(false);
            pnlConfirmPasswordContainer.ResumeLayout(false);
            pnlConfirmPasswordContainer.PerformLayout();
            pnlPasswordContainer.ResumeLayout(false);
            pnlPasswordContainer.PerformLayout();
            pnlFullNameContainer.ResumeLayout(false);
            pnlFullNameContainer.PerformLayout();
            pnlEmailContainer.ResumeLayout(false);
            pnlEmailContainer.PerformLayout();
            pnlUsernameContainer.ResumeLayout(false);
            pnlUsernameContainer.PerformLayout();
            ResumeLayout(false);
            }
        #endregion

        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlRegisterCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlUsernameContainer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlEmailContainer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlFullNameContainer;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlPasswordContainer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlConfirmPasswordContainer;
        private System.Windows.Forms.Button btnToggleConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Panel pnlRoleContainer;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.Panel pnlLinksContainer;
        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.Label lblLoginPrompt;
        private UI.Controls.ModernButton BtnRegister;
        private UI.Controls.ModernButton BtnCancel;
        }
    }