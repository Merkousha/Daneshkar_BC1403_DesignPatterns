// Patterns/Factory/PaymentFactory.cs
using System;

namespace BookStore.Patterns.Factory
{
    public static class PaymentFactory
    {
        public static IPayment CreatePayment(string type, string data)
        {
            switch (type)
            {
                case "CreditCard":
                    return new CreditCardPayment(data);
                case "PayPal":
                    return new PayPalPayment(data);
                default:
                    throw new ArgumentException("Invalid payment type");
            }
        }
    }
}
