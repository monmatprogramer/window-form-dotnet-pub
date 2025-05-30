using System;
using System.Drawing;
using System.Windows.Forms;
using window_form_dotnet.UI.Controls;

namespace window_form_dotnet.UI.Helpers
    {
    /// <summary>
    /// Factory class for creating standardized ModernButton controls
    /// This makes it easy to create consistent buttons throughout the application
    /// </summary>
    public static class ModernButtonFactory
        {
        #region Default Sizes
        public static readonly Size SmallSize = new Size(80, 32);
        public static readonly Size MediumSize = new Size(120, 40);
        public static readonly Size LargeSize = new Size(160, 48);
        public static readonly Size WideSize = new Size(200, 40);
        #endregion

        #region Primary Button Methods
        /// <summary>
        /// Creates a primary button (blue) for main actions
        /// </summary>
        public static ModernButton CreatePrimaryButton(string text, Size? size = null)
            {
            return CreateButton(text, ButtonStyle.Primary, size ?? MediumSize);
            }

        /// <summary>
        /// Creates a secondary button (gray) for secondary actions
        /// </summary>
        public static ModernButton CreateSecondaryButton(string text, Size? size = null)
            {
            return CreateButton(text, ButtonStyle.Secondary, size ?? MediumSize);
            }

        /// <summary>
        /// Creates a success button (green) for positive actions
        /// </summary>
        public static ModernButton CreateSuccessButton(string text, Size? size = null)
            {
            return CreateButton(text, ButtonStyle.Success, size ?? MediumSize);
            }

        /// <summary>
        /// Creates a warning button (yellow) for warning actions
        /// </summary>
        public static ModernButton CreateWarningButton(string text, Size? size = null)
            {
            return CreateButton(text, ButtonStyle.Warning, size ?? MediumSize);
            }

        /// <summary>
        /// Creates a danger button (red) for destructive actions
        /// </summary>
        public static ModernButton CreateDangerButton(string text, Size? size = null)
            {
            return CreateButton(text, ButtonStyle.Danger, size ?? MediumSize);
            }

        /// <summary>
        /// Creates a light button for subtle actions
        /// </summary>
        public static ModernButton CreateLightButton(string text, Size? size = null)
            {
            return CreateButton(text, ButtonStyle.Light, size ?? MediumSize);
            }

        /// <summary>
        /// Creates a dark button for dark themes
        /// </summary>
        public static ModernButton CreateDarkButton(string text, Size? size = null)
            {
            return CreateButton(text, ButtonStyle.Dark, size ?? MediumSize);
            }
        #endregion

        #region Core Button Creation
        /// <summary>
        /// Creates a ModernButton with specified style and size
        /// </summary>
        private static ModernButton CreateButton(string text, ButtonStyle style, Size size)
            {
            var button = new ModernButton
                {
                Text = text,
                ButtonStyle = style,
                Size = size,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                BorderRadius = 8,
                TabStop = true
                };

            return button;
            }

        /// <summary>
        /// Creates a custom button with specific parameters
        /// </summary>
        public static ModernButton CreateCustomButton(
            string text,
            ButtonStyle style,
            Size size,
            int borderRadius = 8,
            Color? customColor = null)
            {
            var button = CreateButton(text, style, size);
            button.BorderRadius = borderRadius;

            if (customColor.HasValue)
                {
                button.BaseColor = customColor.Value;
                }

            return button;
            }
        #endregion

        #region Special Purpose Buttons
        /// <summary>
        /// Creates a login button with specific styling
        /// </summary>
        public static ModernButton CreateLoginButton()
            {
            var button = CreatePrimaryButton("SIGN IN", WideSize);
            button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button.BorderRadius = 6;
            return button;
            }

        /// <summary>
        /// Creates a cancel button with specific styling
        /// </summary>
        public static ModernButton CreateCancelButton()
            {
            var button = CreateSecondaryButton("Cancel", SmallSize);
            button.BorderRadius = 6;
            return button;
            }

        /// <summary>
        /// Creates a save button with specific styling
        /// </summary>
        public static ModernButton CreateSaveButton()
            {
            var button = CreateSuccessButton("Save", MediumSize);
            button.BorderRadius = 6;
            return button;
            }

        /// <summary>
        /// Creates a delete button with specific styling
        /// </summary>
        public static ModernButton CreateDeleteButton()
            {
            var button = CreateDangerButton("Delete", MediumSize);
            button.BorderRadius = 6;
            return button;
            }

        /// <summary>
        /// Creates a close button with specific styling
        /// </summary>
        public static ModernButton CreateCloseButton()
            {
            var button = CreateSecondaryButton("Close", MediumSize);
            button.BorderRadius = 6;
            return button;
            }
        #endregion

        #region Quick Action Buttons
        /// <summary>
        /// Creates quick action buttons for dashboard
        /// </summary>
        public static ModernButton CreateQuickActionButton(string text, Color backgroundColor)
            {
            var button = new ModernButton
                {
                Text = text,
                ButtonStyle = ButtonStyle.Primary,
                BaseColor = backgroundColor,
                Size = new Size(250, 35),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                BorderRadius = 6,
                ForeColor = Color.White
                };

            return button;
            }
        #endregion
        }

    /// <summary>
    /// Extension methods for enhancing existing buttons
    /// </summary>
    public static class ButtonExtensions
        {
        /// <summary>
        /// Converts a regular Button to have modern styling
        /// </summary>
        public static void ApplyModernStyle(this Button button, ButtonStyle style = ButtonStyle.Primary)
            {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button.Cursor = Cursors.Hand;

            // Apply colors based on style
            switch (style)
                {
                case ButtonStyle.Primary:
                    button.BackColor = Color.FromArgb(64, 123, 255);
                    button.ForeColor = Color.White;
                    break;
                case ButtonStyle.Secondary:
                    button.BackColor = Color.FromArgb(108, 117, 125);
                    button.ForeColor = Color.White;
                    break;
                case ButtonStyle.Success:
                    button.BackColor = Color.FromArgb(40, 167, 69);
                    button.ForeColor = Color.White;
                    break;
                case ButtonStyle.Warning:
                    button.BackColor = Color.FromArgb(255, 193, 7);
                    button.ForeColor = Color.FromArgb(51, 51, 51);
                    break;
                case ButtonStyle.Danger:
                    button.BackColor = Color.FromArgb(220, 53, 69);
                    button.ForeColor = Color.White;
                    break;
                }
            }

        /// <summary>
        /// Adds hover effects to existing buttons
        /// </summary>
        public static void AddHoverEffect(this Button button)
            {
            Color originalColor = button.BackColor;
            Color hoverColor = ControlPaint.Dark(originalColor, 0.1f);

            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = originalColor;
            }
        }

    /// <summary>
    /// Utility class for button-related operations
    /// </summary>
    public static class ButtonUtils
        {
        /// <summary>
        /// Creates a button panel with consistent spacing
        /// </summary>
        public static Panel CreateButtonPanel(params ModernButton[] buttons)
            {
            var panel = new Panel
                {
                Height = 60,
                Dock = DockStyle.Bottom,
                Padding = new Padding(20)
                };

            int spacing = 10;
            int totalWidth = 0;

            // Calculate total width needed
            foreach (var button in buttons)
                {
                totalWidth += button.Width + spacing;
                }
            totalWidth -= spacing; // Remove last spacing

            // Position buttons centered
            int startX = (panel.Width - totalWidth) / 2;
            int currentX = startX;

            foreach (var button in buttons)
                {
                button.Location = new Point(currentX, (panel.Height - button.Height) / 2);
                panel.Controls.Add(button);
                currentX += button.Width + spacing;
                }

            return panel;
            }

        /// <summary>
        /// Creates a vertical stack of buttons
        /// </summary>
        public static Panel CreateVerticalButtonStack(int spacing = 10, params ModernButton[] buttons)
            {
            var panel = new Panel
                {
                Width = 200,
                AutoSize = true,
                Padding = new Padding(10)
                };

            int currentY = panel.Padding.Top;

            foreach (var button in buttons)
                {
                button.Location = new Point(panel.Padding.Left, currentY);
                button.Dock = DockStyle.None;
                button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                button.Width = panel.Width - panel.Padding.Horizontal;

                panel.Controls.Add(button);
                currentY += button.Height + spacing;
                }

            panel.Height = currentY + panel.Padding.Bottom - spacing;
            return panel;
            }
        }
    }