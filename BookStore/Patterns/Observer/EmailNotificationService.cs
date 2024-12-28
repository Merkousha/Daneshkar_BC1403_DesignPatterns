// Patterns/Observer/NotificationService.cs
using System;

namespace BookStore.Patterns.Observer
{
    public class EmailNotificationService : IObserver
    {
        public void Update(int stock)
        {
            Console.WriteLine($"Send Email [Notification] Stock updated: {stock}");
            // Actual implementation of sending notifications
        }
    }
}
