namespace IComparable_IComparer_Interfaces_Part1
{
    public class TestCustomer
    {
        static void Main(string[] args)
        {
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(new Customer { IdCustomer = 6, NameCustomer = "John Doe", BalanceCustomer = 20000.0 });
            listCustomers.Add(new Customer { IdCustomer = 4, NameCustomer = "Marks Jim", BalanceCustomer = 25000.0 });
            listCustomers.Add(new Customer { IdCustomer = 1, NameCustomer = "Bernard Pedri", BalanceCustomer = 15000.0 });
            listCustomers.Add(new Customer { IdCustomer = 5, NameCustomer = "Daniel Olmo", BalanceCustomer = 35000.0 });
            Console.WriteLine("Before Sorting the list : ");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.IdCustomer} - Name = {customer.NameCustomer} - Balance = {customer.BalanceCustomer}");
            }
            listCustomers.Sort();
            Console.WriteLine("After Sorting the list in ascending order : ");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.IdCustomer} - Name = {customer.NameCustomer} - Balance = {customer.BalanceCustomer}");
            }
            listCustomers.Reverse();
            Console.WriteLine("After Sorting the list in descending order : ");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.IdCustomer} - Name = {customer.NameCustomer} - Balance = {customer.BalanceCustomer}");
            }
        }
    }
}
