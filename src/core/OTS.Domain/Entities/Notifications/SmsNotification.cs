using OTS.Domain.Entities.Enums;

namespace OTS.Domain.Entities.Notifications
{
    public class SmsNotification
    {
        public string Id { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public NotificationStatus Status { get; set; }
    }
}
