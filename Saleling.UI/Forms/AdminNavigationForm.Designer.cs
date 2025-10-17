namespace Saleling.UI
{
    partial class AdminNavigationForm
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
            lblRole = new Label();
            lblName = new Label();
            drawerPanel = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnInventory = new Button();
            btnSuppliers = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnUsers = new Button();
            btnDashboard = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            drawerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 48, 86);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(-12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 232);
            panel1.TabIndex = 0;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 14F);
            lblRole.ForeColor = SystemColors.Control;
            lblRole.Location = new Point(117, 126);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(158, 32);
            lblRole.TabIndex = 1;
            lblRole.Text = "Administrator";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblName.ForeColor = SystemColors.Control;
            lblName.Location = new Point(62, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(282, 37);
            lblName.TabIndex = 0;
            lblName.Text = "System Administrator";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drawerPanel
            // 
            drawerPanel.BackColor = SystemColors.Highlight;
            drawerPanel.Controls.Add(btnLogout);
            drawerPanel.Controls.Add(btnReports);
            drawerPanel.Controls.Add(btnInventory);
            drawerPanel.Controls.Add(btnSuppliers);
            drawerPanel.Controls.Add(btnCategories);
            drawerPanel.Controls.Add(btnProducts);
            drawerPanel.Controls.Add(btnUsers);
            drawerPanel.Controls.Add(btnDashboard);
            drawerPanel.Controls.Add(panel1);
            drawerPanel.Location = new Point(0, 0);
            drawerPanel.Name = "drawerPanel";
            drawerPanel.Size = new Size(373, 1080);
            drawerPanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Highlight;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 845);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(16, 0, 0, 0);
            btnLogout.Size = new Size(376, 89);
            btnLogout.TabIndex = 8;
            btnLogout.Text = " Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.Highlight;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Image = Properties.Resources.report;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 756);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(16, 0, 0, 0);
            btnReports.Size = new Size(376, 89);
            btnReports.TabIndex = 7;
            btnReports.Text = " Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = SystemColors.Highlight;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Image = Properties.Resources.inventory;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 668);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(16, 0, 0, 0);
            btnInventory.Size = new Size(376, 89);
            btnInventory.TabIndex = 6;
            btnInventory.Text = " Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = SystemColors.Highlight;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Image = Properties.Resources.supplier;
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(0, 581);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Padding = new Padding(16, 0, 0, 0);
            btnSuppliers.Size = new Size(376, 89);
            btnSuppliers.TabIndex = 5;
            btnSuppliers.Text = " Suppliers";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = SystemColors.Highlight;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Image = Properties.Resources.category;
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategories.Location = new Point(0, 408);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(16, 0, 0, 0);
            btnCategories.Size = new Size(376, 89);
            btnCategories.TabIndex = 4;
            btnCategories.Text = " Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.Highlight;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = Properties.Resources.product;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 497);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(16, 0, 0, 0);
            btnProducts.Size = new Size(376, 89);
            btnProducts.TabIndex = 3;
            btnProducts.Text = " Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = SystemColors.Highlight;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnUsers.ForeColor = Color.White;
            btnUsers.Image = Properties.Resources.users;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 319);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(16, 0, 0, 0);
            btnUsers.Size = new Size(376, 89);
            btnUsers.TabIndex = 2;
            btnUsers.Text = " Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.Highlight;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 232);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(16, 0, 0, 0);
            btnDashboard.Size = new Size(376, 89);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = " Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // AdminNavigationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(drawerPanel);
            ForeColor = SystemColors.ButtonShadow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminNavigationForm";
            Padding = new Padding(24, 0, 0, 0);
            Text = "AdminNavigation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            drawerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel drawerPanel;
        private Label lblName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblRole;
        private Button btnDashboard;
        private Button btnReports;
        private Button btnInventory;
        private Button btnSuppliers;
        private Button btnCategories;
        private Button btnProducts;
        private Button btnUsers;
        private Button btnLogout;
    }
}