using OTS.Application.Interfaces;
using OTS.Domain.Entities.Notifications;

namespace OTS.Infrastructure.Services
{
    public class SmtpService : ISmtpService
    {
        public Task SendEmail(EmailNotification emailNotification) => Task.CompletedTask;
    }
}
