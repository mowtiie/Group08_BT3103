namespace Saleling.UI
{
    partial class CashierPage
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
            menuCashier = new MenuStrip();
            menuItemDashboard = new ToolStripMenuItem();
            menuItemPOS = new ToolStripMenuItem();
            menuItemProducts = new ToolStripMenuItem();
            menuItemTransactions = new ToolStripMenuItem();
            menuItemReports = new ToolStripMenuItem();
            menuItemLogout = new ToolStripMenuItem();
            menuCashier.SuspendLayout();
            SuspendLayout();
            // 
            // menuCashier
            // 
            menuCashier.BackColor = Color.FromArgb(64, 64, 64);
            menuCashier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            menuCashier.ImageScalingSize = new Size(20, 20);
            menuCashier.Items.AddRange(new ToolStripItem[] { menuItemDashboard, menuItemPOS, menuItemProducts, menuItemTransactions, menuItemReports, menuItemLogout });
            menuCashier.Location = new Point(0, 0);
            menuCashier.Name = "menuCashier";
            menuCashier.Size = new Size(1920, 36);
            menuCashier.TabIndex = 1;
            // 
            // menuItemDashboard
            // 
            menuItemDashboard.ForeColor = SystemColors.Control;
            menuItemDashboard.Name = "menuItemDashboard";
            menuItemDashboard.Size = new Size(124, 32);
            menuItemDashboard.Text = "Dashboard";
            // 
            // menuItemPOS
            // 
            menuItemPOS.ForeColor = SystemColors.Control;
            menuItemPOS.Name = "menuItemPOS";
            menuItemPOS.Size = new Size(64, 32);
            menuItemPOS.Text = "POS";
            // 
            // menuItemProducts
            // 
            menuItemProducts.ForeColor = SystemColors.Control;
            menuItemProducts.Name = "menuItemProducts";
            menuItemProducts.Size = new Size(106, 32);
            menuItemProducts.Text = "Products";
            // 
            // menuItemTransactions
            // 
            menuItemTransactions.ForeColor = SystemColors.Control;
            menuItemTransactions.Name = "menuItemTransactions";
            menuItemTransactions.Size = new Size(137, 32);
            menuItemTransactions.Text = "Transactions";
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
            menuItemLogout.Click += menuItemLogout_Click;
            // 
            // CashierPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(menuCashier);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierPage";
            Text = "Cashier Dashboard";
            Load += CashierPage_Load;
            menuCashier.ResumeLayout(false);
            menuCashier.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuCashier;
        private ToolStripMenuItem menuItemDashboard;
        private ToolStripMenuItem menuItemPOS;
        private ToolStripMenuItem menuItemProducts;
        private ToolStripMenuItem menuItemTransactions;
        private ToolStripMenuItem menuItemReports;
        private ToolStripMenuItem menuItemLogout;
    }
}