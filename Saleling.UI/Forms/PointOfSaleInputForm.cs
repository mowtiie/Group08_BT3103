using Saleling.Util;

namespace Saleling.UI
{
    public partial class PointOfSaleInputForm : Form
    {
        public string? InputValue { get; set; } = null;

        public PointOfSaleInputForm(Image formIcon, string title, string buttonText)
        {
            InitializeComponent();

            btnAction.Text = buttonText;
            lblTitle.Text = title;
            pbIcon.Image = formIcon;
        }

        private async void btnAction_Click(object sender, EventArgs e)
        {
            InputValue = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(InputValue))
            {
                MessageBox.Show("Input cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void PointOfSaleInputForm_Load(object sender, EventArgs e)
        {
            txtInput.Text = InputValue ?? string.Empty;
        }
    }
}
