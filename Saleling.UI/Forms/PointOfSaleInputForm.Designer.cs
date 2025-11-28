namespace Saleling.UI;

partial class PointOfSaleInputForm
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
        pbIcon = new PictureBox();
        lblTitle = new Label();
        txtInput = new TextBox();
        btnAction = new Button();
        ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
        SuspendLayout();
        // 
        // pbIcon
        // 
        pbIcon.Image = Properties.Resources.icon_placeholder;
        pbIcon.Location = new Point(161, 39);
        pbIcon.Name = "pbIcon";
        pbIcon.Size = new Size(181, 170);
        pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
        pbIcon.TabIndex = 3;
        pbIcon.TabStop = false;
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.Location = new Point(51, 237);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(417, 63);
        lblTitle.TabIndex = 4;
        lblTitle.Text = "PLACEHOLDER";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtInput
        // 
        txtInput.Font = new Font("Segoe UI", 24.2F);
        txtInput.Location = new Point(51, 319);
        txtInput.Name = "txtInput";
        txtInput.Size = new Size(417, 61);
        txtInput.TabIndex = 5;
        txtInput.TextAlign = HorizontalAlignment.Center;
        // 
        // btnAction
        // 
        btnAction.BackColor = SystemColors.Highlight;
        btnAction.FlatAppearance.BorderSize = 0;
        btnAction.FlatStyle = FlatStyle.Flat;
        btnAction.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
        btnAction.ForeColor = Color.White;
        btnAction.Location = new Point(51, 411);
        btnAction.Name = "btnAction";
        btnAction.Size = new Size(417, 52);
        btnAction.TabIndex = 70;
        btnAction.Text = "Placeholder";
        btnAction.UseVisualStyleBackColor = false;
        btnAction.Click += btnAction_Click;
        // 
        // PointOfSaleInputForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(511, 497);
        Controls.Add(btnAction);
        Controls.Add(txtInput);
        Controls.Add(lblTitle);
        Controls.Add(pbIcon);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "PointOfSaleInputForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Input Form";
        Load += PointOfSaleInputForm_Load;
        ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private PictureBox pbIcon;
    private Label lblTitle;
    private TextBox txtInput;
    private Button btnAction;
}