namespace Saleling.UI
{
    partial class CashierNavigationForm
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
            drawerPanel = new Panel();
            panel1 = new Panel();
            lblUsername = new Label();
            lblRole = new Label();
            btnPOS = new Button();
            btnReports = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            btnLogout = new Button();
            contentPanel = new Panel();
            pictureBox1 = new PictureBox();
            drawerPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // drawerPanel
            // 
            drawerPanel.BackColor = SystemColors.Highlight;
            drawerPanel.Controls.Add(btnLogout);
            drawerPanel.Controls.Add(panel1);
            drawerPanel.Controls.Add(btnPOS);
            drawerPanel.Controls.Add(btnDashboard);
            drawerPanel.Controls.Add(btnProducts);
            drawerPanel.Controls.Add(btnReports);
            drawerPanel.Dock = DockStyle.Left;
            drawerPanel.Location = new Point(0, 0);
            drawerPanel.Name = "drawerPanel";
            drawerPanel.Size = new Size(373, 1080);
            drawerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 48, 86);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblRole);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 324);
            panel1.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblUsername.ForeColor = SystemColors.Control;
            lblUsername.Location = new Point(58, 193);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(262, 37);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Adrienne Jalocon";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 14F);
            lblRole.ForeColor = SystemColors.Control;
            lblRole.Location = new Point(58, 249);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(262, 37);
            lblRole.TabIndex = 8;
            lblRole.Text = "Cashier";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPOS
            // 
            btnPOS.BackColor = SystemColors.Highlight;
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnPOS.ForeColor = Color.White;
            btnPOS.Image = Properties.Resources.icon_sale;
            btnPOS.ImageAlign = ContentAlignment.MiddleLeft;
            btnPOS.Location = new Point(0, 405);
            btnPOS.Name = "btnPOS";
            btnPOS.Padding = new Padding(24, 0, 0, 0);
            btnPOS.Size = new Size(379, 89);
            btnPOS.TabIndex = 9;
            btnPOS.Text = "  POS";
            btnPOS.TextAlign = ContentAlignment.MiddleLeft;
            btnPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.Highlight;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Image = Properties.Resources.icon_report;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 576);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(24, 0, 0, 0);
            btnReports.Size = new Size(379, 89);
            btnReports.TabIndex = 7;
            btnReports.Text = "  Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.Highlight;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = Properties.Resources.icon_product;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 491);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(24, 0, 0, 0);
            btnProducts.Size = new Size(379, 89);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "  Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.Highlight;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.icon_home;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 320);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(24, 0, 0, 0);
            btnDashboard.Size = new Size(379, 89);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Highlight;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.icon_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 660);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(24, 0, 0, 0);
            btnLogout.Size = new Size(379, 89);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(373, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1547, 1080);
            contentPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_cashier;
            pictureBox1.Location = new Point(100, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CashierNavigationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(contentPanel);
            Controls.Add(drawerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierNavigationForm";
            Text = "CashierDashboard";
            Load += CashierDashboard_Load;
            drawerPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel drawerPanel;
        private Panel panel1;
        private Label lblUsername;
        private Label lblRole;
        private Button btnReports;
        private Button btnProducts;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnPOS;
        private Panel contentPanel;
        private PictureBox pictureBox1;
    }
}