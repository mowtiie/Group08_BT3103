namespace Saleling.Model.Sale
{
    public class SalesReceiptModel
    {
        public int SaleId { get; set; }
        public List<SalesCartModel> Items { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal ChangeDue { get; set; }
        public decimal Subtotal => Items.Sum(item => item.Quantity * item.UnitPrice);
        public decimal TotalDiscount => Items.Sum(item => item.Discount);
        public decimal GrandTotal => Subtotal - TotalDiscount;
        public int TotalItems => Items.Sum(item => item.Quantity);
        public decimal DiscountRate => Subtotal > 0 ? TotalDiscount / Subtotal * 100 : 0m;
    }
}
