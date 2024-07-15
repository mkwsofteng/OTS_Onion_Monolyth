namespace OTS.Domain.Entities
{
    public class Payment
    {
        public string Id { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public string TransactionStatus { get; set; } = string.Empty;

        //Navigation Properties
        public Booking Booking { get; set; } = new Booking();

    }
}
