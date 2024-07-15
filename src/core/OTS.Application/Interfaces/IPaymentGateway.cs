namespace OTS.Application.Interfaces
{
    public interface IPaymentGateway
    {
        Task CheckTranactionStatus(string transactionId);
        Task RefundPayment(string transactionId);
    }
}
