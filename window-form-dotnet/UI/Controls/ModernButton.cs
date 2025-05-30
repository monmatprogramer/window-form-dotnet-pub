using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace window_form_dotnet.UI.Controls
    {
    /// <summary>
    /// Modern Button Control with Rounded Corners and Beautiful Styling
    /// This custom button provides professional appearance with smooth animations
    /// </summary>
    public class ModernButton : Button
        {
        #region Private Fields
        private int borderRadius = 8;
        private Color baseColor = Color.FromArgb(64, 123, 255);
        private Color hoverColor = Color.FromArgb(45, 105, 230);
        private Color pressedColor = Color.FromArgb(30, 85, 200);
        private Color textColor = Color.White;
        private ButtonStyle buttonStyle = ButtonStyle.Primary;
        private bool isHovered = false;
        private bool isPressed = false;
        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        private float currentAnimationValue = 0f;
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the border radius for rounded corners
        /// </summary>
        [DefaultValue(8)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
            {
            get => borderRadius;
            set
                {
                borderRadius = Math.Max(0, value);
                Invalidate(); // Trigger repaint
                }
            }

        /// <summary>
        /// Gets or sets the button style (Primary, Secondary, Success, Warning, Danger)
        /// </summary>
        [DefaultValue(ButtonStyle.Primary)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ButtonStyle ButtonStyle
            {
            get => buttonStyle;
            set
                {
                buttonStyle = value;
                UpdateColors();
                Invalidate();
                }
            }

        /// <summary>
        /// Gets or sets the base color of the button
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BaseColor
            {
            get => baseColor;
            set
                {
                baseColor = value;
                UpdateHoverColors();
                Invalidate();
                }
            }

        /// <summary>
        /// Indicates whether the BaseColor property should be serialized
        /// </summary>
        private bool ShouldSerializeBaseColor()
            {
            return baseColor != Color.FromArgb(64, 123, 255);
            }

        /// <summary>
        /// Resets the BaseColor property to its default value
        /// </summary>
        private void ResetBaseColor()
            {
            BaseColor = Color.FromArgb(64, 123, 255);
            }
        #endregion

        #region Constructor
        public ModernButton()
            {
            InitializeComponent();
            }

        private void InitializeComponent()
            {
            // Set default properties for modern appearance
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                    ControlStyles.DoubleBuffer |
                    ControlStyles.ResizeRedraw, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Cursor = Cursors.Hand;

            // Setup animation timer
            animationTimer.Interval = 16; // ~60 FPS
            animationTimer.Tick += AnimationTimer_Tick;

            // Initialize colors based on default style
            UpdateColors();
            }
        #endregion

        #region Color Management
        private void UpdateColors()
            {
            switch (buttonStyle)
                {
                case ButtonStyle.Primary:
                    baseColor = Color.FromArgb(64, 123, 255);
                    textColor = Color.White;
                    break;
                case ButtonStyle.Secondary:
                    baseColor = Color.FromArgb(108, 117, 125);
                    textColor = Color.White;
                    break;
                case ButtonStyle.Success:
                    baseColor = Color.FromArgb(40, 167, 69);
                    textColor = Color.White;
                    break;
                case ButtonStyle.Warning:
                    baseColor = Color.FromArgb(255, 193, 7);
                    textColor = Color.FromArgb(51, 51, 51);
                    break;
                case ButtonStyle.Danger:
                    baseColor = Color.FromArgb(220, 53, 69);
                    textColor = Color.White;
                    break;
                case ButtonStyle.Light:
                    baseColor = Color.FromArgb(248, 249, 250);
                    textColor = Color.FromArgb(51, 51, 51);
                    break;
                case ButtonStyle.Dark:
                    baseColor = Color.FromArgb(52, 58, 64);
                    textColor = Color.White;
                    break;
                }

            UpdateHoverColors();
            ForeColor = textColor;
            }

        private void UpdateHoverColors()
            {
            // Calculate hover and pressed colors based on base color
            hoverColor = DarkenColor(baseColor, 0.15f);
            pressedColor = DarkenColor(baseColor, 0.25f);
            }

        private Color DarkenColor(Color color, float factor)
            {
            return Color.FromArgb(
                color.A,
                (int)(color.R * (1 - factor)),
                (int)(color.G * (1 - factor)),
                (int)(color.B * (1 - factor))
            );
            }
        #endregion

        #region Animation
        private void AnimationTimer_Tick(object? sender, EventArgs e)
            {
            if (isHovered && currentAnimationValue < 1.0f)
                {
                currentAnimationValue += 0.1f;
                if (currentAnimationValue >= 1.0f)
                    {
                    currentAnimationValue = 1.0f;
                    animationTimer.Stop();
                    }
                Invalidate();
                }
            else if (!isHovered && currentAnimationValue > 0.0f)
                {
                currentAnimationValue -= 0.1f;
                if (currentAnimationValue <= 0.0f)
                    {
                    currentAnimationValue = 0.0f;
                    animationTimer.Stop();
                    }
                Invalidate();
                }
            }
        #endregion

        #region Mouse Events
        protected override void OnMouseEnter(EventArgs e)
            {
            base.OnMouseEnter(e);
            isHovered = true;
            animationTimer.Start();
            }

        protected override void OnMouseLeave(EventArgs e)
            {
            base.OnMouseLeave(e);
            isHovered = false;
            isPressed = false;
            animationTimer.Start();
            }

        protected override void OnMouseDown(MouseEventArgs e)
            {
            base.OnMouseDown(e);
            isPressed = true;
            Invalidate();
            }

        protected override void OnMouseUp(MouseEventArgs e)
            {
            base.OnMouseUp(e);
            isPressed = false;
            Invalidate();
            }
        #endregion

        #region Custom Painting
        protected override void OnPaint(PaintEventArgs e)
            {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Calculate current color based on state and animation
            Color currentColor = GetCurrentBackgroundColor();

            // Draw button background with rounded corners
            using (GraphicsPath path = GetRoundedRectanglePath(ClientRectangle, borderRadius))
                {
                using (SolidBrush brush = new SolidBrush(currentColor))
                    {
                    g.FillPath(brush, path);
                    }

                // Add subtle border for Light style
                if (buttonStyle == ButtonStyle.Light)
                    {
                    using (Pen borderPen = new Pen(Color.FromArgb(220, 220, 220), 1))
                        {
                        g.DrawPath(borderPen, path);
                        }
                    }

                // Add inner highlight for depth effect
                using (Pen highlightPen = new Pen(Color.FromArgb(30, 255, 255, 255), 1))
                    {
                    GraphicsPath innerPath = GetRoundedRectanglePath(
                        new Rectangle(1, 1, Width - 2, Height - 2),
                        Math.Max(0, borderRadius - 1));
                    g.DrawPath(highlightPen, innerPath);
                    }
                }

            // Draw button text
            DrawButtonText(g);

            // Draw focus rectangle if needed
            if (Focused && ShowFocusCues)
                {
                DrawFocusRectangle(g);
                }
            }

        private Color GetCurrentBackgroundColor()
            {
            Color targetColor;

            if (!Enabled)
                {
                return Color.FromArgb(200, baseColor.R, baseColor.G, baseColor.B);
                }

            if (isPressed)
                {
                targetColor = pressedColor;
                }
            else if (isHovered)
                {
                targetColor = hoverColor;
                }
            else
                {
                targetColor = baseColor;
                }

            // Apply animation interpolation
            if (currentAnimationValue > 0 && !isPressed)
                {
                return InterpolateColor(baseColor, hoverColor, currentAnimationValue);
                }

            return targetColor;
            }

        private Color InterpolateColor(Color color1, Color color2, float ratio)
            {
            ratio = Math.Max(0, Math.Min(1, ratio));

            int r = (int)(color1.R + (color2.R - color1.R) * ratio);
            int g = (int)(color1.G + (color2.G - color1.G) * ratio);
            int b = (int)(color1.B + (color2.B - color1.B) * ratio);

            return Color.FromArgb(r, g, b);
            }

        private void DrawButtonText(Graphics g)
            {
            if (string.IsNullOrEmpty(Text)) return;

            Color currentTextColor = Enabled ? textColor : Color.FromArgb(120, textColor);

            using (SolidBrush textBrush = new SolidBrush(currentTextColor))
                {
                StringFormat stringFormat = new StringFormat
                    {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                    };

                Rectangle textRect = ClientRectangle;
                g.DrawString(Text, Font, textBrush, textRect, stringFormat);
                }
            }

        private void DrawFocusRectangle(Graphics g)
            {
            using (Pen focusPen = new Pen(Color.FromArgb(100, textColor), 1))
                {
                focusPen.DashStyle = DashStyle.Dot;
                Rectangle focusRect = new Rectangle(2, 2, Width - 4, Height - 4);
                using (GraphicsPath focusPath = GetRoundedRectanglePath(focusRect, Math.Max(0, borderRadius - 2)))
                    {
                    g.DrawPath(focusPen, focusPath);
                    }
                }
            }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
            {
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
                {
                path.AddRectangle(rect);
                return path;
                }

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            // Top-left arc
            path.AddArc(arc, 180, 90);

            // Top-right arc
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom-right arc
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom-left arc
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
            }
        #endregion

        #region Cleanup
        protected override void Dispose(bool disposing)
            {
            if (disposing)
                {
                animationTimer?.Dispose();
                }
            base.Dispose(disposing);
            }
        #endregion
        }

    #region Button Style Enum
    /// <summary>
    /// Defines the visual style of the ModernButton
    /// </summary>
    public enum ButtonStyle
        {
        Primary,    // Blue - Main actions
        Secondary,  // Gray - Secondary actions
        Success,    // Green - Success/Positive actions
        Warning,    // Yellow - Warning actions
        Danger,     // Red - Destructive actions
        Light,      // Light gray - Subtle actions
        Dark        // Dark gray - Dark theme actions
        }
    #endregion
    }