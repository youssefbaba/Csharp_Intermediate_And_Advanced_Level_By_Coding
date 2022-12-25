namespace Collections_Part3
{
    public class GenericListCollection
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = new List<int>();
            listNumbers.Add(10);
            listNumbers.Add(20);
            listNumbers.Add(30);
            listNumbers.Add(40);
            listNumbers.Add(50);
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write($"{listNumbers[i]} ");
            }
            Console.WriteLine();
            foreach (int number in listNumbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            List<string> listCars = new List<string>();
            listCars.Add("Ford");
            listCars.Add("Ferrari");
            listCars.Add("Mercedes");
            listCars.Add("Honda");
            listCars.Add("Kia");
            for (int i = 0; i < listCars.Count; i++)
            {
                Console.Write($"{listCars[i]} ");
            }
            Console.WriteLine();
            foreach (string car in listCars)
            {
                Console.Write($"{car} ");
            }
            Console.WriteLine();

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(new Customer { IdCustomer = 1, NameCustomer = "John Doe", BalanceCustomer = 20000.0 });
            listCustomers.Add(new Customer { IdCustomer = 2, NameCustomer = "Marks Jim", BalanceCustomer = 25000.0 });
            listCustomers.Add(new Customer { IdCustomer = 3, NameCustomer = "Bernard Pedri", BalanceCustomer = 15000.0 });
            for (int i = 0; i < listCustomers.Count; i++)
            {
                Console.WriteLine($"Id = {listCustomers[i].IdCustomer} , Name = {listCustomers[i].NameCustomer} , Balance = {listCustomers[i].BalanceCustomer}");
            }
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine($"Id = {customer.IdCustomer} , Name = {customer.NameCustomer} , Balance = {customer.BalanceCustomer}");
            }

            List<string> listNames = new List<string> { "John Doe", "Marks Alba", "Jim Song", "David Gea" };
            listNames.Add("Bernard Silva");
            foreach (string name in listNames)
            {
                Console.Write($"'{name}' ");
            }
            Console.WriteLine();
            listNames.Insert(2, "Youssef Baba");
            listNames.InsertRange(3, new List<string> { "Mohamed Zidani", "Omar Abderahmane", "Hamza Aziz" });
            foreach (string name in listNames)
            {
                Console.Write($"'{name}' ");
            }
            Console.WriteLine();
            listNames.Remove("Hamza Aziz");
            foreach (string name in listNames)
            {
                Console.Write($"'{name}' ");
            }
            Console.WriteLine();
            listNames.RemoveAt(3);
            foreach (string name in listNames)
            {
                Console.Write($"'{name}' ");
            }
            Console.WriteLine();
            listNames.RemoveRange(1, 3);
            foreach (string name in listNames)
            {
                Console.Write($"'{name}' ");
            }
            Console.WriteLine();
        }
    }
}
