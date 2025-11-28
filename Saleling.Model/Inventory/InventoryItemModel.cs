namespace Saleling.Model.Inventory
{
    public class InventoryItemModel
    {
        public int ProductID { get; set; }
        public int VariantID { get; set; }
        public required string ProductName { get; set; }
        public required string Category { get; set; }
        public required string Supplier { get; set; }
        public required string SKU { get; set; }
        public required string Size { get; set; }
        public required string Color { get; set; }
        public int StockQuantity { get; set; }
        public int ReorderLevel { get; set; }
        public required string ProductStatus { get; set; }
        public required string VariantStatus { get; set; }
    }
}
