// Patterns/Observer/NotificationService.cs
using System;

namespace BookStore.Patterns.Observer
{
    public class ConsoleNotificationService : IObserver
    {
        public void Update(int stock)
        {
            Console.WriteLine($"Console [Notification] Stock updated: {stock}");
            // Actual implementation of sending notifications
        }
    }
}
