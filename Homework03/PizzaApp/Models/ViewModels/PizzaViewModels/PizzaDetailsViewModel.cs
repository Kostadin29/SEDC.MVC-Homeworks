using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels.PizzaViewModels
{
    public class PizzaDetailsViewModel
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public string? ImageUrl { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public List<PizzaSize> PizzaSize { get; set; } 
    }
}
