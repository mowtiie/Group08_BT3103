namespace Saleling.Model.Inventory
{
    public class InventoryStockKPIModel
    {
        public decimal TotalInventoryValue { get; set; }
        public int TotalSKUsInStock { get; set; }
        public int TotalSKUsBelowReorderLevel { get; set; }
        public decimal LowStockRate { get; set; }
    }
}
