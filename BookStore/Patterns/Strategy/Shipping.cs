// Patterns/Strategy/Shipping.cs
using System;
using BookStore.Patterns.Strategy;

namespace BookStore.Patterns.Strategy
{
    public class Shipping
    {
        private IShippingStrategy _strategy;

        public void SetStrategy(IShippingStrategy strategy)
        {
            _strategy = strategy;
            Console.WriteLine($"Shipping strategy changed to: {_strategy.GetType().Name}");
        }

        public void ShipOrder(Models.Order order)
        {
            if (_strategy == null)
            {
                Console.WriteLine("Shipping strategy not set.");
                return;
            }
            _strategy.Ship(order);
        }
    }
}
