namespace Saleling.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 60F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 133);
            label1.TabIndex = 1;
            label1.Text = "Saleling";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(267, 276);
            button1.Name = "button1";
            button1.Size = new Size(194, 78);
            button1.TabIndex = 2;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 562);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(267, 383);
            button2.Name = "button2";
            button2.Size = new Size(194, 78);
            button2.TabIndex = 5;
            button2.Text = "Cahier";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Fax", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 227);
            label2.Name = "label2";
            label2.Size = new Size(362, 36);
            label2.TabIndex = 6;
            label2.Text = "Choose Your Account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Sep_6__2025__08_56_49_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 603);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label2;
    }
}
