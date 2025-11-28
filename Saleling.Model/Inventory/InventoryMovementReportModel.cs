namespace Saleling.Model.Inventory
{
    public class InventoryMovementReportModel
    {
        public DateTime ChangeDate { get; set; }
        public string Reason { get; set; }
        public int QuantityChange { get; set; }
        public string ProcessedBy { get; set; }
        public int? TransactionReferenceID { get; set; }
        public string Notes { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string VariantDetails { get; set; }
    }
}
