using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.BurgerViewModels;

namespace BurgerApp.Mappers
{
    public static class BurgerMapper
    {
        public static BurgerListViewModel ToBurgerListViewModel(this Burger burger)
        {
            return new BurgerListViewModel()
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                ImageUrl = burger.ImageUrl,
                IsOnPromotion = burger.IsOnPromotion
            };
        }


        public static BurgerDetailsViewModel ToBurgerDetailsViewModel(this Burger burger)
        {
            return new BurgerDetailsViewModel()
            {
                Price = burger.Price,
                ImageUrl = burger.ImageUrl,
                Name = burger.Name,
                IsVegan = burger.IsVegan,
                IsVegetarian = burger.IsVegetarian,
                HasFries = burger.HasFries,
                IsOnPromotion = burger.IsOnPromotion
            };
        }

        public static Burger ToBurger(this BurgerViewModel burgerViewModel)
        {
            return new Burger()
            {
                Id = burgerViewModel.Id,
                Name = burgerViewModel.Name,
                Price = burgerViewModel.Price,
                ImageUrl = burgerViewModel.ImageUrl,
                IsVegetarian = burgerViewModel.IsVegetarian,
                IsVegan = burgerViewModel.IsVegan,
                HasFries = burgerViewModel.HasFries,
                IsOnPromotion = burgerViewModel.IsOnPromotion
            };
        }

        public static BurgerViewModel ToBurgerViewModel(this Burger burgerDb)
        {
            return new BurgerViewModel()
            {
                Id = burgerDb.Id,
                Name = burgerDb.Name,
                Price = burgerDb.Price,
                ImageUrl = burgerDb.ImageUrl,
                IsVegetarian = burgerDb.IsVegetarian,
                IsVegan = burgerDb.IsVegan,
                HasFries = burgerDb.HasFries,
                IsOnPromotion = burgerDb.IsOnPromotion
            };
        }

        public static BurgersForDropdownViewModel ToBurgersForDropdown(this Burger burger)
        {
            return new BurgersForDropdownViewModel()
            {
                Id = burger.Id,
                Name = burger.Name
            };
        }
    }
}
