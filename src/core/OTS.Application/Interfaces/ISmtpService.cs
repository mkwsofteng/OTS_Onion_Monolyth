using OTS.Domain.Entities.Notifications;

namespace OTS.Application.Interfaces
{
    public interface ISmtpService
    {
        Task SendEmail(EmailNotification emailNotification);
    }
}
