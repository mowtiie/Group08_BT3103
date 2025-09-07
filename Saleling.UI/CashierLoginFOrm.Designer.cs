namespace Saleling.UI
{
    partial class cashierlogin
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_back = new Button();
            field_password = new TextBox();
            field_username = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(90, 21);
            label3.Name = "label3";
            label3.Size = new Size(334, 40);
            label3.TabIndex = 13;
            label3.Text = "Welcome Back! Cashier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(90, 197);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(90, 95);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(216, 379);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(106, 29);
            btn_back.TabIndex = 10;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // field_password
            // 
            field_password.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            field_password.Location = new Point(90, 225);
            field_password.Multiline = true;
            field_password.Name = "field_password";
            field_password.Size = new Size(360, 54);
            field_password.TabIndex = 9;
            // 
            // field_username
            // 
            field_username.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            field_username.Location = new Point(90, 123);
            field_username.Multiline = true;
            field_username.Name = "field_username";
            field_username.Size = new Size(360, 54);
            field_username.TabIndex = 8;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(191, 317);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(150, 49);
            btn_login.TabIndex = 7;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // cashierlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Name = "cashierlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_back;
        private TextBox field_password;
        private TextBox field_username;
        private Button btn_login;
    }
}