namespace window_form_dotnet
    {
    partial class DashboardForm
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
            pnlTopNavigation = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnDashboard = new Button();
            lblAppTitle = new Label();
            pnlContentArea = new Panel();
            pnlSidebar = new Panel();
            pnlProfileCard = new Panel();
            lblProfileRole = new Label();
            lblProfileName = new Label();
            lblProfileTitle = new Label();
            pnlQuickActions = new Panel();
            btnQuickAction5 = new Button();
            btnQuickAction4 = new Button();
            btnQuickAction3 = new Button();
            btnQuickAction2 = new Button();
            btnQuickAction1 = new Button();
            lblQuickActionsTitle = new Label();
            pnlMainContent = new Panel();
            pnlStatsContainer = new Panel();
            pnlStat4 = new Panel();
            lblStat4Value = new Label();
            lblStat4Title = new Label();
            pnlStat3 = new Panel();
            lblStat3Value = new Label();
            lblStat3Title = new Label();
            pnlStat2 = new Panel();
            lblStat2Value = new Label();
            lblStat2Title = new Label();
            pnlStat1 = new Panel();
            lblStat1Value = new Label();
            lblStat1Title = new Label();
            pnlChartsContainer = new Panel();
            pnlChart2 = new Panel();
            lblChart2Title = new Label();
            pnlChart1 = new Panel();
            lblChart1Title = new Label();
            pnlRecentActivity = new Panel();
            lstRecentActivity = new ListBox();
            lblRecentActivityTitle = new Label();
            pnlMainContainer.SuspendLayout();
            pnlTopNavigation.SuspendLayout();
            pnlContentArea.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlProfileCard.SuspendLayout();
            pnlQuickActions.SuspendLayout();
            pnlMainContent.SuspendLayout();
            pnlStatsContainer.SuspendLayout();
            pnlStat4.SuspendLayout();
            pnlStat3.SuspendLayout();
            pnlStat2.SuspendLayout();
            pnlStat1.SuspendLayout();
            pnlChartsContainer.SuspendLayout();
            pnlChart2.SuspendLayout();
            pnlChart1.SuspendLayout();
            pnlRecentActivity.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.BackColor = Color.FromArgb(240, 242, 247);
            pnlMainContainer.Controls.Add(pnlTopNavigation);
            pnlMainContainer.Controls.Add(pnlContentArea);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 0);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Size = new Size(1400, 800);
            pnlMainContainer.TabIndex = 0;
            // 
            // pnlTopNavigation
            // 
            pnlTopNavigation.BackColor = Color.White;
            pnlTopNavigation.Controls.Add(btnLogout);
            pnlTopNavigation.Controls.Add(btnProfile);
            pnlTopNavigation.Controls.Add(btnSettings);
            pnlTopNavigation.Controls.Add(btnReports);
            pnlTopNavigation.Controls.Add(btnCustomers);
            pnlTopNavigation.Controls.Add(btnOrders);
            pnlTopNavigation.Controls.Add(btnDashboard);
            pnlTopNavigation.Controls.Add(lblAppTitle);
            pnlTopNavigation.Dock = DockStyle.Top;
            pnlTopNavigation.Location = new Point(0, 0);
            pnlTopNavigation.Name = "pnlTopNavigation";
            pnlTopNavigation.Padding = new Padding(20, 10, 20, 10);
            pnlTopNavigation.Size = new Size(1400, 70);
            pnlTopNavigation.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1300, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 30);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 9F);
            btnProfile.ForeColor = Color.FromArgb(64, 123, 255);
            btnProfile.Location = new Point(640, 20);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(80, 30);
            btnProfile.TabIndex = 6;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += NavButton_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9F);
            btnSettings.ForeColor = Color.FromArgb(64, 123, 255);
            btnSettings.Location = new Point(540, 20);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(80, 30);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += NavButton_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9F);
            btnReports.ForeColor = Color.FromArgb(64, 123, 255);
            btnReports.Location = new Point(440, 20);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(80, 30);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += NavButton_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 9F);
            btnCustomers.ForeColor = Color.FromArgb(64, 123, 255);
            btnCustomers.Location = new Point(340, 20);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(80, 30);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += NavButton_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Transparent;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 9F);
            btnOrders.ForeColor = Color.FromArgb(64, 123, 255);
            btnOrders.Location = new Point(240, 20);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(80, 30);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += NavButton_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(64, 123, 255);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(126, 20);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(94, 30);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += NavButton_Click;
            // 
            // lblAppTitle
            // 
            lblAppTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblAppTitle.Location = new Point(20, 15);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(100, 40);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "MyApp";
            lblAppTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContentArea
            // 
            pnlContentArea.Controls.Add(pnlSidebar);
            pnlContentArea.Controls.Add(pnlMainContent);
            pnlContentArea.Dock = DockStyle.Fill;
            pnlContentArea.Location = new Point(0, 0);
            pnlContentArea.Name = "pnlContentArea";
            pnlContentArea.Padding = new Padding(20);
            pnlContentArea.Size = new Size(1400, 800);
            pnlContentArea.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pnlProfileCard);
            pnlSidebar.Controls.Add(pnlQuickActions);
            pnlSidebar.Dock = DockStyle.Right;
            pnlSidebar.Location = new Point(1080, 20);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(10, 0, 0, 0);
            pnlSidebar.Size = new Size(300, 760);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlProfileCard
            // 
            pnlProfileCard.BackColor = Color.White;
            pnlProfileCard.Controls.Add(lblProfileRole);
            pnlProfileCard.Controls.Add(lblProfileName);
            pnlProfileCard.Controls.Add(lblProfileTitle);
            pnlProfileCard.Dock = DockStyle.Top;
            pnlProfileCard.Location = new Point(10, 386);
            pnlProfileCard.Name = "pnlProfileCard";
            pnlProfileCard.Padding = new Padding(20);
            pnlProfileCard.Size = new Size(290, 322);
            pnlProfileCard.TabIndex = 1;
            // 
            // lblProfileRole
            // 
            lblProfileRole.Font = new Font("Segoe UI", 9F);
            lblProfileRole.ForeColor = Color.FromArgb(128, 128, 128);
            lblProfileRole.Location = new Point(20, 80);
            lblProfileRole.Name = "lblProfileRole";
            lblProfileRole.Size = new Size(250, 20);
            lblProfileRole.TabIndex = 2;
            lblProfileRole.Text = "Administrator";
            // 
            // lblProfileName
            // 
            lblProfileName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProfileName.ForeColor = Color.FromArgb(51, 51, 51);
            lblProfileName.Location = new Point(20, 50);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(250, 25);
            lblProfileName.TabIndex = 1;
            lblProfileName.Text = "John Doe";
            // 
            // lblProfileTitle
            // 
            lblProfileTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfileTitle.ForeColor = Color.FromArgb(64, 123, 255);
            lblProfileTitle.Location = new Point(20, 20);
            lblProfileTitle.Name = "lblProfileTitle";
            lblProfileTitle.Size = new Size(250, 25);
            lblProfileTitle.TabIndex = 0;
            lblProfileTitle.Text = "USER PROFILE";
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.BackColor = Color.White;
            pnlQuickActions.Controls.Add(btnQuickAction5);
            pnlQuickActions.Controls.Add(btnQuickAction4);
            pnlQuickActions.Controls.Add(btnQuickAction3);
            pnlQuickActions.Controls.Add(btnQuickAction2);
            pnlQuickActions.Controls.Add(btnQuickAction1);
            pnlQuickActions.Controls.Add(lblQuickActionsTitle);
            pnlQuickActions.Dock = DockStyle.Top;
            pnlQuickActions.Location = new Point(10, 0);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Padding = new Padding(20);
            pnlQuickActions.Size = new Size(290, 386);
            pnlQuickActions.TabIndex = 0;
            // 
            // btnQuickAction5
            // 
            btnQuickAction5.BackColor = Color.FromArgb(255, 192, 128);
            btnQuickAction5.FlatAppearance.BorderSize = 0;
            btnQuickAction5.FlatStyle = FlatStyle.Flat;
            btnQuickAction5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAction5.ForeColor = Color.White;
            btnQuickAction5.Location = new Point(17, 237);
            btnQuickAction5.Name = "btnQuickAction5";
            btnQuickAction5.Size = new Size(250, 35);
            btnQuickAction5.TabIndex = 5;
            btnQuickAction5.Text = "Add New Supplier";
            btnQuickAction5.UseVisualStyleBackColor = false;
            btnQuickAction5.Click += QuickAction_Click;
            // 
            // btnQuickAction4
            // 
            btnQuickAction4.BackColor = Color.FromArgb(255, 128, 255);
            btnQuickAction4.FlatAppearance.BorderSize = 0;
            btnQuickAction4.FlatStyle = FlatStyle.Flat;
            btnQuickAction4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAction4.ForeColor = Color.White;
            btnQuickAction4.Location = new Point(17, 181);
            btnQuickAction4.Name = "btnQuickAction4";
            btnQuickAction4.Size = new Size(250, 35);
            btnQuickAction4.TabIndex = 4;
            btnQuickAction4.Text = "Add New Product";
            btnQuickAction4.UseVisualStyleBackColor = false;
            btnQuickAction4.Click += QuickAction_Click;
            // 
            // btnQuickAction3
            // 
            btnQuickAction3.BackColor = Color.FromArgb(40, 167, 69);
            btnQuickAction3.FlatAppearance.BorderSize = 0;
            btnQuickAction3.FlatStyle = FlatStyle.Flat;
            btnQuickAction3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAction3.ForeColor = Color.White;
            btnQuickAction3.Location = new Point(17, 295);
            btnQuickAction3.Name = "btnQuickAction3";
            btnQuickAction3.Size = new Size(250, 35);
            btnQuickAction3.TabIndex = 3;
            btnQuickAction3.Text = "Generate Report";
            btnQuickAction3.UseVisualStyleBackColor = false;
            btnQuickAction3.Click += QuickAction_Click;
            // 
            // btnQuickAction2
            // 
            btnQuickAction2.BackColor = Color.FromArgb(255, 193, 7);
            btnQuickAction2.FlatAppearance.BorderSize = 0;
            btnQuickAction2.FlatStyle = FlatStyle.Flat;
            btnQuickAction2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAction2.ForeColor = Color.White;
            btnQuickAction2.Location = new Point(20, 128);
            btnQuickAction2.Name = "btnQuickAction2";
            btnQuickAction2.Size = new Size(250, 35);
            btnQuickAction2.TabIndex = 2;
            btnQuickAction2.Text = "Manage Orders";
            btnQuickAction2.UseVisualStyleBackColor = false;
            btnQuickAction2.Click += QuickAction_Click;
            // 
            // btnQuickAction1
            // 
            btnQuickAction1.BackColor = Color.FromArgb(64, 123, 255);
            btnQuickAction1.FlatAppearance.BorderSize = 0;
            btnQuickAction1.FlatStyle = FlatStyle.Flat;
            btnQuickAction1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAction1.ForeColor = Color.White;
            btnQuickAction1.Location = new Point(20, 83);
            btnQuickAction1.Name = "btnQuickAction1";
            btnQuickAction1.Size = new Size(250, 35);
            btnQuickAction1.TabIndex = 1;
            btnQuickAction1.Text = "Add New Customer";
            btnQuickAction1.UseVisualStyleBackColor = false;
            btnQuickAction1.Click += QuickAction_Click;
            // 
            // lblQuickActionsTitle
            // 
            lblQuickActionsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQuickActionsTitle.ForeColor = Color.FromArgb(64, 123, 255);
            lblQuickActionsTitle.Location = new Point(20, 10);
            lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            lblQuickActionsTitle.Size = new Size(250, 25);
            lblQuickActionsTitle.TabIndex = 0;
            lblQuickActionsTitle.Text = "QUICK ACTIONS";
            // 
            // pnlMainContent
            // 
            pnlMainContent.Controls.Add(pnlStatsContainer);
            pnlMainContent.Controls.Add(pnlChartsContainer);
            pnlMainContent.Controls.Add(pnlRecentActivity);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(20, 20);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1360, 760);
            pnlMainContent.TabIndex = 0;
            // 
            // pnlStatsContainer
            // 
            pnlStatsContainer.Controls.Add(pnlStat4);
            pnlStatsContainer.Controls.Add(pnlStat3);
            pnlStatsContainer.Controls.Add(pnlStat2);
            pnlStatsContainer.Controls.Add(pnlStat1);
            pnlStatsContainer.Dock = DockStyle.Top;
            pnlStatsContainer.Location = new Point(0, 0);
            pnlStatsContainer.Name = "pnlStatsContainer";
            pnlStatsContainer.Padding = new Padding(0, 0, 10, 20);
            pnlStatsContainer.Size = new Size(1360, 120);
            pnlStatsContainer.TabIndex = 0;
            // 
            // pnlStat4
            // 
            pnlStat4.BackColor = Color.White;
            pnlStat4.Controls.Add(lblStat4Value);
            pnlStat4.Controls.Add(lblStat4Title);
            pnlStat4.Dock = DockStyle.Left;
            pnlStat4.Location = new Point(780, 0);
            pnlStat4.Name = "pnlStat4";
            pnlStat4.Padding = new Padding(20);
            pnlStat4.Size = new Size(260, 100);
            pnlStat4.TabIndex = 3;
            // 
            // lblStat4Value
            // 
            lblStat4Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStat4Value.ForeColor = Color.FromArgb(255, 193, 7);
            lblStat4Value.Location = new Point(20, 45);
            lblStat4Value.Name = "lblStat4Value";
            lblStat4Value.Size = new Size(220, 35);
            lblStat4Value.TabIndex = 1;
            lblStat4Value.Text = "98.5%";
            // 
            // lblStat4Title
            // 
            lblStat4Title.Font = new Font("Segoe UI", 9F);
            lblStat4Title.ForeColor = Color.FromArgb(128, 128, 128);
            lblStat4Title.Location = new Point(20, 20);
            lblStat4Title.Name = "lblStat4Title";
            lblStat4Title.Size = new Size(220, 20);
            lblStat4Title.TabIndex = 0;
            lblStat4Title.Text = "Customer Satisfaction";
            // 
            // pnlStat3
            // 
            pnlStat3.BackColor = Color.White;
            pnlStat3.Controls.Add(lblStat3Value);
            pnlStat3.Controls.Add(lblStat3Title);
            pnlStat3.Dock = DockStyle.Left;
            pnlStat3.Location = new Point(520, 0);
            pnlStat3.Name = "pnlStat3";
            pnlStat3.Padding = new Padding(20);
            pnlStat3.Size = new Size(260, 100);
            pnlStat3.TabIndex = 2;
            // 
            // lblStat3Value
            // 
            lblStat3Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStat3Value.ForeColor = Color.FromArgb(40, 167, 69);
            lblStat3Value.Location = new Point(20, 45);
            lblStat3Value.Name = "lblStat3Value";
            lblStat3Value.Size = new Size(220, 35);
            lblStat3Value.TabIndex = 1;
            lblStat3Value.Text = "$125,420";
            // 
            // lblStat3Title
            // 
            lblStat3Title.Font = new Font("Segoe UI", 9F);
            lblStat3Title.ForeColor = Color.FromArgb(128, 128, 128);
            lblStat3Title.Location = new Point(20, 20);
            lblStat3Title.Name = "lblStat3Title";
            lblStat3Title.Size = new Size(220, 20);
            lblStat3Title.TabIndex = 0;
            lblStat3Title.Text = "Monthly Revenue";
            // 
            // pnlStat2
            // 
            pnlStat2.BackColor = Color.White;
            pnlStat2.Controls.Add(lblStat2Value);
            pnlStat2.Controls.Add(lblStat2Title);
            pnlStat2.Dock = DockStyle.Left;
            pnlStat2.Location = new Point(260, 0);
            pnlStat2.Name = "pnlStat2";
            pnlStat2.Padding = new Padding(20);
            pnlStat2.Size = new Size(260, 100);
            pnlStat2.TabIndex = 1;
            // 
            // lblStat2Value
            // 
            lblStat2Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStat2Value.ForeColor = Color.FromArgb(220, 53, 69);
            lblStat2Value.Location = new Point(20, 45);
            lblStat2Value.Name = "lblStat2Value";
            lblStat2Value.Size = new Size(220, 35);
            lblStat2Value.TabIndex = 1;
            lblStat2Value.Text = "23";
            // 
            // lblStat2Title
            // 
            lblStat2Title.Font = new Font("Segoe UI", 9F);
            lblStat2Title.ForeColor = Color.FromArgb(128, 128, 128);
            lblStat2Title.Location = new Point(20, 20);
            lblStat2Title.Name = "lblStat2Title";
            lblStat2Title.Size = new Size(220, 20);
            lblStat2Title.TabIndex = 0;
            lblStat2Title.Text = "Pending Orders";
            // 
            // pnlStat1
            // 
            pnlStat1.BackColor = Color.White;
            pnlStat1.Controls.Add(lblStat1Value);
            pnlStat1.Controls.Add(lblStat1Title);
            pnlStat1.Dock = DockStyle.Left;
            pnlStat1.Location = new Point(0, 0);
            pnlStat1.Name = "pnlStat1";
            pnlStat1.Padding = new Padding(20);
            pnlStat1.Size = new Size(260, 100);
            pnlStat1.TabIndex = 0;
            // 
            // lblStat1Value
            // 
            lblStat1Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStat1Value.ForeColor = Color.FromArgb(64, 123, 255);
            lblStat1Value.Location = new Point(20, 45);
            lblStat1Value.Name = "lblStat1Value";
            lblStat1Value.Size = new Size(220, 35);
            lblStat1Value.TabIndex = 1;
            lblStat1Value.Text = "1,247";
            // 
            // lblStat1Title
            // 
            lblStat1Title.Font = new Font("Segoe UI", 9F);
            lblStat1Title.ForeColor = Color.FromArgb(128, 128, 128);
            lblStat1Title.Location = new Point(20, 20);
            lblStat1Title.Name = "lblStat1Title";
            lblStat1Title.Size = new Size(220, 20);
            lblStat1Title.TabIndex = 0;
            lblStat1Title.Text = "Total Customers";
            // 
            // pnlChartsContainer
            // 
            pnlChartsContainer.Controls.Add(pnlChart2);
            pnlChartsContainer.Controls.Add(pnlChart1);
            pnlChartsContainer.Dock = DockStyle.Fill;
            pnlChartsContainer.Location = new Point(0, 0);
            pnlChartsContainer.Name = "pnlChartsContainer";
            pnlChartsContainer.Padding = new Padding(0, 0, 10, 20);
            pnlChartsContainer.Size = new Size(1360, 560);
            pnlChartsContainer.TabIndex = 1;
            // 
            // pnlChart2
            // 
            pnlChart2.BackColor = Color.White;
            pnlChart2.Controls.Add(lblChart2Title);
            pnlChart2.Dock = DockStyle.Fill;
            pnlChart2.Location = new Point(530, 0);
            pnlChart2.Name = "pnlChart2";
            pnlChart2.Padding = new Padding(20);
            pnlChart2.Size = new Size(820, 540);
            pnlChart2.TabIndex = 1;
            // 
            // lblChart2Title
            // 
            lblChart2Title.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChart2Title.ForeColor = Color.FromArgb(51, 51, 51);
            lblChart2Title.Location = new Point(20, 20);
            lblChart2Title.Name = "lblChart2Title";
            lblChart2Title.Size = new Size(490, 30);
            lblChart2Title.TabIndex = 0;
            lblChart2Title.Text = "Sales by Category";
            // 
            // pnlChart1
            // 
            pnlChart1.BackColor = Color.White;
            pnlChart1.Controls.Add(lblChart1Title);
            pnlChart1.Dock = DockStyle.Left;
            pnlChart1.Location = new Point(0, 0);
            pnlChart1.Name = "pnlChart1";
            pnlChart1.Padding = new Padding(20);
            pnlChart1.Size = new Size(530, 540);
            pnlChart1.TabIndex = 0;
            // 
            // lblChart1Title
            // 
            lblChart1Title.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChart1Title.ForeColor = Color.FromArgb(51, 51, 51);
            lblChart1Title.Location = new Point(20, 20);
            lblChart1Title.Name = "lblChart1Title";
            lblChart1Title.Size = new Size(490, 30);
            lblChart1Title.TabIndex = 0;
            lblChart1Title.Text = "Monthly Sales Trend";
            // 
            // pnlRecentActivity
            // 
            pnlRecentActivity.BackColor = Color.White;
            pnlRecentActivity.Controls.Add(lstRecentActivity);
            pnlRecentActivity.Controls.Add(lblRecentActivityTitle);
            pnlRecentActivity.Dock = DockStyle.Bottom;
            pnlRecentActivity.Location = new Point(0, 560);
            pnlRecentActivity.Name = "pnlRecentActivity";
            pnlRecentActivity.Padding = new Padding(20);
            pnlRecentActivity.Size = new Size(1360, 200);
            pnlRecentActivity.TabIndex = 2;
            // 
            // lstRecentActivity
            // 
            lstRecentActivity.BorderStyle = BorderStyle.None;
            lstRecentActivity.Dock = DockStyle.Fill;
            lstRecentActivity.Font = new Font("Segoe UI", 9F);
            lstRecentActivity.FormattingEnabled = true;
            lstRecentActivity.Location = new Point(20, 50);
            lstRecentActivity.Name = "lstRecentActivity";
            lstRecentActivity.Size = new Size(1320, 130);
            lstRecentActivity.TabIndex = 1;
            // 
            // lblRecentActivityTitle
            // 
            lblRecentActivityTitle.Dock = DockStyle.Top;
            lblRecentActivityTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecentActivityTitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblRecentActivityTitle.Location = new Point(20, 20);
            lblRecentActivityTitle.Name = "lblRecentActivityTitle";
            lblRecentActivityTitle.Size = new Size(1320, 30);
            lblRecentActivityTitle.TabIndex = 0;
            lblRecentActivityTitle.Text = "Recent Activity";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 247);
            ClientSize = new Size(1400, 800);
            Controls.Add(pnlMainContainer);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1200, 600);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - MyApp";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            pnlMainContainer.ResumeLayout(false);
            pnlTopNavigation.ResumeLayout(false);
            pnlContentArea.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlProfileCard.ResumeLayout(false);
            pnlQuickActions.ResumeLayout(false);
            pnlMainContent.ResumeLayout(false);
            pnlStatsContainer.ResumeLayout(false);
            pnlStat4.ResumeLayout(false);
            pnlStat3.ResumeLayout(false);
            pnlStat2.ResumeLayout(false);
            pnlStat1.ResumeLayout(false);
            pnlChartsContainer.ResumeLayout(false);
            pnlChart2.ResumeLayout(false);
            pnlChart1.ResumeLayout(false);
            pnlRecentActivity.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private Panel pnlMainContainer;
        private Panel pnlTopNavigation;
        private Panel pnlContentArea;
        private Label lblAppTitle;
        private Button btnDashboard;
        private Button btnOrders;
        private Button btnCustomers;
        private Button btnReports;
        private Button btnSettings;
        private Button btnProfile;
        private Button btnLogout;
        private Panel pnlMainContent;
        private Panel pnlSidebar;
        private Panel pnlStatsContainer;
        private Panel pnlStat1;
        private Label lblStat1Title;
        private Label lblStat1Value;
        private Panel pnlStat2;
        private Label lblStat2Value;
        private Label lblStat2Title;
        private Panel pnlStat3;
        private Label lblStat3Value;
        private Label lblStat3Title;
        private Panel pnlStat4;
        private Label lblStat4Value;
        private Label lblStat4Title;
        private Panel pnlChartsContainer;
        private Panel pnlChart1;
        private Label lblChart1Title;
        private Panel pnlChart2;
        private Label lblChart2Title;
        private Panel pnlRecentActivity;
        private Label lblRecentActivityTitle;
        private ListBox lstRecentActivity;
        private Panel pnlQuickActions;
        private Label lblQuickActionsTitle;
        private Button btnQuickAction1;
        private Button btnQuickAction2;
        private Button btnQuickAction3;
        private Panel pnlProfileCard;
        private Label lblProfileTitle;
        private Label lblProfileName;
        private Label lblProfileRole;
        private Button btnQuickAction4;
        private Button btnQuickAction5;
        }
    }