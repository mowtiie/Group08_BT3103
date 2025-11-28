namespace Saleling.Model.Inventory
{
    public class InventoryLogTransactionModel
    {
        public int VariantID { get; set; }
        public int QuantityChange { get; set; }
        public required string Reason { get; set; }
        public int ProcessedByUserID { get; set; }
        public string? Notes { get; set; }
    }
}
