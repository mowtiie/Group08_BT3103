namespace Saleling.Model.Product
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public required string ProductName { get; set; }
        public required string Category { get; set; }
        public string? Supplier { get; set; }
        public required string Status { get; set; }

        public enum StatusOption
        {
            Active,
            Archived
        }
    }
}
