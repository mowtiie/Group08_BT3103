namespace Saleling.UI
{
    partial class ProductListingControls
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
            label2 = new Label();
            cmbFilter = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.Highlight;
            btnClear.Location = new Point(1191, 84);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 48);
            btnClear.TabIndex = 36;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(634, 37);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 35;
            label2.Text = "Search By:";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 18.2F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Name", "SKU", "Category", "Supplier" });
            cmbFilter.Location = new Point(634, 83);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(344, 49);
            cmbFilter.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(215, 38);
            label1.TabIndex = 33;
            label1.Text = "Search Product:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18.2F);
            txtSearch.Location = new Point(46, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(552, 48);
            txtSearch.TabIndex = 32;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1001, 84);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(175, 48);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Control;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(46, 158);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1457, 876);
            dgvProducts.TabIndex = 37;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Highlight;
            btnRefresh.Location = new Point(1355, 84);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(148, 48);
            btnRefresh.TabIndex = 38;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ProductListingControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnRefresh);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(cmbFilter);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "ProductListingControls";
            Size = new Size(1547, 1080);
            Load += ProductListingControls_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label label2;
        private ComboBox cmbFilter;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private Button btnRefresh;
    }
}
