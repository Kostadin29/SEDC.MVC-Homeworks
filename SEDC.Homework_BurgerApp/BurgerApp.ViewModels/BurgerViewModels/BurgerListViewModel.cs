namespace BurgerApp.ViewModels.BurgerViewModels
{
    public class BurgerListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsOnPromotion { get; set; }

    }
}
