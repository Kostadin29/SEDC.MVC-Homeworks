using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels.UserViewModels;

namespace PizzaApp.Models.Mappers
{
    public static class UserMapper
    {
        public static UserListViewModel MapFromUserToListAllUsers(this User user)
        {
            return new UserListViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,     
                PhoneNumber = user.PhoneNumber,
                Address = $"{user.Address.Street} {user.Address.Number}"
            };
        }
    }
}
