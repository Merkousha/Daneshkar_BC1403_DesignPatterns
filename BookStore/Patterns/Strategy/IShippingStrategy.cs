// Patterns/Strategy/IShippingStrategy.cs
namespace BookStore.Patterns.Strategy
{
    public interface IShippingStrategy
    {
        void Ship(Models.Order order);
    }
}
