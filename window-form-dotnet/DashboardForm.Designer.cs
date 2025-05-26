// DashboardForm.Designer.cs
using window_form_dotnet.Common;
using window_form_dotnet.Model.impl;

namespace window_form_dotnet
    {
    partial class DashboardForm
        {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        private void InitializeComponent()
            {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUserInfoTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.lblSessionDuration = new System.Windows.Forms.Label();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.lblQuickActionsTitle = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.Size = new System.Drawing.Size(800, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(500, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome back!";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(680, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 40);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.pnlUserInfo);
            this.pnlMain.Controls.Add(this.pnlQuickActions);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30);
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.White;
            this.pnlUserInfo.Controls.Add(this.lblUserInfoTitle);
            this.pnlUserInfo.Controls.Add(this.lblUsername);
            this.pnlUserInfo.Controls.Add(this.lblRole);
            this.pnlUserInfo.Controls.Add(this.lblLoginTime);
            this.pnlUserInfo.Controls.Add(this.lblSessionDuration);
            this.pnlUserInfo.Location = new System.Drawing.Point(30, 30);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlUserInfo.Size = new System.Drawing.Size(350, 200);
            this.pnlUserInfo.TabIndex = 0;
            // 
            // lblUserInfoTitle
            // 
            this.lblUserInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUserInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblUserInfoTitle.Location = new System.Drawing.Point(20, 20);
            this.lblUserInfoTitle.Name = "lblUserInfoTitle";
            this.lblUserInfoTitle.Size = new System.Drawing.Size(310, 25);
            this.lblUserInfoTitle.TabIndex = 0;
            this.lblUserInfoTitle.Text = "User Information";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblUsername.Location = new System.Drawing.Point(20, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(310, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username: ";
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblRole.Location = new System.Drawing.Point(20, 90);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(310, 20);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role: ";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoginTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblLoginTime.Location = new System.Drawing.Point(20, 120);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(310, 20);
            this.lblLoginTime.TabIndex = 3;
            this.lblLoginTime.Text = "Login Time: ";
            // 
            // lblSessionDuration
            // 
            this.lblSessionDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSessionDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblSessionDuration.Location = new System.Drawing.Point(20, 150);
            this.lblSessionDuration.Name = "lblSessionDuration";
            this.lblSessionDuration.Size = new System.Drawing.Size(310, 20);
            this.lblSessionDuration.TabIndex = 4;
            this.lblSessionDuration.Text = "Session Duration: ";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BackColor = System.Drawing.Color.White;
            this.pnlQuickActions.Controls.Add(this.lblQuickActionsTitle);
            this.pnlQuickActions.Controls.Add(this.btnChangePassword);
            this.pnlQuickActions.Controls.Add(this.btnViewProfile);
            this.pnlQuickActions.Controls.Add(this.btnSettings);
            this.pnlQuickActions.Location = new System.Drawing.Point(420, 30);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Padding = new System.Windows.Forms.Padding(20);
            this.pnlQuickActions.Size = new System.Drawing.Size(350, 200);
            this.pnlQuickActions.TabIndex = 1;
            // 
            // lblQuickActionsTitle
            // 
            this.lblQuickActionsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblQuickActionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblQuickActionsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            this.lblQuickActionsTitle.Size = new System.Drawing.Size(310, 25);
            this.lblQuickActionsTitle.TabIndex = 0;
            this.lblQuickActionsTitle.Text = "Quick Actions";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(20, 60);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(310, 35);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnViewProfile.FlatAppearance.BorderSize = 0;
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewProfile.ForeColor = System.Drawing.Color.White;
            this.btnViewProfile.Location = new System.Drawing.Point(20, 105);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(310, 35);
            this.btnViewProfile.TabIndex = 2;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(20, 150);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(310, 35);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Your App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlQuickActions.ResumeLayout(false);
            this.ResumeLayout(false);
            }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserInfoTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.Label lblSessionDuration;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Label lblQuickActionsTitle;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnSettings;
        }
    }
