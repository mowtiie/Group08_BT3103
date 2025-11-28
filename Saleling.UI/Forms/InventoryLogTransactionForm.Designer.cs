namespace Saleling.UI
{
    partial class InventoryLogTransactionForm
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
            cmbReason = new ComboBox();
            txtQuantityChange = new TextBox();
            label3 = new Label();
            txtNotes = new TextBox();
            label7 = new Label();
            btnCloseWindow = new Button();
            btnSaveVariant = new Button();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(56, 37);
            label1.Name = "label1";
            label1.Size = new Size(115, 38);
            label1.TabIndex = 55;
            label1.Text = "Reason:";
            // 
            // cmbReason
            // 
            cmbReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReason.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReason.FormattingEnabled = true;
            cmbReason.Items.AddRange(new object[] { "Found Stock", "Physical Reconciliation", "System Error Correction", "Damaged/Scrap", "Shrinkage/Loss", "Physical Discrepancy" });
            cmbReason.Location = new Point(56, 93);
            cmbReason.Name = "cmbReason";
            cmbReason.Size = new Size(415, 49);
            cmbReason.TabIndex = 62;
            // 
            // txtQuantityChange
            // 
            txtQuantityChange.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantityChange.Location = new Point(551, 93);
            txtQuantityChange.Name = "txtQuantityChange";
            txtQuantityChange.Size = new Size(300, 47);
            txtQuantityChange.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(551, 37);
            label3.Name = "label3";
            label3.Size = new Size(237, 38);
            label3.TabIndex = 64;
            label3.Text = "Quantity Change:";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(56, 240);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(795, 276);
            txtNotes.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(56, 188);
            label7.Name = "label7";
            label7.Size = new Size(99, 38);
            label7.TabIndex = 69;
            label7.Text = "Notes:";
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.BackColor = Color.OrangeRed;
            btnCloseWindow.FlatAppearance.BorderSize = 0;
            btnCloseWindow.FlatStyle = FlatStyle.Flat;
            btnCloseWindow.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnCloseWindow.ForeColor = Color.White;
            btnCloseWindow.Location = new Point(366, 548);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(211, 53);
            btnCloseWindow.TabIndex = 74;
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
            btnSaveVariant.Location = new Point(56, 548);
            btnSaveVariant.Name = "btnSaveVariant";
            btnSaveVariant.Size = new Size(288, 53);
            btnSaveVariant.TabIndex = 73;
            btnSaveVariant.Text = "Log Transaction";
            btnSaveVariant.UseVisualStyleBackColor = false;
            btnSaveVariant.Click += btnSaveVariant_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnHelp.Location = new Point(477, 91);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(50, 49);
            btnHelp.TabIndex = 75;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // InventoryLogTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(911, 627);
            Controls.Add(btnHelp);
            Controls.Add(btnCloseWindow);
            Controls.Add(btnSaveVariant);
            Controls.Add(txtNotes);
            Controls.Add(label7);
            Controls.Add(txtQuantityChange);
            Controls.Add(label3);
            Controls.Add(cmbReason);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InventoryLogTransactionForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Transaction Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbReason;
        private TextBox txtQuantityChange;
        private Label label3;
        private TextBox txtNotes;
        private Label label7;
        private Button btnCloseWindow;
        private Button btnSaveVariant;
        private Button btnHelp;
    }
}