namespace Saleling.UI
{
    partial class PointOfSalesControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSalesControls));
            btnRemoveItem = new Button();
            lblChange = new Label();
            label23 = new Label();
            panel1 = new Panel();
            lblTime = new Label();
            label16 = new Label();
            lblCurrentCashierName = new Label();
            lblDate = new Label();
            label10 = new Label();
            label14 = new Label();
            label8 = new Label();
            btnApplyPayment = new Button();
            lblPayment = new Label();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label5 = new Label();
            lblGrandTotal = new Label();
            btnFinalizeSale = new Button();
            label12 = new Label();
            lblDiscount = new Label();
            lblSubtotal = new Label();
            lblTotalItems = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnRefresh = new Button();
            btnAddItem = new Button();
            label2 = new Label();
            cmbFilter = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            tblAvailableProducts = new DataGridView();
            label3 = new Label();
            tblSalesCart = new DataGridView();
            btnClear = new Button();
            label4 = new Label();
            label1 = new Label();
            btnApplyDiscount = new Button();
            btnUpdateQuantity = new Button();
            saleReceiptDocument = new System.Drawing.Printing.PrintDocument();
            saleReceiptPreview = new PrintPreviewDialog();
            timeTrackerTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblAvailableProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblSalesCart).BeginInit();
            SuspendLayout();
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.White;
            btnRemoveItem.FlatAppearance.BorderColor = Color.OrangeRed;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRemoveItem.ForeColor = Color.OrangeRed;
            btnRemoveItem.Location = new Point(512, 985);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(204, 48);
            btnRemoveItem.TabIndex = 85;
            btnRemoveItem.Text = "Void Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // lblChange
            // 
            lblChange.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChange.ForeColor = SystemColors.ControlText;
            lblChange.Location = new Point(180, 520);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(203, 31);
            lblChange.TabIndex = 91;
            lblChange.Text = "₱0.00";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.ForeColor = SystemColors.ControlText;
            label23.Location = new Point(40, 523);
            label23.Name = "label23";
            label23.Size = new Size(82, 28);
            label23.TabIndex = 90;
            label23.Text = "Change:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(lblCurrentCashierName);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnApplyPayment);
            panel1.Controls.Add(lblPayment);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblChange);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(lblGrandTotal);
            panel1.Controls.Add(btnFinalizeSale);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(lblSubtotal);
            panel1.Controls.Add(lblTotalItems);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1094, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 875);
            panel1.TabIndex = 81;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTime.Location = new Point(152, 216);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(231, 28);
            lblTime.TabIndex = 108;
            lblTime.Text = "1:30AM";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(40, 216);
            label16.Name = "label16";
            label16.Size = new Size(58, 28);
            label16.TabIndex = 107;
            label16.Text = "Time:";
            // 
            // lblCurrentCashierName
            // 
            lblCurrentCashierName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCurrentCashierName.Location = new Point(152, 118);
            lblCurrentCashierName.Name = "lblCurrentCashierName";
            lblCurrentCashierName.Size = new Size(231, 28);
            lblCurrentCashierName.TabIndex = 106;
            lblCurrentCashierName.Text = "John Doe";
            lblCurrentCashierName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDate.Location = new Point(152, 167);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(231, 28);
            lblDate.TabIndex = 105;
            lblDate.Text = "10-31-2025";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(40, 118);
            label10.Name = "label10";
            label10.Size = new Size(79, 28);
            label10.TabIndex = 104;
            label10.Text = "Cashier:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(40, 167);
            label14.Name = "label14";
            label14.Size = new Size(57, 28);
            label14.TabIndex = 103;
            label14.Text = "Date:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 244);
            label8.Name = "label8";
            label8.Size = new Size(349, 25);
            label8.TabIndex = 102;
            label8.Text = "_________________________________________________________________________________";
            // 
            // btnApplyPayment
            // 
            btnApplyPayment.BackColor = Color.White;
            btnApplyPayment.FlatStyle = FlatStyle.Flat;
            btnApplyPayment.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnApplyPayment.ForeColor = SystemColors.Highlight;
            btnApplyPayment.Location = new Point(40, 704);
            btnApplyPayment.Name = "btnApplyPayment";
            btnApplyPayment.Size = new Size(345, 53);
            btnApplyPayment.TabIndex = 100;
            btnApplyPayment.Text = "Apply Payment";
            btnApplyPayment.UseVisualStyleBackColor = false;
            btnApplyPayment.Click += btnApplyPayment_Click;
            // 
            // lblPayment
            // 
            lblPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPayment.ForeColor = SystemColors.ControlText;
            lblPayment.Location = new Point(180, 463);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(203, 31);
            lblPayment.TabIndex = 98;
            lblPayment.Text = "₱0.00";
            lblPayment.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(40, 466);
            label15.Name = "label15";
            label15.Size = new Size(91, 28);
            label15.TabIndex = 97;
            label15.Text = "Payment:";
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(39, 565);
            label13.Name = "label13";
            label13.Size = new Size(349, 25);
            label13.TabIndex = 96;
            label13.Text = "_________________________________________________________________________________";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(39, 654);
            label11.Name = "label11";
            label11.Size = new Size(349, 25);
            label11.TabIndex = 95;
            label11.Text = "_________________________________________________________________________________";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(54, 26);
            label5.Name = "label5";
            label5.Size = new Size(330, 54);
            label5.TabIndex = 87;
            label5.Text = "SALE SUMMARY";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblGrandTotal.ForeColor = SystemColors.Highlight;
            lblGrandTotal.Location = new Point(205, 609);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(183, 45);
            lblGrandTotal.TabIndex = 77;
            lblGrandTotal.Text = "₱0.00";
            lblGrandTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnFinalizeSale
            // 
            btnFinalizeSale.BackColor = SystemColors.Highlight;
            btnFinalizeSale.FlatAppearance.BorderSize = 0;
            btnFinalizeSale.FlatStyle = FlatStyle.Flat;
            btnFinalizeSale.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizeSale.ForeColor = Color.White;
            btnFinalizeSale.Location = new Point(40, 772);
            btnFinalizeSale.Name = "btnFinalizeSale";
            btnFinalizeSale.Size = new Size(345, 60);
            btnFinalizeSale.TabIndex = 69;
            btnFinalizeSale.Text = "Process Sale";
            btnFinalizeSale.UseVisualStyleBackColor = false;
            btnFinalizeSale.Click += btnFinalizeSale_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(40, 619);
            label12.Name = "label12";
            label12.Size = new Size(127, 28);
            label12.TabIndex = 76;
            label12.Text = "Grand Total:";
            // 
            // lblDiscount
            // 
            lblDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDiscount.ForeColor = SystemColors.ControlText;
            lblDiscount.Location = new Point(180, 408);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(203, 25);
            lblDiscount.TabIndex = 75;
            lblDiscount.Text = "₱0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSubtotal.Location = new Point(180, 349);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(203, 25);
            lblSubtotal.TabIndex = 74;
            lblSubtotal.Text = "₱0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalItems
            // 
            lblTotalItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalItems.Location = new Point(180, 289);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(203, 25);
            lblTotalItems.TabIndex = 73;
            lblTotalItems.Text = "0";
            lblTotalItems.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(40, 408);
            label9.Name = "label9";
            label9.Size = new Size(93, 28);
            label9.TabIndex = 72;
            label9.Text = "Discount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(40, 347);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 70;
            label7.Text = "Subtotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(40, 286);
            label6.Name = "label6";
            label6.Size = new Size(110, 28);
            label6.TabIndex = 69;
            label6.Text = "Total Items:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Highlight;
            btnRefresh.Location = new Point(264, 518);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(152, 48);
            btnRefresh.TabIndex = 80;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = SystemColors.Highlight;
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(44, 518);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(204, 48);
            btnAddItem.TabIndex = 79;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(498, 39);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 78;
            label2.Text = "Search By:";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 18.2F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Name", "Category" });
            cmbFilter.Location = new Point(498, 84);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(295, 49);
            cmbFilter.TabIndex = 77;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18.2F);
            txtSearch.Location = new Point(44, 86);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(432, 48);
            txtSearch.TabIndex = 71;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(809, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 46);
            btnSearch.TabIndex = 70;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tblAvailableProducts
            // 
            tblAvailableProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblAvailableProducts.BackgroundColor = SystemColors.Control;
            tblAvailableProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAvailableProducts.Location = new Point(44, 205);
            tblAvailableProducts.MultiSelect = false;
            tblAvailableProducts.Name = "tblAvailableProducts";
            tblAvailableProducts.ReadOnly = true;
            tblAvailableProducts.RowHeadersVisible = false;
            tblAvailableProducts.RowHeadersWidth = 51;
            tblAvailableProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblAvailableProducts.Size = new Size(1027, 304);
            tblAvailableProducts.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(44, 155);
            label3.Name = "label3";
            label3.Size = new Size(246, 38);
            label3.TabIndex = 73;
            label3.Text = "Product Selection:";
            // 
            // tblSalesCart
            // 
            tblSalesCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblSalesCart.BackgroundColor = SystemColors.Control;
            tblSalesCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblSalesCart.Location = new Point(44, 643);
            tblSalesCart.Name = "tblSalesCart";
            tblSalesCart.ReadOnly = true;
            tblSalesCart.RowHeadersVisible = false;
            tblSalesCart.RowHeadersWidth = 51;
            tblSalesCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblSalesCart.Size = new Size(1027, 318);
            tblSalesCart.TabIndex = 76;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.Highlight;
            btnClear.Location = new Point(961, 86);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 48);
            btnClear.TabIndex = 75;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(44, 592);
            label4.Name = "label4";
            label4.Size = new Size(149, 38);
            label4.TabIndex = 74;
            label4.Text = "Sales Cart:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(44, 39);
            label1.Name = "label1";
            label1.Size = new Size(215, 38);
            label1.TabIndex = 72;
            label1.Text = "Search Product:";
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BackColor = SystemColors.Highlight;
            btnApplyDiscount.FlatAppearance.BorderSize = 0;
            btnApplyDiscount.FlatStyle = FlatStyle.Flat;
            btnApplyDiscount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnApplyDiscount.ForeColor = Color.White;
            btnApplyDiscount.Location = new Point(44, 985);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(204, 48);
            btnApplyDiscount.TabIndex = 86;
            btnApplyDiscount.Text = "Apply Discount";
            btnApplyDiscount.UseVisualStyleBackColor = false;
            btnApplyDiscount.Click += btnApplyDiscount_Click;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.BackColor = SystemColors.Highlight;
            btnUpdateQuantity.FlatAppearance.BorderSize = 0;
            btnUpdateQuantity.FlatStyle = FlatStyle.Flat;
            btnUpdateQuantity.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnUpdateQuantity.ForeColor = Color.White;
            btnUpdateQuantity.Location = new Point(264, 985);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(232, 48);
            btnUpdateQuantity.TabIndex = 82;
            btnUpdateQuantity.Text = "Update Quantity";
            btnUpdateQuantity.UseVisualStyleBackColor = false;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
            // 
            // saleReceiptDocument
            // 
            saleReceiptDocument.PrintPage += saleReceiptDocument_PrintPage;
            // 
            // saleReceiptPreview
            // 
            saleReceiptPreview.AutoScrollMargin = new Size(0, 0);
            saleReceiptPreview.AutoScrollMinSize = new Size(0, 0);
            saleReceiptPreview.ClientSize = new Size(400, 300);
            saleReceiptPreview.Enabled = true;
            saleReceiptPreview.Icon = (Icon)resources.GetObject("saleReceiptPreview.Icon");
            saleReceiptPreview.Name = "saleReceiptPreview";
            saleReceiptPreview.Visible = false;
            // 
            // timeTrackerTimer
            // 
            timeTrackerTimer.Interval = 1000;
            timeTrackerTimer.Tick += timeTrackerTimer_Tick;
            // 
            // PointOfSalesControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnApplyDiscount);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnUpdateQuantity);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddItem);
            Controls.Add(label2);
            Controls.Add(cmbFilter);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(tblAvailableProducts);
            Controls.Add(label3);
            Controls.Add(tblSalesCart);
            Controls.Add(btnClear);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "PointOfSalesControls";
            Size = new Size(1547, 1080);
            Load += POSControls_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblAvailableProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblSalesCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoveItem;
        private TextBox txtQuantity;
        private Label lblChange;
        private Label label23;
        private Label label19;
        private TextBox txtDiscount;
        private Panel panel1;
        private Label label18;
        private TextBox txtPayment;
        private Label lblGrandTotal;
        private Button btnFinalizeSale;
        private Label label12;
        private Label lblDiscount;
        private Label lblSubtotal;
        private Label lblTotalItems;
        private Label label9;
        private Label label7;
        private Label label6;
        private Button btnRefresh;
        private Button btnAddItem;
        private Label label2;
        private ComboBox cmbFilter;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView tblAvailableProducts;
        private Label label3;
        private DataGridView tblSalesCart;
        private Button btnClear;
        private Label label4;
        private Label label1;
        private Label label8;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label lblPayment;
        private Label label15;
        private Button btnApplyDiscount;
        private Button btnUpdateQuantity;
        private Button btnApplyPayment;
        private Label label14;
        private Label lblCurrentCashierName;
        private Label lblDate;
        private System.Drawing.Printing.PrintDocument saleReceiptDocument;
        private PrintPreviewDialog saleReceiptPreview;
        private Label lblTime;
        private Label label16;
        private System.Windows.Forms.Timer timeTrackerTimer;
    }
}
