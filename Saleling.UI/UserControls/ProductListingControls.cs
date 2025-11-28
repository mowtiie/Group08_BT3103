using Saleling.Controller;
using Saleling.Model.Product;
using Saleling.Util;

namespace Saleling.UI
{
    public partial class ProductListingControls : UserControl
    {
        private ProductController _productController;

        public ProductListingControls()
        {
            InitializeComponent();
            _productController = new ProductController();
            cmbFilter.SelectedIndex = 0;
        }

        private async void ProductListingControls_Load(object sender, EventArgs e)
        {
            await LoadProductListings();
        }

        private async Task LoadProductListings()
        {
            try
            {
                List<ProductListingModel> productListings = await _productController.GetProductListingsAsync();
                dgvProducts.DataSource = productListings;
                dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
                dgvProducts.Columns["ProductName"].HeaderText = "Product Name";
                dgvProducts.Columns["VariantID"].HeaderText = "Variant ID";
                dgvProducts.Columns["StockQuantity"].HeaderText = "Stock Quantity";
                dgvProducts.Columns["ReorderLevel"].HeaderText = "Reorder Level";
                dgvProducts.Columns["SellingPrice"].HeaderText = "Unit Price";
                dgvProducts.Columns["SellingPrice"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, $"Error loading product listings: {ex.Message}");
                MessageBox.Show($"Error loading product listings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadProductListings();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                string searchFilter = cmbFilter.Text.Trim();

                List<ProductListingModel> searchedProductListing = await _productController.SearchProductListingsAsync(searchTerm, searchFilter);
                if (searchedProductListing.Count == 0)
                {
                    MessageBox.Show("No products found matching your search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvProducts.DataSource = searchedProductListing;
                    dgvProducts.Columns["SellingPrice"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                LoggerUtil.Instance.LogExceptionAsync(ex, $"Error during product search: {ex.Message}").Wait();
                MessageBox.Show($"Error during product search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}