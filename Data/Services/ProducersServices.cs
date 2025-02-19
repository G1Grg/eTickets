using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ProducersServices: EntityBaseRepository<Producer>, IProducersService
    {

        public ProducersServices(AppDbContext context):base(context)
        {

        }
    }
}
