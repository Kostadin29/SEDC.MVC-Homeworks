using PizzaApp.Models.Enums;

namespace PizzaApp.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public string? ImageUrl { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public List<PizzaSize> PizzaSize { get; set; } = new List<PizzaSize>();
        public bool HasExtras { get; set; }

    }
}
