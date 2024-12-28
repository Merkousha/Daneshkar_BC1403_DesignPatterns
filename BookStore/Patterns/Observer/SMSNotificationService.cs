// Patterns/Observer/NotificationService.cs
using System;

namespace BookStore.Patterns.Observer
{
    public class SMSNotificationService : IObserver
    {
        public void Update(int stock)
        {
            Console.WriteLine($"SMS [Notification] Stock updated: {stock}");
            // Actual implementation of sending notifications
        }
    }
}
