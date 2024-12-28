// Patterns/Strategy/AirShipping.cs
using System;

namespace BookStore.Patterns.Strategy
{
    public class AirShipping : IShippingStrategy
    {
        public void Ship(Models.Order order)
        {
            Console.WriteLine($"Order #{order.OrderId} shipped by airplane to {order.Destination}");
            // Actual implementation of air shipping
        }
    }
}
