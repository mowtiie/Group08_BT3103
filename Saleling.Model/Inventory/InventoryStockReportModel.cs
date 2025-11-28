namespace Saleling.Model.Inventory
{
    public class InventoryStockReportModel
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string VariantDetails { get; set; }
        public int StockQuantity { get; set; }
        public int ReorderLevel { get; set; }
        public string Status { get; set; }
    }
}
