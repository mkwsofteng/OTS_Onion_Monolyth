using OTS.Application.DTOs;

namespace OTS.Application.Interfaces.Data
{
    public interface IEventService
    {
        Task Create(EventDto eventDto);
        Task Update(EventDto eventDto);
        Task Delete(string id);

        Task<IEnumerable<EventDto>> GetAll();
        Task<EventDto> GetById(string id);

        Task<SeatDto> GetAvailableSeats(string eventId);
    }
}
