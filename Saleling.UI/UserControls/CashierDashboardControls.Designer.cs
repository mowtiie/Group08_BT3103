namespace Saleling.UI
{
    partial class CashierDashboardControls
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
            panel2 = new Panel();
            lblTransactions = new Label();
            label7 = new Label();
            lblSales = new Label();
            label5 = new Label();
            panel1 = new Panel();
            lblAveragePerTransaction = new Label();
            label4 = new Label();
            label2 = new Label();
            lblItemsSold = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label12 = new Label();
            label10 = new Label();
            lblLowStock = new Label();
            dataFetchTimer = new System.Windows.Forms.Timer(components);
            dgvTransactionReport = new DataGridView();
            label14 = new Label();
            dgvStockReport = new DataGridView();
            label13 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockReport).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTransactions);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblSales);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(53, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 272);
            panel2.TabIndex = 19;
            // 
            // lblTransactions
            // 
            lblTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(31, 205);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(394, 28);
            lblTransactions.TabIndex = 33;
            lblTransactions.Text = "0 transactions";
            lblTransactions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 157);
            label7.Name = "label7";
            label7.Size = new Size(394, 32);
            label7.TabIndex = 2;
            label7.Text = "______________________________________";
            // 
            // lblSales
            // 
            lblSales.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblSales.Location = new Point(134, 102);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(191, 46);
            lblSales.TabIndex = 1;
            lblSales.Text = "0";
            lblSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label5.Location = new Point(68, 25);
            label5.Name = "label5";
            label5.Size = new Size(310, 54);
            label5.TabIndex = 0;
            label5.Text = "My Sales Today";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblAveragePerTransaction);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblItemsSold);
            panel1.Location = new Point(550, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 272);
            panel1.TabIndex = 20;
            // 
            // lblAveragePerTransaction
            // 
            lblAveragePerTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAveragePerTransaction.Location = new Point(28, 211);
            lblAveragePerTransaction.Name = "lblAveragePerTransaction";
            lblAveragePerTransaction.Size = new Size(394, 28);
            lblAveragePerTransaction.TabIndex = 34;
            lblAveragePerTransaction.Text = "Average: 0.00 per transaction";
            lblAveragePerTransaction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label4.Location = new Point(64, 25);
            label4.Name = "label4";
            label4.Size = new Size(310, 54);
            label4.TabIndex = 4;
            label4.Text = "Items Sold";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 162);
            label2.Name = "label2";
            label2.Size = new Size(394, 32);
            label2.TabIndex = 6;
            label2.Text = "______________________________________";
            // 
            // lblItemsSold
            // 
            lblItemsSold.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblItemsSold.Location = new Point(131, 107);
            lblItemsSold.Name = "lblItemsSold";
            lblItemsSold.Size = new Size(191, 46);
            lblItemsSold.TabIndex = 5;
            lblItemsSold.Text = "0";
            lblItemsSold.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblLowStock);
            panel3.Location = new Point(1039, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 272);
            panel3.TabIndex = 21;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 211);
            label1.Name = "label1";
            label1.Size = new Size(394, 28);
            label1.TabIndex = 34;
            label1.Text = "Items need restocking";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label12.Location = new Point(66, 25);
            label12.Name = "label12";
            label12.Size = new Size(310, 54);
            label12.TabIndex = 8;
            label12.Text = "Stock Alerts";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 162);
            label10.Name = "label10";
            label10.Size = new Size(394, 32);
            label10.TabIndex = 10;
            label10.Text = "______________________________________";
            // 
            // lblLowStock
            // 
            lblLowStock.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblLowStock.ForeColor = SystemColors.ControlText;
            lblLowStock.Location = new Point(133, 107);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(191, 46);
            lblLowStock.TabIndex = 9;
            lblLowStock.Text = "0";
            lblLowStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataFetchTimer
            // 
            dataFetchTimer.Interval = 30000;
            dataFetchTimer.Tick += dataFetchTimer_Tick;
            // 
            // dgvTransactionReport
            // 
            dgvTransactionReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionReport.BackgroundColor = SystemColors.Control;
            dgvTransactionReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionReport.Location = new Point(53, 753);
            dgvTransactionReport.MultiSelect = false;
            dgvTransactionReport.Name = "dgvTransactionReport";
            dgvTransactionReport.ReadOnly = true;
            dgvTransactionReport.RowHeadersVisible = false;
            dgvTransactionReport.RowHeadersWidth = 51;
            dgvTransactionReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionReport.Size = new Size(1436, 288);
            dgvTransactionReport.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(53, 704);
            label14.Name = "label14";
            label14.Size = new Size(306, 37);
            label14.TabIndex = 25;
            label14.Text = "My Recent Transactions";
            // 
            // dgvStockReport
            // 
            dgvStockReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockReport.BackgroundColor = SystemColors.Control;
            dgvStockReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockReport.Location = new Point(53, 412);
            dgvStockReport.MultiSelect = false;
            dgvStockReport.Name = "dgvStockReport";
            dgvStockReport.ReadOnly = true;
            dgvStockReport.RowHeadersVisible = false;
            dgvStockReport.RowHeadersWidth = 51;
            dgvStockReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockReport.Size = new Size(1436, 265);
            dgvStockReport.TabIndex = 24;
            dgvStockReport.RowPrePaint += dgvStockReport_RowPrePaint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(53, 360);
            label13.Name = "label13";
            label13.Size = new Size(253, 37);
            label13.TabIndex = 23;
            label13.Text = "Recent Stock Alerts";
            // 
            // CashierDashboardControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvTransactionReport);
            Controls.Add(label14);
            Controls.Add(dgvStockReport);
            Controls.Add(label13);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "CashierDashboardControls";
            Size = new Size(1547, 1080);
            Load += CashierDashboardControls_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private Label lblSales;
        private Label label5;
        private Panel panel1;
        private Panel panel3;
        private Label label4;
        private Label label2;
        private Label lblItemsSold;
        private Label label12;
        private Label label10;
        private Label lblLowStock;
        private System.Windows.Forms.Timer dataFetchTimer;
        private Label label8;
        private Label lblTransactions;
        private Label lblAveragePerTransaction;
        private Label label1;
        private DataGridView dgvTransactionReport;
        private Label label14;
        private DataGridView dgvStockReport;
        private Label label13;
    }
}
