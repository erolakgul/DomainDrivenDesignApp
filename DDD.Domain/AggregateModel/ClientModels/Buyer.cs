using DDD.Domain.Global;

namespace DDD.Domain.AggregateModel.ClientModels
{
    /// <summary>
    /// bounded context, client domain i altındaki class
    /// </summary>
    public class Buyer : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
