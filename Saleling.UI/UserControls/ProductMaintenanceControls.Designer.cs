namespace Saleling.UI
{
    partial class ProductMaintenanceControls
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
            label4 = new Label();
            label3 = new Label();
            tblProductVariants = new DataGridView();
            label2 = new Label();
            cmbFilter = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            tblProductMaster = new DataGridView();
            btnAddProduct = new Button();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            btnDeleteVariant = new Button();
            btnEditVariant = new Button();
            btnAddVariant = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)tblProductVariants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblProductMaster).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(56, 624);
            label4.Name = "label4";
            label4.Size = new Size(164, 38);
            label4.TabIndex = 23;
            label4.Text = "Variant List:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(56, 168);
            label3.Name = "label3";
            label3.Size = new Size(163, 38);
            label3.TabIndex = 22;
            label3.Text = "Master List:";
            // 
            // tblProductVariants
            // 
            tblProductVariants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblProductVariants.BackgroundColor = SystemColors.Control;
            tblProductVariants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblProductVariants.Location = new Point(56, 676);
            tblProductVariants.MultiSelect = false;
            tblProductVariants.Name = "tblProductVariants";
            tblProductVariants.ReadOnly = true;
            tblProductVariants.RowHeadersVisible = false;
            tblProductVariants.RowHeadersWidth = 51;
            tblProductVariants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblProductVariants.Size = new Size(1435, 292);
            tblProductVariants.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(779, 43);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 20;
            label2.Text = "Search By:";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 18.2F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Name", "Category", "Supplier" });
            cmbFilter.Location = new Point(779, 90);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(344, 49);
            cmbFilter.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(56, 43);
            label1.Name = "label1";
            label1.Size = new Size(215, 38);
            label1.TabIndex = 18;
            label1.Text = "Search Product:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18.2F);
            txtSearch.Location = new Point(56, 90);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(696, 48);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1147, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(175, 48);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tblProductMaster
            // 
            tblProductMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblProductMaster.BackgroundColor = SystemColors.Control;
            tblProductMaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblProductMaster.Location = new Point(56, 220);
            tblProductMaster.MultiSelect = false;
            tblProductMaster.Name = "tblProductMaster";
            tblProductMaster.ReadOnly = true;
            tblProductMaster.RowHeadersVisible = false;
            tblProductMaster.RowHeadersWidth = 51;
            tblProductMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblProductMaster.Size = new Size(1435, 292);
            tblProductMaster.TabIndex = 15;
            tblProductMaster.CellClick += tblProductMaster_CellClick;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.Highlight;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(56, 532);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(208, 48);
            btnAddProduct.TabIndex = 24;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = SystemColors.Highlight;
            btnEditProduct.FlatAppearance.BorderSize = 0;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(502, 532);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(208, 48);
            btnEditProduct.TabIndex = 25;
            btnEditProduct.Text = "Edit Product";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.OrangeRed;
            btnDeleteProduct.FlatAppearance.BorderSize = 0;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(905, 532);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(208, 48);
            btnDeleteProduct.TabIndex = 26;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnDeleteVariant
            // 
            btnDeleteVariant.BackColor = Color.OrangeRed;
            btnDeleteVariant.FlatAppearance.BorderSize = 0;
            btnDeleteVariant.FlatStyle = FlatStyle.Flat;
            btnDeleteVariant.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnDeleteVariant.ForeColor = Color.White;
            btnDeleteVariant.Location = new Point(279, 985);
            btnDeleteVariant.Name = "btnDeleteVariant";
            btnDeleteVariant.Size = new Size(208, 48);
            btnDeleteVariant.TabIndex = 29;
            btnDeleteVariant.Text = "Delete Variant";
            btnDeleteVariant.UseVisualStyleBackColor = false;
            btnDeleteVariant.Click += btnDeleteVariant_Click;
            // 
            // btnEditVariant
            // 
            btnEditVariant.BackColor = SystemColors.Highlight;
            btnEditVariant.FlatAppearance.BorderSize = 0;
            btnEditVariant.FlatStyle = FlatStyle.Flat;
            btnEditVariant.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnEditVariant.ForeColor = Color.White;
            btnEditVariant.Location = new Point(56, 985);
            btnEditVariant.Name = "btnEditVariant";
            btnEditVariant.Size = new Size(208, 48);
            btnEditVariant.TabIndex = 28;
            btnEditVariant.Text = "Edit Variant";
            btnEditVariant.UseVisualStyleBackColor = false;
            btnEditVariant.Click += btnEditVariant_Click;
            // 
            // btnAddVariant
            // 
            btnAddVariant.BackColor = SystemColors.Highlight;
            btnAddVariant.FlatAppearance.BorderSize = 0;
            btnAddVariant.FlatStyle = FlatStyle.Flat;
            btnAddVariant.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAddVariant.ForeColor = Color.White;
            btnAddVariant.Location = new Point(279, 532);
            btnAddVariant.Name = "btnAddVariant";
            btnAddVariant.Size = new Size(208, 48);
            btnAddVariant.TabIndex = 27;
            btnAddVariant.Text = "Add Variant";
            btnAddVariant.UseVisualStyleBackColor = false;
            btnAddVariant.Click += btnAddVariant_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.Highlight;
            btnClear.Location = new Point(1343, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 48);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Highlight;
            btnRefresh.Location = new Point(725, 532);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(163, 48);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ProductMaintenanceControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteVariant);
            Controls.Add(btnEditVariant);
            Controls.Add(btnAddVariant);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tblProductVariants);
            Controls.Add(label2);
            Controls.Add(cmbFilter);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(tblProductMaster);
            Name = "ProductMaintenanceControls";
            Size = new Size(1547, 1080);
            Load += ProductMaintenanceScreen_Load;
            ((System.ComponentModel.ISupportInitialize)tblProductVariants).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblProductMaster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private DataGridView tblProductVariants;
        private Label label2;
        private ComboBox cmbFilter;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView tblProductMaster;
        private Button btnAddProduct;
        private Button btnEditProduct;
        private Button btnDeleteProduct;
        private Button btnDeleteVariant;
        private Button btnEditVariant;
        private Button btnAddVariant;
        private Button btnClear;
        private Button btnRefresh;
    }
}
