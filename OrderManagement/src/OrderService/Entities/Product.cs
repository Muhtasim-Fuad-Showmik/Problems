using System;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Entities;

public class Product
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string Description { get; set; } = "";
    public int Price { get; set; }
    public string Supplier { get; set; } = "Undefined";
    public int InStock { get; set; }

    public ICollection<OrderProductMap>? OrderProducts { get; set; }
}
