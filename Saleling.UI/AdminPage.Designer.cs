namespace Saleling.UI
{
    partial class AdminPage
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
            menuAdmin = new MenuStrip();
            menuItemDashboard = new ToolStripMenuItem();
            menuItemProducts = new ToolStripMenuItem();
            menuItemInventory = new ToolStripMenuItem();
            menuItemSales = new ToolStripMenuItem();
            menuItemReports = new ToolStripMenuItem();
            menuItemLogout = new ToolStripMenuItem();
            menuAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // menuAdmin
            // 
            menuAdmin.BackColor = Color.FromArgb(64, 64, 64);
            menuAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            menuAdmin.ImageScalingSize = new Size(20, 20);
            menuAdmin.Items.AddRange(new ToolStripItem[] { menuItemDashboard, menuItemProducts, menuItemInventory, menuItemSales, menuItemReports, menuItemLogout });
            menuAdmin.Location = new Point(0, 0);
            menuAdmin.Name = "menuAdmin";
            menuAdmin.Size = new Size(1920, 36);
            menuAdmin.TabIndex = 0;
            menuAdmin.Text = "menuStrip1";
            // 
            // menuItemDashboard
            // 
            menuItemDashboard.ForeColor = SystemColors.Control;
            menuItemDashboard.Name = "menuItemDashboard";
            menuItemDashboard.Size = new Size(124, 32);
            menuItemDashboard.Text = "Dashboard";
            // 
            // menuItemProducts
            // 
            menuItemProducts.ForeColor = SystemColors.Control;
            menuItemProducts.Name = "menuItemProducts";
            menuItemProducts.Size = new Size(106, 32);
            menuItemProducts.Text = "Products";
            // 
            // menuItemInventory
            // 
            menuItemInventory.ForeColor = SystemColors.Control;
            menuItemInventory.Name = "menuItemInventory";
            menuItemInventory.Size = new Size(114, 32);
            menuItemInventory.Text = "Inventory";
            // 
            // menuItemSales
            // 
            menuItemSales.ForeColor = SystemColors.Control;
            menuItemSales.Name = "menuItemSales";
            menuItemSales.Size = new Size(72, 32);
            menuItemSales.Text = "Sales";
            // 
            // menuItemReports
            // 
            menuItemReports.ForeColor = SystemColors.Control;
            menuItemReports.Name = "menuItemReports";
            menuItemReports.Size = new Size(96, 32);
            menuItemReports.Text = "Reports";
            // 
            // menuItemLogout
            // 
            menuItemLogout.ForeColor = SystemColors.Control;
            menuItemLogout.Name = "menuItemLogout";
            menuItemLogout.Size = new Size(91, 32);
            menuItemLogout.Text = "Logout";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(menuAdmin);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuAdmin;
            Name = "AdminPage";
            Text = "Admin Dashboard";
            Load += AdminPage_Load;
            menuAdmin.ResumeLayout(false);
            menuAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuAdmin;
        private ToolStripMenuItem menuItemDashboard;
        private ToolStripMenuItem menuItemProducts;
        private ToolStripMenuItem menuItemInventory;
        private ToolStripMenuItem menuItemSales;
        private ToolStripMenuItem menuItemReports;
        private ToolStripMenuItem menuItemLogout;
    }
}