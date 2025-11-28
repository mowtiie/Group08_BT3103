namespace Saleling.UI
{
    partial class ReportsManagementControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsManagementControls));
            panel2 = new Panel();
            lblLeftSubKPI = new Label();
            label7 = new Label();
            lblLeftKPI = new Label();
            lblLeftKPIHeader = new Label();
            panel1 = new Panel();
            lblMiddleKPIHeader = new Label();
            label2 = new Label();
            lblMiddleKPI = new Label();
            panel3 = new Panel();
            lblRightKPIHeader = new Label();
            label10 = new Label();
            lblRightKPI = new Label();
            dgvReport = new DataGridView();
            btnExportExcel = new Button();
            btnPrintReport = new Button();
            btnGenerate = new Button();
            label9 = new Label();
            label8 = new Label();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            label3 = new Label();
            cmbReportPeriod = new ComboBox();
            label1 = new Label();
            lblReportHeader = new Label();
            cmbProcessedBy = new ComboBox();
            cmbReportType = new ComboBox();
            label6 = new Label();
            label11 = new Label();
            reportDocument = new System.Drawing.Printing.PrintDocument();
            reportPreviewDialog = new PrintPreviewDialog();
            btnResetFilters = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblLeftSubKPI);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblLeftKPI);
            panel2.Controls.Add(lblLeftKPIHeader);
            panel2.Location = new Point(51, 399);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 215);
            panel2.TabIndex = 22;
            // 
            // lblLeftSubKPI
            // 
            lblLeftSubKPI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLeftSubKPI.Location = new Point(32, 165);
            lblLeftSubKPI.Name = "lblLeftSubKPI";
            lblLeftSubKPI.Size = new Size(394, 28);
            lblLeftSubKPI.TabIndex = 3;
            lblLeftSubKPI.Text = "0 transactions";
            lblLeftSubKPI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 121);
            label7.Name = "label7";
            label7.Size = new Size(394, 32);
            label7.TabIndex = 2;
            label7.Text = "______________________________________";
            // 
            // lblLeftKPI
            // 
            lblLeftKPI.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblLeftKPI.Location = new Point(131, 75);
            lblLeftKPI.Name = "lblLeftKPI";
            lblLeftKPI.Size = new Size(191, 46);
            lblLeftKPI.TabIndex = 1;
            lblLeftKPI.Text = "0";
            lblLeftKPI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLeftKPIHeader
            // 
            lblLeftKPIHeader.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblLeftKPIHeader.Location = new Point(75, 10);
            lblLeftKPIHeader.Name = "lblLeftKPIHeader";
            lblLeftKPIHeader.Size = new Size(310, 54);
            lblLeftKPIHeader.TabIndex = 0;
            lblLeftKPIHeader.Text = "Total Sales";
            lblLeftKPIHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblMiddleKPIHeader);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblMiddleKPI);
            panel1.Location = new Point(561, 399);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 215);
            panel1.TabIndex = 23;
            // 
            // lblMiddleKPIHeader
            // 
            lblMiddleKPIHeader.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblMiddleKPIHeader.Location = new Point(66, 10);
            lblMiddleKPIHeader.Name = "lblMiddleKPIHeader";
            lblMiddleKPIHeader.Size = new Size(310, 54);
            lblMiddleKPIHeader.TabIndex = 4;
            lblMiddleKPIHeader.Text = "Items Sold";
            lblMiddleKPIHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 121);
            label2.Name = "label2";
            label2.Size = new Size(394, 32);
            label2.TabIndex = 6;
            label2.Text = "______________________________________";
            // 
            // lblMiddleKPI
            // 
            lblMiddleKPI.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblMiddleKPI.Location = new Point(129, 75);
            lblMiddleKPI.Name = "lblMiddleKPI";
            lblMiddleKPI.Size = new Size(191, 46);
            lblMiddleKPI.TabIndex = 5;
            lblMiddleKPI.Text = "0";
            lblMiddleKPI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblRightKPIHeader);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblRightKPI);
            panel3.Location = new Point(1050, 399);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 215);
            panel3.TabIndex = 24;
            // 
            // lblRightKPIHeader
            // 
            lblRightKPIHeader.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblRightKPIHeader.Location = new Point(70, 10);
            lblRightKPIHeader.Name = "lblRightKPIHeader";
            lblRightKPIHeader.Size = new Size(310, 54);
            lblRightKPIHeader.TabIndex = 8;
            lblRightKPIHeader.Text = "Average Sale";
            lblRightKPIHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 121);
            label10.Name = "label10";
            label10.Size = new Size(394, 32);
            label10.TabIndex = 10;
            label10.Text = "______________________________________";
            // 
            // lblRightKPI
            // 
            lblRightKPI.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblRightKPI.ForeColor = SystemColors.ControlText;
            lblRightKPI.Location = new Point(25, 75);
            lblRightKPI.Name = "lblRightKPI";
            lblRightKPI.Size = new Size(394, 46);
            lblRightKPI.TabIndex = 9;
            lblRightKPI.Text = "0";
            lblRightKPI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvReport
            // 
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReport.BackgroundColor = SystemColors.Control;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(51, 636);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(1449, 326);
            dgvReport.TabIndex = 26;
            dgvReport.RowPrePaint += dgvReport_RowPrePaint;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = SystemColors.Highlight;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(51, 983);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(280, 48);
            btnExportExcel.TabIndex = 28;
            btnExportExcel.Text = "Export Spreadsheet";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnPrintReport
            // 
            btnPrintReport.BackColor = SystemColors.Highlight;
            btnPrintReport.FlatAppearance.BorderSize = 0;
            btnPrintReport.FlatStyle = FlatStyle.Flat;
            btnPrintReport.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnPrintReport.ForeColor = Color.White;
            btnPrintReport.Location = new Point(353, 983);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(208, 48);
            btnPrintReport.TabIndex = 29;
            btnPrintReport.Text = "Print Report";
            btnPrintReport.UseVisualStyleBackColor = false;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = SystemColors.Highlight;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(51, 221);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(187, 48);
            btnGenerate.TabIndex = 51;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(1260, 122);
            label9.Name = "label9";
            label9.Size = new Size(94, 30);
            label9.TabIndex = 50;
            label9.Text = "To Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(988, 122);
            label8.Name = "label8";
            label8.Size = new Size(122, 30);
            label8.TabIndex = 49;
            label8.Text = "From Date:";
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 18.2F);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(1260, 157);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(255, 48);
            dtpToDate.TabIndex = 48;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 18.2F);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(988, 157);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.RightToLeft = RightToLeft.No;
            dtpFromDate.Size = new Size(255, 48);
            dtpFromDate.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(719, 123);
            label3.Name = "label3";
            label3.Size = new Size(156, 30);
            label3.TabIndex = 44;
            label3.Text = "Report Period:";
            // 
            // cmbReportPeriod
            // 
            cmbReportPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportPeriod.Font = new Font("Segoe UI", 18.2F);
            cmbReportPeriod.FormattingEnabled = true;
            cmbReportPeriod.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly", "Custom" });
            cmbReportPeriod.Location = new Point(719, 156);
            cmbReportPeriod.Name = "cmbReportPeriod";
            cmbReportPeriod.Size = new Size(249, 49);
            cmbReportPeriod.TabIndex = 43;
            cmbReportPeriod.SelectedIndexChanged += cmbReportPeriod_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(51, 55);
            label1.Name = "label1";
            label1.Size = new Size(257, 41);
            label1.TabIndex = 42;
            label1.Text = "Generate Reports";
            // 
            // lblReportHeader
            // 
            lblReportHeader.AutoSize = true;
            lblReportHeader.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblReportHeader.ForeColor = SystemColors.Highlight;
            lblReportHeader.Location = new Point(51, 335);
            lblReportHeader.Name = "lblReportHeader";
            lblReportHeader.Size = new Size(404, 41);
            lblReportHeader.TabIndex = 53;
            lblReportHeader.Text = "Daily Sales Summary Report";
            // 
            // cmbProcessedBy
            // 
            cmbProcessedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProcessedBy.Font = new Font("Segoe UI", 18.2F);
            cmbProcessedBy.FormattingEnabled = true;
            cmbProcessedBy.Location = new Point(414, 156);
            cmbProcessedBy.Name = "cmbProcessedBy";
            cmbProcessedBy.Size = new Size(289, 49);
            cmbProcessedBy.TabIndex = 54;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Font = new Font("Segoe UI", 18.2F);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Sales Summary", "Inventory Stock", "Inventory Movement" });
            cmbReportType.Location = new Point(51, 156);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(341, 49);
            cmbReportType.TabIndex = 55;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(414, 121);
            label6.Name = "label6";
            label6.Size = new Size(147, 30);
            label6.TabIndex = 56;
            label6.Text = "Processed By:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(51, 122);
            label11.Name = "label11";
            label11.Size = new Size(139, 30);
            label11.TabIndex = 57;
            label11.Text = "Report Type:";
            // 
            // reportDocument
            // 
            reportDocument.PrintPage += reportDocument_PrintPage;
            // 
            // reportPreviewDialog
            // 
            reportPreviewDialog.AutoScrollMargin = new Size(0, 0);
            reportPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            reportPreviewDialog.ClientSize = new Size(400, 300);
            reportPreviewDialog.Enabled = true;
            reportPreviewDialog.Icon = (Icon)resources.GetObject("reportPreviewDialog.Icon");
            reportPreviewDialog.Name = "reportPreviewDialog";
            reportPreviewDialog.Visible = false;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.White;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnResetFilters.ForeColor = SystemColors.Highlight;
            btnResetFilters.Location = new Point(258, 221);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(179, 48);
            btnResetFilters.TabIndex = 52;
            btnResetFilters.Text = "Reset Filters";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnClearFilters_Click;
            // 
            // ReportsManagementControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(cmbReportType);
            Controls.Add(cmbProcessedBy);
            Controls.Add(lblReportHeader);
            Controls.Add(btnResetFilters);
            Controls.Add(btnGenerate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(label3);
            Controls.Add(cmbReportPeriod);
            Controls.Add(label1);
            Controls.Add(btnPrintReport);
            Controls.Add(btnExportExcel);
            Controls.Add(dgvReport);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "ReportsManagementControls";
            Size = new Size(1547, 1080);
            Load += ReportsManagementControls_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblLeftSubKPI;
        private Label label7;
        private Label lblLeftKPI;
        private Label lblLeftKPIHeader;
        private Panel panel1;
        private Label lblMiddleKPIHeader;
        private Label label2;
        private Label lblMiddleKPI;
        private Panel panel3;
        private Label lblRightKPIHeader;
        private Label label10;
        private Label lblRightKPI;
        private DataGridView dgvReport;
        private Button btnExportExcel;
        private Button btnPrintReport;
        private Button btnGenerate;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Label label3;
        private ComboBox cmbReportPeriod;
        private Label label1;
        private Label lblReportHeader;
        private ComboBox cmbProcessedBy;
        private ComboBox cmbReportType;
        private Label label6;
        private Label label11;
        private System.Drawing.Printing.PrintDocument reportDocument;
        private PrintPreviewDialog reportPreviewDialog;
        private Button btnResetFilters;
    }
}
