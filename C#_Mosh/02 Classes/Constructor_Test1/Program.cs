namespace Constructor_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name ?? "null");

            Customer customer1 = new Customer(1);
            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer1.Name ?? "null");

            Customer customer2 = new Customer(2 , "Youssef");
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name ?? "null");

            Order order1 = new Order();
            customer.Orders.Add(order1);

            Order order2 = new Order();
            customer1.Orders.Add(order2);

            Order order3 = new Order();
            customer2.Orders.Add(order3);
        }
    }
}