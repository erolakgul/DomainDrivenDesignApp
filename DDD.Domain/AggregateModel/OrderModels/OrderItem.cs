namespace DDD.Domain.AggregateModel.OrderModels
{
    /// <summary>
    /// aggregateroot altındaki class lardan olan order item ın parametreleri de yine 
    /// yapıcı method üzerinden setlenir, kuralları da burada belirleriz
    /// </summary>
    public class OrderItem
    {
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public int ProdcutId { get; private set; }

        public OrderItem(int quantity, decimal price, int prodcutId)
        {
            if (quantity == 0)
                throw new Exception("Quantity can not be zero");

            Quantity = quantity;
            Price = price;
            ProdcutId = prodcutId;
        }
    }
}
