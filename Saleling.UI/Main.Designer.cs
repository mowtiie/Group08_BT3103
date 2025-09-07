namespace Saleling.UI
{
    partial class Main
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
            btn_admin = new Button();
            btn_exit = new Button();
            btn_cashier = new Button();
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
            // btn_admin
            // 
            btn_admin.BackColor = Color.White;
            btn_admin.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_admin.ForeColor = SystemColors.ControlText;
            btn_admin.Location = new Point(267, 276);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(194, 78);
            btn_admin.TabIndex = 2;
            btn_admin.Text = "Admin";
            btn_admin.UseVisualStyleBackColor = false;
            btn_admin.Click += btn_admin_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(12, 562);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_cashier
            // 
            btn_cashier.BackColor = Color.White;
            btn_cashier.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cashier.Location = new Point(267, 383);
            btn_cashier.Name = "btn_cashier";
            btn_cashier.Size = new Size(194, 78);
            btn_cashier.TabIndex = 5;
            btn_cashier.Text = "Cahier";
            btn_cashier.UseVisualStyleBackColor = false;
            btn_cashier.Click += btn_cashier_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Sep_6__2025__08_56_49_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 603);
            Controls.Add(label2);
            Controls.Add(btn_cashier);
            Controls.Add(btn_exit);
            Controls.Add(btn_admin);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saleling";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_admin;
        private Button btn_exit;
        private Button btn_cashier;
        private Label label2;
    }
}
