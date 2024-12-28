// Patterns/Strategy/SeaShipping.cs
using System;

namespace BookStore.Patterns.Strategy
{
    public class SeaShipping : IShippingStrategy
    {
        public void Ship(Models.Order order)
        {
            Console.WriteLine($"Order #{order.OrderId} shipped by ship to {order.Destination}");
            // Actual implementation of sea shipping
        }
    }
}
