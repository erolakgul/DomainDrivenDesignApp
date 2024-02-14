namespace DDD.Domain.Global
{
    /// <summary>
    /// repository deki işlemlerin de yönetildiği interface olacak
    /// </summary>
    public interface IUnitOfWork
    {
        Task<int> SaveChangeAsync();
    }
}
