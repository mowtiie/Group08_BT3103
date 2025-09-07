namespace Saleling.UI
{
    partial class CashierLogin
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
            checkbox_show_password = new CheckBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(91, 34);
            label3.Name = "label3";
            label3.Size = new Size(334, 40);
            label3.TabIndex = 20;
            label3.Text = "Welcome Back! Cashier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(91, 210);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 19;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(91, 108);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 18;
            label1.Text = "Username";
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(91, 434);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(360, 49);
            btn_back.TabIndex = 17;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // field_password
            // 
            field_password.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            field_password.Location = new Point(91, 238);
            field_password.Multiline = true;
            field_password.Name = "field_password";
            field_password.PasswordChar = '*';
            field_password.Size = new Size(360, 54);
            field_password.TabIndex = 16;
            // 
            // field_username
            // 
            field_username.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            field_username.Location = new Point(91, 136);
            field_username.Multiline = true;
            field_username.Name = "field_username";
            field_username.Size = new Size(360, 54);
            field_username.TabIndex = 15;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.HotTrack;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(91, 370);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(360, 49);
            btn_login.TabIndex = 14;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // checkbox_show_password
            // 
            checkbox_show_password.AutoSize = true;
            checkbox_show_password.Location = new Point(91, 307);
            checkbox_show_password.Name = "checkbox_show_password";
            checkbox_show_password.Size = new Size(132, 24);
            checkbox_show_password.TabIndex = 21;
            checkbox_show_password.Text = "Show Password";
            checkbox_show_password.UseVisualStyleBackColor = true;
            checkbox_show_password.CheckedChanged += checkbox_show_password_CheckedChanged;
            // 
            // CashierLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(540, 508);
            Controls.Add(checkbox_show_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_back);
            Controls.Add(field_password);
            Controls.Add(field_username);
            Controls.Add(btn_login);
            Name = "CashierLoginForm";
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
        private CheckBox checkbox_show_password;
    }
}