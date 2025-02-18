using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        // Define 5 methods to be used for implementation

        //List all the actors
        Task<IEnumerable<Actor>> GetAllAsync();

        //Select only one actor
        Task <Actor> GetByIdAsync(int id);

        //Add data to database
        Task AddAsync(Actor actor);

        //update data to database

        Task <Actor> UpdateAsync(int id, Actor newActor);

        //Delete Data from database

        void Delete(int id);
    }
}
