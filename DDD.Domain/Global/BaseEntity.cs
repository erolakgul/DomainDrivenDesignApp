using MediatR;

namespace DDD.Domain.Global
{
    /// <summary>
    /// veritabanına erişecek olan class lar için ortak property leri içerecek olan class
    /// </summary>
    public abstract class BaseEntity
    {
        private List<INotification> _domainNotificationList;
        public IReadOnlyCollection<INotification> DomainEvents => _domainNotificationList.AsReadOnly();

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

        public void RemoveDomainEvents(INotification notification)
        {
            _domainNotificationList?.Remove(notification);
        }

        public void ClearDomainEvent()
        {
            _domainNotificationList?.Clear();   
        }
    }
}
