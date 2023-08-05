using BurgerApp.DataAccess.DataContext;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.Repositories.Implementations
{
    public class LocationRepository : IRepository<Location>
    {
        private BurgerAppDbContext _dbContext;

        public LocationRepository(BurgerAppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<int> DeleteById(int id)
        {
            Location locationDb = await _dbContext.Locations.FirstOrDefaultAsync(b => b.Id == id);

            if (locationDb == null)
            {
                throw new Exception($"Item with Id:{id} not found");
            }

            _dbContext.Locations.Remove(locationDb);
            await _dbContext.SaveChangesAsync();

            return locationDb.Id;
        }

        public async Task<List<Location>> GetAll()
        {
            return await _dbContext.Locations.ToListAsync();
        }

        public Task<Location> GetById(int id)
        {
            return _dbContext.Locations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Location entity)
        {
            await _dbContext.Locations.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Location entity)
        {
            _dbContext.Locations.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
