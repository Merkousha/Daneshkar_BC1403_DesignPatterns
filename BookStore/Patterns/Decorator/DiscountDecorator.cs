// Patterns/Decorator/DiscountDecorator.cs
using System;

namespace BookStore.Patterns.Decorator
{
    public class DiscountDecorator : ProductDecorator
    {
        private double _discount;

        public DiscountDecorator(IProduct product, double discount) : base(product)
        {
            _discount = discount;
            Console.WriteLine($"Discount of {_discount} added to product {product.Name}.");
        }

        public override double Price => _product.Price - _discount;

        public override void Display()
        {
            Console.WriteLine($"Product: {Name}, Original Price: {_product.Price}, Discounted Price: {Price}");
        }
    }
}
