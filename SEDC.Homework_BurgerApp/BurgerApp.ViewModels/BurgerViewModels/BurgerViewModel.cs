using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BurgerApp.ViewModels.BurgerViewModels
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Burger Name")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Display(Name = "Is Vegetarian")]
        public bool IsVegetarian { get; set; }
        [Display(Name = "Is Vegan")]
        public bool IsVegan { get; set; }
        [Display(Name = "Fries")]
        public bool HasFries { get; set; }

        [Display(Name = "Is On Promotion")]
        public bool IsOnPromotion { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
