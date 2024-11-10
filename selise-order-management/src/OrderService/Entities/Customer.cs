using System;

namespace OrderService.Entities;

public class Customer
{
    public Guid Id { get; set; }
    public required string Email { get; set; }
    public required string Name { get; set; }
    public string Address { get; set; } = "";
    public required string ContactNo { get; set; }
    
    public ICollection<Order>? Orders { get; set; }
}
