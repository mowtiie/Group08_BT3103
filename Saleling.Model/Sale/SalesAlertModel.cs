namespace Saleling.Model.Sale
{
    public class SalesAlertModel
    {
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Cashier { get; set; }
    }
}
