using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace window_form_dotnet.UI.Dialogs
    {
    /// <summary>
    /// Modern message dialog with smooth animations and beautiful design
    /// Replaces the standard MessageBox with a more appealing UI
    /// </summary>
    public partial class ModernMessageDialog : Form
        {
        // Update the Timer declaration to explicitly use System.Windows.Forms.Timer
        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        private int targetHeight;
        private double animationProgress = 0;
        private bool isClosing = false;

        // Dialog result
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult Result { get; private set; } = DialogResult.None;

        // Message type enumeration
        public enum MessageType
            {
            Success,
            Error,
            Warning,
            Information
            }

        // UI Controls
        private Panel pnlMain = new Panel();
        private Panel pnlIcon = new Panel();
        private Label lblIcon = new Label();
        private Label lblTitle = new Label();
        private Label lblMessage = new Label();
        private Button btnOK = new Button();
        private Button btnCancel = new Button();

        // Constructor
        public ModernMessageDialog(string title, string message, MessageType type, bool showCancelButton = false)
            {
            InitializeComponent();
            SetupDialog(title, message, type, showCancelButton);
            InitializeAnimation();
            }

        private void InitializeComponent()
            {
            // Form settings
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(45, 45, 45);
            this.ShowInTaskbar = false;
            this.Size = new Size(400, 1); // Start with minimal height for animation
            this.MinimumSize = new Size(400, 1);
            this.MaximumSize = new Size(400, 250);

            // Main panel
            pnlMain = new Panel
                {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(1)
                };

            // Icon panel
            pnlIcon = new Panel
                {
                Size = new Size(60, 60),
                Location = new Point(20, 20),
                BackColor = Color.Transparent
                };

            // Icon label
            lblIcon = new Label
                {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 24F),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
                };

            // Title label
            lblTitle = new Label
                {
                Location = new Point(95, 20),
                Size = new Size(285, 30),
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 33, 33),
                TextAlign = ContentAlignment.MiddleLeft
                };

            // Message label
            lblMessage = new Label
                {
                Location = new Point(95, 55),
                Size = new Size(285, 60),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(66, 66, 66),
                TextAlign = ContentAlignment.TopLeft,
                AutoSize = false
                };

            // OK Button
            btnOK = new Button
                {
                Size = new Size(100, 35),
                Location = new Point(280, 140),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Text = "OK"
                };
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Click += BtnOK_Click;

            // Cancel Button
            btnCancel = new Button
                {
                Size = new Size(100, 35),
                Location = new Point(170, 140),
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(240, 240, 240),
                ForeColor = Color.FromArgb(66, 66, 66),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Text = "Cancel",
                Visible = false
                };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += BtnCancel_Click;

            // Add controls
            pnlIcon.Controls.Add(lblIcon);
            pnlMain.Controls.AddRange(new Control[] { pnlIcon, lblTitle, lblMessage, btnOK, btnCancel });
            this.Controls.Add(pnlMain);

            // Set target height for animation
            targetHeight = 200;
            }

        private void SetupDialog(string title, string message, MessageType type, bool showCancelButton)
            {
            lblTitle.Text = title;
            lblMessage.Text = message;

            // Show/hide cancel button
            if (showCancelButton)
                {
                btnCancel.Visible = true;
                btnOK.Location = new Point(280, 140);
                }
            else
                {
                btnCancel.Visible = false;
                btnOK.Location = new Point(170, 140); // Center the OK button
                }

            // Set colors and icon based on message type
            switch (type)
                {
                case MessageType.Success:
                    SetSuccessTheme();
                    break;
                case MessageType.Error:
                    SetErrorTheme();
                    break;
                case MessageType.Warning:
                    SetWarningTheme();
                    break;
                case MessageType.Information:
                    SetInformationTheme();
                    break;
                }
            }

        private void SetSuccessTheme()
            {
            Color successColor = Color.FromArgb(46, 204, 113);
            pnlIcon.BackColor = successColor;
            lblIcon.Text = "✓";
            btnOK.BackColor = successColor;

            // Add rounded corners to icon panel
            CreateRoundedPanel(pnlIcon);
            }

        private void SetErrorTheme()
            {
            Color errorColor = Color.FromArgb(231, 76, 60);
            pnlIcon.BackColor = errorColor;
            lblIcon.Text = "✕";
            btnOK.BackColor = errorColor;

            CreateRoundedPanel(pnlIcon);
            }

        private void SetWarningTheme()
            {
            Color warningColor = Color.FromArgb(241, 196, 15);
            pnlIcon.BackColor = warningColor;
            lblIcon.Text = "!";
            btnOK.BackColor = warningColor;

            CreateRoundedPanel(pnlIcon);
            }

        private void SetInformationTheme()
            {
            Color infoColor = Color.FromArgb(52, 152, 219);
            pnlIcon.BackColor = infoColor;
            lblIcon.Text = "i";
            btnOK.BackColor = infoColor;

            CreateRoundedPanel(pnlIcon);
            }

        private void CreateRoundedPanel(Panel panel)
            {
            // Create rounded corners for the icon panel
            GraphicsPath path = new GraphicsPath();
            int radius = 30;
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
            }

        private void InitializeAnimation()
            {
            animationTimer.Interval = 10; // 10ms for smooth animation
            animationTimer.Tick += AnimationTimer_Tick;
            }

        private void AnimationTimer_Tick(object? sender, EventArgs e)
            {
            if (!isClosing)
                {
                // Opening animation
                animationProgress += 0.08; // Speed of animation
                if (animationProgress >= 1)
                    {
                    animationProgress = 1;
                    animationTimer.Stop();
                    }

                // Ease-out cubic function for smooth animation
                double easedProgress = 1 - Math.Pow(1 - animationProgress, 3);
                this.Height = (int)(targetHeight * easedProgress);
                }
            else
                {
                // Closing animation
                animationProgress -= 0.12; // Faster closing
                if (animationProgress <= 0)
                    {
                    animationProgress = 0;
                    animationTimer.Stop();
                    this.Close();
                    }

                double easedProgress = Math.Pow(animationProgress, 3);
                this.Height = (int)(targetHeight * easedProgress);
                this.Opacity = easedProgress;
                }
            }

        protected override void OnShown(EventArgs e)
            {
            base.OnShown(e);

            // Start opening animation
            animationProgress = 0;
            animationTimer.Start();

            // Add fade-in effect
            this.Opacity = 0;
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer { Interval = 10 };
            fadeTimer.Tick += (s, args) =>
            {
                this.Opacity += 0.05;
                if (this.Opacity >= 1)
                    {
                    this.Opacity = 1;
                    fadeTimer.Stop();
                    fadeTimer.Dispose();
                    }
            };
            fadeTimer.Start();
            }

        protected override void OnPaint(PaintEventArgs e)
            {
            base.OnPaint(e);

            // Draw shadow border
            using (Pen shadowPen = new Pen(Color.FromArgb(30, 0, 0, 0), 2))
                {
                e.Graphics.DrawRectangle(shadowPen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }

        private void BtnOK_Click(object? sender, EventArgs e)
            {
            Result = DialogResult.OK;
            CloseWithAnimation();
            }

        private void BtnCancel_Click(object? sender, EventArgs e)
            {
            Result = DialogResult.Cancel;
            CloseWithAnimation();
            }

        private void CloseWithAnimation()
            {
            isClosing = true;
            animationProgress = 1;
            animationTimer.Start();
            }

        // Button hover effects
        protected override void OnControlAdded(ControlEventArgs e)
            {
            base.OnControlAdded(e);

            if (e.Control is Button btn && btn != btnCancel)
                {
                Color originalColor = btn.BackColor;
                btn.MouseEnter += (s, args) =>
                {
                    btn.BackColor = ControlPaint.Dark(originalColor, 0.1f);
                };
                btn.MouseLeave += (s, args) =>
                {
                    btn.BackColor = originalColor;
                };
                }
            }

        // Static helper methods for easy usage
        public static DialogResult ShowSuccess(string message, string title = "Success")
            {
            using (var dialog = new ModernMessageDialog(title, message, MessageType.Success))
                {
                dialog.ShowDialog();
                return dialog.Result;
                }
            }

        public static DialogResult ShowError(string message, string title = "Error")
            {
            using (var dialog = new ModernMessageDialog(title, message, MessageType.Error))
                {
                dialog.ShowDialog();
                return dialog.Result;
                }
            }

        public static DialogResult ShowWarning(string message, string title = "Warning")
            {
            using (var dialog = new ModernMessageDialog(title, message, MessageType.Warning))
                {
                dialog.ShowDialog();
                return dialog.Result;
                }
            }

        public static DialogResult ShowInformation(string message, string title = "Information")
            {
            using (var dialog = new ModernMessageDialog(title, message, MessageType.Information))
                {
                dialog.ShowDialog();
                return dialog.Result;
                }
            }

        public static DialogResult ShowQuestion(string message, string title = "Confirm")
            {
            using (var dialog = new ModernMessageDialog(title, message, MessageType.Information, true))
                {
                dialog.ShowDialog();
                return dialog.Result;
                }
            }
        }
    }