namespace Saleling.UI
{
    partial class AdminLoginForm
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
            btn_login = new Button();
            field_username = new TextBox();
            field_password = new TextBox();
            btn_back = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(187, 323);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(150, 49);
            btn_login.TabIndex = 0;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // field_username
            // 
            field_username.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            field_username.Location = new Point(86, 129);
            field_username.Multiline = true;
            field_username.Name = "field_username";
            field_username.Size = new Size(360, 54);
            field_username.TabIndex = 1;
            // 
            // field_password
            // 
            field_password.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            field_password.Location = new Point(86, 231);
            field_password.Multiline = true;
            field_password.Name = "field_password";
            field_password.Size = new Size(360, 54);
            field_password.TabIndex = 2;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(212, 385);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(106, 29);
            btn_back.TabIndex = 3;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 101);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 203);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 27);
            label3.Name = "label3";
            label3.Size = new Size(321, 40);
            label3.TabIndex = 6;
            label3.Text = "Welcome Back! Admin";
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(540, 428);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_back);
            Controls.Add(field_password);
            Controls.Add(field_username);
            Controls.Add(btn_login);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox field_username;
        private TextBox field_password;
        private Button btn_back;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}