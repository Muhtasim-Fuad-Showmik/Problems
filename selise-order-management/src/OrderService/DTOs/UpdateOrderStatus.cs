using System;
using System.ComponentModel.DataAnnotations;
using OrderService.Entities;

namespace OrderService.DTOs;

public class UpdateOrderStatus
{
    [Required]
    public Status Status { get; set; }
}
