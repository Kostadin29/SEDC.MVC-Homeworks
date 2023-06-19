using PizzaApp.Models.Domain;

namespace PizzaApp.Models.ViewModels.UserViewModels
{
    public class UserListViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; }
    }
}
