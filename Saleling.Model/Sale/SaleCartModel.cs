namespace Saleling.Model.Sale
{
    public class SaleCartModel
    {
        public int VariantID { get; set; }
        public required string ProductName { get; set; }
        public required string SKU { get; set; }
        public required string Size { get; set; }
        public required string Color { get; set; }
        public int CurrentStock { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal LineTotal { get; set; }
    }
}
