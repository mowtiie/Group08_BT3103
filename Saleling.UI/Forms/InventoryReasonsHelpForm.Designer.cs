namespace Saleling.UI
{
    partial class InventoryReasonsHelpForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(357, 37);
            label1.TabIndex = 0;
            label1.Text = "Reasons for adding stocks:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 94);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 1;
            label2.Text = "Found Stock:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(36, 133);
            label3.Name = "label3";
            label3.Size = new Size(357, 120);
            label3.TabIndex = 2;
            label3.Text = "Items were located that were previously misplaced, mislabeled, or stored in an uncounted location (e.g., in a back corner, or still on a loading dock).";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(36, 315);
            label4.Name = "label4";
            label4.Size = new Size(357, 120);
            label4.TabIndex = 4;
            label4.Text = "The physical count revealed more stock than the system recorded. This is the positive side of correcting a data entry error or a previous counting mistake.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 276);
            label5.Name = "label5";
            label5.Size = new Size(314, 28);
            label5.TabIndex = 3;
            label5.Text = "Physical Inventory Reconciliation:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(36, 493);
            label6.Name = "label6";
            label6.Size = new Size(357, 185);
            label6.TabIndex = 6;
            label6.Text = "An inventory transaction failed or was recorded incorrectly (e.g., a return was processed but the stock wasn't put back on the shelf), requiring a manual correction to restore the correct quantity.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 454);
            label7.Name = "label7";
            label7.Size = new Size(232, 28);
            label7.TabIndex = 5;
            label7.Text = "System Error Correction:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(484, 493);
            label8.Name = "label8";
            label8.Size = new Size(397, 185);
            label8.TabIndex = 13;
            label8.Text = "The physical count revealed less stock than the system recorded. This is the negative side of correcting a counting error, indicating an unrecorded loss or transaction.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(484, 454);
            label9.Name = "label9";
            label9.Size = new Size(297, 28);
            label9.TabIndex = 12;
            label9.Text = "Physical Inventory Discrepancy:";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(484, 315);
            label10.Name = "label10";
            label10.Size = new Size(397, 120);
            label10.TabIndex = 11;
            label10.Text = "Stock is missing due to theft, fraud, or simply lost in transit or storage, and the cause cannot be definitively identified.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(484, 276);
            label11.Name = "label11";
            label11.Size = new Size(108, 28);
            label11.TabIndex = 10;
            label11.Text = "Shrinkage:";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(484, 133);
            label12.Name = "label12";
            label12.Size = new Size(397, 120);
            label12.TabIndex = 9;
            label12.Text = "Products are damaged, expired, spoiled, or otherwise unsellable and must be removed from the active inventory. This is the most common reason for negative adjustments.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(484, 94);
            label13.Name = "label13";
            label13.Size = new Size(104, 28);
            label13.TabIndex = 8;
            label13.Text = "Damaged:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(484, 38);
            label14.Name = "label14";
            label14.Size = new Size(397, 37);
            label14.TabIndex = 7;
            label14.Text = "Reasons for deducting stocks:";
            // 
            // InventoryReasonsHelpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(926, 710);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InventoryReasonsHelpForm";
            Text = "Reasons Definition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}