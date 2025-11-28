using Saleling.Controller;
using Saleling.Model;
using Saleling.Model.Product;
using Saleling.Util;

namespace Saleling_Debug.UI
{
    public partial class ProductVariantDetailForm : Form
    {
        private delegate Task SaveProductVariantDelegate();

        private readonly ProductController _productController;
        private UserModel _currentUser;

        private int _productID;
        private int _productVariantID;

        private bool _isEditMode = false;

        public ProductVariantDetailForm(int productID)
        {
            InitializeComponent();
            Text = "Add Product Variant";

            _productID = productID;
            _currentUser = SessionUtil.Instance.CurrentUser;
            _productController = new ProductController();
        }

        public ProductVariantDetailForm(int productID, int productVariantID)
        {
            InitializeComponent();
            Text = "Edit Product Variant";

            _productID = productID;
            _productVariantID = productVariantID;
            _currentUser = SessionUtil.Instance.CurrentUser;
            _isEditMode = true;
            _productController = new ProductController();
        }

        private async void ProductVariantDetailForm_Load(object sender, EventArgs e)
        {
            cmbSize.DataSource = Enum.GetValues(typeof(ProductVariantModel.SizeOption));
            cmbColor.DataSource = Enum.GetValues(typeof(ProductVariantModel.ColorOption));
            cmbStatus.DataSource = Enum.GetValues(typeof(ProductVariantModel.StatusOption));

            if (_isEditMode)
            {
                txtStockQuantity.Enabled = false;
                await LoadProductVariantDetails(_productVariantID);
            }
        }

        private async Task LoadProductVariantDetails(int productVariantID)
        {
            try
            {
                ProductVariantModel productVariant = await _productController.GetProductVariantByIDAsync(productVariantID);
                txtSKU.Text = productVariant.SKU;
                cmbColor.Text = productVariant.Color;
                cmbStatus.Text = productVariant.Status;
                cmbSize.Text = productVariant.Size;
                txtCostPrice.Text = productVariant.CostPrice.ToString("N");
                txtSellingPrice.Text = productVariant.SellingPrice.ToString("N");
                txtStockQuantity.Text = productVariant.StockQuantity.ToString();
                txtReorderLevel.Text = productVariant.ReorderLevel.ToString();
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, $"Failed to load details for Product Variant ID: {productVariantID}.");
                MessageBox.Show("Failed to load product variant details. See logs for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSaveVariant_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProductVariantDelegate saveVariantDelegate;
                saveVariantDelegate = (_isEditMode) ? EditProductVariant : AddProductVariant;
                await saveVariantDelegate();

                string action = _isEditMode ? "updated" : "added";
                MessageBox.Show($"Product variant successfully {action}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                await LoggerUtil.Instance.LogWarningAsync($"Invalid number format detected on variant save for Product ID {_productID}.");
                MessageBox.Show("Please check that Cost Price, Selling Price, Stock Quantity, and Reorder Level are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException argEx)
            {
                await LoggerUtil.Instance.LogExceptionAsync(argEx, $"Variant save failed due to validation error for Product ID {_productID}.");
                MessageBox.Show(argEx.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, $"Unexpected error during product variant save for Product ID {_productID}.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AddProductVariant()
        {
            ProductVariantModel newProductVariant = new ProductVariantModel
            {
                ProductID = _productID,
                SKU = txtSKU.Text.Trim(),
                Size = cmbSize.Text,
                Color = cmbColor.Text,
                Status = cmbStatus.Text,
                CostPrice = decimal.Parse(txtCostPrice.Text.Trim()),
                SellingPrice = decimal.Parse(txtSellingPrice.Text.Trim()),
                StockQuantity = int.Parse(txtStockQuantity.Text.Trim()),
                ReorderLevel = int.Parse(txtReorderLevel.Text.Trim())
            };

            await _productController.AddProductVariantAsync(newProductVariant, _currentUser.UserID);
            await LoggerUtil.Instance.LogInfoAsync($"Product variant (SKU: {newProductVariant.SKU}) added successfully to Product ID {_productID} by User {_currentUser.UserID}.");
        }

        private async Task EditProductVariant()
        {
            ProductVariantModel editedProductVariant = new ProductVariantModel
            {
                VariantID = _productVariantID,
                ProductID = _productID,
                SKU = txtSKU.Text.Trim(),
                Size = cmbSize.Text,
                Color = cmbColor.Text,
                CostPrice = decimal.Parse(txtCostPrice.Text.Trim()),
                SellingPrice = decimal.Parse(txtSellingPrice.Text.Trim()),
                Status = cmbStatus.Text,
                ReorderLevel = int.Parse(txtReorderLevel.Text)
            };

            await _productController.EditProductVariantAsync(editedProductVariant);
            await LoggerUtil.Instance.LogInfoAsync($"Product variant ID {_productVariantID} (SKU: {editedProductVariant.SKU}) updated successfully.");
        }
    }
}
