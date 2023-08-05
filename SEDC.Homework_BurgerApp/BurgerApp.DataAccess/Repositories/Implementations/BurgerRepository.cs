
namespace BurgerApp.DataAccess.Repositories.Implementations
{

    using BurgerApp.DataAccess.DataContext;
    using BurgerApp.DataAccess.Repositories.Interfaces;
    using BurgerApp.Domain.Models;
    using Microsoft.EntityFrameworkCore;


    public class BurgerRepository : IBurgerRepository
    {
        private BurgerAppDbContext _dbContext;

        public BurgerRepository(BurgerAppDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public async Task<int> DeleteById(int id)
        {
            Burger burgerDb = await _dbContext.Burgers.SingleOrDefaultAsync(x => x.Id == id);

            if (burgerDb == null)
                throw new Exception($"Item with Id:{id} not found!");

            _dbContext.Burgers.Remove(burgerDb);
            await _dbContext.SaveChangesAsync();

            return burgerDb.Id;
        }

        public async Task<List<Burger>> GetAll()
        {
            return await _dbContext.Burgers.ToListAsync();
        }

        //public Burger GetBurgerForPromotion()
        //{
        //    return _dbContext.Burgers.FirstOrDefault(x => x.IsOnPromotion == true);
        //}

        public List<Burger> GetBurgersOnPromotion()
        {
            // Replace this with your actual data retrieval logic to get burgers on promotion from your data source
            // For example:
            return _dbContext.Burgers.Where(burger => burger.IsOnPromotion).ToList();
        }

        public async Task<Burger> GetById(int id)
        {
            return await _dbContext.Burgers.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Burger entity)
        {
            await _dbContext.Burgers.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Burger entity)
        {
            _dbContext.Burgers.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
