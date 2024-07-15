using OTS.Application.DTOs;

namespace OTS.Application.Interfaces.Data
{
    public interface IBookingService
    {
        Task<BookingDto> BookSeats(IEnumerable<string> seatIds, string userId);
        Task CancelBooking(Guid bookingId);
    }
}
