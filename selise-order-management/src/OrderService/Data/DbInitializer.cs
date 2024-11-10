using System;
using Microsoft.EntityFrameworkCore;
using OrderService.Entities;

namespace OrderService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        /**
         * Create scope for app services so that it will get 
         * disposed off after finished usage within this scope
         **/
        using var scope = app.Services.CreateScope();

        // See data using the Rent Db Context
        SeedData(scope.ServiceProvider.GetService<OrderDbContext>());
    }

    private static void SeedData(OrderDbContext context)
    {
        // Apply any migrations not yet applied to the database
        context.Database.Migrate();

        // Do nothing in this method if any data is already present for rents
        if (context.Orders.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        // TODO: Add seed logic later
        // Create orders to be added as seed to the database
        // var orders = new List<Order>()
        // {
            
        // }

        // Add orders to the memory
        // context.AddRange(orders);

        // Update database to add orders from the memory to the database
        // context.SaveChanges();
    }
}
