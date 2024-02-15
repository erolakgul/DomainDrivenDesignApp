using DDD.Domain.Global;

namespace DDD.Domain.AggregateModel.OrderModels
{
    /// <summary>
    /// bounded context class ımız olan orderhead class ındaki property ler yapıcı method üzerinden kontrol edilecek
    /// bir orderitem eklenecekse veya adress eklenecekse bu aggrgate root olan orderhead üzerinden olacak
    /// </summary>
    public class OrderHead : BaseEntity, IAggregateRoot
    {
        public int BuyerId { get; private set; }
        public string? OrderStatus { get; private set; }
        public string? Description { get; private set; }
        public DateTime OrderDate { get; private set; }
        public Address? Address { get; private set; }
        public ICollection<OrderItem>? OrderItems { get; private set; }

        public OrderHead(int buyerId, string? orderStatus, string? description, DateTime orderDate, Address? address, ICollection<OrderItem>? orderItems)
        {
            // rule 1
            if (orderDate <= DateTime.Now)
                throw new Exception("orderdate must be greater than now");

            // rule 2
            if (string.IsNullOrEmpty(address.City))
                throw new Exception("City Name can not be null");

            BuyerId = buyerId;
            OrderStatus = orderStatus;
            Description = description;
            OrderDate = orderDate;
            Address = address;
            OrderItems = orderItems;
        }

        public void AddOrderItem(int quan,int prodId,decimal price) 
        {
            OrderItem newOrderItem = new(quan,price,prodId);
            OrderItems.Add(newOrderItem);
        }
    }
}
