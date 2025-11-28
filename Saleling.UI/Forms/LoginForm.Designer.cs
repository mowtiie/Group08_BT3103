namespace Saleling.UI
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pbClose = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            panel3 = new Panel();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            cbShowPassword = new CheckBox();
            btnLogin = new Button();
            label2 = new Label();
            inactivityTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pbClose
            // 
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(1066, 12);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(39, 37);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 1;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 617);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 372);
            label3.Name = "label3";
            label3.Size = new Size(374, 28);
            label3.TabIndex = 7;
            label3.Text = "A sale and inventory management system";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 55.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(52, 257);
            label1.Name = "label1";
            label1.Size = new Size(437, 104);
            label1.TabIndex = 1;
            label1.Text = "SALELING";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_clothing;
            pictureBox1.Location = new Point(204, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(602, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 59);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icon_user;
            pictureBox2.Location = new Point(15, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(60, 9);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(386, 36);
            txtUsername.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(602, 302);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 59);
            panel3.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(60, 9);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(386, 41);
            txtPassword.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icon_key;
            pictureBox3.Location = new Point(15, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cbShowPassword.Location = new Point(602, 376);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(151, 27);
            cbShowPassword.TabIndex = 3;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(602, 445);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 62);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(603, 130);
            label2.Name = "label2";
            label2.Size = new Size(150, 62);
            label2.TabIndex = 3;
            label2.Text = "Login";
            // 
            // inactivityTimer
            // 
            inactivityTimer.Interval = 300000;
            inactivityTimer.Tick += inactivityTimer_Tick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1117, 617);
            Controls.Add(btnLogin);
            Controls.Add(cbShowPassword);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pbClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbClose;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private TextBox txtUsername;
        private Panel panel3;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private CheckBox cbShowPassword;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer inactivityTimer;
    }
}
