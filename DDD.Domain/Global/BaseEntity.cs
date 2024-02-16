using MediatR;

namespace DDD.Domain.Global
{
    /// <summary>
    /// veritabanına erişecek olan class lar için ortak property leri içerecek olan class
    /// </summary>
    public abstract class BaseEntity
    {
        private ICollection<INotification> _domainNotificationList;
        public ICollection<INotification> DomainEvents => _domainNotificationList;

        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ChangedAt { get; set; }
        public string? ChangedBy { get; set; }

        public void AddDomainEvents(INotification notification)
        {
            _domainNotificationList ??= new List<INotification>();
            _domainNotificationList.Add(notification);
        }
    }
}
