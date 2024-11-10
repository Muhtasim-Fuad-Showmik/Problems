using System;

namespace OrderService.Commands;

public interface IEventStore
{
    Task SaveEventAsync(OrderPlacedEvent orderPlacedEvent);
}
