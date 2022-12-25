using System.Net.WebSockets;

namespace List_Collection_Class_Test2
{
    internal class Test
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer { Id = 110, Name = "David Alaba", Balance = 900.00, Type = "RetailCustomer" };
            Customer customer2 = new Customer { Id = 107, Name = "Gerard Alonso", Balance = 1500.00, Type = "RetailCustomer" };
            Customer customer3 = new Customer { Id = 104, Name = "Jim Pedri", Balance = 1300.00, Type = "RetailCustomer" };
            Customer customer4 = new Customer { Id = 101, Name = "Marks Gea", Balance = 2000.00, Type = "CorporateCustomer" };
            Customer customer5 = new Customer { Id = 115, Name = "Jphn Doe", Balance = 800.00, Type = "CorporateCustomer" };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCutomers = new List<Customer>();
            listCorporateCutomers.Add(customer4);
            listCorporateCutomers.Add(customer5);

            Console.WriteLine("------ AddRange Method bu using list ------");
            listCustomers.AddRange(listCorporateCutomers);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance} , Type = {customer.Type}");
            }
            Console.WriteLine();


            Customer customer6 = new Customer { Id = 106, Name = "Jean Bernad", Balance = 14500.00, Type = "RetailCustomer" };
            Customer customer7 = new Customer { Id = 107, Name = "Vadid Villa", Balance = 1010.00, Type = "RetailCustomer" };
            Customer[] customers = new Customer[2];
            customers[0] = customer6;
            customers[1] = customer7;
            Console.WriteLine("------ AddRange Method bu using array ------");
            listCustomers.AddRange(customers);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance} , Type = {customer.Type}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Get only one item from the list ------");
            Customer lastCustomer = listCustomers[listCustomers.Count - 1];
            Console.WriteLine($"Id = {lastCustomer.Id} , Name = {lastCustomer.Name} , Balance = {lastCustomer.Balance} , Type = {lastCustomer.Type}");
            Console.WriteLine();


            Console.WriteLine("------ Get range of items from the list ------");
            List<Customer> newListCustomers = listCustomers.GetRange(3, 2);
            foreach (Customer customer in newListCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance} , Type = {customer.Type}");
            }
            Console.WriteLine();


            Console.WriteLine("------ InsertRange Method ------");
            listCustomers.InsertRange(0, listCorporateCutomers);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance} , Type = {customer.Type}");
            }
            Console.WriteLine();

            Console.WriteLine("------ Remove and RemoveAt methods ------");
            listCustomers.Remove(customer6);
            listCustomers.RemoveAt(5);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance} , Type = {customer.Type}");
            }
            Console.WriteLine();


            Console.WriteLine("------ RemoveAll methods ------");
            /*
            Predicate<Customer> obj = customer => customer.Type == "CorporateCustomer";
            int removerItems = listCustomers.RemoveAll(obj);
            */
            int removerItems = listCustomers.RemoveAll(customer => customer.Type == "CorporateCustomer");
            Console.WriteLine($"Total of removed items is : {removerItems}");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance} , Type = {customer.Type}");
            }
            Console.WriteLine();


            listCustomers.InsertRange(2 ,listCorporateCutomers);


            Console.WriteLine("------ RemoveRange methods ------");
            listCustomers.RemoveRange(2, 4);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance} , Type = {customer.Type}");
            }
            Console.WriteLine();

        }
    }
}