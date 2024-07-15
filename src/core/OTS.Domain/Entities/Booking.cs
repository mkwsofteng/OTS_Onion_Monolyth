namespace OTS.Domain.Entities
{
    public class Booking
    {
        public string Id { get; set; } = string.Empty;
        public IEnumerable<string> SeatIds { get; set; } = Enumerable.Empty<string>();
        public string PaymentId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;

        public decimal TotalPrice { get; set; }
        public DateTime BookedAt { get; set; }


        //Navigation Properties
        public ApplicationUser User { get; set; } = new ApplicationUser();
        public Payment Payment { get; set; } = new Payment();
        public IEnumerable<Seat> Seats { get; set; } = Enumerable.Empty<Seat>();
    }
}
