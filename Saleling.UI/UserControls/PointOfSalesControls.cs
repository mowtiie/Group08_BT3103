using Saleling.Controller;
using Saleling.Model;
using Saleling.Util;
using System.Drawing.Printing;

namespace Saleling.UI
{
    public partial class PointOfSalesControls : UserControl
    {
        private readonly SalesController _salesController;
        private readonly CustomerController _customerController;

        private UserModel _currentUser;
        private SalesReceiptModel _currentSaleReceipt;

        private BindingSource _cartBindingSource;

        public PointOfSalesControls()
        {
            InitializeComponent();
            timeTrackerTimer.Start();

            _currentSaleReceipt = new SalesReceiptModel();
            _currentUser = SessionUtil.Instance.CurrentUser;
            _salesController = new SalesController();
            _customerController = new CustomerController();

            _cartBindingSource = new BindingSource();
            _cartBindingSource.DataSource = _salesController.CartItems;

            tblSalesCart.DataSource = _cartBindingSource;
            tblSalesCart.AllowUserToAddRows = false;

            tblSalesCart.Columns["CurrentStock"].Visible = false;
            tblSalesCart.Columns["VariantID"].Visible = false;

            tblSalesCart.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
            tblSalesCart.Columns["Discount"].DefaultCellStyle.Format = "C2";
            tblSalesCart.Columns["LineTotal"].DefaultCellStyle.Format = "C2";

            tblSalesCart.Columns["ProductName"].HeaderText = "Product Name";
            tblSalesCart.Columns["UnitPrice"].HeaderText = "Unit Price";
            tblSalesCart.Columns["LineTotal"].HeaderText = "Line Total";

            saleReceiptDocument.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 315, 615);
            saleReceiptDocument.DefaultPageSettings.Margins = new Margins(20, 20, 30, 10);

            saleReceiptDocument.PrintPage -= saleReceiptDocument_PrintPage;
            saleReceiptDocument.PrintPage += saleReceiptDocument_PrintPage;

            saleReceiptPreview.Document = saleReceiptDocument;
        }

