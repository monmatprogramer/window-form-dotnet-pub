using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using window_form_dotnet.Common;

namespace window_form_dotnet
    {
    public partial class DashboardForm : Form
        {
        // Fix for CS0191: A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)
        // Solution: Remove the `readonly` modifier from the `activityTimer` field declaration.
        private System.Windows.Forms.Timer activityTimer;
        // Change the declaration of the `animationTimer` field to remove the `readonly` modifier
        private System.Windows.Forms.Timer animationTimer;
        private readonly Random random = new Random();
        private string currentUsername;
        private string currentUserRole;
        private readonly ToolTip helpToolTip = new ToolTip
            {
            InitialDelay = 500,
            ReshowDelay = 100,
            AutoPopDelay = 5000,
            ShowAlways = true,
            IsBalloon = true,
            ToolTipIcon = ToolTipIcon.Info,
            ToolTipTitle = "Help Guide"
            };
       
        //private readonly Button btnHelp; // This declaration is retained, and any duplicate is removed.
        private bool isHelpModeActive = false;
        private int animationStep = 0;
        // Fix for CS0103: The name 'btnHelp' does not exist in the current context
        // Ensure that the `btnHelp` field is declared as a class-level variable.

        private Button btnHelp; // Add this declaration at the class level

        // Update the constructor to initialize the `animationTimer` field
        public DashboardForm()
            {
            InitializeComponent();
            InitializeHelpSystem();
            InitializeFormStyle();
            SetupActivityTimer();
            SetupAnimationTimer(); // This method initializes the `animationTimer`
            AddHelpButton();
            }

        public DashboardForm(string username, string userRole) : this()
            {
            currentUsername = username;
            currentUserRole = userRole;
            UpdateUserProfile(username, userRole);
            }

        private void InitializeHelpSystem()
            {
            // Initialize ToolTip component
            // Removed reassignment to readonly field 'helpToolTip' and directly used the existing field.
            SetupTooltips();
            }

        private void SetupTooltips()
            {
            // Navigation buttons tooltips
            helpToolTip.SetToolTip(btnDashboard, "🏠 Dashboard: View your main overview with key metrics and recent activity");
            helpToolTip.SetToolTip(btnOrders, "📦 Orders: Manage customer orders, track status, and process payments");
            helpToolTip.SetToolTip(btnCustomers, "👥 Customers: View and manage customer database and profiles");
            helpToolTip.SetToolTip(btnReports, "📊 Reports: Generate analytics, view insights, and export reports");
            helpToolTip.SetToolTip(btnSettings, "⚙️ Settings: Configure application preferences and system settings");
            helpToolTip.SetToolTip(btnProfile, "👤 Profile: Manage your user profile and account settings");
            helpToolTip.SetToolTip(btnAboutMe, "ℹ️ About: Learn more about the application and developer");
            helpToolTip.SetToolTip(btnLogout, "🚪 Logout: Safely sign out of your account");

            // Quick action buttons tooltips
            helpToolTip.SetToolTip(btnQuickAction1, "➕ Add Customer: Quickly register a new customer to your database");
            helpToolTip.SetToolTip(btnQuickAction2, "📋 Manage Orders: Access order management tools and processing");
            helpToolTip.SetToolTip(btnQuickAction3, "📈 Generate Report: Create instant reports from your current data");
            helpToolTip.SetToolTip(btnQuickAction4, "🏷️ Add Product: Register new products to your inventory");
            helpToolTip.SetToolTip(btnQuickAction5, "🏢 Add Supplier: Add new suppliers to your business network");

            // Stats panels tooltips
            helpToolTip.SetToolTip(pnlStat1, "📈 Total customer count in your database - Track growth over time");
            helpToolTip.SetToolTip(pnlStat2, "⏳ Orders awaiting processing - Requires immediate attention");
            helpToolTip.SetToolTip(pnlStat3, "💰 Revenue generated this month - Track financial performance");
            helpToolTip.SetToolTip(pnlStat4, "⭐ Customer satisfaction rating - Monitor service quality");

            // Chart panels tooltips
            helpToolTip.SetToolTip(pnlChart1, "📊 Monthly Sales Trend: Visual representation of sales performance over time");
            helpToolTip.SetToolTip(pnlChart2, "🥧 Sales by Category: Distribution of sales across different product categories");

            // Recent activity tooltip
            helpToolTip.SetToolTip(pnlRecentActivity, "🕒 Recent Activity: Live feed of system events and user actions");
            }

        private void AddHelpButton()
            {
            // Create help button
            btnHelp = new Button
                {
                Text = "?",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Size = new Size(40, 40),
                BackColor = Color.FromArgb(255, 193, 7),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(850, 15),
                Cursor = Cursors.Help,
                Name = "btnHelp"
                };

            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.Click += BtnHelp_Click;

            // Add modern rounded appearance
            btnHelp.Paint += (s, e) =>
            {
                var path = new GraphicsPath();
                path.AddEllipse(0, 0, btnHelp.Width - 1, btnHelp.Height - 1);
                btnHelp.Region = new Region(path);
            };

            // Add hover effect
            btnHelp.MouseEnter += (s, e) =>
            {
                btnHelp.BackColor = Color.FromArgb(255, 206, 84);
                btnHelp.Transform(1.1f);
            };

            btnHelp.MouseLeave += (s, e) =>
            {
                btnHelp.BackColor = Color.FromArgb(255, 193, 7);
                btnHelp.Transform(1.0f);
            };

            //pnlTopNavigation.Controls.Add(btnHelp);
            helpToolTip.SetToolTip(btnHelp, "❓ Help: Click to toggle help mode or access user guide");
            }

        // Fix for CS0111: Remove the duplicate definition of BtnHelp_Click method.
        // The existing BtnHelp_Click method is already defined in the class, so we need to remove the redundant one.

        //private void BtnHelp_Click(object sender, EventArgs e)
        //    {
        //    if (!isHelpModeActive)
        //        {
        //        ShowUserGuide();
        //        }
        //    else
        //        {
        //        ToggleHelpMode();
        //        }
        //    }

        private void ShowUserGuide()
            {
            var userGuideForm = new UserGuideForm();
            userGuideForm.ShowDialog(this);
            }

        private void ToggleHelpMode()
            {
            isHelpModeActive = !isHelpModeActive;

            if (isHelpModeActive)
                {
                btnHelp.BackColor = Color.FromArgb(40, 167, 69);
                btnHelp.Text = "✓";
                ShowHelpOverlay();
                }
            else
                {
                btnHelp.BackColor = Color.FromArgb(255, 193, 7);
                btnHelp.Text = "?";
                HideHelpOverlay();
                }
            }

        private void ShowHelpOverlay()
            {
            // Add pulsing animation to important elements
            animationTimer.Start();

            // Show contextual help message
            var helpMessage = new Form
                {
                Text = "Help Mode Active",
                Size = new Size(300, 100),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White
                };

            var label = new Label
                {
                Text = "Help mode is now active!\nHover over any element to see detailed help.",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F)
                };

            helpMessage.Controls.Add(label);

            var timer = new System.Windows.Forms.Timer { Interval = 3000 };
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                helpMessage.Close();
            };
            timer.Start();

            helpMessage.Show();
            }

        private void HideHelpOverlay()
            {
            animationTimer.Stop();
            // Reset any visual help indicators
            }

        private void SetupAnimationTimer()
            {
            animationTimer = new System.Windows.Forms.Timer
                {
                Interval = 100
                };
            animationTimer.Tick += AnimationTimer_Tick;
            }

        private void AnimationTimer_Tick(object sender, EventArgs e)
            {
            animationStep++;

            if (isHelpModeActive)
                {
                // Add subtle pulsing effect to interactive elements
                var alpha = (int)(128 + 127 * Math.Sin(animationStep * 0.1));
                // Apply pulsing effect to help-enabled controls
                }
            }

        private void InitializeFormStyle()
            {
            ApplyCardStyling();
            this.Font = new Font("Segoe UI", 9F);
            ApplyNavigationHoverEffects();
            ApplyQuickActionHoverEffects();
            ApplyModernStyling();
            }

        private void ApplyModernStyling()
            {
            // Add gradient background to main container
            pnlMainContainer.Paint += (s, e) =>
            {
                using (var brush = new LinearGradientBrush(
                    pnlMainContainer.ClientRectangle,
                    Color.FromArgb(240, 242, 247),
                    Color.FromArgb(250, 252, 255),
                    LinearGradientMode.Vertical))
                    {
                    e.Graphics.FillRectangle(brush, pnlMainContainer.ClientRectangle);
                    }
            };

            // Modern navigation styling
            pnlTopNavigation.Paint += (s, e) =>
            {
                using (var brush = new LinearGradientBrush(
                    pnlTopNavigation.ClientRectangle,
                    Color.White,
                    Color.FromArgb(248, 249, 250),
                    LinearGradientMode.Vertical))
                    {
                    e.Graphics.FillRectangle(brush, pnlTopNavigation.ClientRectangle);
                    }

                // Add bottom border
                using (var pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                    {
                    e.Graphics.DrawLine(pen, 0, pnlTopNavigation.Height - 1,
                        pnlTopNavigation.Width, pnlTopNavigation.Height - 1);
                    }
            };
            }

        private void ApplyCardStyling()
            {
            ApplyModernCardShadow(pnlStat1);
            ApplyModernCardShadow(pnlStat2);
            ApplyModernCardShadow(pnlStat3);
            ApplyModernCardShadow(pnlStat4);
            ApplyModernCardShadow(pnlChart1);
            ApplyModernCardShadow(pnlChart2);
            ApplyModernCardShadow(pnlQuickActions);
            ApplyModernCardShadow(pnlProfileCard);
            ApplyModernCardShadow(pnlRecentActivity);
            }

        private void ApplyModernCardShadow(Panel panel)
            {
            panel.Paint += (s, e) =>
            {
                // Modern card shadow effect
                var graphics = e.Graphics;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw shadow
                using (var shadowBrush = new SolidBrush(Color.FromArgb(15, 0, 0, 0)))
                    {
                    var shadowRect = new Rectangle(2, 2, panel.Width - 2, panel.Height - 2);
                    graphics.FillRectangle(shadowBrush, shadowRect);
                    }

                // Draw card background
                using (var cardBrush = new SolidBrush(Color.White))
                    {
                    var cardRect = new Rectangle(0, 0, panel.Width - 2, panel.Height - 2);
                    graphics.FillRectangle(cardBrush, cardRect);
                    }

                // Add subtle border
                using (var borderPen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
                    {
                    var borderRect = new Rectangle(0, 0, panel.Width - 3, panel.Height - 3);
                    graphics.DrawRectangle(borderPen, borderRect);
                    }
            };
            }

        private void ApplyNavigationHoverEffects()
            {
            Button[] navButtons = { btnDashboard, btnOrders, btnCustomers, btnReports, btnSettings, btnProfile, btnAboutMe };

            foreach (Button btn in navButtons)
                {
                btn.MouseEnter += NavButton_MouseEnter;
                btn.MouseLeave += NavButton_MouseLeave;

                // Add smooth transition effect
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 240, 255);
                }
            }

        private void ApplyQuickActionHoverEffects()
            {
            Button[] quickButtons = { btnQuickAction1, btnQuickAction2, btnQuickAction3, btnQuickAction4, btnQuickAction5 };

            foreach (Button btn in quickButtons)
                {
                btn.MouseEnter += QuickButton_MouseEnter;
                btn.MouseLeave += QuickButton_MouseLeave;

                // Add modern button styling
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
                }
            }

        // Fix for IDE0017: Object initialization can be simplified
        // Solution: Use object initializer syntax to simplify the initialization of `activityTimer`.
        private void SetupActivityTimer()
            {
            activityTimer = new System.Windows.Forms.Timer
                {
                Interval = 5000
                };
            activityTimer.Tick += ActivityTimer_Tick;
            activityTimer.Start();
            }

        private void DashboardForm_Load(object sender, EventArgs e)
            {
            LoadSampleData();
            LoadRecentActivity();
            if (!string.IsNullOrEmpty(currentUsername))
                {
                lblProfileName.Text = currentUsername;
                lblProfileRole.Text = currentUserRole ?? "User";
                lblAppTitle.Text = $"MyApp - Welcome {currentUsername}!";
                }
            this.Focus();

            // Show welcome tooltip
            ShowWelcomeMessage();
            }

        private void ShowWelcomeMessage()
            {
            var timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                helpToolTip.Show("💡 Tip: Click the ? button for help or hover over any element for guidance!",
                    btnHelp, 0, -30, 4000);
            };
            timer.Start();
            }

        // Rest of the existing methods remain the same...
        private void LoadSampleData()
            {
            lblStat1Value.Text = "1,247";
            lblStat1Title.Text = "Total Customers";
            lblStat2Value.Text = "23";
            lblStat2Title.Text = "Pending Orders";
            lblStat3Value.Text = "$125,420";
            lblStat3Title.Text = "Monthly Revenue";
            lblStat4Value.Text = "98.5%";
            lblStat4Title.Text = "Customer Satisfaction";
            lblProfileName.Text = "John Doe";
            lblProfileRole.Text = "Administrator";
            AddChartPlaceholders();
            }

        private void AddChartPlaceholders()
            {
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
            g.SmoothingMode = SmoothingMode.AntiAlias;
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
            g.SmoothingMode = SmoothingMode.AntiAlias;
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
            Button[] navButtons = { btnDashboard, btnOrders, btnCustomers, btnReports, btnSettings, btnProfile, btnAboutMe };

            foreach (Button btn in navButtons)
                {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(64, 123, 255);
                btn.Font = new Font("Segoe UI", 9F);
                }

            if (sender is Button clickedButton)
                {
                clickedButton.BackColor = Color.FromArgb(64, 123, 255);
                clickedButton.ForeColor = Color.White;
                clickedButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                HandleNavigation(clickedButton.Text);
                }
            }

        private void HandleNavigation(string section)
            {
            switch (section.ToLower())
                {
                case "dashboard":
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
                    MessageBox.Show("Profile section would open here.\n\nThis would typically show:\n- User profile editor\n- Account settings\n- Security options");
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
                    case "Add New Product":
                        var addProductForm = new NewProductForm();
                        addProductForm.Show();
                        this.Hide();
                        break;
                    case "Add New Supplier":
                        var addNewSupplier = new NewSupplierForm();
                        addNewSupplier.Show();
                        this.Hide();
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
                if (activityTimer != null)
                    {
                    activityTimer.Stop();
                    activityTimer.Dispose();
                    }

                if (animationTimer != null)
                    {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                    }

                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                }
            }

        // Hover Effects
        private void NavButton_MouseEnter(object sender, EventArgs e)
            {
            if (sender is Button button && button.BackColor == Color.Transparent)
                {
                button.BackColor = Color.FromArgb(230, 240, 255);
                button.Transform(1.05f);
                }
            }

        private void NavButton_MouseLeave(object sender, EventArgs e)
            {
            if (sender is Button button && button.BackColor != Color.FromArgb(64, 123, 255))
                {
                button.BackColor = Color.Transparent;
                button.Transform(1.0f);
                }
            }

        private void QuickButton_MouseEnter(object sender, EventArgs e)
            {
            if (sender is Button button)
                {
                Color originalColor = button.BackColor;
                int r = Math.Max(0, originalColor.R - 20);
                int g = Math.Max(0, originalColor.G - 20);
                int b = Math.Max(0, originalColor.B - 20);
                button.BackColor = Color.FromArgb(r, g, b);
                button.Transform(1.05f);
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
            else if (sender == btnQuickAction4)
                btnQuickAction4.BackColor = Color.FromArgb(255, 128, 255);
            else if (sender == btnQuickAction5)
                btnQuickAction5.BackColor = Color.FromArgb(255, 192, 128);

            if (sender is Button button)
                button.Transform(1.0f);
            }

        private void ActivityTimer_Tick(object sender, EventArgs e)
            {
            string[] newActivities = {
                "System health check completed",
                "Database backup successful",
                "New notification received",
                "User session updated",
                "Cache cleared successfully"
            };

            string newActivity = $"[{DateTime.Now:HH:mm}] {newActivities[random.Next(newActivities.Length)]}";
            lstRecentActivity.Items.Insert(0, newActivity);

            while (lstRecentActivity.Items.Count > 10)
                {
                lstRecentActivity.Items.RemoveAt(lstRecentActivity.Items.Count - 1);
                }
            }

        // Public methods
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

                if (activityTimer != null)
                    {
                    activityTimer.Stop();
                    activityTimer.Dispose();
                    }

                if (animationTimer != null)
                    {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                    }

                Application.Exit();
                }

            base.OnFormClosing(e);
            }

        protected override void OnResize(EventArgs e)
            {
            base.OnResize(e);
            pnlChart1.Invalidate();
            pnlChart2.Invalidate();
            }

        private void btnAboutMe_Click(object sender, EventArgs e)
            {
            using (var aboutForm = new AboutMeForm())
                {
                Form overlay = new Form
                    {
                    StartPosition = FormStartPosition.Manual,
                    FormBorderStyle = FormBorderStyle.None,
                    Opacity = 0.5,
                    BackColor = Color.Black,
                    WindowState = FormWindowState.Maximized,
                    TopMost = true,
                    Location = this.Location,
                    ShowInTaskbar = false
                    };

                overlay.Show(this);
                aboutForm.Owner = overlay;
                aboutForm.TopMost = true;
                aboutForm.ShowDialog();
                overlay.Close();
                overlay.Dispose();
                }
            }
        }

    // Extension method for smooth transforms
    public static class ControlExtensions
        {
        public static void Transform(this Control control, float scale)
            {
            if (scale == 1.0f) return;

            // Use the control's current size directly instead of assuming a 'Value' property
            var originalSize = control.Tag as Size? ?? control.Size;
            if (control.Tag == null) control.Tag = control.Size;

            int newWidth = (int)(originalSize.Width * scale); // Corrected to use 'Width' directly
            int newHeight = (int)(originalSize.Height * scale); // Corrected to use 'Height' directly

            control.Size = new Size(newWidth, newHeight);
            }
        }
    }