using DDD.Domain.Global;

namespace DDD.Domain.AggregateModel.OrderModels
{
    /// <summary>
    /// address class ı order domain i için bir value object,çünkü kimlik değeri olmayacak
    /// </summary>
    public class Address : ValueObject
    {
        public string? City { get; set; }
        public string? Town { get; set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return Town;
        }
    }
}
