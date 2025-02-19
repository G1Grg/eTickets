using eTickets.Models;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()

    {
        // Define 5 methods to be used for implementation

        //List all the actors
        Task<IEnumerable<T>> GetAllAsync();

        //Select only one actor
        Task<T> GetByIdAsync(int id);

        //Add data to database
        Task AddAsync(T entity);

        //update data to database

        Task UpdateAsync(int id, T entity);

        //Delete Data from database

        Task DeleteAsync(int id);
    }
}
