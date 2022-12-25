namespace Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(101, "John Doe");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();
            Console.WriteLine($"Number of orders = {customer.Orders.Count}");



        }
    }
}