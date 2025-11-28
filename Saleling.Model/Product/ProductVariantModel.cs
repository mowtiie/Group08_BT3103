namespace Saleling.Model.Product
{
    public class ProductVariantModel
    {
        public int VariantID { get; set; }
        public int ProductID { get; set; }
        public required string SKU { get; set; }
        public required string Size { get; set; }
        public required string Color { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int StockQuantity { get; set; }
        public int ReorderLevel { get; set; }
        public required string Status { get; set; }

        public enum SizeOption
        {
            XS,
            S,
            M,
            L,
            XL,
            XXL,
            XXXL
        }

        public enum ColorOption
        {
            Black,
            White,
            Red,
            Blue,
            Green,
            Gray,
            Brown
        }

        public enum StatusOption
        {
            Active,
            Discontinued
        }
    }
}
