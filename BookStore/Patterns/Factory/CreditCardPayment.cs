// Patterns/Factory/CreditCardPayment.cs
using System;

namespace BookStore.Patterns.Factory
{
    public class CreditCardPayment : IPayment
    {
        private string _cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public void Process()
        {
            Console.WriteLine($"Processing credit card: {_cardNumber}");
            // Actual implementation of credit card processing
        }
    }
}
