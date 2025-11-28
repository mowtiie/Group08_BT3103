namespace Saleling.Model.Sale
{
    public class SalesReportKPIModel
    {
        public decimal TotalSalesRevenue { get; set; }
        public int TransactionCount { get; set; }
        public int ItemsSoldCount { get; set; }
        public decimal AverageSaleValue { get; set; }
    }
}
