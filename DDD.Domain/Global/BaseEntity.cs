namespace DDD.Domain.Global
{
    /// <summary>
    /// veritabanına erişecek olan class lar için ortak property leri içerecek olan class
    /// </summary>
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ChangedAt { get; set; }
        public string? ChangedBy { get; set; }
    }
}
