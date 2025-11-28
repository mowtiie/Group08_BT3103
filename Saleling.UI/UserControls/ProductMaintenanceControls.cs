using Saleling.Controller;
using Saleling.Model.Product;
using Saleling.Util;
using Saleling_Debug.UI;

namespace Saleling.UI
{
    public partial class ProductMaintenanceControls : UserControl
    {
        private readonly ProductController _productController;

        public ProductMaintenanceControls()
        {
            InitializeComponent();
            _productController = new ProductController();
            cmbFilter.SelectedIndex = 0;
        }

        private async void ProductMaintenanceScreen_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadProducts();
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Critical error during Product Maintenance Screen initialization (LoadProducts).");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadProducts(List<ProductModel>? searchedProducts = null)
        {
            List<ProductModel> products = searchedProducts ?? await _productController.GetProductsAsync();

            int productIdToLoadVariants = -1;
            if (products.Any())
            {
                tblProductMaster.DataSource = products;
                tblProductMaster.Columns["ProductID"].HeaderText = "Product ID";
                tblProductMaster.Columns["ProductName"].HeaderText = "Product Name";

                productIdToLoadVariants = products[0].ProductID;
                tblProductMaster.Rows[0].Selected = true;

                await LoadProductVariants(productIdToLoadVariants);
            }
            else if (searchedProducts != null)
            {
                await LoggerUtil.Instance.LogInfoAsync("Product search completed, no products found matching criteria.");
                MessageBox.Show("No products found matching your search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task LoadProductVariants(int productId)
        {
            List<ProductVariantModel> productVariants = await _productController.GetProductVariantsAsync(productId);
            tblProductVariants.DataSource = productVariants;
            tblProductVariants.Columns["VariantID"].HeaderText = "Variant ID";
            tblProductVariants.Columns["ProductID"].HeaderText = "Product ID";
            tblProductVariants.Columns["CostPrice"].HeaderText = "Cost Price";
            tblProductVariants.Columns["SellingPrice"].HeaderText = "Unit Price";
            tblProductVariants.Columns["StockQuantity"].HeaderText = "Stock Quantity";
            tblProductVariants.Columns["ReorderLevel"].HeaderText = "Reorder Level";
            tblProductVariants.Columns["CostPrice"].DefaultCellStyle.Format = "C2";
            tblProductVariants.Columns["SellingPrice"].DefaultCellStyle.Format = "C2";
        }

        private async void tblProductMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int selectedProductID = tblProductMaster.Rows[e.RowIndex].Cells["ProductID"].Value is int ID ? ID : -1;
                await LoadProductVariants(selectedProductID);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, $"Error loading variants after product click (RowIndex: {e.RowIndex}).");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProductDetailForm productDetailsForm = new ProductDetailForm())
                {
                    if (productDetailsForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error adding new product.");
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnAddVariant_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblProductMaster.CurrentRow == null)
                {
                    await LoggerUtil.Instance.LogWarningAsync("User attempted to add variant without selecting a product.");
                    throw new InvalidOperationException("Please select a product first to add a variant.");
                }

                int selectedProductID = tblProductMaster.CurrentRow.Cells["ProductID"].Value is int id ? id : -1;
                using (ProductVariantDetailForm productVariantDetailsForm = new ProductVariantDetailForm(selectedProductID))
                {
                    if (productVariantDetailsForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadProductVariants(selectedProductID);
                    }
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync(ioex.Message);
                MessageBox.Show(ioex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error adding new product variant.");
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblProductMaster.CurrentRow == null)
                {
                    await LoggerUtil.Instance.LogWarningAsync("User attempted to edit product without selecting a product.");
                    throw new InvalidOperationException("Please select a product to edit.");
                }

                int selectedProductID = tblProductMaster.CurrentRow.Cells["ProductID"].Value is int id ? id : -1;
                using (ProductDetailForm productDetailsForm = new ProductDetailForm(selectedProductID))
                {
                    if (productDetailsForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadProducts();
                    }
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync(ioex.Message);
                MessageBox.Show(ioex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error editing product.");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblProductMaster.CurrentRow == null)
                {
                    await LoggerUtil.Instance.LogWarningAsync("User attempted to delete product without selecting a product.");
                    throw new InvalidOperationException("Please select a product to delete.");
                }

                DialogResult confirmDeleteResult = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmDeleteResult == DialogResult.Yes)
                {
                    int selectedProductID = tblProductMaster.CurrentRow.Cells["ProductID"].Value is int id ? id : -1;
                    await _productController.DeleteProductAsync(selectedProductID);
                    MessageBox.Show("Product deleted successfully", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync(ioex.Message);
                MessageBox.Show(ioex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error deleting product.");
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await LoadProducts();
            }
        }

        private async void btnEditVariant_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblProductMaster.CurrentRow == null || tblProductVariants.CurrentRow == null)
                {
                    await LoggerUtil.Instance.LogWarningAsync("User attempted to edit variant without selecting a product or variant.");
                    throw new InvalidOperationException("Please select both a product and a variant to edit.");
                }

                int selectedProductVariantID = tblProductVariants.CurrentRow.Cells["VariantID"].Value is int id ? id : -1;
                int selectedProductID = tblProductMaster.CurrentRow.Cells["ProductID"].Value is int pid ? pid : -1;

                using (ProductVariantDetailForm productVariantDetailsForm = new ProductVariantDetailForm(selectedProductID, selectedProductVariantID))
                {
                    if (productVariantDetailsForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadProductVariants(selectedProductID);
                    }
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync(ioex.Message);
                MessageBox.Show(ioex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error editing product variant.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteVariant_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblProductMaster.CurrentRow == null || tblProductVariants.CurrentRow == null)
                {
                    await LoggerUtil.Instance.LogWarningAsync("User attempted to delete variant without selecting a product or variant.");
                    throw new InvalidOperationException("Please select both a product and a variant to delete.");
                }

                DialogResult confirmDeleteResult = MessageBox.Show(
                    "Are you sure you want to delete this product variant?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmDeleteResult == DialogResult.Yes)
                {
                    int selectedProductVariantID = tblProductVariants.CurrentRow.Cells["VariantID"].Value is int id ? id : -1;
                    int selectedProductID = tblProductMaster.CurrentRow.Cells["ProductID"].Value is int pid ? pid : -1;

                    await _productController.DeleteProductVariantAsync(selectedProductVariantID);
                    await LoadProductVariants(selectedProductID);

                    await LoggerUtil.Instance.LogWarningAsync($"Product Variant ID {selectedProductVariantID} deleted successfully.");
                    MessageBox.Show("Product variant deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync(ioex.Message);
                MessageBox.Show(ioex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error deleting product variant.");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchFilter = cmbFilter.Text;
            string searchTerm = txtSearch.Text;

            try
            {
                List<ProductModel> searchedProducts = await _productController.SearchProductsAsync(searchTerm, searchFilter);
                await LoadProducts(searchedProducts);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, $"Error during product search (Query: {searchTerm}, Filter: {searchFilter}).");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error refreshing all products.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
