﻿using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.LocationViewModels;

namespace BurgerApp.Services.Impelmentations
{
    public class LocationService : ILocationService
    {
        private IRepository<Location> _locationRepository;

        public LocationService(IRepository<Location> locationRepository)
        {
            this._locationRepository = locationRepository;
        }

        public Task CreateLocation(LocationViewModel locationViewModel)
        {
            return _locationRepository.Insert(locationViewModel.ToLocation());
        }

        public async Task<int> DeleteLocationById(int id)
        {
            return await _locationRepository.DeleteById(id);
        }

        public async Task<List<LocationListViewModel>> GetAllLocations()
        {
           List<Location> locationDb = await _locationRepository.GetAll();
            return locationDb.Select(x => x.ToLocationListViewModel()).ToList();
        }

        public async Task<List<LocationsForDropdownViewModel>> GetLocationsForDropdown()
        {
            List<Location> locationDb = await _locationRepository.GetAll();
            return locationDb.Select(x => x.ToLocationsForDropdown()).ToList();
        }
    }
}
