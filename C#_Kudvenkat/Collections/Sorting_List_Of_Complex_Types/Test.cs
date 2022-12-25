namespace Sorting_List_Of_Complex_Types
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 110, Name = "David Alaba", Balance = 900.00};
            Customer customer2 = new Customer { Id = 107, Name = "Gerard Alonso", Balance = 1500.00};
            Customer customer3 = new Customer { Id = 104, Name = "Jim Pedri", Balance = 1300.00};
            Customer customer4 = new Customer { Id = 101, Name = "Marks Gea", Balance = 1000.00};
            Customer customer5 = new Customer { Id = 115, Name = "Youssef Baba", Balance = 3000.00};
            List<Customer> listCustomers = new List<Customer> { customer1, customer2, customer3, customer4, customer5 };  // list of complex type

            Console.WriteLine("------ List of customers before sorting ------");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
            }
            Console.WriteLine();


            Console.WriteLine("------ List of customers after sorting in ascending order ------");
            listCustomers.Sort(); // Sorting by Balance
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
            }
            Console.WriteLine();


            Console.WriteLine("------ List of customers after sorting in descending order ------");
            listCustomers.Reverse();
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
            }
            Console.WriteLine();


            Console.WriteLine("------ List of customers after sorting ny using IComparer interface ------");
            CustomerComparer customerComparer = new CustomerComparer();
            listCustomers.Sort(customerComparer); // Sorting by Name
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
            }
            Console.WriteLine();


            Console.WriteLine("------ List of customers after sorting ny using IComparer interface ------");
            listCustomers.Sort(1 ,3 , customerComparer); // Sorting by Name
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
            }
            Console.WriteLine();


        }
    }
}