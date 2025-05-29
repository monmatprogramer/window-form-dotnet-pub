using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using window_form_dotnet.Common;

namespace window_form_dotnet
    {
    public partial class DashboardForm : Form
        {
        private System.Windows.Forms.Timer activityTimer;
        private Random random = new Random();
        private string currentUsername;
        private string currentUserRole;

        public DashboardForm()
            {
            InitializeComponent();
            InitializeFormStyle();
            SetupActivityTimer();
            }

        public DashboardForm(string username, string userRole) : this()
            {
            currentUsername = username;
            currentUserRole = userRole;
            // Immediately update the profile display
            UpdateUserProfile(username, userRole);
            }

        private void InitializeFormStyle()
            {
            // Apply modern styling to cards
            ApplyCardStyling();

            // Set form properties
            this.Font = new Font("Segoe UI", 9F);

            // Apply hover effects to navigation buttons
            ApplyNavigationHoverEffects();

            // Apply hover effects to quick action buttons
            ApplyQuickActionHoverEffects();
            }

        private void ApplyCardStyling()
            {
            // Apply card styling to stat panels
            ApplyCardShadow(pnlStat1);
            ApplyCardShadow(pnlStat2);
            ApplyCardShadow(pnlStat3);
            ApplyCardShadow(pnlStat4);

            // Apply card styling to chart panels
            ApplyCardShadow(pnlChart1);
            ApplyCardShadow(pnlChart2);

            // Apply card styling to sidebar panels
            ApplyCardShadow(pnlQuickActions);
            ApplyCardShadow(pnlProfileCard);
            ApplyCardShadow(pnlRecentActivity);

            // Apply card styling to navigation
            ApplyCardShadow(pnlTopNavigation);
            }

        private void ApplyCardShadow(Panel panel)
            {
            panel.Paint += (s, e) =>
            {
                // Create subtle border effect
                using (Pen borderPen = new Pen(Color.FromArgb(20, 0, 0, 0), 1))
                    {
                    Rectangle borderRect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                    e.Graphics.DrawRectangle(borderPen, borderRect);
                    }

                // Add subtle inner highlight
                using (Pen highlightPen = new Pen(Color.FromArgb(10, 255, 255, 255), 1))
                    {
                    Rectangle highlightRect = new Rectangle(1, 1, panel.Width - 3, panel.Height - 3);
                    e.Graphics.DrawRectangle(highlightPen, highlightRect);
                    }
            };
            }

        private void ApplyNavigationHoverEffects()
            {
            Button[] navButtons = { btnDashboard, btnOrders, btnCustomers, btnReports, btnSettings, btnProfile };

            foreach (Button btn in navButtons)
                {
                btn.MouseEnter += NavButton_MouseEnter;
                btn.MouseLeave += NavButton_MouseLeave;
                }
            }

        private void ApplyQuickActionHoverEffects()
            {
            Button[] quickButtons = { btnQuickAction1, btnQuickAction2, btnQuickAction3 };

            foreach (Button btn in quickButtons)
                {
                btn.MouseEnter += QuickButton_MouseEnter;
                btn.MouseLeave += QuickButton_MouseLeave;
                }
            }

        private void SetupActivityTimer()
            {
            activityTimer = new System.Windows.Forms.Timer();
            activityTimer.Interval = 5000; // Update every 5 seconds
            activityTimer.Tick += ActivityTimer_Tick;
            activityTimer.Start();
            }

        // The error CS0111 indicates that there are two methods with the same name and parameter types in the same class.
        // To fix this, we need to ensure that there is only one `DashboardForm_Load` method in the `DashboardForm` class.
        // Below is the corrected code where the duplicate method is removed.

        private void DashboardForm_Load(object sender, EventArgs e)
            {
            LoadSampleData();
            LoadRecentActivity();
            if (!string.IsNullOrEmpty(currentUsername))
                {
                lblProfileName.Text = currentUsername;
                lblProfileRole.Text = currentUserRole ?? "User";
                // Update the welcome message or any other UI elements
                lblAppTitle.Text = $"MyApp - Welcome {currentUsername}!";
                }
                // Set initial focus
                this.Focus();
            }

        private void LoadSampleData()
            {
            // Load sample statistics (replace with actual data from your MySQL database)
            lblStat1Value.Text = "1,247";
            lblStat1Title.Text = "Total Customers";

            lblStat2Value.Text = "23";
            lblStat2Title.Text = "Pending Orders";

            lblStat3Value.Text = "$125,420";
            lblStat3Title.Text = "Monthly Revenue";

            lblStat4Value.Text = "98.5%";
            lblStat4Title.Text = "Customer Satisfaction";

            // Load user profile data (replace with actual user data)
            lblProfileName.Text = "John Doe";
            lblProfileRole.Text = "Administrator";

            // Add sample chart placeholders
            AddChartPlaceholders();
            }

        private void AddChartPlaceholders()
            {
            // Add placeholder graphics for charts
            pnlChart1.Paint += (s, e) =>
            {
                if (pnlChart1.Width > 40 && pnlChart1.Height > 80)
                    {
                    DrawSampleChart(e.Graphics, new Rectangle(20, 60, pnlChart1.Width - 40, pnlChart1.Height - 80));
                    }
            };

            pnlChart2.Paint += (s, e) =>
            {
                if (pnlChart2.Width > 40 && pnlChart2.Height > 80)
                    {
                    DrawSamplePieChart(e.Graphics, new Rectangle(20, 60, pnlChart2.Width - 40, pnlChart2.Height - 80));
                    }
            };
            }

        private void DrawSampleChart(Graphics g, Rectangle rect)
            {
            using (Pen linePen = new Pen(Color.FromArgb(64, 123, 255), 3))
                {
                Point[] points = new Point[10];
                for (int i = 0; i < 10; i++)
                    {
                    int x = rect.X + (i * rect.Width / 9);
                    int y = rect.Y + random.Next(rect.Height / 4, rect.Height * 3 / 4);
                    points[i] = new Point(x, y);
                    }
                if (points.Length > 1)
                    g.DrawLines(linePen, points);
                }
            }

        private void DrawSamplePieChart(Graphics g, Rectangle rect)
            {
            Color[] colors = {
                Color.FromArgb(64, 123, 255),
                Color.FromArgb(40, 167, 69),
                Color.FromArgb(255, 193, 7),
                Color.FromArgb(220, 53, 69)
            };

            float[] angles = { 90f, 120f, 80f, 70f };
            float startAngle = 0f;

            Rectangle pieRect = new Rectangle(
                rect.X + rect.Width / 4,
                rect.Y + rect.Height / 4,
                rect.Width / 2,
                rect.Height / 2
            );

            for (int i = 0; i < angles.Length; i++)
                {
                using (SolidBrush brush = new SolidBrush(colors[i]))
                    {
                    g.FillPie(brush, pieRect, startAngle, angles[i]);
                    startAngle += angles[i];
                    }
                }
            }

        private void LoadRecentActivity()
            {
            // Load sample recent activity data
            lstRecentActivity.Items.Clear();
            string[] activities = {
                "New customer registered: Sarah Johnson",
                "Order #12345 completed successfully",
                "Payment received from CustomerCorp",
                "Product inventory updated",
                "New order placed by John Smith",
                "Customer support ticket resolved",
                "Monthly report generated",
                "System backup completed"
            };

            foreach (string activity in activities)
                {
                lstRecentActivity.Items.Add($"[{DateTime.Now.AddMinutes(-random.Next(1, 120)):HH:mm}] {activity}");
                }
            }

        // Event Handlers
        private void NavButton_Click(object sender, EventArgs e)
            {
            // Reset all navigation buttons
            Button[] navButtons = { btnDashboard, btnOrders, btnCustomers, btnReports, btnSettings, btnProfile };

            foreach (Button btn in navButtons)
                {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(64, 123, 255);
                btn.Font = new Font("Segoe UI", 9F);
                }

            // Highlight selected button
            if (sender is Button clickedButton)
                {
                clickedButton.BackColor = Color.FromArgb(64, 123, 255);
                clickedButton.ForeColor = Color.White;
                clickedButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                // Handle navigation based on button clicked
                HandleNavigation(clickedButton.Text);
                }
            }

        private void HandleNavigation(string section)
            {
            switch (section.ToLower())
                {
                case "dashboard":
                    // Already on dashboard
                    break;
                case "orders":
                    MessageBox.Show("Orders section would open here.\n\nThis would typically show:\n- Order management interface\n- Order history\n- Order processing tools",
                                  "Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "customers":
                    MessageBox.Show("Customers section would open here.\n\nThis would typically show:\n- Customer database\n- Customer profiles\n- Customer management tools",
                                  "Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "reports":
                    MessageBox.Show("Reports section would open here.\n\nThis would typically show:\n- Analytics dashboard\n- Generated reports\n- Report builder",
                                  "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "settings":
                    MessageBox.Show("Settings section would open here.\n\nThis would typically show:\n- Application settings\n- User preferences\n- System configuration",
                                  "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "profile":
                    MessageBox.Show("Profile section would open here.\n\nThis would typically show:\n- User profile editor\n- Account settings\n- Security options",
                                  "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

        private void QuickAction_Click(object sender, EventArgs e)
            {
            if (sender is Button button)
                {
                switch (button.Text)
                    {
                    case "Add New Customer":
                        
                        var addCustomerForm = new NewCustomerForm();
                        addCustomerForm.Show();
                        this.Hide();
                        break;
                    case "Manage Orders":
                        MessageBox.Show("Order Management interface would open here.\n\nThis would allow you to:\n- View pending orders\n- Update order status\n- Process payments",
                                      "Manage Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Generate Report":
                        MessageBox.Show("Report Generator would open here.\n\nThis would allow you to:\n- Select report type\n- Choose date range\n- Generate PDF/Excel reports",
                                      "Generate Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }

        private void BtnLogout_Click(object sender, EventArgs e)
            {
            var result = MessageBox.Show("Are you sure you want to logout?",
                                       "Confirm Logout",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                {
                // Stop the activity timer
                if (activityTimer != null)
                    {
                    activityTimer.Stop();
                    activityTimer.Dispose();
                    }

                // Show login form
                var loginForm = new LoginForm();
                loginForm.Show();

                // Close dashboard
                this.Hide();
                }
            }

        // Hover Effects
        private void NavButton_MouseEnter(object sender, EventArgs e)
            {
            if (sender is Button button && button.BackColor == Color.Transparent)
                {
                button.BackColor = Color.FromArgb(230, 240, 255);
                }
            }

        private void NavButton_MouseLeave(object sender, EventArgs e)
            {
            if (sender is Button button && button.BackColor != Color.FromArgb(64, 123, 255))
                {
                button.BackColor = Color.Transparent;
                }
            }

        private void QuickButton_MouseEnter(object sender, EventArgs e)
            {
            if (sender is Button button)
                {
                // Slightly darken the button on hover
                Color originalColor = button.BackColor;
                int r = Math.Max(0, originalColor.R - 20);
                int g = Math.Max(0, originalColor.G - 20);
                int b = Math.Max(0, originalColor.B - 20);
                button.BackColor = Color.FromArgb(r, g, b);
                }
            }

        private void QuickButton_MouseLeave(object sender, EventArgs e)
            {
            if (sender == btnQuickAction1)
                btnQuickAction1.BackColor = Color.FromArgb(64, 123, 255);
            else if (sender == btnQuickAction2)
                btnQuickAction2.BackColor = Color.FromArgb(255, 193, 7);
            else if (sender == btnQuickAction3)
                btnQuickAction3.BackColor = Color.FromArgb(40, 167, 69);
            }

        // Activity Timer
        private void ActivityTimer_Tick(object sender, EventArgs e)
            {
            // Simulate new activity
            string[] newActivities = {
                "System health check completed",
                "Database backup successful",
                "New notification received",
                "User session updated",
                "Cache cleared successfully"
            };

            string newActivity = $"[{DateTime.Now:HH:mm}] {newActivities[random.Next(newActivities.Length)]}";
            lstRecentActivity.Items.Insert(0, newActivity);

            // Keep only last 10 activities
            while (lstRecentActivity.Items.Count > 10)
                {
                lstRecentActivity.Items.RemoveAt(lstRecentActivity.Items.Count - 1);
                }
            }

        // Public methods for external access
        public void UpdateUserProfile(string name, string role)
            {
            lblProfileName.Text = name;
            lblProfileRole.Text = role;
            }

        public void UpdateStatistics(int customers, int pendingOrders, decimal revenue, double satisfaction)
            {
            lblStat1Value.Text = customers.ToString("N0");
            lblStat2Value.Text = pendingOrders.ToString();
            lblStat3Value.Text = revenue.ToString("C0");
            lblStat4Value.Text = satisfaction.ToString("P1");
            }

        public void AddActivity(string activity)
            {
            string formattedActivity = $"[{DateTime.Now:HH:mm}] {activity}";
            lstRecentActivity.Items.Insert(0, formattedActivity);

            while (lstRecentActivity.Items.Count > 10)
                {
                lstRecentActivity.Items.RemoveAt(lstRecentActivity.Items.Count - 1);
                }
            }

        // Form lifecycle
        protected override void OnFormClosing(FormClosingEventArgs e)
            {
            if (e.CloseReason == CloseReason.UserClosing)
                {
                var result = MessageBox.Show("Are you sure you want to exit the application?",
                                           "Confirm Exit",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    {
                    e.Cancel = true;
                    return;
                    }

                // Stop timer before closing
                if (activityTimer != null)
                    {
                    activityTimer.Stop();
                    activityTimer.Dispose();
                    }

                Application.Exit();
                }

            base.OnFormClosing(e);
            }

        // Handle window state changes
        protected override void OnResize(EventArgs e)
            {
            base.OnResize(e);

            // Refresh chart drawings when form is resized
            pnlChart1.Invalidate();
            pnlChart2.Invalidate();
            }
        }
    }