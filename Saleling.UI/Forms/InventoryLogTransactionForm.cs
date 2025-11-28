using Saleling.Controller;
using Saleling.Model;
using Saleling.Model.Inventory;
using Saleling.Util;

namespace Saleling.UI
{
    public partial class InventoryLogTransactionForm : Form
    {
        private InventoryController _inventoryController;
        private UserModel _currentUser;

        private int _inventoryItemID;

        public InventoryLogTransactionForm(int inventoryItemID)
        {
            InitializeComponent();
            _currentUser = SessionUtil.Instance.CurrentUser;
            _inventoryController = new InventoryController();
            _inventoryItemID = inventoryItemID;
            cmbReason.SelectedIndex = 0;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSaveVariant_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryLogTransactionModel inventoryTransaction = new InventoryLogTransactionModel
                {
                    VariantID = _inventoryItemID,
                    QuantityChange = int.Parse(txtQuantityChange.Text),
                    Reason = cmbReason.Text,
                    ProcessedByUserID = _currentUser.UserID,
                    Notes = txtNotes.Text
                };

                await _inventoryController.LogTransactionAsync(inventoryTransaction);
                await LoggerUtil.Instance.LogInfoAsync($"Added a new inventory transaction (Item: {_inventoryItemID}) by User {_currentUser.UserID}.");

                MessageBox.Show
                (
                    $"Successfully added a new inventory transaction for product variant {_inventoryItemID}",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException fex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(fex, $"Inventory Transaction Format Error for Item {_inventoryItemID}.");
                MessageBox.Show(fex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, $"Unexpected error logging inventory transaction for Item {_inventoryItemID}.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            using (InventoryReasonsHelpForm inventoryReasonsHelpForm = new InventoryReasonsHelpForm())
            {
                inventoryReasonsHelpForm.ShowDialog();
            }
        }
    }
}
