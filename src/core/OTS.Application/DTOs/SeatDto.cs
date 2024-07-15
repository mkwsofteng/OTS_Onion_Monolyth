namespace OTS.Application.DTOs
{
    public class SeatDto
    {
        public string Id { get; set; } = string.Empty;
        public string EventId { get; set; } = string.Empty;
        public string RowNumber { get; set; } = string.Empty;
        public string SeatNumber { get; set; } = string.Empty;
        public bool Available { get; set; }
    }
}
