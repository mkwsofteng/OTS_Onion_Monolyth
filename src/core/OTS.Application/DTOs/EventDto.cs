namespace OTS.Application.DTOs
{
    public class EventDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Venue { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
