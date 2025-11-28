namespace Saleling.UI
{
    partial class InventoryManagementControls
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
            btnClear = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            dgvLogs = new DataGridView();
            label2 = new Label();
            cmbFilter = new ComboBox();
            btnAdjustStock = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.Highlight;
            btnClear.Location = new Point(1343, 84);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 48);
            btnClear.TabIndex = 46;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(56, 657);
            label4.Name = "label4";
            label4.Size = new Size(223, 38);
            label4.TabIndex = 39;
            label4.Text = "History Log List:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(56, 153);
            label3.Name = "label3";
            label3.Size = new Size(174, 38);
            label3.TabIndex = 38;
            label3.Text = "Product List:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(56, 37);
            label1.Name = "label1";
            label1.Size = new Size(108, 38);
            label1.TabIndex = 34;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18.2F);
            txtSearch.Location = new Point(56, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(702, 48);
            txtSearch.TabIndex = 33;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1147, 84);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(175, 48);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Control;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(56, 203);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1435, 347);
            dgvProducts.TabIndex = 31;
            dgvProducts.CellClick += tblInventory_CellClick;
            dgvProducts.RowPrePaint += dgvProducts_RowPrePaint;
            // 
            // dgvLogs
            // 
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = SystemColors.Control;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(56, 708);
            dgvLogs.MultiSelect = false;
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersVisible = false;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(1435, 331);
            dgvLogs.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(779, 37);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 49;
            label2.Text = "Search By:";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 18.2F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Name", "SKU" });
            cmbFilter.Location = new Point(779, 84);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(344, 49);
            cmbFilter.TabIndex = 48;
            // 
            // btnAdjustStock
            // 
            btnAdjustStock.BackColor = SystemColors.Highlight;
            btnAdjustStock.FlatAppearance.BorderSize = 0;
            btnAdjustStock.FlatStyle = FlatStyle.Flat;
            btnAdjustStock.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAdjustStock.ForeColor = Color.White;
            btnAdjustStock.Location = new Point(56, 566);
            btnAdjustStock.Name = "btnAdjustStock";
            btnAdjustStock.Size = new Size(204, 48);
            btnAdjustStock.TabIndex = 50;
            btnAdjustStock.Text = "Adjust Stock";
            btnAdjustStock.UseVisualStyleBackColor = false;
            btnAdjustStock.Click += btnAdjustStock_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Highlight;
            btnRefresh.Location = new Point(276, 566);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(152, 48);
            btnRefresh.TabIndex = 51;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // InventoryManagementControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnRefresh);
            Controls.Add(btnAdjustStock);
            Controls.Add(label2);
            Controls.Add(cmbFilter);
            Controls.Add(dgvLogs);
            Controls.Add(btnClear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvProducts);
            Name = "InventoryManagementControls";
            Size = new Size(1547, 1080);
            Load += InventoryManagementScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private DataGridView dgvLogs;
        private Label label2;
        private ComboBox cmbFilter;
        private Button btnAdjustStock;
        private Button btnRefresh;
    }
}
