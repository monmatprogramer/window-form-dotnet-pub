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
            groupAddress = new GroupBox();
            txtPostal = new TextBox();
            label10 = new Label();
            txtProvince = new TextBox();
            label9 = new Label();
            txtCity = new TextBox();
            label8 = new Label();
            txtStreet = new TextBox();
            label7 = new Label();
            groupContact = new GroupBox();
            txtEmail = new TextBox();
            label5 = new Label();
            txtTel = new TextBox();
            label4 = new Label();
            groupPersonal = new GroupBox();
            radioF = new RadioButton();
            radioM = new RadioButton();
            lblGender = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            txtCusID = new TextBox();
            label1 = new Label();
            lblTitle = new Label();
            buttonsPanel = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            mainPanel.SuspendLayout();
            groupAddress.SuspendLayout();
            groupContact.SuspendLayout();
            groupPersonal.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(groupAddress);
            mainPanel.Controls.Add(groupContact);
            mainPanel.Controls.Add(groupPersonal);
            mainPanel.Controls.Add(lblTitle);
            mainPanel.Controls.Add(buttonsPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(820, 520);
            mainPanel.TabIndex = 0;
            // 
            // groupAddress
            // 
            groupAddress.BackColor = Color.White;
            groupAddress.Controls.Add(txtPostal);
            groupAddress.Controls.Add(label10);
            groupAddress.Controls.Add(txtProvince);
            groupAddress.Controls.Add(label9);
            groupAddress.Controls.Add(txtCity);
            groupAddress.Controls.Add(label8);
            groupAddress.Controls.Add(txtStreet);
            groupAddress.Controls.Add(label7);
            groupAddress.Dock = DockStyle.Top;
            groupAddress.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupAddress.Location = new Point(0, 280);
            groupAddress.Name = "groupAddress";
            groupAddress.Padding = new Padding(20, 15, 20, 10);
            groupAddress.Size = new Size(820, 120);
            groupAddress.TabIndex = 3;
            groupAddress.TabStop = false;
            groupAddress.Text = "Address Information";
            // 
            // txtPostal
            // 
            txtPostal.Font = new Font("Segoe UI", 10F);
            txtPostal.Location = new Point(450, 87);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(130, 30);
            txtPostal.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(360, 90);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 6;
            label10.Text = "Postal Code";
            // 
            // txtProvince
            // 
            txtProvince.Font = new Font("Segoe UI", 10F);
            txtProvince.Location = new Point(140, 87);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(200, 30);
            txtProvince.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(30, 90);
            label9.Name = "label9";
            label9.Size = new Size(120, 23);
            label9.TabIndex = 4;
            label9.Text = "Province/State";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(430, 47);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 30);
            txtCity.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(360, 50);
            label8.Name = "label8";
            label8.Size = new Size(39, 23);
            label8.TabIndex = 2;
            label8.Text = "City";
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Segoe UI", 10F);
            txtStreet.Location = new Point(140, 47);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(200, 30);
            txtStreet.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(30, 50);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 0;
            label7.Text = "Street";
            // 
            // groupContact
            // 
            groupContact.BackColor = Color.White;
            groupContact.Controls.Add(txtEmail);
            groupContact.Controls.Add(label5);
            groupContact.Controls.Add(txtTel);
            groupContact.Controls.Add(label4);
            groupContact.Dock = DockStyle.Top;
            groupContact.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupContact.Location = new Point(0, 190);
            groupContact.Name = "groupContact";
            groupContact.Padding = new Padding(20, 15, 20, 10);
            groupContact.Size = new Size(820, 90);
            groupContact.TabIndex = 2;
            groupContact.TabStop = false;
            groupContact.Text = "Contact Information";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(450, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 30);
            txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(340, 50);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 2;
            label5.Text = "Email Address";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 10F);
            txtTel.Location = new Point(140, 47);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(180, 30);
            txtTel.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(30, 50);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 0;
            label4.Text = "Mobile Phone";
            // 
            // groupPersonal
            // 
            groupPersonal.BackColor = Color.White;
            groupPersonal.Controls.Add(radioF);
            groupPersonal.Controls.Add(radioM);
            groupPersonal.Controls.Add(lblGender);
            groupPersonal.Controls.Add(txtLName);
            groupPersonal.Controls.Add(label3);
            groupPersonal.Controls.Add(txtFName);
            groupPersonal.Controls.Add(label2);
            groupPersonal.Controls.Add(txtCusID);
            groupPersonal.Controls.Add(label1);
            groupPersonal.Dock = DockStyle.Top;
            groupPersonal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupPersonal.Location = new Point(0, 70);
            groupPersonal.Name = "groupPersonal";
            groupPersonal.Padding = new Padding(20, 15, 20, 10);
            groupPersonal.Size = new Size(820, 120);
            groupPersonal.TabIndex = 1;
            groupPersonal.TabStop = false;
            groupPersonal.Text = "Personal Information";
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.FlatStyle = FlatStyle.Flat;
            radioF.Font = new Font("Segoe UI", 10F);
            radioF.Location = new Point(220, 88);
            radioF.Name = "radioF";
            radioF.Size = new Size(84, 27);
            radioF.TabIndex = 8;
            radioF.TabStop = true;
            radioF.Text = "Female";
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            radioM.AutoSize = true;
            radioM.FlatStyle = FlatStyle.Flat;
            radioM.Font = new Font("Segoe UI", 10F);
            radioM.Location = new Point(140, 88);
            radioM.Name = "radioM";
            radioM.Size = new Size(67, 27);
            radioM.TabIndex = 7;
            radioM.TabStop = true;
            radioM.Text = "Male";
            radioM.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10F);
            lblGender.Location = new Point(30, 90);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(66, 23);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Segoe UI", 10F);
            txtLName.Location = new Point(640, 47);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(130, 30);
            txtLName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(550, 50);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Segoe UI", 10F);
            txtFName.Location = new Point(400, 47);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(130, 30);
            txtFName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(310, 50);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // txtCusID
            // 
            txtCusID.Font = new Font("Segoe UI", 10F);
            txtCusID.Location = new Point(140, 47);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(150, 30);
            txtCusID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(30, 50);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "Customer ID";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(236, 240, 241);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(820, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Customer";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = Color.FromArgb(236, 240, 241);
            buttonsPanel.Controls.Add(btnCancel);
            buttonsPanel.Controls.Add(btnSave);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.Location = new Point(0, 450);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(820, 70);
            buttonsPanel.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(189, 195, 199);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(660, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(520, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            //btnSave.Click += btnSave_Click;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(820, 520);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 10F);
            Name = "NewCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Customer";
            mainPanel.ResumeLayout(false);
            groupAddress.ResumeLayout(false);
            groupAddress.PerformLayout();
            groupContact.ResumeLayout(false);
            groupContact.PerformLayout();
            groupPersonal.ResumeLayout(false);
            groupPersonal.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupAddress;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupPersonal;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label6;
        }
    }