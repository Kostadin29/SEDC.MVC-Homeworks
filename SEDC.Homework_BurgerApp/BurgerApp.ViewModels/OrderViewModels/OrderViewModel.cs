using System.ComponentModel.DataAnnotations;

namespace BurgerApp.ViewModels.OrderViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Your Address")]
        public string Address { get; set; }
        [Display(Name = "Is Delivered")]
        public bool IsDelivered { get; set; }
        [Display(Name = "Select location")]
        public int LocationId { get; set; }

        [Display(Name = "Select burgers")]
        public List<int> BurgerId { get; set; }
    }
}
