namespace Saleling.Model.Sale
{
    public class SalesTransactionModel
    {
        public int CustomerID { get; set; }
        public int ProcessedByUserID { get; set; }
        public decimal TotalAmount { get; set; }
        public List<SalesItemModel> Items { get; set; } = new List<SalesItemModel>();
    }
}
