using Saleling.Controller;
using Saleling.Model.Product;
using Saleling.Util;

namespace Saleling.UI
{
    public partial class ProductDetailForm : Form
    {
        private delegate Task SaveProductDelegate();

        private readonly SupplierController _supplierController;
        private readonly CategoryController _categoryController;
        private readonly ProductController _productController;

        private int _productID;
        private bool _isEditMode;

        private readonly string NO_SELECTED_SUPPLIER = "No Supplier Assigned";

        public ProductDetailForm()
        {
            InitializeComponent();
            Text = "Add Product";

            _productController = new ProductController();
            _supplierController = new SupplierController();
            _categoryController = new CategoryController();
        }

        public ProductDetailForm(int productID)
        {
            InitializeComponent();
            Text = "Edit Product";

            _productController = new ProductController();
            _supplierController = new SupplierController();
            _categoryController = new CategoryController();

            _productID = productID;
            _isEditMode = true;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ProductMasterDetailForm_Load(object sender, EventArgs e)
        {
            await LoadComboBoxes();
            if (_isEditMode)
            {
                await LoadProductDetails(_productID);
            }
        }

        private async Task LoadProductDetails(int productID)
        {
            try
            {
                ProductModel product = await _productController.GetProductByIDAsync(productID);
                string supplier = product.Supplier == null ? NO_SELECTED_SUPPLIER : product.Supplier;

                txtProductName.Text = product.ProductName;
                cmbStatus.Text = product.Status;
                cmbSupplier.Text = supplier;
                cmbCategory.Text = product.Category;

                await LoggerUtil.Instance.LogInfoAsync($"Loaded details for ProductID: {productID}.");
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, $"Failed to load details for ProductID: {productID}.");
                MessageBox.Show(ex.Message, "Error Loading Product", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private async Task LoadComboBoxes()
        {
            List<string> categories = await _categoryController.GetAllNamesAsync();
            List<string> suppliers = await _supplierController.GetAllNamesAsync();
            suppliers.Insert(0, NO_SELECTED_SUPPLIER);

            cmbSupplier.DataSource = suppliers;
            cmbCategory.DataSource = categories;
            cmbStatus.DataSource = Enum.GetValues(typeof(ProductModel.StatusOption));
        }

        private async void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProductDelegate saveProductDelegate;
                saveProductDelegate = _isEditMode ? EditProduct : AddProduct;
                await saveProductDelegate();

                string action = _isEditMode ? "updated" : "added";
                MessageBox.Show($"Product successfully {action}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                await LoggerUtil.Instance.LogWarningAsync("Invalid base unit price format or other numerical error encountered during save.");
                MessageBox.Show("Please ensure all numerical fields have valid formats.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException argEx)
            {
                await LoggerUtil.Instance.LogExceptionAsync(argEx, "Product save failed due to validation error.");
                MessageBox.Show(argEx.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Unexpected error during product save operation.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AddProduct()
        {
            string? supplier = cmbSupplier.Text.Equals(NO_SELECTED_SUPPLIER) ? null : cmbSupplier.Text;

            ProductModel product = new ProductModel
            {
                ProductName = txtProductName.Text.Trim(),
                Category = cmbCategory.Text.Trim(),
                Supplier = supplier,
                Status = cmbStatus.Text.Trim(),
            };

            await _productController.AddProductAsync(product);
            await LoggerUtil.Instance.LogInfoAsync($"Product '{product.ProductName}' successfully added.");
        }

        private async Task EditProduct()
        {
            string? supplier = cmbSupplier.Text.Equals(NO_SELECTED_SUPPLIER) ? null : cmbSupplier.Text;

            ProductModel product = new ProductModel
            {
                ProductID = _productID,
                ProductName = txtProductName.Text.Trim(),
                Category = cmbCategory.Text.Trim(),
                Supplier = supplier,
                Status = cmbStatus.Text.Trim(),
            };

            await _productController.EditProductAsync(product);
            await LoggerUtil.Instance.LogInfoAsync($"Product ID {_productID} ('{product.ProductName}') successfully updated.");
        }
    }
}
