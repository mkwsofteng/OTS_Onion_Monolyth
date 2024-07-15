using OTS.Domain.Entities;

namespace OTS.Domain.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Task<IEnumerable<Booking>> GetByUserId(Guid userId);
    }
}
