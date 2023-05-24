﻿using Microsoft.Extensions.Logging;
using Ordering.Domain.Common.Entities;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order() {UserName = "swn", FirstName = "Stefan", LastName = "Kolaric", EmailAddress = "stefan.kolaric5@gmail.com", AddressLine = "Belgrade", Country = "Serbia", TotalPrice = 350 }
            };
        }
    }
}
