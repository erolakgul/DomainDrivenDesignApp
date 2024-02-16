using DDD.Application.Repository;

namespace DDD.Infrastructure.Repository
{
    /// <summary>
    /// application domain i implemente edilir
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        public async Task<int> SaveChangeAsync()
        {
           return await Task.FromResult(0);
        }
    }
}
