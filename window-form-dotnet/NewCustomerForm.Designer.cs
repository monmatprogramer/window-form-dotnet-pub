namespace window_form_dotnet
{
    partial class NewCustomerForm
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
            this.SuspendLayout();

            // Main Panel
            var mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(0)
            };

            // Title
            var lblTitle = new Label
            {
                Text = "New Customer",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                Dock = DockStyle.Top,
                Height = 70,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(236, 240, 241)
            };
            mainPanel.Controls.Add(lblTitle);

            // Padding for mainPanel
            // Personal Info Group
            var groupPersonal = new GroupBox
            {
                Text = "Personal Information",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 120,
                Padding = new Padding(20, 15, 20, 10),
                BackColor = Color.White
            };

            label1 = new Label { Text = "Customer ID", Font = new Font("Segoe UI", 10F), Location = new Point(10, 30), Width = 100 };
            txtCusID = new TextBox { Name = "txtCusID", Location = new Point(120, 27), Width = 150, Font = new Font("Segoe UI", 10F) };

            label2 = new Label { Text = "First Name", Font = new Font("Segoe UI", 10F), Location = new Point(290, 30), Width = 80 };
            txtFName = new TextBox { Name = "txtFName", Location = new Point(380, 27), Width = 130, Font = new Font("Segoe UI", 10F) };

            label3 = new Label { Text = "Last Name", Font = new Font("Segoe UI", 10F), Location = new Point(530, 30), Width = 80 };
            txtLName = new TextBox { Name = "txtLName", Location = new Point(620, 27), Width = 130, Font = new Font("Segoe UI", 10F) };

            // Gender
            var lblGender = new Label { Text = "Gender", Font = new Font("Segoe UI", 10F), Location = new Point(10, 70), Width = 100 };
            radioM = new RadioButton { Text = "Male", Location = new Point(120, 68), Font = new Font("Segoe UI", 10F), FlatStyle = FlatStyle.Flat };
            radioF = new RadioButton { Text = "Female", Location = new Point(200, 68), Font = new Font("Segoe UI", 10F), FlatStyle = FlatStyle.Flat };

            groupPersonal.Controls.AddRange(new Control[] { label1, txtCusID, label2, txtFName, label3, txtLName, lblGender, radioM, radioF });
            mainPanel.Controls.Add(groupPersonal);

            // Contact Info Group
            var groupContact = new GroupBox
            {
                Text = "Contact Information",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 90,
                Padding = new Padding(20, 15, 20, 10),
                BackColor = Color.White
            };

            label4 = new Label { Text = "Mobile Phone", Font = new Font("Segoe UI", 10F), Location = new Point(10, 30), Width = 100 };
            txtTel = new TextBox { Name = "txtTel", Location = new Point(120, 27), Width = 180, Font = new Font("Segoe UI", 10F) };

            label5 = new Label { Text = "Email Address", Font = new Font("Segoe UI", 10F), Location = new Point(320, 30), Width = 100 };
            txtEmail = new TextBox { Name = "txtEmail", Location = new Point(430, 27), Width = 320, Font = new Font("Segoe UI", 10F) };

            groupContact.Controls.AddRange(new Control[] { label4, txtTel, label5, txtEmail });
            mainPanel.Controls.Add(groupContact);

            // Address Group
            var groupAddress = new GroupBox
            {
                Text = "Address Information",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 120,
                Padding = new Padding(20, 15, 20, 10),
                BackColor = Color.White
            };

            // Street
            label7 = new Label { Text = "Street", Font = new Font("Segoe UI", 10F), Location = new Point(10, 30), Width = 100 };
            txtStreet = new TextBox { Name = "txtStreet", Location = new Point(120, 27), Width = 200, Font = new Font("Segoe UI", 10F) };

            // City
            label8 = new Label { Text = "City", Font = new Font("Segoe UI", 10F), Location = new Point(340, 30), Width = 60 };
            txtCity = new TextBox { Name = "txtCity", Location = new Point(410, 27), Width = 150, Font = new Font("Segoe UI", 10F) };

            // Province/State
            label9 = new Label { Text = "Province/State", Font = new Font("Segoe UI", 10F), Location = new Point(10, 70), Width = 100 };
            txtProvince = new TextBox { Name = "txtProvince", Location = new Point(120, 67), Width = 200, Font = new Font("Segoe UI", 10F) };

            // Postal Code
            label10 = new Label { Text = "Postal Code", Font = new Font("Segoe UI", 10F), Location = new Point(340, 70), Width = 80 };
            txtPostal = new TextBox { Name = "txtPostal", Location = new Point(430, 67), Width = 130, Font = new Font("Segoe UI", 10F) };

            groupAddress.Controls.AddRange(new Control[] { label7, txtStreet, label8, txtCity, label9, txtProvince, label10, txtPostal });
            mainPanel.Controls.Add(groupAddress);

            // Buttons Panel (for bottom right alignment)
            var buttonsPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 70,
                BackColor = Color.FromArgb(236, 240, 241)
            };

            // Save Button
            var btnSave = new Button
            {
                Name = "btnSave",
                Text = "Save",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 120,
                Height = 44,
                Cursor = Cursors.Hand,
                Location = new Point(520, 13),
                TabIndex = 100
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 22, 22)
            );

            // Cancel Button
            var btnCancel = new Button
            {
                Name = "btnCancel",
                Text = "Cancel",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(189, 195, 199),
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Width = 120,
                Height = 44,
                Cursor = Cursors.Hand,
                Location = new Point(660, 13),
                TabIndex = 101
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, btnCancel.Width, btnCancel.Height, 22, 22)
            );

            buttonsPanel.Controls.Add(btnSave);
            buttonsPanel.Controls.Add(btnCancel);
            mainPanel.Controls.Add(buttonsPanel);

            // Add mainPanel to Form
            this.Controls.Add(mainPanel);

            // Form properties
            this.BackColor = Color.White;
            this.ClientSize = new Size(820, 520);
            this.Font = new Font("Segoe UI", 10F);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtCusID;
        private TextBox txtFName;
        private Label label2;
        private TextBox txtLName;
        private Label label3;
        private RadioButton radioM;
        private RadioButton radioF;
        private Label label4;
        private Label label5;
        private TextBox txtTel;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtStreet;
        private TextBox txtCity;
        private TextBox txtProvince;
        private TextBox txtPostal;
    }

    // Helper for rounded corners
    internal static class NativeMethods
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", SetLastError = true)]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}