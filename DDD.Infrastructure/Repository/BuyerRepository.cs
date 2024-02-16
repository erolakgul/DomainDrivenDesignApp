using DDD.Application.Repository;

namespace DDD.Infrastructure.Repository
{
    public class BuyerRepository : IBuyerRepository
    {
        public async Task<int> SaveChangeAsync()
        {
            return await Task.FromResult(0);
        }
    }
}
