namespace Saleling.UI
{
    partial class AdminDashboardControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataFetchTimer = new System.Windows.Forms.Timer(components);
            dgvTransactionReport = new DataGridView();
            panel2 = new Panel();
            lblTransactionCount = new Label();
            label7 = new Label();
            lblTodaySales = new Label();
            label5 = new Label();
            panel1 = new Panel();
            lblCategoryCount = new Label();
            label2 = new Label();
            lblProductCount = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lblOutOfStockCount = new Label();
            label10 = new Label();
            lblLowStockCount = new Label();
            label12 = new Label();
            label14 = new Label();
            dgvStockReport = new DataGridView();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionReport).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockReport).BeginInit();
            SuspendLayout();
            // 
            // dataFetchTimer
            // 
            dataFetchTimer.Interval = 30000;
            dataFetchTimer.Tick += monitoringTimer_TickAsync;
            // 
            // dgvTransactionReport
            // 
            dgvTransactionReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionReport.BackgroundColor = SystemColors.Control;
            dgvTransactionReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionReport.Location = new Point(58, 745);
            dgvTransactionReport.MultiSelect = false;
            dgvTransactionReport.Name = "dgvTransactionReport";
            dgvTransactionReport.ReadOnly = true;
            dgvTransactionReport.RowHeadersVisible = false;
            dgvTransactionReport.RowHeadersWidth = 51;
            dgvTransactionReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionReport.Size = new Size(1426, 288);
            dgvTransactionReport.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTransactionCount);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblTodaySales);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(58, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 272);
            panel2.TabIndex = 16;
            // 
            // lblTransactionCount
            // 
            lblTransactionCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionCount.Location = new Point(31, 217);
            lblTransactionCount.Name = "lblTransactionCount";
            lblTransactionCount.Size = new Size(387, 28);
            lblTransactionCount.TabIndex = 4;
            lblTransactionCount.Text = "0 categories";
            lblTransactionCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 171);
            label7.Name = "label7";
            label7.Size = new Size(402, 32);
            label7.TabIndex = 2;
            label7.Text = "____________________________________________";
            // 
            // lblTodaySales
            // 
            lblTodaySales.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTodaySales.Location = new Point(31, 116);
            lblTodaySales.Name = "lblTodaySales";
            lblTodaySales.Size = new Size(387, 46);
            lblTodaySales.TabIndex = 1;
            lblTodaySales.Text = "0";
            lblTodaySales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label5.Location = new Point(91, 34);
            label5.Name = "label5";
            label5.Size = new Size(258, 54);
            label5.TabIndex = 0;
            label5.Text = "Today's Sales";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCategoryCount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblProductCount);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(546, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 272);
            panel1.TabIndex = 17;
            // 
            // lblCategoryCount
            // 
            lblCategoryCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryCount.Location = new Point(38, 217);
            lblCategoryCount.Name = "lblCategoryCount";
            lblCategoryCount.Size = new Size(384, 28);
            lblCategoryCount.TabIndex = 3;
            lblCategoryCount.Text = "0 categories";
            lblCategoryCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 171);
            label2.Name = "label2";
            label2.Size = new Size(384, 32);
            label2.TabIndex = 2;
            label2.Text = "____________________________________________";
            // 
            // lblProductCount
            // 
            lblProductCount.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblProductCount.Location = new Point(38, 116);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(392, 46);
            lblProductCount.TabIndex = 1;
            lblProductCount.Text = "0";
            lblProductCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label4.Location = new Point(96, 34);
            label4.Name = "label4";
            label4.Size = new Size(289, 54);
            label4.TabIndex = 0;
            label4.Text = "Total Products";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblOutOfStockCount);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblLowStockCount);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(1047, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 272);
            panel3.TabIndex = 18;
            // 
            // lblOutOfStockCount
            // 
            lblOutOfStockCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutOfStockCount.ForeColor = SystemColors.ControlText;
            lblOutOfStockCount.Location = new Point(42, 217);
            lblOutOfStockCount.Name = "lblOutOfStockCount";
            lblOutOfStockCount.Size = new Size(366, 28);
            lblOutOfStockCount.TabIndex = 3;
            lblOutOfStockCount.Text = "0 out of stock";
            lblOutOfStockCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(42, 171);
            label10.Name = "label10";
            label10.Size = new Size(366, 32);
            label10.TabIndex = 2;
            label10.Text = "____________________________________________";
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblLowStockCount.ForeColor = SystemColors.ControlText;
            lblLowStockCount.Location = new Point(62, 116);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(331, 46);
            lblLowStockCount.TabIndex = 1;
            lblLowStockCount.Text = "0";
            lblLowStockCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label12.Location = new Point(62, 34);
            label12.Name = "label12";
            label12.Size = new Size(324, 54);
            label12.TabIndex = 0;
            label12.Text = "Low Stock Alerts";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(58, 696);
            label14.Name = "label14";
            label14.Size = new Size(260, 37);
            label14.TabIndex = 21;
            label14.Text = "Recent Transactions";
            // 
            // dgvStockReport
            // 
            dgvStockReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockReport.BackgroundColor = SystemColors.Control;
            dgvStockReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockReport.Location = new Point(58, 405);
            dgvStockReport.MultiSelect = false;
            dgvStockReport.Name = "dgvStockReport";
            dgvStockReport.ReadOnly = true;
            dgvStockReport.RowHeadersVisible = false;
            dgvStockReport.RowHeadersWidth = 51;
            dgvStockReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockReport.Size = new Size(1426, 265);
            dgvStockReport.TabIndex = 20;
            dgvStockReport.RowPrePaint += dgvStockReport_RowPrePaint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(58, 354);
            label13.Name = "label13";
            label13.Size = new Size(253, 37);
            label13.TabIndex = 19;
            label13.Text = "Recent Stock Alerts";
            // 
            // AdminDashboardControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvTransactionReport);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label14);
            Controls.Add(dgvStockReport);
            Controls.Add(label13);
            Name = "AdminDashboardControls";
            Size = new Size(1547, 1080);
            Load += AdminDashboardScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactionReport).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer dataFetchTimer;
        private DataGridView dgvTransactionReport;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label lblTodaySales;
        private Label label5;
        private Panel panel1;
        private Label lblCategoryCount;
        private Label label2;
        private Label lblProductCount;
        private Label label4;
        private Panel panel3;
        private Label lblOutOfStockCount;
        private Label label10;
        private Label lblLowStockCount;
        private Label label12;
        private Label label14;
        private DataGridView dgvStockReport;
        private Label label13;
        private Label lblTransactionCount;
    }
}
