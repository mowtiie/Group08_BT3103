namespace Saleling.Model.Sale
{
    public class SalesReportItemModel
    {
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public string ProcessedBy { get; set; }
        public decimal TotalAmount { get; set; }
        public string ProductName { get; set; }
        public string VariantDetails { get; set; }
        public string Category { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Revenue { get; set; }
        public decimal COGS { get; set; }
        public decimal GrossProfit { get; set; }
    }
}
