namespace Saleling.Model.Product
{
    public class POSProductModel
    {
        public int VariantID { get; set; }
        public int ProductID { get; set; }
        public required string ProductName { get; set; }
        public required string SKU { get; set; }
        public required string Size { get; set; }
        public required string Color { get; set; }
        public decimal SellingPrice { get; set; }
        public int StockQuantity { get; set; }
        public required string Category { get; set; }
    }
}
