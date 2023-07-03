namespace BurgerApp.Domain.Models
{
    public class Location : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; }
        public string OpensAt { get; set; }
        public string ClosesAt { get; set; }
        public List<Order> Orders { get; set; }
    }
}
