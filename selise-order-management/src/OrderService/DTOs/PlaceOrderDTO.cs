using System;
using System.ComponentModel.DataAnnotations;

namespace OrderService.DTOs;

public class PlaceOrderDTO
{
    [Required]
    public required string DeliveryAddress { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public Guid CustomerId { get; set; }
}
