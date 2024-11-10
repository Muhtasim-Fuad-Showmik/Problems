using System;
using OrderService.Entities;

namespace OrderService.Commands;

public class OrderPlacedEvent
{
    public Guid OrderId { get; set; }
    public Guid CustomerId { get; set; }
    public required List<Product> Products { get; set; }
}
