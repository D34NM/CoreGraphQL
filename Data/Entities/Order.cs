namespace CoreGraphQL.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
    }
}