namespace Saleling.Model.Product
{
    public class ProductListingModel
    {
        public int ProductID { get; set; }
        public int VariantID { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int StockQuantity { get; set; }
        public int ReorderLevel { get; set; }
        public decimal SellingPrice { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
    }
}
