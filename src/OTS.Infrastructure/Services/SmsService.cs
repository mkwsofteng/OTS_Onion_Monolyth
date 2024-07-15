using OTS.Application.Interfaces;

namespace OTS.Infrastructure.Services
{
    public class SmsService : ISmsService
    {
        public Task SendMessage() => Task.CompletedTask;
    }
}
