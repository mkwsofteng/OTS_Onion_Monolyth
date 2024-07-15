using OTS.Application.DTOs;
using OTS.Application.Interfaces.Data;
using OTS.Domain.Entities;
using OTS.Domain.Interfaces;

namespace OTS.Application.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        #region CRUD
        public async Task Create(EventDto eventDto)
        {
            //TODO: Use Mapper
            var evt = new Event
            {
                Name = eventDto.Name,
                Description = eventDto.Description,
                Date = eventDto.Date,
                Venue = eventDto.Venue,
                Price = eventDto.Price,
            };

            await _eventRepository.AddAsync(evt);
        }

        public async Task Update(EventDto eventDto)
        {
            var evt = await _eventRepository.GetByIdAsync(eventDto.Id);
            if (evt != null)
            {
                evt.Name = eventDto.Name;
                evt.Description = eventDto.Description;
                evt.Date = eventDto.Date;
                evt.Venue = eventDto.Venue;
                evt.Price = eventDto.Price;
                await _eventRepository.UpdateAsync(evt);
            }
        }

        public async Task Delete(string id)
        {
            var evt = await _eventRepository.GetByIdAsync(id);
            if (evt != null)
            {
                await _eventRepository.DeleteAsync(evt);
            }
        }
        #endregion

        public async Task<IEnumerable<EventDto>> GetAll()
        {
            var events = await _eventRepository.GetAllAsync();

            //TODO: Use Mapper
            return events.Select(evt => new EventDto
            {
                Id = evt.Id,
                Name = evt.Name,
                Description = evt.Description,
                Date = evt.Date,
                Venue = evt.Venue,
                Price = evt.Price,
            }).ToList();
        }

        public async Task<EventDto> GetById(string eventId)
        {
            var evt = await _eventRepository.GetByIdAsync(eventId);

            //TODO: Use Mapper
            return new EventDto
            {
                Id = evt.Id,
                Name = evt.Name,
                Description = evt.Description,
                Date = evt.Date,
                Venue = evt.Venue,
                Price = evt.Price,
            };
        }

        public Task<SeatDto> GetAvailableSeats(string eventId)
        {
            throw new NotImplementedException();
        }
    }
}
