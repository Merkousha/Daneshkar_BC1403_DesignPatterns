// Program.cs
using System;
using BookStore.Models;
using BookStore.Patterns.Singleton;
using BookStore.Patterns.Factory;
using BookStore.Patterns.Observer;
using BookStore.Patterns.Strategy;
using BookStore.Patterns.Decorator;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Online Shop...\n");

            // Using Singleton to manage database connection
            var db = DatabaseConnection.Instance;
            db.Query("SELECT * FROM Products");
            db.Query("SELECT * FROM Orders");

            Console.WriteLine("\n-----------------------------\n");

            // Using Factory to create payment objects
            IPayment payment1 = PaymentFactory.CreatePayment("CreditCard", "1234-5678-9012-3456");
            IPayment payment2 = PaymentFactory.CreatePayment("PayPal", "user@example.com");

            payment1.Process();
            payment2.Process();

            Console.WriteLine("\n-----------------------------\n");

            // Using Observer to manage inventory
            Inventory inventory = new Inventory();
            ConsoleNotificationService notifier = new ConsoleNotificationService();
            EmailNotificationService emailNotificationService = new EmailNotificationService();
            SMSNotificationService smsNotificationService = new SMSNotificationService();   
            inventory.AddObserver(notifier);    
            inventory.AddObserver(emailNotificationService);
            inventory.AddObserver(smsNotificationService);

            inventory.AddStock(50);
            inventory.AddStock(30);

            Console.WriteLine("\n-----------------------------\n");

            // Using Strategy to send orders
            Shipping shipping = new Shipping();

            Order order1 = new Order("International");
            Order order2 = new Order("Domestic");

            if (order1.Destination == "International")
            {
                shipping.SetStrategy(new AirShipping());
            }
            else
            {
                shipping.SetStrategy(new SeaShipping());
            }
            shipping.ShipOrder(order1);

            if (order2.Destination == "International")
            {
                shipping.SetStrategy(new AirShipping());
            }
            else
            {
                shipping.SetStrategy(new SeaShipping());
            }
            shipping.ShipOrder(order2);

            Console.WriteLine("\n-----------------------------\n");

            // Using Decorator to add discount to product
            IProduct product = new Product { Name = "Laptop", Price = 1500 };
            IProduct discountedProduct = new DiscountDecorator(product, 200);

            product.Display();
            discountedProduct.Display();

            Console.WriteLine("\nEnd Program.");
            Console.ReadLine();
        }
    }
}
