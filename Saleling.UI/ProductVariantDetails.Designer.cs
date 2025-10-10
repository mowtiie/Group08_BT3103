namespace Saleling.UI
{
    partial class ProductVariantDetails
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
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(343, 38);
            label1.TabIndex = 0;
            label1.Text = "Stock keeping unit (SKU)*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 116);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(746, 47);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(54, 203);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 2;
            label2.Text = "Units in Stock";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 259);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(366, 47);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(434, 203);
            label3.Name = "label3";
            label3.Size = new Size(183, 38);
            label3.TabIndex = 4;
            label3.Text = "Reorder level";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(434, 259);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(366, 47);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(54, 339);
            label4.Name = "label4";
            label4.Size = new Size(79, 38);
            label4.TabIndex = 6;
            label4.Text = "Size*";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(54, 390);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 49);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(434, 339);
            label5.Name = "label5";
            label5.Size = new Size(97, 38);
            label5.TabIndex = 8;
            label5.Text = "Color*";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 18F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(434, 390);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(366, 49);
            comboBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(54, 504);
            button1.Name = "button1";
            button1.Size = new Size(208, 48);
            button1.TabIndex = 10;
            button1.Text = "Save Variant";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(284, 504);
            button2.Name = "button2";
            button2.Size = new Size(208, 48);
            button2.TabIndex = 11;
            button2.Text = "Close Window";
            button2.UseVisualStyleBackColor = false;
            // 
            // ProductVariantDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(857, 608);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Location = new Point(54, 116);
            Name = "ProductVariantDetails";
            Text = "ProductVariantDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
    }
}