// Patterns/Decorator/Product.cs
using System;

namespace BookStore.Patterns.Decorator
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void Display()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }
    }
}
