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
            label1 = new Label();
            txtCusID = new TextBox();
            txtFName = new TextBox();
            label2 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            radioM = new RadioButton();
            radioF = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            txtTel = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtProvince = new TextBox();
            txtPostal = new TextBox();
            btnSave = new Button();
            bntClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 27);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer ID:";
            label1.Click += label1_Click;
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(162, 24);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(156, 27);
            txtCusID.TabIndex = 1;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(162, 79);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(156, 27);
            txtFName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 86);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(433, 79);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(111, 27);
            txtLName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 86);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // radioM
            // 
            radioM.AutoSize = true;
            radioM.Location = new Point(590, 84);
            radioM.Name = "radioM";
            radioM.Size = new Size(63, 24);
            radioM.TabIndex = 8;
            radioM.TabStop = true;
            radioM.Text = "Male";
            radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Location = new Point(672, 84);
            radioF.Name = "radioF";
            radioF.Size = new Size(78, 24);
            radioF.TabIndex = 9;
            radioF.TabStop = true;
            radioF.Text = "Female";
            radioF.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 145);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 10;
            label4.Text = "Mobile Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 202);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 11;
            label5.Text = "Email Address:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(162, 138);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(156, 27);
            txtTel.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 260);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 13;
            label6.Text = "Customer Address:";
            label6.Click += label6_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 27);
            txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 311);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 15;
            label7.Text = "Street:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(284, 311);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 16;
            label8.Text = "City:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(511, 311);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 17;
            label9.Text = "Province/State:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 376);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 18;
            label10.Text = "Postal Code:";
            label10.Click += label10_Click;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(109, 304);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(148, 27);
            txtStreet.TabIndex = 19;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(333, 304);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(146, 27);
            txtCity.TabIndex = 20;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(635, 308);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(144, 27);
            txtProvince.TabIndex = 21;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(162, 369);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(148, 27);
            txtPostal.TabIndex = 22;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(318, 444);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // bntClose
            // 
            bntClose.Location = new Point(464, 444);
            bntClose.Name = "bntClose";
            bntClose.Size = new Size(94, 29);
            bntClose.TabIndex = 24;
            bntClose.Text = "Close";
            bntClose.UseVisualStyleBackColor = true;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(865, 536);
            Controls.Add(bntClose);
            Controls.Add(btnSave);
            Controls.Add(txtPostal);
            Controls.Add(txtProvince);
            Controls.Add(txtCity);
            Controls.Add(txtStreet);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtTel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(radioF);
            Controls.Add(radioM);
            Controls.Add(txtLName);
            Controls.Add(label3);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(txtCusID);
            Controls.Add(label1);
            Name = "NewCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewCustomerForm";
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnSave;
        private Button bntClose;
    }
}