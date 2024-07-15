namespace OTS.Domain.Entities
{
    public class Event
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Venue { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        //Navigation Properties
        public IEnumerable<Seat> Seats { get; set; } = Enumerable.Empty<Seat>();

    }
}
