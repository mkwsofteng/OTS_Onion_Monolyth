using OTS.Domain.Entities;
using OTS.Domain.Interfaces;

namespace OTS.Infrastructure.Data.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(OtsDbContext context) : base(context) { }
    }
}
