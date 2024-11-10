using System;

namespace OrderService.Entities;

public class Order
{
    public Guid Id { get; set; }
    public required string DeliveryAddress { get; set; }
    public DateTime IssueDate { get; set; } = DateTime.UtcNow;
    public DateTime DeliveryDate { get; set; } = DateTime.UtcNow;
    public Status Status { get; set; } = Status.Placed;
    
    public required Customer Customer { get; set; }
    public Guid CustomerId { get; set; }
    public required ICollection<OrderProductMap> OrderProducts { get; set; }
}
