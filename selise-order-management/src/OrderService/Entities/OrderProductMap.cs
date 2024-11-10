using System;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Entities;

public class OrderProductMap
{
    [Key]
    public int OrderId { get; set; }
    public required Order Order { get; set; }
    
    [Key]
    public int ProductId { get; set; }
    public required Product Product { get; set; }

    public int Quantity { get; set; }
    public int PriceDuringOrder { get; set; }
}
