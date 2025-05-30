using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace window_form_dotnet
    {
    public partial class AboutMeForm : Form
        {
        // Animation timer for fade effect
        private System.Windows.Forms.Timer fadeTimer;
        private int targetOpacity = 100;

        public AboutMeForm()
            {
            InitializeComponent();
            InitializeFormStyle();
            SetupAnimation();
            }

        private void InitializeFormStyle()
            {
            // Set form properties for modern appearance
            this.Font = new Font("Segoe UI", 9F);
            this.DoubleBuffered = true;

            // Add shadow effect to the form
            this.Paint += (s, e) =>
            {
                // Draw border shadow
                using (Pen shadowPen = new Pen(Color.FromArgb(50, 0, 0, 0), 3))
                    {
                    Rectangle shadowRect = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
                    e.Graphics.DrawRectangle(shadowPen, shadowRect);
                    }
            };
            }

        private void SetupAnimation()
            {
            // Initialize fade timer
            fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 10;
            fadeTimer.Tick += FadeTimer_Tick;

            // Start with 0 opacity
            this.Opacity = 0;
            }

        private void AboutMeForm_Load(object sender, EventArgs e)
            {
            LoadProfileData();
            LoadTechnologies();
            LoadSkills();

            // Start fade in animation
            fadeTimer.Start();
            }

        private void LoadProfileData()
            {
            // Set profile information
            lblName.Text = "Passionate Developer";
            lblRole.Text = "Full Stack Developer | Mobile App Specialist";

            // Set description
            lblDescription.Text = "I am a dedicated software developer currently pursuing my Master's degree in IT. " +
                                "With a strong passion for mobile development using Flutter and Dart, I create " +
                                "innovative cross-platform applications. My journey in technology is driven by " +
                                "curiosity and a love for discovering new advancements.\n\n" +
                                "Currently expanding my skillset by learning .NET Core with C# to broaden my " +
                                "development capabilities. I enjoy building robust backend solutions using Express.js " +
                                "and Spring Boot with MySQL databases. When I'm not coding, you'll find me immersed " +
                                "in English literature, constantly learning and growing both personally and professionally.";
            }

        private void LoadTechnologies()
            {
            string[] technologies = {
                "Flutter", "Dart", "C#", ".NET Core", "Express.js",
                "Spring Boot", "MySQL", "Java", "JavaScript", "Node.js",
                "REST APIs", "Git", "Mobile Development", "Windows Forms"
            };

            foreach (string tech in technologies)
                {
                AddTechnologyChip(tech);
                }
            }

        private void LoadSkills()
            {
            string[] skills = {
                "Mobile App Development", "API Development", "Database Design",
                "UI/UX Design", "Problem Solving", "Agile Development",
                "Cross-platform Development", "Backend Development"
            };

            foreach (string skill in skills)
                {
                AddSkillChip(skill);
                }
            }

        private void AddTechnologyChip(string technology)
            {
            Label chip = CreateChip(technology, Color.FromArgb(64, 123, 255));
            flpTechnologies.Controls.Add(chip);
            }

        private void AddSkillChip(string skill)
            {
            Label chip = CreateChip(skill, Color.FromArgb(40, 167, 69));
            flpSkills.Controls.Add(chip);
            }

        private Label CreateChip(string text, Color backgroundColor)
            {
            Label chip = new Label
                {
                Text = text,
                AutoSize = false,
                Size = new Size(text.Length * 8 + 20, 28),
                BackColor = backgroundColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(5),
                Padding = new Padding(10, 5, 10, 5)
                };

            // Add rounded corners effect
            chip.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = GetRoundedRectangle(chip.ClientRectangle, 14))
                    {
                    chip.Region = new Region(path);
                    }
            };

            // Add hover effect
            chip.MouseEnter += (s, e) =>
            {
                chip.BackColor = ControlPaint.Dark(backgroundColor, 0.1f);
                chip.Cursor = Cursors.Hand;
            };

            chip.MouseLeave += (s, e) =>
            {
                chip.BackColor = backgroundColor;
                chip.Cursor = Cursors.Default;
            };

            return chip;
            }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
            {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
            }

        // Event Handlers
        private void BtnClose_Click(object sender, EventArgs e)
            {
            // Start fade out animation
            targetOpacity = 0;
            fadeTimer.Start();
            }

        private void BtnEmail_Click(object sender, EventArgs e)
            {
            // Open email client
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                FileName = "mailto:your.email@example.com",
                UseShellExecute = true
                });
            }

        private void BtnGitHub_Click(object sender, EventArgs e)
            {
            // Open GitHub profile
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                FileName = "https://github.com/yourusername",
                UseShellExecute = true
                });
            }

        private void BtnLinkedIn_Click(object sender, EventArgs e)
            {
            // Open LinkedIn profile
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                FileName = "https://linkedin.com/in/yourusername",
                UseShellExecute = true
                });
            }

        private void PicProfile_Paint(object sender, PaintEventArgs e)
            {
            // Draw a placeholder profile image (circle with initials)
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw circle background
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(240, 242, 247)))
                {
                g.FillEllipse(brush, 0, 0, picProfile.Width - 1, picProfile.Height - 1);
                }

            // Draw initials
            using (Font font = new Font("Segoe UI", 28F, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(64, 123, 255)))
                {
                string initials = "PD"; // Passionate Developer
                SizeF textSize = g.MeasureString(initials, font);
                float x = (picProfile.Width - textSize.Width) / 2;
                float y = (picProfile.Height - textSize.Height) / 2;
                g.DrawString(initials, font, textBrush, x, y);
                }

            // Draw border
            using (Pen borderPen = new Pen(Color.White, 3))
                {
                g.DrawEllipse(borderPen, 1, 1, picProfile.Width - 3, picProfile.Height - 3);
                }
            }

        // Animation
        private void FadeTimer_Tick(object sender, EventArgs e)
            {
            if (targetOpacity > 0)
                {
                // Fade in
                if (this.Opacity < 1)
                    {
                    this.Opacity += 0.05;
                    }
                else
                    {
                    fadeTimer.Stop();
                    }
                }
            else
                {
                // Fade out
                if (this.Opacity > 0)
                    {
                    this.Opacity -= 0.05;
                    }
                else
                    {
                    fadeTimer.Stop();
                    this.Close();
                    }
                }
            }

        // Make form draggable
        private Point mouseDownLocation;

        protected override void OnMouseDown(MouseEventArgs e)
            {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                {
                mouseDownLocation = e.Location;
                }
            }

        protected override void OnMouseMove(MouseEventArgs e)
            {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
                {
                this.Location = new Point(
                    this.Location.X + e.X - mouseDownLocation.X,
                    this.Location.Y + e.Y - mouseDownLocation.Y
                );
                }
            }

        // Override ProcessCmdKey to handle Escape key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
            if (keyData == Keys.Escape)
                {
                BtnClose_Click(this, EventArgs.Empty);
                return true;
                }
            return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }