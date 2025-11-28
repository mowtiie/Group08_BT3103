namespace Saleling.Model.Sale
{
    public class SalesItemModel
    {
        public int VariantID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal SubTotal { get; set; }
    }
}
