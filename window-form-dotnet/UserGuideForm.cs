using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace window_form_dotnet
    {
    public partial class UserGuideForm : Form
        {
        private TabControl tabControl;
        private Button btnClose;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        public UserGuideForm()
            {
            InitializeComponent(); // Ensure this method is defined only once.
            SetupUserGuide();
            }

        //private void InitializeComponent()
        //    {
        //    this.SuspendLayout();

        //    // Form properties
        //    this.AutoScaleDimensions = new SizeF(8F, 20F);
        //    this.AutoScaleMode = AutoScaleMode.Font;
        //    this.ClientSize = new Size(800, 600);
        //    this.Font = new Font("Segoe UI", 9F);
        //    this.FormBorderStyle = FormBorderStyle.FixedDialog;
        //    this.MaximizeBox = false;
        //    this.MinimizeBox = false;
        //    this.Name = "UserGuideForm";
        //    this.StartPosition = FormStartPosition.CenterParent;
        //    this.Text = "User Guide - MyApp";
        //    this.BackColor = Color.FromArgb(248, 249, 250);

        //    this.ResumeLayout(false);
        //    }

        private void SetupUserGuide()
            {
            // Header Panel
            pnlHeader = new Panel
                {
                Height = 80,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(64, 123, 255)
                };

            pnlHeader.Paint += (s, e) =>
            {
                using (var brush = new LinearGradientBrush(
                    pnlHeader.ClientRectangle,
                    Color.FromArgb(64, 123, 255),
                    Color.FromArgb(84, 143, 255),
                    LinearGradientMode.Horizontal))
                    {
                    e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
                    }
            };

            lblTitle = new Label
                {
                Text = "📚 User Guide",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 15),
                AutoSize = true
                };

            lblSubtitle = new Label
                {
                Text = "Complete guide to using MyApp dashboard effectively",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(220, 230, 255),
                Location = new Point(20, 45),
                AutoSize = true
                };

            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            // Close Button
            btnClose = new Button
                {
                Text = "✕",
                Size = new Size(40, 40),
                Location = new Point(740, 20),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Cursor = Cursors.Hand
                };

            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255, 30);
            btnClose.Click += (s, e) => this.Close();

            pnlHeader.Controls.Add(btnClose);

            // Tab Control
            tabControl = new TabControl
                {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F),
                Appearance = TabAppearance.FlatButtons,
                Margin = new Padding(10)
                };

            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += TabControl_DrawItem;

            // Add tabs
            CreateOverviewTab();
            CreateNavigationTab();
            CreateQuickActionsTab();
            CreateStatsTab();
            CreateTipsTab();
            CreateTroubleshootingTab();

            this.Controls.AddRange(new Control[] { pnlHeader, tabControl });
            }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
            {
            TabControl tabCtrl = sender as TabControl;
            string tabText = tabCtrl.TabPages[e.Index].Text;
            Font tabFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            Brush textBrush;

            Rectangle tabRect = e.Bounds;

            if (e.State == DrawItemState.Selected)
                {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 123, 255)), tabRect);
                textBrush = new SolidBrush(Color.White);
                }
            else
                {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(240, 242, 247)), tabRect);
                textBrush = new SolidBrush(Color.FromArgb(64, 123, 255));
                }

            StringFormat sf = new StringFormat
                {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
                };

            e.Graphics.DrawString(tabText, tabFont, textBrush, tabRect, sf);
            }

        private void CreateOverviewTab()
            {
            var tab = new TabPage("🏠 Overview");
            var panel = CreateScrollablePanel();

            var content = @"Welcome to MyApp Dashboard!

MyApp is your comprehensive business management solution that helps you:

• 📊 Monitor key business metrics in real-time
• 👥 Manage customers and their information
• 📦 Track and process orders efficiently  
• 📈 Generate detailed reports and analytics
• ⚙️ Customize settings to fit your workflow

GETTING STARTED:
1. Familiarize yourself with the navigation menu at the top
2. Use Quick Actions in the sidebar for common tasks
3. Monitor your statistics cards for business insights
4. Check Recent Activity for latest updates

The dashboard is designed to give you a complete overview of your business at a glance. Each section is interactive and provides detailed information when you hover over it.

💡 TIP: Look for the yellow help button (?) in the navigation bar for instant assistance!";

            var lblContent = CreateContentLabel(content);
            panel.Controls.Add(lblContent);
            tab.Controls.Add(panel);
            tabControl.TabPages.Add(tab);
            }

        private void CreateNavigationTab()
            {
            var tab = new TabPage("🧭 Navigation");
            var panel = CreateScrollablePanel();

            var content = @"NAVIGATION BAR GUIDE:

🏠 DASHBOARD
Your main control center showing overview of all activities

📦 ORDERS  
• View all customer orders
• Update order status
• Process payments
• Track delivery status

👥 CUSTOMERS
• Customer database management
• View customer profiles
• Update contact information
• Track customer history

📊 REPORTS
• Generate business analytics
• Export data to Excel/PDF
• View trend analysis
• Performance metrics

⚙️ SETTINGS
• Application preferences
• User account settings
• System configuration
• Backup and security

👤 PROFILE
• Edit your personal information
• Change password
• Account security settings
• Notification preferences

ℹ️ ABOUT ME
• Application information
• Developer contact
• Version details
• Support resources

🚪 LOGOUT
• Safely sign out of your account
• Clear session data
• Return to login screen

NAVIGATION TIPS:
• Active section is highlighted in blue
• Hover over buttons for additional information
• Use keyboard shortcuts when available
• Click the logo to return to dashboard quickly";

            var lblContent = CreateContentLabel(content);
            panel.Controls.Add(lblContent);
            tab.Controls.Add(panel);
            tabControl.TabPages.Add(tab);
            }

        private void CreateQuickActionsTab()
            {
            var tab = new TabPage("⚡ Quick Actions");
            var panel = CreateScrollablePanel();

            var content = @"QUICK ACTIONS SIDEBAR:

The Quick Actions panel provides instant access to frequently used features:

➕ ADD NEW CUSTOMER
• Quickly register new customers
• Fill in contact details
• Set customer preferences
• Add to mailing lists

📋 MANAGE ORDERS
• View pending orders
• Update order status
• Process refunds
• Track shipments

📈 GENERATE REPORT
• Create instant reports
• Choose from templates
• Export in multiple formats
• Schedule automatic reports

🏷️ ADD NEW PRODUCT
• Register new inventory items
• Set pricing and descriptions
• Upload product images
• Configure stock alerts

🏢 ADD NEW SUPPLIER
• Add business partners
• Store contact information
• Set payment terms
• Track supplier performance

USING QUICK ACTIONS:
1. Click any colored button to start
2. Follow the guided form process
3. Save changes automatically
4. Return to dashboard when complete

💡 PRO TIP: Quick Actions remember your last entries to speed up data entry!

COLOR CODING:
• Blue: Customer-related actions
• Yellow: Order management
• Green: Reports and analytics
• Purple: Product management
• Orange: Supplier operations";

            var lblContent = CreateContentLabel(content);
            panel.Controls.Add(lblContent);
            tab.Controls.Add(panel);
            tabControl.TabPages.Add(tab);
            }

        private void CreateStatsTab()
            {
            var tab = new TabPage("📊 Statistics");
            var panel = CreateScrollablePanel();

            var content = @"DASHBOARD STATISTICS EXPLAINED:

📈 TOTAL CUSTOMERS
• Shows complete customer database count
• Updates automatically with new registrations
• Click to view detailed customer analytics
• Green trend indicates growth

⏳ PENDING ORDERS  
• Orders awaiting processing
• Requires immediate attention
• Red color indicates urgency
• Click to access order management

💰 MONTHLY REVENUE
• Current month's income total
• Includes all completed transactions
• Updates in real-time
• Green indicates positive performance

⭐ CUSTOMER SATISFACTION
• Based on reviews and feedback
• Percentage of satisfied customers
• Yellow indicates good performance
• Target: Above 95%

CHART SECTIONS:

📊 MONTHLY SALES TREND
• Visual representation of sales over time
• Shows seasonal patterns
• Helps predict future performance
• Click and drag to zoom in

🥧 SALES BY CATEGORY
• Product category distribution
• Identifies top-performing products
• Helps with inventory planning
• Color-coded for easy reading

🕒 RECENT ACTIVITY
• Live feed of system events
• Shows user actions
• Updates every 5 seconds
• Scrollable history

INTERPRETING DATA:
• Green numbers = positive trends
• Red numbers = need attention
• Yellow = stable performance
• Hover for detailed explanations";

            var lblContent = CreateContentLabel(content);
            panel.Controls.Add(lblContent);
            tab.Controls.Add(panel);
            tabControl.TabPages.Add(tab);
            }

        private void CreateTipsTab()
            {
            var tab = new TabPage("💡 Tips & Tricks");
            var panel = CreateScrollablePanel();

            var content = @"PRODUCTIVITY TIPS:

🚀 EFFICIENCY SHORTCUTS:
• Use Tab key to navigate between form fields quickly
• Double-click stat cards for detailed views
• Right-click charts for export options
• Ctrl+R to refresh dashboard data

⌨️ KEYBOARD SHORTCUTS:
• F1 - Open help guide
• Ctrl+N - Add new customer
• Ctrl+O - Open orders
• Ctrl+S - Quick save
• Esc - Close dialogs

🎯 BEST PRACTICES:
• Check pending orders first thing each morning
• Update customer information regularly
• Generate weekly performance reports
• Backup data before major changes

📱 RESPONSIVE DESIGN:
• Dashboard adapts to different screen sizes
• Use full-screen mode for better experience
• Resize panels by dragging borders
• Minimize unused sections

🔄 DATA MANAGEMENT:
• System auto-saves every 30 seconds
• Use export features for backups
• Regular database maintenance recommended
• Keep customer data up-to-date

🎨 CUSTOMIZATION:
• Drag panels to rearrange layout
• Right-click for context menus
• Adjust chart timeframes
• Set personal preferences in Settings

⚡ PERFORMANCE TIPS:
• Close unused forms to free memory
• Clear browser cache weekly
• Use filters to find data quickly
• Archive old records periodically

🛡️ SECURITY REMINDERS:
• Log out when away from computer
• Use strong passwords
• Update regularly
• Report suspicious activity

💬 GETTING HELP:
• Hover over any element for instant help
• Use the ? button for guided assistance
• Check Recent Activity for error messages
• Contact support through About section";

            var lblContent = CreateContentLabel(content);
            panel.Controls.Add(lblContent);
            tab.Controls.Add(panel);
            tabControl.TabPages.Add(tab);
            }

        private void CreateTroubleshootingTab()
            {
            var tab = new TabPage("🔧 Troubleshooting");
            var panel = CreateScrollablePanel();

            var content = @"COMMON ISSUES & SOLUTIONS:

🐛 DATA NOT LOADING:
Problem: Statistics show old or missing data
Solution: 
• Click refresh button or press F5
• Check internet connection
• Clear browser cache
• Restart application if needed

🔄 SLOW PERFORMANCE:
Problem: Dashboard loads slowly
Solution:
• Close unnecessary browser tabs
• Clear temporary files
• Check available memory
• Reduce number of open forms

❌ FORM SUBMISSION ERRORS:
Problem: Cannot save customer/order data
Solution:
• Check all required fields are filled
• Verify data format (emails, phone numbers)
• Ensure unique constraints (no duplicate IDs)
• Try refreshing and re-entering data

🔐 LOGIN ISSUES:
Problem: Cannot access dashboard
Solution:
• Verify username and password
• Check Caps Lock status
• Clear browser cookies
• Contact administrator for password reset

📊 CHARTS NOT DISPLAYING:
Problem: Graphs appear blank or corrupted
Solution:
• Refresh the page
• Check date range settings
• Verify data exists for selected period
• Update browser to latest version

💾 DATA SYNC PROBLEMS:
Problem: Changes not saving properly
Solution:
• Wait for auto-save indicator
• Check network connection
• Manually save using Ctrl+S
• Verify sufficient storage space

🖱️ INTERFACE ISSUES:
Problem: Buttons or menus not responding
Solution:
• Right-click and select 'Reload'
• Check for JavaScript errors
• Disable browser extensions temporarily
• Try different browser if problem persists

📱 RESPONSIVE LAYOUT PROBLEMS:
Problem: Dashboard doesn't fit screen properly
Solution:
• Adjust browser zoom level (Ctrl+0 for reset)
• Switch to full-screen mode (F11)
• Update display resolution
• Use recommended browsers (Chrome, Firefox, Edge)

🔍 SEARCH NOT WORKING:
Problem: Cannot find customers or orders
Solution:
• Check spelling and try partial matches
• Remove special characters
• Use broader search terms
• Clear search filters

⚠️ WHEN TO CONTACT SUPPORT:
• Database corruption errors
• Persistent login failures
• Data loss or corruption
• Security-related issues
• Feature requests

📞 SUPPORT CHANNELS:
• Email: support@myapp.com
• Phone: 1-800-MYAPP-HELP
• Live Chat: Available 9 AM - 5 PM
• Knowledge Base: help.myapp.com";

            var lblContent = CreateContentLabel(content);
            panel.Controls.Add(lblContent);
            tab.Controls.Add(panel);
            tabControl.TabPages.Add(tab);
            }

        private Panel CreateScrollablePanel()
            {
            var panel = new Panel
                {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(20),
                BackColor = Color.White
                };
            return panel;
            }

        private Label CreateContentLabel(string text)
            {
            var label = new Label
                {
                Text = text,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(51, 51, 51),
                AutoSize = true,
                MaximumSize = new Size(720, 0),
                Padding = new Padding(10),
                BackColor = Color.White
                };
            return label;
            }

        protected override void OnPaint(PaintEventArgs e)
            {
            // Add subtle border to the form
            using (var pen = new Pen(Color.FromArgb(200, 200, 200), 1))
                {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            base.OnPaint(e);
            }
        }
    }