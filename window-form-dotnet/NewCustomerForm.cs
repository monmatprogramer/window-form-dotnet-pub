using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_form_dotnet
    {
    public partial class NewCustomerForm : Form
        {
        public NewCustomerForm()
            {
            InitializeComponent();

            // Apply rounded corners to buttons after initialization
            ApplyRoundedCorners(btnSave, 22);
            ApplyRoundedCorners(btnCancel, 22);
            }

        private void ApplyRoundedCorners(Button button, int radius)
            {
            // Create a GraphicsPath for rounded rectangle
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);

            // Add arcs for corners
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Apply the region to the button
            button.Region = new Region(path);

            // Add hover effects
            button.MouseEnter += (s, e) =>
            {
                if (button.Name == "btnSave")
                    button.BackColor = Color.FromArgb(41, 128, 185);
                else if (button.Name == "btnCancel")
                    button.BackColor = Color.FromArgb(149, 165, 166);
            };

            button.MouseLeave += (s, e) =>
            {
                if (button.Name == "btnSave")
                    button.BackColor = Color.FromArgb(52, 152, 219);
                else if (button.Name == "btnCancel")
                    button.BackColor = Color.FromArgb(189, 195, 199);
            };
            }

        // Remove empty click handlers unless you need them
        private void label1_Click(object sender, EventArgs e)
            {
            // Implement if needed
            }

        private void label4_Click(object sender, EventArgs e)
            {
            // Implement if needed
            }

        private void label6_Click(object sender, EventArgs e)
            {
            // Implement if needed
            }

        private void label10_Click(object sender, EventArgs e)
            {
            // Implement if needed
            }

        private void btnSave_Click(object sender, EventArgs e)
            {

            }
        }
    }