namespace Saleling.Model
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int? LoyaltyPoints { get; set; }
    }
}
