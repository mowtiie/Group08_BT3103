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
            adminMenu = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            adminMenu.SuspendLayout();
            SuspendLayout();
            // 
            // adminMenu
            // 
            adminMenu.BackColor = Color.FromArgb(77, 157, 152);
            adminMenu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminMenu.ImageScalingSize = new Size(20, 20);
            adminMenu.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, productsToolStripMenuItem, inventoryToolStripMenuItem, salesToolStripMenuItem, reportToolStripMenuItem, logoutToolStripMenuItem });
            adminMenu.Location = new Point(0, 0);
            adminMenu.Name = "adminMenu";
            adminMenu.Size = new Size(1902, 31);
            adminMenu.TabIndex = 0;
            adminMenu.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(107, 27);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(91, 27);
            productsToolStripMenuItem.Text = "Products";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(96, 27);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(62, 27);
            salesToolStripMenuItem.Text = "Sales";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(75, 27);
            reportToolStripMenuItem.Text = "Report";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(78, 27);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1902, 1033);
            Controls.Add(adminMenu);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = adminMenu;
            Name = "AdminPage";
            Text = "Admin Dashboard";
            adminMenu.ResumeLayout(false);
            adminMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip adminMenu;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}