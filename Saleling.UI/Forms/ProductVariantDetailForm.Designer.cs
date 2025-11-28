namespace Saleling_Debug.UI
{
    partial class ProductVariantDetailForm
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
            txtSKU = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbColor = new ComboBox();
            cmbSize = new ComboBox();
            txtStockQuantity = new TextBox();
            label4 = new Label();
            txtReorderLevel = new TextBox();
            label5 = new Label();
            btnCloseWindow = new Button();
            btnSaveVariant = new Button();
            label6 = new Label();
            cmbStatus = new ComboBox();
            label14 = new Label();
            txtSellingPrice = new TextBox();
            txtCostPrice = new TextBox();
            label15 = new Label();
            SuspendLayout();
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSKU.Location = new Point(54, 94);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(366, 47);
            txtSKU.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(54, 38);
            label1.Name = "label1";
            label1.Size = new Size(76, 38);
            label1.TabIndex = 27;
            label1.Text = "SKU:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(480, 444);
            label3.Name = "label3";
            label3.Size = new Size(93, 38);
            label3.TabIndex = 32;
            label3.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(56, 444);
            label2.Name = "label2";
            label2.Size = new Size(74, 38);
            label2.TabIndex = 31;
            label2.Text = "Size:";
            // 
            // cmbColor
            // 
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(480, 495);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(366, 49);
            cmbColor.TabIndex = 6;
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(56, 495);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(366, 49);
            cmbSize.TabIndex = 5;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockQuantity.Location = new Point(56, 367);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(366, 47);
            txtStockQuantity.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(56, 311);
            label4.Name = "label4";
            label4.Size = new Size(210, 38);
            label4.TabIndex = 33;
            label4.Text = "Stock Quantity:";
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReorderLevel.Location = new Point(480, 367);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(366, 47);
            txtReorderLevel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(480, 311);
            label5.Name = "label5";
            label5.Size = new Size(197, 38);
            label5.TabIndex = 36;
            label5.Text = "Reorder Level:";
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.BackColor = Color.OrangeRed;
            btnCloseWindow.FlatAppearance.BorderSize = 0;
            btnCloseWindow.FlatStyle = FlatStyle.Flat;
            btnCloseWindow.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnCloseWindow.ForeColor = Color.White;
            btnCloseWindow.Location = new Point(287, 591);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(208, 48);
            btnCloseWindow.TabIndex = 8;
            btnCloseWindow.Text = "Close Window";
            btnCloseWindow.UseVisualStyleBackColor = false;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // btnSaveVariant
            // 
            btnSaveVariant.BackColor = SystemColors.Highlight;
            btnSaveVariant.FlatAppearance.BorderSize = 0;
            btnSaveVariant.FlatStyle = FlatStyle.Flat;
            btnSaveVariant.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSaveVariant.ForeColor = Color.White;
            btnSaveVariant.Location = new Point(54, 591);
            btnSaveVariant.Name = "btnSaveVariant";
            btnSaveVariant.Size = new Size(208, 48);
            btnSaveVariant.TabIndex = 7;
            btnSaveVariant.Text = "Save Variant";
            btnSaveVariant.UseVisualStyleBackColor = false;
            btnSaveVariant.Click += btnSaveVariant_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(478, 38);
            label6.Name = "label6";
            label6.Size = new Size(101, 38);
            label6.TabIndex = 40;
            label6.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(478, 92);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(366, 49);
            cmbStatus.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(480, 173);
            label14.Name = "label14";
            label14.Size = new Size(146, 38);
            label14.TabIndex = 50;
            label14.Text = "Unit Price:";
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSellingPrice.Location = new Point(480, 229);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(366, 47);
            txtSellingPrice.TabIndex = 48;
            // 
            // txtCostPrice
            // 
            txtCostPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCostPrice.Location = new Point(56, 229);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.Size = new Size(366, 47);
            txtCostPrice.TabIndex = 47;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.Highlight;
            label15.Location = new Point(56, 173);
            label15.Name = "label15";
            label15.Size = new Size(149, 38);
            label15.TabIndex = 49;
            label15.Text = "Cost Price:";
            // 
            // ProductVariantDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(903, 685);
            Controls.Add(label14);
            Controls.Add(txtSellingPrice);
            Controls.Add(txtCostPrice);
            Controls.Add(label15);
            Controls.Add(label6);
            Controls.Add(cmbStatus);
            Controls.Add(btnCloseWindow);
            Controls.Add(btnSaveVariant);
            Controls.Add(label5);
            Controls.Add(txtReorderLevel);
            Controls.Add(txtStockQuantity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbColor);
            Controls.Add(cmbSize);
            Controls.Add(txtSKU);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductVariantDetailForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Variant Details";
            Load += ProductVariantDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSKU;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox cmbColor;
        private ComboBox cmbSize;
        private TextBox txtStockQuantity;
        private Label label4;
        private TextBox txtReorderLevel;
        private Label label5;
        private Button btnCloseWindow;
        private Button btnSaveVariant;
        private Label label6;
        private ComboBox cmbStatus;
        private Label label14;
        private TextBox txtSellingPrice;
        private TextBox txtCostPrice;
        private Label label15;
    }
}