using OTS.Domain.Entities;
using OTS.Domain.Interfaces;

namespace OTS.Infrastructure.Data.Repositories
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        public BookingRepository(OtsDbContext context) : base(context) { }

        public Task<IEnumerable<Booking>> GetByUserId(Guid userId) => Task.FromResult(Enumerable.Empty<Booking>());
    }
}
