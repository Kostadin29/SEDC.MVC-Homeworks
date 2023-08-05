using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.LocationViewModels;

namespace BurgerApp.Mappers
{
    public static class LocationMapper
    {
        public static LocationListViewModel ToLocationListViewModel(this Location location)
        {
            return new LocationListViewModel
            {
                Id = location.Id,
                Name = location.Name,
                Address = location.Address,
                OpensAt = location.OpensAt,
                ClosesAt = location.ClosesAt
            };
        }

        public static Location ToLocation(this LocationViewModel locationViewModel)
        {
            return new Location()
            {
                Id = locationViewModel.Id,
                Name = locationViewModel.Name,
                Address = locationViewModel.Address,
                OpensAt = locationViewModel.OpensAt,
                ClosesAt= locationViewModel.ClosesAt
            };
        }

        public static LocationsForDropdownViewModel ToLocationsForDropdown(this Location location)
        {
            return new LocationsForDropdownViewModel
            {
                Id = location.Id,
                Name = location.Name
            };
        }
    }
}
