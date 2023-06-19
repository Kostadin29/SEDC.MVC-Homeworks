using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels.PizzaViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<PizzaSize> PizzaSizes { get; set; }
        public bool HasExtras { get; set; }
        public bool IsOnPromotion { get; set; }

    }
}