        private async void POSControls_Load(object sender, EventArgs e)
        {
            try
            {
                lblCurrentCashierName.Text = _currentUser.FullName;
                lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy");
                lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                await LoadAvailableProducts();
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error during POS startup");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadAvailableProducts(List<POSProductModel>? searchedProducts = null)
        {
            List<POSProductModel> availableProducts = searchedProducts ?? await _salesController.GetAvailableProductsAsync();
            tblAvailableProducts.DataSource = availableProducts;
            tblAvailableProducts.Columns["ProductID"].Visible = false;
            tblAvailableProducts.Columns["VariantID"].Visible = false;
            tblAvailableProducts.Columns["SellingPrice"].HeaderText = "Unit Price";
            tblAvailableProducts.Columns["StockQuantity"].HeaderText = "Stock Quantity";
            tblAvailableProducts.Columns["ProductName"].HeaderText = "Product Name";
            tblAvailableProducts.Columns["SellingPrice"].DefaultCellStyle.Format = "C2";
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            if (tblAvailableProducts.CurrentRow == null) return;

            try
            {
                POSProductModel selectedProduct = (POSProductModel)tblAvailableProducts.CurrentRow.DataBoundItem;
                _salesController.AddItemToCart(selectedProduct);
                RefreshCart();
            }
            catch (InvalidOperationException ex)
            {
                await LoggerUtil.Instance.LogWarningAsync($"Stock Warning: {ex.Message}");
                MessageBox.Show(ex.Message, "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error adding item to cart");
                MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCart()
        {
            _cartBindingSource.ResetBindings(false);

            decimal grandTotal = _salesController.RecalculateCartTotals();
            lblGrandTotal.Text = grandTotal.ToString("C2");

            RefreshCheckoutUI();
        }

        public void RefreshCheckoutUI()
        {
            lblTotalItems.Text = _salesController.GetTotalItems().ToString();
            lblDiscount.Text = _salesController.GetTotalDiscount().ToString("C2");
            lblSubtotal.Text = _salesController.GetSubTotal().ToString("C2");
            lblPayment.Text = _salesController.PaymentAmount.ToString("C2");
            lblChange.Text = _salesController.GetChangeDue().ToString("C2");
        }

        private async void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult voidItemResult = MessageBox.Show
                (
                    "Are you sure you want to remove the selected item from the cart?",
                    "Confirm Remove Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (voidItemResult == DialogResult.Yes)
                {
                    int selectedVariantID = await GetSelectedCartVariantId();
                    _salesController.RemoveItemFromCart(selectedVariantID);
                    RefreshCart();
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync($"Invalid Operation: {ioex.Message}");
                MessageBox.Show(ioex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error removing item from cart");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnApplyPayment_Click(object sender, EventArgs e)
        {
            try
            {
                Image paymentFormIcon = Properties.Resources.icon_payment;
                string title = "Enter Payment (₱):";
                string buttonText = "Save";

                using (PointOfSaleInputForm paymentInputForm = new PointOfSaleInputForm(paymentFormIcon, title, buttonText))
                {
                    paymentInputForm.InputValue = _salesController.PaymentAmount.ToString("F2");

                    if (paymentInputForm.ShowDialog() == DialogResult.OK)
                    {
                        if (!decimal.TryParse(paymentInputForm.InputValue, out decimal paymentAmount))
                        {
                            await LoggerUtil.Instance.LogWarningAsync($"Invalid payment input: '{paymentInputForm.InputValue}'");
                            throw new InvalidOperationException("Invalid input. Please enter a valid monetary amount for payment.");
                        }

                        if (paymentAmount <= 0)
                        {
                            await LoggerUtil.Instance.LogWarningAsync($"Payment amount too low: {paymentAmount}");
                            throw new InvalidOperationException("Please enter a valid monetary amount for payment.");
                        }

                        _salesController.PaymentAmount = paymentAmount;
                        RefreshCheckoutUI();

                        await LoggerUtil.Instance.LogInfoAsync($"Payment of {paymentAmount:C2} applied.");
                    }
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync($"Invalid Operation: {ioex.Message}");
                MessageBox.Show(ioex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error applying payment");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> selectedVariantIDs = await GetSelectedCartVariantIds();

                if (!selectedVariantIDs.Any())
                {
                    throw new InvalidOperationException("No item(s) selected in the cart to apply a discount to.");
                }

                Image discountFormIcon = Properties.Resources.icon_discount;

                string title = "Enter Discount (₱):";
                string buttonText = "Save";

                using (PointOfSaleInputForm discountInputForm = new PointOfSaleInputForm(discountFormIcon, title, buttonText))
                {
                    if (selectedVariantIDs.Count == 1)
                    {
                        int singleVariantID = selectedVariantIDs.First();
                        discountInputForm.InputValue = _salesController.CartItems
                            .FirstOrDefault(i => i.VariantID == singleVariantID)?.Discount.ToString("F2") ?? "0.00";
                    }
                    else
                    {
                        discountInputForm.InputValue = "0.00";
                    }

                    if (discountInputForm.ShowDialog() == DialogResult.OK)
                    {
                        if (!decimal.TryParse(discountInputForm.InputValue, out decimal discountValue))
                        {
                            await LoggerUtil.Instance.LogWarningAsync($"Invalid discount input: '{discountInputForm.InputValue}'");
                            throw new InvalidOperationException("Invalid input. Please enter a valid monetary amount for the discount (e.g., 5.00).");
                        }

                        if (discountValue < 0)
                        {
                            await LoggerUtil.Instance.LogWarningAsync($"Discount value too low: {discountValue}");
                            throw new InvalidOperationException("Discount amount must be zero or a positive value.");
                        }

                        _salesController.ApplyBulkDiscountToSelectedItems(selectedVariantIDs, discountValue);
                        RefreshCart();
                    }
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync($"Invalid Operation (Apply Discount): {ioex.Message}");
                MessageBox.Show(ioex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Unexpected error applying item discount.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> selectedVariantIDs = await GetSelectedCartVariantIds();

                if (!selectedVariantIDs.Any())
                {
                    throw new InvalidOperationException("No item(s) selected in the cart to update the quantity.");
                }

                Image quantityFormIcon = Properties.Resources.icon_quantity;

                string title = "Enter Quantity:";
                string buttonText = "Save";

                using (PointOfSaleInputForm quantityInputForm = new PointOfSaleInputForm(quantityFormIcon, title, buttonText))
                {
                    if (selectedVariantIDs.Count == 1)
                    {
                        int singleVariantID = selectedVariantIDs.First();
                        quantityInputForm.InputValue = _salesController.CartItems
                            .FirstOrDefault(i => i.VariantID == singleVariantID)?.Quantity.ToString() ?? "1";
                    }
                    else
                    {
                        quantityInputForm.InputValue = "1";
                    }

                    if (quantityInputForm.ShowDialog() == DialogResult.OK)
                    {
                        if (!int.TryParse(quantityInputForm.InputValue, out int quantityValue))
                        {
                            await LoggerUtil.Instance.LogWarningAsync($"Invalid quantity input: '{quantityInputForm.InputValue}'");
                            throw new InvalidOperationException("Invalid input. Please enter a whole number for the quantity.");
                        }

                        if (quantityValue <= 0)
                        {
                            await LoggerUtil.Instance.LogWarningAsync($"Quantity update failed: Value must be greater than zero. Value: {quantityValue}");
                            throw new InvalidOperationException("Please enter a valid quantity greater than zero.");
                        }

                        _salesController.UpdateBulkItemQuantity(selectedVariantIDs, quantityValue);
                        RefreshCart();
                    }
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync($"Invalid Operation (Update Quantity): {ioex.Message}");
                MessageBox.Show(ioex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Unexpected error updating item quantity.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalculateReceiptHeight()
        {
            int baseHeight = 400;

            int heightPerItem = 40;

            int itemCount = _currentSaleReceipt?.Items?.Count ?? 0;
            int totalHeight = baseHeight + (itemCount * heightPerItem);

            int minHeight = 615;
            int maxHeight = 1400;

            return Math.Max(minHeight, Math.Min(totalHeight, maxHeight));
        }

        private async void btnFinalizeSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_salesController.CartItems.Any())
                {
                    await LoggerUtil.Instance.LogWarningAsync("Finalize sale failed: Cart is empty.");
                    throw new InvalidOperationException("Cannot finalize sale. Please ensure there are items in the cart.");
                }

                decimal paymentAmount = _salesController.PaymentAmount;
                decimal grandTotal = _salesController.RecalculateCartTotals();

                if (paymentAmount < grandTotal)
                {
                    await LoggerUtil.Instance.LogWarningAsync($"Finalize sale failed: Insufficient payment. Total: {grandTotal:C2}, Paid: {paymentAmount:C2}.");
                    throw new InvalidOperationException("Insufficient payment amount. Please ensure the payment covers the total amount due.");
                }

                DialogResult finalizeSaleResult = MessageBox.Show("Are you sure you want to finalize the sale?", "Confirm Finalize Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (finalizeSaleResult == DialogResult.Yes)
                {
                    List<SalesCartModel> cartCopy = _salesController.CartItems.ToList();
                    CustomerModel walkInCustomer = await _customerController.GetWalkInCustomerAsync();

                    decimal paymentCopy = _salesController.PaymentAmount;
                    decimal changeDueCopy = _salesController.GetChangeDue();

                    int newSaleId = await _salesController.FinalizeSaleAsync(walkInCustomer.CustomerID);
                    await LoggerUtil.Instance.LogInfoAsync($"SALE SUCCESS! Sale ID: {newSaleId} finalized by user {_currentUser.UserID}. Grand Total: {grandTotal:C2}.");
                    MessageBox.Show($"Sale finalized successfully! Sale ID: {newSaleId}", "Sale Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _currentSaleReceipt = new SalesReceiptModel
                    {
                        SaleId = newSaleId,
                        Items = cartCopy,
                        PaymentAmount = paymentCopy,
                        ChangeDue = changeDueCopy
                    };

                    DialogResult printResult = MessageBox.Show("Would you like to print a sale receipt?", "Print Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (printResult == DialogResult.Yes)
                    {
                        int dynamicHeight = CalculateReceiptHeight();
                        saleReceiptDocument.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 315, dynamicHeight);
                        saleReceiptPreview.ShowDialog();
                    }

                    _salesController.PaymentAmount = 0.00m;
                    RefreshCart();
                    await LoadAvailableProducts();
                }
            }
            catch (InvalidOperationException ioex)
            {
                await LoggerUtil.Instance.LogWarningAsync($"Invalid Operation (Finalize Sale): {ioex.Message}");
                MessageBox.Show(ioex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "CRITICAL: Unexpected error finalizing sale.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<int> GetSelectedCartVariantId()
        {
            if (tblSalesCart.CurrentRow == null)
            {
                throw new InvalidOperationException("No item is currently selected in the cart.");
            }

            if (tblSalesCart.CurrentRow.DataBoundItem is SalesCartModel selectedItem)
            {
                return selectedItem.VariantID;
            }

            if (tblSalesCart.CurrentRow.Cells["VariantID"].Value is int id)
            {
                return id;
            }

            await LoggerUtil.Instance.LogErrorAsync("Structural Error: Could not extract VariantID from the selected cart row.");
            throw new InvalidOperationException("Could not determine the selected item's ID.");
        }

        private async Task<List<int>> GetSelectedCartVariantIds()
        {
            List<int> selectedIDs = new List<int>();

            foreach (DataGridViewRow row in tblSalesCart.SelectedRows)
            {
                if (row.DataBoundItem is SalesCartModel selectedItem)
                {
                    selectedIDs.Add(selectedItem.VariantID);
                }
            }

            if (selectedIDs.Count == 0 && tblSalesCart.CurrentRow != null)
            {
                if (tblSalesCart.CurrentRow.DataBoundItem is SalesCartModel currentItem)
                {
                    selectedIDs.Add(currentItem.VariantID);
                }
            }
            return selectedIDs.Distinct().ToList();
        }

        private void saleReceiptDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics? g = e.Graphics;
            float leftMargin = e.MarginBounds.Left;
            float pageWidth = e.MarginBounds.Width;
            float yPosition = e.MarginBounds.Top;

            Font titleFont = new Font("Courier New", 18, FontStyle.Bold);
            Font boldFont = new Font("Courier New", 9, FontStyle.Bold);
            Font normalFont = new Font("Courier New", 8, FontStyle.Regular);
            Font smallFont = new Font("Courier New", 7, FontStyle.Regular);

            DateTime receiptDateTime = DateTime.Now;
            SalesReceiptModel saleReceipt = _currentSaleReceipt;

            yPosition = PrintCentered(g, "Saleling", titleFont, leftMargin, pageWidth, yPosition);
            yPosition = PrintCentered(g, "WPWJ+55Q, Paz St, Balayan, 4213 Batangas", smallFont, leftMargin, pageWidth, yPosition);
            yPosition = PrintCentered(g, "Tel: (420) 921-7261", smallFont, leftMargin, pageWidth, yPosition);
            yPosition = PrintCentered(g, "Email: support@saleling.com", smallFont, leftMargin, pageWidth, yPosition);
            yPosition += 10;

            yPosition = PrintLine(g, "========================================", normalFont, leftMargin, yPosition);

            yPosition = PrintLeft(g, $"Receipt No: {saleReceipt.SaleId}", normalFont, leftMargin, yPosition);
            yPosition = PrintLeft(g, $"Date: {receiptDateTime:MMMM dd, yyyy}", normalFont, leftMargin, yPosition);
            yPosition = PrintLeft(g, $"Time: {receiptDateTime:hh:mm tt}", normalFont, leftMargin, yPosition);
            yPosition = PrintLeft(g, $"Cashier: {_currentUser.FullName}", normalFont, leftMargin, yPosition);

            yPosition = PrintLine(g, "========================================", normalFont, leftMargin, yPosition);

            yPosition = PrintLeft(g, "ITEM            QTY  PRICE    TOTAL", boldFont, leftMargin, yPosition);
            yPosition = PrintLine(g, "----------------------------------------", normalFont, leftMargin, yPosition);

            foreach (var item in saleReceipt.Items)
            {
                string itemNamePadded = item.SKU.Length > 15
                    ? item.SKU.Substring(0, 15) : item.SKU.PadRight(15);

                decimal itemLineTotal = item.LineTotal;

                string itemLine = $"{itemNamePadded}  {item.Quantity,3}  {item.UnitPrice,7:F2}  ={itemLineTotal,8:F2}";
                yPosition = PrintLeft(g, itemLine, normalFont, leftMargin, yPosition);

                if (item.Discount > 0)
                {
                    string discLine = $"-{item.Discount:C2}";
                    yPosition = PrintRight(g, discLine, smallFont, leftMargin, pageWidth, yPosition);
                }

                yPosition += 3;
            }

            yPosition = PrintLine(g, "----------------------------------------", normalFont, leftMargin, yPosition);

            yPosition = PrintCentered(g, $"Total Items: {saleReceipt.TotalItems}", normalFont, leftMargin, pageWidth, yPosition);
            yPosition = PrintCentered(g, $"Subtotal: {saleReceipt.Subtotal:C2}", normalFont, leftMargin, pageWidth, yPosition);

            if (saleReceipt.TotalDiscount > 0)
            {
                yPosition = PrintCentered(g, $"Discount ({saleReceipt.DiscountRate:F1}%): -{saleReceipt.TotalDiscount:C2}",
                    normalFont, leftMargin, pageWidth, yPosition);
            }

            yPosition = PrintLine(g, "========================================", normalFont, leftMargin, yPosition);

            yPosition = PrintCentered(g, $"GRAND TOTAL: {saleReceipt.GrandTotal:C2}", boldFont, leftMargin, pageWidth, yPosition);

            yPosition = PrintLine(g, "========================================", normalFont, leftMargin, yPosition);

            yPosition = PrintCentered(g, $"Cash Payment: {saleReceipt.PaymentAmount:C2}", normalFont, leftMargin, pageWidth, yPosition);
            yPosition = PrintCentered(g, $"Change: {saleReceipt.ChangeDue:C2}", normalFont, leftMargin, pageWidth, yPosition);

            yPosition += 15;
            yPosition = PrintLine(g, "========================================", normalFont, leftMargin, yPosition);

            yPosition = PrintCentered(g, "THANK YOU!", boldFont, leftMargin, pageWidth, yPosition);
            yPosition = PrintCentered(g, "Please Come Again", normalFont, leftMargin, pageWidth, yPosition);
            yPosition += 10;
            yPosition = PrintCentered(g, "This serves as your official receipt", smallFont, leftMargin, pageWidth, yPosition);

            titleFont.Dispose();
            boldFont.Dispose();
            normalFont.Dispose();
            smallFont.Dispose();

            e.HasMorePages = false;
        }

        private float PrintCentered(Graphics g, string text, Font font, float leftMargin, float pageWidth, float yPosition)
        {
            SizeF size = g.MeasureString(text, font);
            float x = leftMargin + (pageWidth - size.Width) / 2;
            g.DrawString(text, font, Brushes.Black, x, yPosition);
            return yPosition + font.GetHeight(g);
        }

        private float PrintLeft(Graphics g, string text, Font font, float leftMargin, float yPosition)
        {
            g.DrawString(text, font, Brushes.Black, leftMargin, yPosition);
            return yPosition + font.GetHeight(g);
        }

        private float PrintLine(Graphics g, string text, Font font, float leftMargin, float yPosition)
        {
            g.DrawString(text, font, Brushes.Black, leftMargin, yPosition);
            return yPosition + font.GetHeight(g);
        }

        private float PrintRight(Graphics g, string text, Font font, float leftMargin, float pageWidth, float yPosition)
        {
            SizeF textSize = g.MeasureString(text, font);
            float xPosition = leftMargin + pageWidth - textSize.Width;
            g.DrawString(text, font, Brushes.Red, xPosition, yPosition);
            return yPosition + font.GetHeight(g);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadAvailableProducts();
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, "Error refreshing available products.");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string searchFilter = cmbFilter.Text.Trim();

            try
            {
                List<POSProductModel> searchedSaleableProducts = await _salesController.SearchAvailableProductsAsync(searchTerm, searchFilter);
                await LoadAvailableProducts(searchedSaleableProducts);
            }
            catch (InvalidOperationException ioex)
            {
                MessageBox.Show(ioex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                await LoggerUtil.Instance.LogExceptionAsync(ex, $"Error during product search (Query: {searchTerm}, Filter: {searchFilter}).");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timeTrackerTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
