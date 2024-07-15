namespace OTS.Domain.Entities
{
    public class Seat
    {
        public string Id { get; set; } = string.Empty;
        public string EventId { get; set; } = string.Empty;
        public string RowNumber { get; set; } = string.Empty;
        public string SeatNumber { get; set; } = string.Empty;
        public bool Available { get; set; }

        //Navigation Properties
        public Booking Booking { get; set; } = new Booking();
        public Event Event { get; set; } = new Event();
    }
}
