namespace window_form_dotnet
{
    partial class NewProductForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            checkedListBox1 = new CheckedListBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            pictureBox = new PictureBox();
            button1 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            checkedListBox2 = new CheckedListBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 51);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 113);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 402);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 4;
            label3.Text = "Buy From Supplier:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(509, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 117);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 6;
            label4.Text = "Barcode:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 257);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 8;
            label5.Text = "Product Description:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(207, 280);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(540, 87);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 177);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 10;
            label6.Text = "Category:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Category1", "Category2", "Category3" });
            checkedListBox1.Location = new Point(207, 166);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(118, 70);
            checkedListBox1.TabIndex = 12;
            // 
            // pictureBox
            // 
            pictureBox.AccessibleName = "";
            pictureBox.BackColor = SystemColors.ButtonShadow;
            pictureBox.Location = new Point(692, 51);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(178, 146);
            pictureBox.TabIndex = 13;
            pictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(309, 633);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(156, 501);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 27);
            textBox5.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(419, 402);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 15;
            label7.Text = "Perchased Date:";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Supplier 1", "Supplier 2", "Supplier 3" });
            checkedListBox2.Location = new Point(224, 402);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 70);
            checkedListBox2.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 505);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 18;
            label8.Text = "Cost:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(419, 425);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(74, 566);
            label9.Name = "label9";
            label9.Size = new Size(35, 20);
            label9.TabIndex = 20;
            label9.Text = "Qty:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(357, 508);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 22;
            label10.Text = "Selling Price:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(490, 505);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(156, 559);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 27);
            textBox6.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(509, 633);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NewProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(916, 703);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(checkedListBox2);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(pictureBox);
            Controls.Add(checkedListBox1);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "NewProductForm";
            Text = "NewProductForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckedListBox checkedListBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private PictureBox pictureBox;
        private Button button1;
        private TextBox textBox5;
        private Label label7;
        private CheckedListBox checkedListBox2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private TextBox textBox6;
        private Button button2;
    }
}