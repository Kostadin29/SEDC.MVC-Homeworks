using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels.OrderViewModels
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public string PizzaName { get; set; } = string.Empty;
        public string UserFullName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string UserAddress { get; set; }
    }
}
