
namespace BurgerApp.Services.Impelmentations
{
    using BurgerApp.DataAccess.Repositories.Interfaces;
    using BurgerApp.Domain.Models;
    using BurgerApp.Mappers;
    using BurgerApp.Services.Interfaces;
    using BurgerApp.ViewModels.BurgerViewModels;
    public class BurgerService : IBurgerService
    {
        private IBurgerRepository _burgerRepository;

        public BurgerService(IBurgerRepository _burgerRepository)
        {
            this._burgerRepository = _burgerRepository;
        }

        public Task CreateBurger(BurgerViewModel burgerViewModel)
        {
            return _burgerRepository.Insert(burgerViewModel.ToBurger());
        }

        public async Task<int> DeleteBurgerById(int id)
        {
            return await _burgerRepository.DeleteById(id);
        }

        public async Task EditBurger(BurgerViewModel burgerViewModel)
        {
            Burger burgerDb = await _burgerRepository.GetById(burgerViewModel.Id);

            if (burgerDb == null)
                throw new Exception("Burger not found");

            burgerDb.Name = burgerViewModel.Name;
            burgerDb.IsVegetarian = burgerViewModel.IsVegetarian;
            burgerDb.IsVegan = burgerViewModel.IsVegan;
            burgerDb.HasFries = burgerViewModel.HasFries;
            burgerDb.ImageUrl = burgerViewModel.ImageUrl;
            burgerDb.Price = burgerViewModel.Price;
            burgerDb.IsOnPromotion = burgerViewModel.IsOnPromotion;

            await _burgerRepository.Update(burgerDb);
        }

        public async Task<BurgerDetailsViewModel> GetBurgerDetails(int id)
        {
            Burger burgerDb = await _burgerRepository.GetById(id);
            return burgerDb.ToBurgerDetailsViewModel();
        }

        public async Task<BurgerViewModel> GetBurgerForEditing(int id)
        {
            Burger burger = await _burgerRepository.GetById(id);

            if (burger == null)
                throw new Exception("Burger not found!");

            BurgerViewModel burgerViewModel = burger.ToBurgerViewModel();

            return burgerViewModel;
        }

        //public string GetBurgerForPromotion()
        //{
        //    //return _burgerRepository.GetBurgerForPromotion().Name;

        //    var burger = _burgerRepository.GetBurgerForPromotion();
        //    if (burger != null)
        //    {
        //        return burger.Name;
        //    }
        //    else
        //    {
        //        // Handle the case where the burger for promotion is not found
        //        return "No burger on promotion";
        //    }
        //}

        public async Task<List<BurgerListViewModel>> GetBurgersForCards()
        {
            List<Burger> burgerDb = await _burgerRepository.GetAll();
            return burgerDb.Select(x => x.ToBurgerListViewModel()).ToList();
        }

        public async Task<List<BurgersForDropdownViewModel>> GetBurgersForDropdown()
        {
            List<Burger> burgerDb = await _burgerRepository.GetAll();
            return burgerDb.Select(x => x.ToBurgersForDropdown()).ToList();
        }

        public List<BurgerViewModel> GetBurgersForPromotion()
        {
            // Replace this with your logic to fetch burgers on promotion from your data source
            // For example, assuming you have a method in your repository to get burgers on promotion:
            var burgersOnPromotion = _burgerRepository.GetBurgersOnPromotion();

            // Convert the data from your data source (e.g., entities) to BurgerViewModel objects
            var burgerViewModels = burgersOnPromotion.Select(burger => new BurgerViewModel
            {
                Name = burger.Name,
                Price = burger.Price,
                HasFries = burger.HasFries,
                IsOnPromotion = burger.IsOnPromotion,
                Id = burger.Id,
                IsVegan = burger.IsVegan,
                IsVegetarian = burger.IsVegetarian,
                ImageUrl = burger.ImageUrl

                // Map other properties as needed
            }).ToList();

            return burgerViewModels;
        }
    }
}
