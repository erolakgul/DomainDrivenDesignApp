using DDD.Domain.AggregateModel.OrderModels;
using MediatR;

namespace DDD.Domain.Events
{
    /// <summary>
    /// mediatr kütüphanesinn INotification interface ini implementini ekliyoruz
    /// siparişin başladığı ile ilgili event i burada tutacağız
    /// bu statü altında hangi bilgilerin olacağına (property) karar veriyoruz
    /// </summary>
    public class OrderStartedEvent : INotification
    {
        public string? BuyerFirstName { get;private set; }
        public string? BuyerLastName { get;private set; }
        public OrderHead? OrderHead { get;private set; }

        public OrderStartedEvent(string? buyerFirstName, string? buyerLastName, OrderHead? orderHead)
        {
            BuyerFirstName = buyerFirstName;
            BuyerLastName = buyerLastName;
            OrderHead = orderHead;
        }
    }
}
