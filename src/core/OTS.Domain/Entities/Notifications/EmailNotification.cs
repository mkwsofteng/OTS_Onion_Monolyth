using OTS.Domain.Entities.Enums;

namespace OTS.Domain.Entities.Notifications
{
    public class EmailNotification
    {
        public string Id { get; set; } = string.Empty;
        public string ToEmail { get; set; } = string.Empty;
        public string FromEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public NotificationStatus Status { get; set; }
    }
}
