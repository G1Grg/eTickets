using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        // Define 5 methods to be used for implementation

        //List all the actors
        Task<IEnumerable<Actor>> GetAll();

        //Select only one actor
        Actor GetById(int id);

        //Add data to database
        void Add(Actor actor);

        //update data to database

        Actor Update(int id, Actor newActor);

        //Delete Data from database

        void Delete(int id);
    }
}
