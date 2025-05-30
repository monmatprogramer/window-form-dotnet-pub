namespace window_form_dotnet
    {
    partial class AboutMeForm
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
            pnlContent = new Panel();
            pnlSocialLinks = new Panel();
            btnLinkedIn = new Button();
            btnGitHub = new Button();
            btnEmail = new Button();
            lblSocialTitle = new Label();
            pnlSkills = new Panel();
            flpSkills = new FlowLayoutPanel();
            lblSkillsTitle = new Label();
            pnlTechnologies = new Panel();
            flpTechnologies = new FlowLayoutPanel();
            lblTechnologiesTitle = new Label();
            pnlDescription = new Panel();
            lblDescription = new Label();
            pnlHeader = new Panel();
            btnClose = new Button();
            lblRole = new Label();
            lblName = new Label();
            picProfile = new PictureBox();
            pnlMainContainer.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlSocialLinks.SuspendLayout();
            pnlSkills.SuspendLayout();
            pnlTechnologies.SuspendLayout();
            pnlDescription.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.BackColor = Color.White;
            pnlMainContainer.Controls.Add(pnlContent);
            pnlMainContainer.Controls.Add(pnlHeader);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 0);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Size = new Size(827, 725);
            pnlMainContainer.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.Controls.Add(pnlSocialLinks);
            pnlContent.Controls.Add(pnlSkills);
            pnlContent.Controls.Add(pnlTechnologies);
            pnlContent.Controls.Add(pnlDescription);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 180);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(30, 20, 30, 30);
            pnlContent.Size = new Size(827, 545);
            pnlContent.TabIndex = 1;
            // 
            // pnlSocialLinks
            // 
            pnlSocialLinks.Controls.Add(btnLinkedIn);
            pnlSocialLinks.Controls.Add(btnGitHub);
            pnlSocialLinks.Controls.Add(btnEmail);
            pnlSocialLinks.Controls.Add(lblSocialTitle);
            pnlSocialLinks.Dock = DockStyle.Top;
            pnlSocialLinks.Location = new Point(30, 410);
            pnlSocialLinks.Name = "pnlSocialLinks";
            pnlSocialLinks.Size = new Size(767, 100);
            pnlSocialLinks.TabIndex = 3;
            // 
            // btnLinkedIn
            // 
            btnLinkedIn.BackColor = Color.FromArgb(0, 119, 181);
            btnLinkedIn.FlatAppearance.BorderSize = 0;
            btnLinkedIn.FlatStyle = FlatStyle.Flat;
            btnLinkedIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLinkedIn.ForeColor = Color.White;
            btnLinkedIn.Location = new Point(180, 40);
            btnLinkedIn.Name = "btnLinkedIn";
            btnLinkedIn.Size = new Size(80, 35);
            btnLinkedIn.TabIndex = 3;
            btnLinkedIn.Text = "LinkedIn";
            btnLinkedIn.UseVisualStyleBackColor = false;
            btnLinkedIn.Click += BtnLinkedIn_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.BackColor = Color.FromArgb(36, 41, 46);
            btnGitHub.FlatAppearance.BorderSize = 0;
            btnGitHub.FlatStyle = FlatStyle.Flat;
            btnGitHub.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGitHub.ForeColor = Color.White;
            btnGitHub.Location = new Point(90, 40);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(80, 35);
            btnGitHub.TabIndex = 2;
            btnGitHub.Text = "GitHub";
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += BtnGitHub_Click;
            // 
            // btnEmail
            // 
            btnEmail.BackColor = Color.FromArgb(64, 123, 255);
            btnEmail.FlatAppearance.BorderSize = 0;
            btnEmail.FlatStyle = FlatStyle.Flat;
            btnEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmail.ForeColor = Color.White;
            btnEmail.Location = new Point(0, 40);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(80, 35);
            btnEmail.TabIndex = 1;
            btnEmail.Text = "Email";
            btnEmail.UseVisualStyleBackColor = false;
            btnEmail.Click += BtnEmail_Click;
            // 
            // lblSocialTitle
            // 
            lblSocialTitle.Dock = DockStyle.Top;
            lblSocialTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSocialTitle.ForeColor = Color.FromArgb(64, 123, 255);
            lblSocialTitle.Location = new Point(0, 0);
            lblSocialTitle.Name = "lblSocialTitle";
            lblSocialTitle.Size = new Size(767, 30);
            lblSocialTitle.TabIndex = 0;
            lblSocialTitle.Text = "CONNECT WITH ME";
            lblSocialTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSkills
            // 
            pnlSkills.Controls.Add(flpSkills);
            pnlSkills.Controls.Add(lblSkillsTitle);
            pnlSkills.Dock = DockStyle.Top;
            pnlSkills.Location = new Point(30, 290);
            pnlSkills.Name = "pnlSkills";
            pnlSkills.Size = new Size(767, 120);
            pnlSkills.TabIndex = 2;
            // 
            // flpSkills
            // 
            flpSkills.Dock = DockStyle.Fill;
            flpSkills.Location = new Point(0, 30);
            flpSkills.Name = "flpSkills";
            flpSkills.Size = new Size(767, 90);
            flpSkills.TabIndex = 1;
            // 
            // lblSkillsTitle
            // 
            lblSkillsTitle.Dock = DockStyle.Top;
            lblSkillsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSkillsTitle.ForeColor = Color.FromArgb(64, 123, 255);
            lblSkillsTitle.Location = new Point(0, 0);
            lblSkillsTitle.Name = "lblSkillsTitle";
            lblSkillsTitle.Size = new Size(767, 30);
            lblSkillsTitle.TabIndex = 0;
            lblSkillsTitle.Text = "SKILLS & EXPERTISE";
            lblSkillsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTechnologies
            // 
            pnlTechnologies.Controls.Add(flpTechnologies);
            pnlTechnologies.Controls.Add(lblTechnologiesTitle);
            pnlTechnologies.Dock = DockStyle.Top;
            pnlTechnologies.Location = new Point(30, 170);
            pnlTechnologies.Name = "pnlTechnologies";
            pnlTechnologies.Size = new Size(767, 120);
            pnlTechnologies.TabIndex = 1;
            // 
            // flpTechnologies
            // 
            flpTechnologies.Dock = DockStyle.Fill;
            flpTechnologies.Location = new Point(0, 30);
            flpTechnologies.Name = "flpTechnologies";
            flpTechnologies.Size = new Size(767, 90);
            flpTechnologies.TabIndex = 1;
            // 
            // lblTechnologiesTitle
            // 
            lblTechnologiesTitle.Dock = DockStyle.Top;
            lblTechnologiesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTechnologiesTitle.ForeColor = Color.FromArgb(64, 123, 255);
            lblTechnologiesTitle.Location = new Point(0, 0);
            lblTechnologiesTitle.Name = "lblTechnologiesTitle";
            lblTechnologiesTitle.Size = new Size(767, 30);
            lblTechnologiesTitle.TabIndex = 0;
            lblTechnologiesTitle.Text = "TECHNOLOGIES";
            lblTechnologiesTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDescription
            // 
            pnlDescription.Controls.Add(lblDescription);
            pnlDescription.Dock = DockStyle.Top;
            pnlDescription.Location = new Point(30, 20);
            pnlDescription.Name = "pnlDescription";
            pnlDescription.Size = new Size(767, 150);
            pnlDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(51, 51, 51);
            lblDescription.Location = new Point(0, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(767, 150);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(64, 123, 255);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lblRole);
            pnlHeader.Controls.Add(lblName);
            pnlHeader.Controls.Add(picProfile);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(827, 180);
            pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(787, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 11F);
            lblRole.ForeColor = Color.FromArgb(230, 240, 255);
            lblRole.Location = new Point(140, 100);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(420, 25);
            lblRole.TabIndex = 2;
            lblRole.Text = "Full Stack Developer | Mobile App Specialist";
            lblRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(140, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(420, 40);
            lblName.TabIndex = 1;
            lblName.Text = "Your Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.White;
            picProfile.Location = new Point(30, 50);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(90, 90);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            picProfile.Paint += PicProfile_Paint;
            // 
            // AboutMeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 725);
            Controls.Add(pnlMainContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutMeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Me";
            Load += AboutMeForm_Load;
            pnlMainContainer.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlSocialLinks.ResumeLayout(false);
            pnlSkills.ResumeLayout(false);
            pnlTechnologies.ResumeLayout(false);
            pnlDescription.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel pnlMainContainer;
        private Panel pnlContent;
        private Panel pnlHeader;
        private PictureBox picProfile;
        private Label lblName;
        private Label lblRole;
        private Button btnClose;
        private Panel pnlDescription;
        private Label lblDescription;
        private Panel pnlTechnologies;
        private Label lblTechnologiesTitle;
        private FlowLayoutPanel flpTechnologies;
        private Panel pnlSkills;
        private FlowLayoutPanel flpSkills;
        private Label lblSkillsTitle;
        private Panel pnlSocialLinks;
        private Button btnEmail;
        private Label lblSocialTitle;
        private Button btnGitHub;
        private Button btnLinkedIn;
        }
    }