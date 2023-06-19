using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels.PizzaViewModels;

namespace PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaListViewModel MapFromPizzaToPizzaListViewModel(this Pizza pizza)
        {
            return new PizzaListViewModel()
            {
                Id = pizza.Id,
                imgUrl = pizza.ImageUrl,
                Name = pizza.Name,
                Price = pizza.Price
            };
        }

        public static PizzaDetailsViewModel MapFromPizzaToPizzaDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel()
            {
                ImageUrl = pizza.ImageUrl,
                Ingredients = pizza.Ingredients,
                IsOnPromotion = pizza.IsOnPromotion,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.Price
            };
        }

        public static PizzaViewModel MapFromPizzaToPizzaViewModel(this Pizza pizza)
        {
            return new PizzaViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSizes = pizza.PizzaSize,
                HasExtras = pizza.HasExtras
            };
        }
    }
}
