// Patterns/Decorator/ProductDecorator.cs
namespace BookStore.Patterns.Decorator
{
    public abstract class ProductDecorator : IProduct
    {
        protected IProduct _product;

        protected ProductDecorator(IProduct product)
        {
            _product = product;
        }

        public virtual string Name => _product.Name;
        public virtual double Price => _product.Price;

        public virtual void Display()
        {
            _product.Display();
        }
    }
}
