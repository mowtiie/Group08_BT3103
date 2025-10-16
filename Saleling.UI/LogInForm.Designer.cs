namespace Saleling.UI
{
    partial class LoginForm
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
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            txtPassword = new TextBox();
            chkboxShowPassword = new CheckBox();
            btnLogin = new Button();
            pbClose = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 617);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hanger_2_svgrepo_com__1_;
            pictureBox3.Location = new Point(204, 115);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(132, 112);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 372);
            label3.Name = "label3";
            label3.Size = new Size(374, 28);
            label3.TabIndex = 1;
            label3.Text = "A sale and inventory management system";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 55.8000031F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(52, 257);
            label2.Name = "label2";
            label2.Size = new Size(437, 104);
            label2.TabIndex = 0;
            label2.Text = "SALELING";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(603, 130);
            label1.Name = "label1";
            label1.Size = new Size(150, 62);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(602, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 59);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.man_user_svgrepo_com;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 16F);
            txtUsername.Location = new Point(60, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(386, 36);
            txtUsername.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(txtPassword);
            panel3.Location = new Point(602, 302);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 59);
            panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key_svgrepo_com;
            pictureBox2.Location = new Point(15, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 16F);
            txtPassword.Location = new Point(60, 11);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(386, 36);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkboxShowPassword
            // 
            chkboxShowPassword.AutoSize = true;
            chkboxShowPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            chkboxShowPassword.Location = new Point(602, 376);
            chkboxShowPassword.Name = "chkboxShowPassword";
            chkboxShowPassword.Size = new Size(151, 27);
            chkboxShowPassword.TabIndex = 4;
            chkboxShowPassword.Text = "Show Password";
            chkboxShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(602, 445);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 62);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pbClose
            // 
            pbClose.BackgroundImageLayout = ImageLayout.Center;
            pbClose.Cursor = Cursors.Hand;
            pbClose.ErrorImage = null;
            pbClose.Image = Properties.Resources.close;
            pbClose.Location = new Point(1075, 12);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(30, 33);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 2;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 617);
            Controls.Add(pbClose);
            Controls.Add(btnLogin);
            Controls.Add(chkboxShowPassword);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LogInForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtUsername;
        private Panel panel3;
        private TextBox txtPassword;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox chkboxShowPassword;
        private PictureBox pictureBox3;
        private Label label3;
        private Button btnLogin;
        private PictureBox pbClose;
    }
}