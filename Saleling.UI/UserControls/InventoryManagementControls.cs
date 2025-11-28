using Saleling.Controller;
using Saleling.Model.Inventory;
using Saleling.Util;

namespace Saleling.UI
{
    public partial class InventoryManagementControls : UserControl
    {
        private InventoryController _inventoryController;

        public InventoryManagementControls()
        {
            InitializeComponent();
            _inventoryController = new InventoryController();
            cmbFilter.SelectedIndex = 0;
        }

        private async void InventoryManagementScreen_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadProducts();
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Failed to load Inventory Management screen.");
                MessageBox.Show("Failed to load inventory data. Please check the application log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadProducts(List<InventoryItemModel>? searchedInventory = null)
        {
            List<InventoryItemModel> inventoryDetails = searchedInventory ?? await _inventoryController.GetAllAsync();

            int inventoryItemID = -1;
            if (inventoryDetails.Any())
            {
                dgvProducts.DataSource = inventoryDetails;
                dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
                dgvProducts.Columns["ProductName"].HeaderText = "Product Name";
                dgvProducts.Columns["ProductStatus"].HeaderText = "Product Status";
                dgvProducts.Columns["VariantID"].HeaderText = "Variant ID";
                dgvProducts.Columns["VariantStatus"].HeaderText = "Variant Status";
                dgvProducts.Columns["StockQuantity"].HeaderText = "Stock Quantity";
                dgvProducts.Columns["ReorderLevel"].HeaderText = "Reorder Level";

                inventoryItemID = inventoryDetails[0].VariantID;
                dgvProducts.Rows[0].Selected = true;

                await LoggerUtil.Instance.LogInfoAsync($"Inventory list loaded with {inventoryDetails.Count} items.");
                await LoadLogs(inventoryItemID);
            }
            else if (dgvProducts != null)
            {
                MessageBox.Show("No inventory items found matching your search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void tblInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow selectedRow = dgvProducts.Rows[e.RowIndex];

                int selectedInventoryItemID = selectedRow.Cells["VariantID"].Value as int? ?? -1;
                if (selectedInventoryItemID != -1)
                {
                    await LoadLogs(selectedInventoryItemID);
                }
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error during DataGridView CellClick/History load.");
                MessageBox.Show("Failed to load inventory history. Please check the application log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadLogs(int inventoryItemID)
        {
            List<InventoryLogModel> inventoryHistory = await _inventoryController.GetLogsAsync(inventoryItemID);
            dgvLogs.DataSource = inventoryHistory;
            dgvLogs.Columns["InventoryID"].HeaderText = "Item ID";
            dgvLogs.Columns["VariantID"].HeaderText = "Variant ID";
            dgvLogs.Columns["QuantityChange"].HeaderText = "Quantity Change";
            dgvLogs.Columns["ChangeDate"].HeaderText = "Date";
            dgvLogs.Columns["TransactionReferenceID"].HeaderText = "Transaction ID";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                string searchFilter = cmbFilter.Text.Trim();

                List<InventoryItemModel> searchedInventory = await _inventoryController.SearchInventoryAsync(searchTerm, searchFilter);
                await LoadProducts(searchedInventory);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error during inventory search operation.");
                MessageBox.Show("An error occurred during search. Please check the application log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
            cmbFilter.SelectedIndex = 0;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadProducts();
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error during inventory refresh operation.");
                MessageBox.Show("Failed to refresh inventory. Please check the application log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdjustStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.CurrentRow == null)
                {
                    throw new InvalidOperationException("Please select an inventory item to adjust stock.");
                }

                int selectedProductVariantID = dgvProducts.CurrentRow.Cells["VariantID"].Value is int variantID ? variantID : -1;
                using (InventoryLogTransactionForm inventoryTransactionForm = new InventoryLogTransactionForm(selectedProductVariantID))
                {
                    if (inventoryTransactionForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadProducts();
                        await LoggerUtil.Instance.LogInfoAsync($"Stock adjustment successfully completed for VariantID {selectedProductVariantID}.");
                    }
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync(ioex.Message);
                MessageBox.Show(ioex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error during stock adjustment operation.");
                MessageBox.Show("An error occurred during stock adjustment. Please check the application log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            int stockQuantity = 0;
            int reorderLevel = 0;

            if (row.Cells["StockQuantity"] != null && row.Cells["StockQuantity"].Value != null)
            {
                int.TryParse(row.Cells["StockQuantity"].Value.ToString(), out stockQuantity);
            }

            if (row.Cells["ReorderLevel"] != null && row.Cells["ReorderLevel"].Value != null)
            {
                int.TryParse(row.Cells["ReorderLevel"].Value.ToString(), out reorderLevel);
            }


            if (stockQuantity == 0)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                row.DefaultCellStyle.ForeColor = Color.DarkRed;
            }
            else if (stockQuantity <= reorderLevel)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                row.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                row.DefaultCellStyle.BackColor = dgvProducts.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = dgvProducts.DefaultCellStyle.ForeColor;
            }
        }
    }
}
