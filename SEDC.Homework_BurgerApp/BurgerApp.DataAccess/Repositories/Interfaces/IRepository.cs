
namespace BurgerApp.DataAccess.Repositories.Interfaces
{
    using BurgerApp.Domain.Models;
    // pravime interface od IRepository da bide genericko kade sto T ke se odnesuva za site klasi koj nasleduvaat od BaseEntity;
    public interface IRepository<T> where T : BaseEntity
    {
        // CRUD Operations
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T entity);
        Task Update(T entity);
        Task<int> DeleteById(int id);

    }
}
