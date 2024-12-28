namespace BookStore.Models
{
    public class Order
    {
        private static int _counter = 1;
        public int OrderId { get; private set; }
        public string Destination { get; set; }

        public Order(string destination)
        {
            OrderId = _counter++;
            Destination = destination;
        }
    }
}
