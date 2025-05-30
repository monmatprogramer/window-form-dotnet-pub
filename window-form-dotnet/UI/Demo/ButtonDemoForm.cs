using System;
using System.Drawing;
using System.Windows.Forms;
using window_form_dotnet.UI.Controls;
using window_form_dotnet.UI.Helpers;

namespace window_form_dotnet.UI.Demo
    {
    /// <summary>
    /// Demonstration form showing different ModernButton styles and features
    /// This form helps developers see all available button styles
    /// </summary>
    public partial class ButtonDemoForm : Form
        {
        public ButtonDemoForm()
            {
            InitializeComponent();
            SetupDemoButtons();
            }

        private void InitializeComponent()
            {
            // Form setup
            this.Text = "Modern Button Demonstration";
            this.Size = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 242, 247);
            this.Font = new Font("Segoe UI", 9F);

            // Main container
            var mainPanel = new Panel
                {
                Dock = DockStyle.Fill,
                Padding = new Padding(30),
                AutoScroll = true
                };
            this.Controls.Add(mainPanel);

            // Title
            var titleLabel = new Label
                {
                Text = "Modern Button Styles Demo",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Size = new Size(800, 40),
                Location = new Point(0, 0),
                TextAlign = ContentAlignment.MiddleLeft
                };
            mainPanel.Controls.Add(titleLabel);

            // Subtitle
            var subtitleLabel = new Label
                {
                Text = "Explore different button styles, sizes, and interactions",
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(128, 128, 128),
                Size = new Size(800, 30),
                Location = new Point(0, 40),
                TextAlign = ContentAlignment.MiddleLeft
                };
            mainPanel.Controls.Add(subtitleLabel);

            SetupButtonSections(mainPanel);
            }

        private void SetupButtonSections(Panel mainPanel)
            {
            int currentY = 100;
            int sectionSpacing = 80;

            // Section 1: Standard Button Styles
            currentY += CreateButtonStyleSection(mainPanel, "Standard Button Styles", currentY);
            currentY += sectionSpacing;

            // Section 2: Button Sizes
            currentY += CreateButtonSizeSection(mainPanel, "Button Sizes", currentY);
            currentY += sectionSpacing;

            // Section 3: Border Radius Variations
            currentY += CreateBorderRadiusSection(mainPanel, "Border Radius Variations", currentY);
            currentY += sectionSpacing;

            // Section 4: Special Purpose Buttons
            currentY += CreateSpecialButtonsSection(mainPanel, "Special Purpose Buttons", currentY);
            currentY += sectionSpacing;

            // Section 5: Custom Colored Buttons
            currentY += CreateCustomColorSection(mainPanel, "Custom Colored Buttons", currentY);
            }

        private int CreateButtonStyleSection(Panel parent, string title, int startY)
            {
            // Section title
            var sectionTitle = CreateSectionTitle(title, startY);
            parent.Controls.Add(sectionTitle);

            int buttonY = startY + 40;
            int buttonSpacing = 15;
            int buttonsPerRow = 4;
            int buttonIndex = 0;

            // Create buttons for each style
            var styles = new[]
            {
                new { Style = ButtonStyle.Primary, Text = "Primary" },
                new { Style = ButtonStyle.Secondary, Text = "Secondary" },
                new { Style = ButtonStyle.Success, Text = "Success" },
                new { Style = ButtonStyle.Warning, Text = "Warning" },
                new { Style = ButtonStyle.Danger, Text = "Danger" },
                new { Style = ButtonStyle.Light, Text = "Light" },
                new { Style = ButtonStyle.Dark, Text = "Dark" }
            };

            foreach (var style in styles)
                {
                var button = new ModernButton
                    {
                    Text = style.Text,
                    ButtonStyle = style.Style,
                    Size = new Size(120, 40),
                    Location = new Point(
                        (buttonIndex % buttonsPerRow) * (120 + buttonSpacing),
                        buttonY + (buttonIndex / buttonsPerRow) * (40 + buttonSpacing)
                    )
                    };

                button.Click += (s, e) => ShowButtonInfo(style.Text, style.Style.ToString());
                parent.Controls.Add(button);
                buttonIndex++;
                }

            return 40 + ((buttonIndex - 1) / buttonsPerRow + 1) * (40 + buttonSpacing);
            }

        private int CreateButtonSizeSection(Panel parent, string title, int startY)
            {
            var sectionTitle = CreateSectionTitle(title, startY);
            parent.Controls.Add(sectionTitle);

            int buttonY = startY + 40;
            int currentX = 0;
            int spacing = 15;

            // Small button
            var smallButton = ModernButtonFactory.CreatePrimaryButton("Small", ModernButtonFactory.SmallSize);
            smallButton.Location = new Point(currentX, buttonY);
            parent.Controls.Add(smallButton);
            currentX += smallButton.Width + spacing;

            // Medium button
            var mediumButton = ModernButtonFactory.CreatePrimaryButton("Medium", ModernButtonFactory.MediumSize);
            mediumButton.Location = new Point(currentX, buttonY);
            parent.Controls.Add(mediumButton);
            currentX += mediumButton.Width + spacing;

            // Large button
            var largeButton = ModernButtonFactory.CreatePrimaryButton("Large", ModernButtonFactory.LargeSize);
            largeButton.Location = new Point(currentX, buttonY);
            parent.Controls.Add(largeButton);
            currentX += largeButton.Width + spacing;

            // Wide button
            var wideButton = ModernButtonFactory.CreatePrimaryButton("Wide", ModernButtonFactory.WideSize);
            wideButton.Location = new Point(0, buttonY + 60);
            parent.Controls.Add(wideButton);

            return 120; // Total height for this section
            }

        private int CreateBorderRadiusSection(Panel parent, string title, int startY)
            {
            var sectionTitle = CreateSectionTitle(title, startY);
            parent.Controls.Add(sectionTitle);

            int buttonY = startY + 40;
            int currentX = 0;
            int spacing = 15;

            var radiusValues = new[] { 0, 4, 8, 12, 20 };

            foreach (var radius in radiusValues)
                {
                var button = ModernButtonFactory.CreatePrimaryButton($"Radius {radius}", new Size(100, 40));
                button.BorderRadius = radius;
                button.Location = new Point(currentX, buttonY);
                parent.Controls.Add(button);
                currentX += 100 + spacing;
                }

            return 80;
            }

        private int CreateSpecialButtonsSection(Panel parent, string title, int startY)
            {
            var sectionTitle = CreateSectionTitle(title, startY);
            parent.Controls.Add(sectionTitle);

            int buttonY = startY + 40;
            int currentX = 0;
            int spacing = 15;

            // Special purpose buttons
            var loginButton = ModernButtonFactory.CreateLoginButton();
            loginButton.Location = new Point(currentX, buttonY);
            loginButton.Size = new Size(150, 40); // Adjust size for demo
            parent.Controls.Add(loginButton);
            currentX += 150 + spacing;

            var saveButton = ModernButtonFactory.CreateSaveButton();
            saveButton.Location = new Point(currentX, buttonY);
            parent.Controls.Add(saveButton);
            currentX += saveButton.Width + spacing;

            var deleteButton = ModernButtonFactory.CreateDeleteButton();
            deleteButton.Location = new Point(currentX, buttonY);
            parent.Controls.Add(deleteButton);
            currentX += deleteButton.Width + spacing;

            var cancelButton = ModernButtonFactory.CreateCancelButton();
            cancelButton.Location = new Point(currentX, buttonY);
            parent.Controls.Add(cancelButton);

            return 80;
            }

        private int CreateCustomColorSection(Panel parent, string title, int startY)
            {
            var sectionTitle = CreateSectionTitle(title, startY);
            parent.Controls.Add(sectionTitle);

            int buttonY = startY + 40;
            int currentX = 0;
            int spacing = 15;

            var customColors = new[]
            {
                new { Color = Color.FromArgb(156, 39, 176), Name = "Purple" },
                new { Color = Color.FromArgb(255, 87, 34), Name = "Orange" },
                new { Color = Color.FromArgb(0, 150, 136), Name = "Teal" },
                new { Color = Color.FromArgb(233, 30, 99), Name = "Pink" }
            };

            foreach (var colorInfo in customColors)
                {
                var button = ModernButtonFactory.CreateCustomButton(
                    colorInfo.Name,
                    ButtonStyle.Primary,
                    new Size(100, 40),
                    8,
                    colorInfo.Color
                );
                button.Location = new Point(currentX, buttonY);
                parent.Controls.Add(button);
                currentX += 100 + spacing;
                }

            return 80;
            }

        private Label CreateSectionTitle(string title, int y)
            {
            return new Label
                {
                Text = title,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 123, 255),
                Size = new Size(800, 30),
                Location = new Point(0, y),
                TextAlign = ContentAlignment.BottomLeft
                };
            }

        private void SetupDemoButtons()
            {
            // This method can be used for additional setup if needed
            }

        private void ShowButtonInfo(string buttonText, string styleInfo)
            {
            MessageBox.Show(
                $"Button: {buttonText}\nStyle: {styleInfo}\n\nThis demonstrates the {styleInfo} button style with hover and click animations.",
                "Button Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            }
        }
    }

// Extension to easily show the demo form
namespace window_form_dotnet.UI.Helpers
    {
    public static class ButtonDemoHelper
        {
        public static void ShowButtonDemo()
            {
            var demoForm = new window_form_dotnet.UI.Demo.ButtonDemoForm();
            demoForm.ShowDialog();
            }
        }
    }