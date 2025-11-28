namespace Saleling.UI
{
    partial class ProductDetailForm
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
            label1 = new Label();
            txtProductName = new TextBox();
            cmbCategory = new ComboBox();
            cmbSupplier = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnSaveProduct = new Button();
            btnCloseWindow = new Button();
            label5 = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(55, 47);
            label1.Name = "label1";
            label1.Size = new Size(207, 38);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(55, 103);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(365, 47);
            txtProductName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(55, 233);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(366, 49);
            cmbCategory.TabIndex = 4;
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(468, 233);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(366, 49);
            cmbSupplier.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(55, 182);
            label2.Name = "label2";
            label2.Size = new Size(140, 38);
            label2.TabIndex = 4;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(468, 182);
            label3.Name = "label3";
            label3.Size = new Size(129, 38);
            label3.TabIndex = 5;
            label3.Text = "Supplier:";
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = SystemColors.Highlight;
            btnSaveProduct.FlatAppearance.BorderSize = 0;
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.Location = new Point(55, 332);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(208, 48);
            btnSaveProduct.TabIndex = 6;
            btnSaveProduct.Text = "Save Product";
            btnSaveProduct.UseVisualStyleBackColor = false;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.BackColor = Color.OrangeRed;
            btnCloseWindow.FlatAppearance.BorderSize = 0;
            btnCloseWindow.FlatStyle = FlatStyle.Flat;
            btnCloseWindow.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnCloseWindow.ForeColor = Color.White;
            btnCloseWindow.Location = new Point(288, 332);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(208, 48);
            btnCloseWindow.TabIndex = 7;
            btnCloseWindow.Text = "Close Window";
            btnCloseWindow.UseVisualStyleBackColor = false;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(467, 47);
            label5.Name = "label5";
            label5.Size = new Size(101, 38);
            label5.TabIndex = 28;
            label5.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(467, 101);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(366, 49);
            cmbStatus.TabIndex = 3;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(891, 434);
            Controls.Add(cmbStatus);
            Controls.Add(label5);
            Controls.Add(btnCloseWindow);
            Controls.Add(btnSaveProduct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbCategory);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductDetailForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Details";
            Load += ProductMasterDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private ComboBox cmbSupplier;
        private Label label2;
        private Label label3;
        private Button btnSaveProduct;
        private Button btnCloseWindow;
        private Label label5;
        private ComboBox cmbStatus;
    }
}