// Patterns/Decorator/IProduct.cs
namespace BookStore.Patterns.Decorator
{
    public interface IProduct
    {
        string Name { get; }
        double Price { get; }
        void Display();
    }
}
