using PizzaApp.Models.Enums;
using PizzaApp.Models.ViewModels.OrderViewModels;

namespace PizzaApp.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public int UserId { get; set; }
        public Pizza Pizza { get; set; }
        public User User { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Address UserAddress { get; set; }


    }
}
