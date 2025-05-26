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
            mainPanel = new Panel();
            lblTitle = new Label();
            groupPersonal = new GroupBox();
            label1 = new Label();
            txtCusID = new TextBox();
            label2 = new Label();
            txtFName = new TextBox();
            label3 = new Label();
            txtLName = new TextBox();
            lblGender = new Label();
            radioM = new RadioButton();
            radioF = new RadioButton();
            groupContact = new GroupBox();
            label4 = new Label();
            txtTel = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            groupAddress = new GroupBox();
            label7 = new Label();
            txtStreet = new TextBox();
            label8 = new Label();
            txtCity = new TextBox();
            label9 = new Label();
            txtProvince = new TextBox();
            label10 = new Label();
            txtPostal = new TextBox();
            buttonsPanel = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            mainPanel.SuspendLayout();
            groupPersonal.SuspendLayout();
            groupContact.SuspendLayout();
            groupAddress.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(lblTitle);

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
            mainPanel.Controls.Add(groupContact);
            mainPanel.Controls.Add(groupAddress);
            mainPanel.Controls.Add(buttonsPanel);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(200, 100);
            mainPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 0;
            // 
            // groupPersonal
            // 
            groupPersonal.Controls.Add(label1);
            groupPersonal.Controls.Add(txtCusID);
            groupPersonal.Controls.Add(label2);
            groupPersonal.Controls.Add(txtFName);
            groupPersonal.Controls.Add(label3);
            groupPersonal.Controls.Add(txtLName);
            groupPersonal.Controls.Add(lblGender);
            groupPersonal.Controls.Add(radioM);
            groupPersonal.Controls.Add(radioF);
            groupPersonal.Location = new Point(0, 0);
            groupPersonal.Name = "groupPersonal";
            groupPersonal.Size = new Size(200, 100);
            groupPersonal.TabIndex = 1;
            groupPersonal.TabStop = false;
            groupPersonal.Enter += groupPersonal_Enter;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(0, 0);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(100, 30);
            txtCusID.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(0, 0);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(100, 30);
            txtFName.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(0, 0);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(100, 30);
            txtLName.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(0, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 6;
            // 
            // radioM
            // 
            radioM.Location = new Point(0, 0);
            radioM.Name = "radioM";
            radioM.Size = new Size(104, 24);
            radioM.TabIndex = 7;
            // 
            // radioF
            // 
            radioF.Location = new Point(0, 0);
            radioF.Name = "radioF";
            radioF.Size = new Size(104, 24);
            radioF.TabIndex = 8;
            // 
            // groupContact
            // 
            groupContact.Controls.Add(label4);
            groupContact.Controls.Add(txtTel);
            groupContact.Controls.Add(label5);
            groupContact.Controls.Add(txtEmail);
            groupContact.Location = new Point(0, 0);
            groupContact.Name = "groupContact";
            groupContact.Size = new Size(200, 100);
            groupContact.TabIndex = 2;
            groupContact.TabStop = false;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(0, 0);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 30);
            txtTel.TabIndex = 1;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 30);
            txtEmail.TabIndex = 3;
            // 
            // groupAddress
            // 
            groupAddress.Controls.Add(label7);
            groupAddress.Controls.Add(txtStreet);
            groupAddress.Controls.Add(label8);
            groupAddress.Controls.Add(txtCity);
            groupAddress.Controls.Add(label9);
            groupAddress.Controls.Add(txtProvince);
            groupAddress.Controls.Add(label10);
            groupAddress.Controls.Add(txtPostal);
            groupAddress.Location = new Point(0, 0);
            groupAddress.Name = "groupAddress";
            groupAddress.Size = new Size(200, 100);
            groupAddress.TabIndex = 3;
            groupAddress.TabStop = false;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(0, 0);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(100, 30);
            txtStreet.TabIndex = 1;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(0, 0);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 30);
            txtCity.TabIndex = 3;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 4;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(0, 0);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(100, 30);
            txtProvince.TabIndex = 5;
            // 
            // label10
            // 
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 6;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(0, 0);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(100, 30);
            txtPostal.TabIndex = 7;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnSave);
            buttonsPanel.Controls.Add(btnCancel);
            buttonsPanel.Location = new Point(0, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(200, 100);
            buttonsPanel.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Location = new Point(0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            // 
            // NewCustomerForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1116, 442);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 10F);
            Name = "NewCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Customer";
            mainPanel.ResumeLayout(false);
            groupPersonal.ResumeLayout(false);
            groupPersonal.PerformLayout();
            groupContact.ResumeLayout(false);
            groupContact.PerformLayout();
            groupAddress.ResumeLayout(false);
            groupAddress.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel mainPanel;
        private Label lblTitle;
        private GroupBox groupPersonal;
        private Label lblGender;
        private GroupBox groupContact;
        private GroupBox groupAddress;
        private Panel buttonsPanel;
        private Button btnSave;
        private Button btnCancel;
        }

    // Helper for rounded corners
    internal static class NativeMethods
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", SetLastError = true)]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}