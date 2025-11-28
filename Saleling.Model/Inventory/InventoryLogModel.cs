namespace Saleling.Model.Inventory
{
    public class InventoryLogModel
    {
        public int InventoryID { get; set; }
        public int VariantID { get; set; }
        public int QuantityChange { get; set; }
        public DateTime ChangeDate { get; set; }
        public required string Reason { get; set; }
        public int? TransactionReferenceID { get; set; }
        public required string Notes { get; set; }
        public required string Processor { get; set; }
        public required string Role { get; set; }
    }
}
