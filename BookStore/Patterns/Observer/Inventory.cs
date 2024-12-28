// Patterns/Observer/Inventory.cs
using System;
using System.Collections.Generic;

namespace BookStore.Patterns.Observer
{
    public class Inventory
    {
        private int _stock;
        private List<IObserver> _observers = new List<IObserver>();

        public int Stock
        {
            get { return _stock; }
            private set
            {
                _stock = value;
                NotifyObservers();
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("A new observer has been added.");
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("An observer has been removed.");
        }

        public void AddStock(int amount)
        {
            Stock += amount;
            Console.WriteLine($"Stock added: {amount}, Total stock: {Stock}");
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_stock);
            }
        }
    }
}
