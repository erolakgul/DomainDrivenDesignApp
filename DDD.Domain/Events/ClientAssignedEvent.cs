using DDD.Domain.AggregateModel.OrderModels;
using MediatR;

namespace DDD.Domain.Events
{
    public class ClientAssignedEvent : INotification
    {
        public OrderHead? OrderHead { get; private set; }

        public ClientAssignedEvent(OrderHead? orderHead)
        {
            OrderHead = orderHead;
        }
    }
}
