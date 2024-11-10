using System;
using Microsoft.EntityFrameworkCore;
using OrderService.Entities;

namespace OrderService.Data;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Order> Orders { get; set; }
    // we override the OnModelCreating method here.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderProductMap>().HasKey(opm => new {opm.OrderId, opm.ProductId});
    }
    
}