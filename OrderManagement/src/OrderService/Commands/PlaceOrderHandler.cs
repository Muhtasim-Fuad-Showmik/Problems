using System;

namespace OrderService.Commands;

public class PlaceOrderHandler : ICommandHandler<PlaceOrderCommand>
{
    private readonly IEventStore _eventStore;

    public PlaceOrderHandler(IEventStore eventStore)
    {
        _eventStore = eventStore;
    }

    public Task HandleAsync(PlaceOrderCommand command)
    {
        var orderPlacedEvent = new OrderPlacedEvent {
            OrderId: command.OrderId,
            CustomerId: command.CustomerId,
            Products: command.Products,
        };
        await _eventStore.SaveEventAsync(orderPlacedEvent);
    }
}
