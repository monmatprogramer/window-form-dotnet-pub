namespace window_form_dotnet
{
    partial class NewSupplierForm
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
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSupID = new TextBox();
            txtSupName = new TextBox();
            txtSupCon = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSupTel = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtAddress = new RichTextBox();
            txtNote = new RichTextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(304, 467);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(515, 467);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 40);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Supplier ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 109);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Supplier Name:";
            // 
            // txtSupID
            // 
            txtSupID.Location = new Point(223, 40);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new Size(141, 27);
            txtSupID.TabIndex = 4;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(223, 106);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(317, 27);
            txtSupName.TabIndex = 6;
            // 
            // txtSupCon
            // 
            txtSupCon.Location = new Point(223, 173);
            txtSupCon.Name = "txtSupCon";
            txtSupCon.Size = new Size(175, 27);
            txtSupCon.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 176);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "Contact Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 243);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Address:";
            // 
            // txtSupTel
            // 
            txtSupTel.Location = new Point(515, 173);
            txtSupTel.Name = "txtSupTel";
            txtSupTel.Size = new Size(141, 27);
            txtSupTel.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 176);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 11;
            label5.Text = "Tel:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 357);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 13;
            label6.Text = "Note:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(223, 243);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(433, 75);
            txtAddress.TabIndex = 15;
            txtAddress.Text = "";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(223, 354);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(433, 75);
            txtNote.TabIndex = 16;
            txtNote.Text = "";
            // 
            // NewSupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(891, 558);
            Controls.Add(txtNote);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtSupTel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSupCon);
            Controls.Add(label3);
            Controls.Add(txtSupName);
            Controls.Add(txtSupID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "NewSupplierForm";
            Text = "NewSupplierForm";
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private TextBox txtSupID;
        private TextBox txtSupName;
        private TextBox txtSupCon;
        private Label label3;
        private Label label4;
        private TextBox txtSupTel;
        private Label label5;
        private Label label6;
        private RichTextBox txtAddress;
        private RichTextBox txtNote;
    }
}