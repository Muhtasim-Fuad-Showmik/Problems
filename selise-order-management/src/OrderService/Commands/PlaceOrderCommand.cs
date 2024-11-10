using System;
using OrderService.Entities;

namespace OrderService.Commands;

public class PlaceOrderCommand
{
    public Guid OrderId { get; set; }
    public required string DeliveryAddress { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public Guid CustomerId { get; set; }
    public required List<Product> Products { get; set; }
}
