// Patterns/Factory/PayPalPayment.cs
using System;

namespace BookStore.Patterns.Factory
{
    public class PayPalPayment : IPayment
    {
        private string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Process()
        {
            Console.WriteLine($"Processing PayPal with email: {_email}");
            // Actual implementation of PayPal processing
        }
    }
}
