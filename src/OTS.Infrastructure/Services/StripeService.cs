using OTS.Application.Interfaces;

namespace OTS.Infrastructure.Services
{
    public class StripeService : IPaymentGateway
    {
        public Task CheckTranactionStatus(string transactionId) => Task.CompletedTask;
        public Task RefundPayment(string transactionId) => Task.CompletedTask;
    }
}
