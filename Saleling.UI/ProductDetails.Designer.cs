namespace Saleling.UI
{
    partial class ProductDetails
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
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(55, 47);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 0;
            label1.Text = "Name*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 103);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 47);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(435, 47);
            label2.Name = "label2";
            label2.Size = new Size(157, 38);
            label2.TabIndex = 3;
            label2.Text = "Base Price*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(435, 103);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(366, 47);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(55, 193);
            label3.Name = "label3";
            label3.Size = new Size(145, 38);
            label3.TabIndex = 5;
            label3.Text = "Category*";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(55, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 49);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(435, 193);
            label4.Name = "label4";
            label4.Size = new Size(121, 38);
            label4.TabIndex = 7;
            label4.Text = "Supplier";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 18F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(435, 244);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(366, 49);
            comboBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(55, 344);
            label5.Name = "label5";
            label5.Size = new Size(161, 38);
            label5.TabIndex = 9;
            label5.Text = "Description";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(55, 396);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(746, 187);
            textBox3.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button1.Location = new Point(54, 613);
            button1.Name = "button1";
            button1.Size = new Size(208, 48);
            button1.TabIndex = 11;
            button1.Text = "Save Product";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button2.Location = new Point(284, 613);
            button2.Name = "button2";
            button2.Size = new Size(208, 48);
            button2.TabIndex = 12;
            button2.Text = "Close Window";
            button2.UseVisualStyleBackColor = false;
            // 
            // ProductDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(857, 702);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "ProductDetails";
            Text = "ProductDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}