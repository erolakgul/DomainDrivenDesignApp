using DDD.Application.Repository;
using DDD.Domain.AggregateModel.ClientModels;
using DDD.Domain.Events;
using MediatR;

namespace DDD.Application.EventHandlers
{
    /// <summary>
    /// OrderStartedEvent notification ı geldiğinde bunu handler edeceksin diyourz.
    /// Handle methodunda artık bir tetikleme mevcut, OrderStartedEvent tetiklendiğinde ne yapmak istiyorsam
    /// kullanıcım var mı yok mu vs gibi
    /// </summary>
    public class OrderStartedEventHandler : INotificationHandler<OrderStartedEvent>
    {
        private readonly IBuyerRepository _buyerRepository;
        public OrderStartedEventHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public Task Handle(OrderStartedEvent notification, CancellationToken cancellationToken)
        {
            // there is no client
            if (notification?.OrderHead?.BuyerId == 0) 
            {
                // create buyer
                var newClient = new Buyer(notification.BuyerFirstName, notification.BuyerLastName) { };

                // _buyerRepository.Add(newClient);
                var buyerID = newClient.ID;
                // son olarak da alınan buyerıd ,siparişin id sine verilir

                //notification.OrderHead.BuyerId = buyerID;

            }

            return Task.CompletedTask;
        }
    }
}
