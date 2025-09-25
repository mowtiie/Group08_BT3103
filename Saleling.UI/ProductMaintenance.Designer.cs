namespace Saleling.UI
{
    partial class ProductMaintenancUI
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1873, 57);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(817, 14);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(249, 249, 249);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1873, 188);
            dataGridView1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(249, 249, 249);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(1873, 92);
            panel3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(441, 10);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Search by:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(441, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(612, 42);
            button2.Name = "button2";
            button2.Size = new Size(121, 34);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(21, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 34);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 10);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 0;
            label4.Text = "Search Product:";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(224, 47);
            button1.TabIndex = 7;
            button1.Text = "Add New Product";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(422, 85);
            button4.Name = "button4";
            button4.Size = new Size(148, 47);
            button4.TabIndex = 11;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(256, 85);
            button3.Name = "button3";
            button3.Size = new Size(148, 47);
            button3.TabIndex = 10;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // ProductMaintenancUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1897, 993);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Name = "ProductMaintenancUI";
            Text = "Product Maintenance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label3;
        private ComboBox comboBox1;
        private Button button2;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}