namespace List_Collection_Class_Test2
{
    internal class Test
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer { Id = 110, Name = "David Alaba", Balance = 900.00 };
            Customer customer2 = new Customer { Id = 107, Name = "Gerard Alonso", Balance = 1500.00 };
            Customer customer3 = new Customer { Id = 104, Name = "Jim Pedri", Balance = 1300.00 };
            Customer customer4 = new Customer { Id = 101, Name = "Marks Gea", Balance = 2000.00 };
            //Customer customer10 = new Customer { Id = 101, Name = "Marks Gea", Balance = 70000.00 };


            List<Customer> listCustomersOne = new List<Customer>();
            listCustomersOne.Add(customer1);
            listCustomersOne.Add(customer2);
            listCustomersOne.Add(customer3);
            listCustomersOne.Add(customer4);
            //listCustomersOne.Add(customer10);


            Customer customer5 = new Customer { Id = 105, Name = "John Doe", Balance = 2100.00 };


            Console.WriteLine("------ Contains Method ------");
            //if (listCustomersOne.Contains(customer5))  // Not Found
            if (listCustomersOne.Contains(customer2)) // Is Found
            {
                Console.WriteLine("item object exists in the list.");
            }
            else
            {
                Console.WriteLine("item object doesn't exist in the list.");
            }
            Console.WriteLine();


            Console.WriteLine("------ Exists Method ------");
            /*
            Predicate<Customer> obj = customer => customer.Name.StartsWith("p" , StringComparison.OrdinalIgnoreCase);
            if (listCustomersOne.Exists(obj))
            */
            if (listCustomersOne.Exists(customer => customer.Name.StartsWith("p", StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("item object exists in the list.");
            }
            else
            {
                Console.WriteLine("item object doesn't exist in the list.");
            }
            Console.WriteLine();


            Console.WriteLine("------ Find Method ------");
            /*
            Predicate<Customer> obj1 = customer => customer.Balance >= 4000.00;
            Customer customer6 = listCustomersOne.Find(obj1);
            */
            Customer customer6 = listCustomersOne.Find(customer => customer.Balance >= 1000.00);
            if (customer6 == null)
            {
                Console.WriteLine($"Item object contains its default value which is null .");
            }
            else
            {
                Console.WriteLine($"Id = {customer6.Id} , Name = {customer6.Name} , Balance = {customer6.Balance}");
            }
            Console.WriteLine();


            Console.WriteLine("------ FindLast Method ------");
            /*
            Predicate<Customer> obj2 = customer => customer.Balance >= 3000.00;
            Customer customer7 = listCustomersOne.FindLast(obj2);
            */
            Customer customer7 = listCustomersOne.Find(customer => customer.Balance >= 1500.00);
            if (customer7 == null)
            {
                Console.WriteLine($"Item object contains its default value which is null .");
            }
            else
            {
                Console.WriteLine($"Id = {customer7.Id} , Name = {customer7.Name} , Balance = {customer7.Balance}");
            }
            Console.WriteLine();

            Console.WriteLine("------ FindAll Method ------");
            /*
            Predicate<Customer> obj3 = customer => customer.Balance >= 1000.00;
            List<Customer> customers =  listCustomersOne.FindAll(obj3);
            */
            List<Customer> customers = listCustomersOne.FindAll(customer => customer.Balance >= 1000.00);
            if (customers.Count == 0)
            {
                Console.WriteLine("Empty Colletion of customers");
            }
            else
            {
                foreach (Customer customer in customers)
                {
                    Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
                }
            }
            Console.WriteLine();


            Console.WriteLine("------ FindIndex Method ------");

            int result = listCustomersOne.FindIndex(customer => customer.Balance >= 1000.00); // 1
            //int result = listCustomersOne.FindIndex(2 ,customer => customer.Balance >= 1000.00); // 2
            //int result = listCustomersOne.FindIndex(1 , 2 ,customer => customer.Balance >= 1500.00); // 1
            if (result != -1)
            {
                Console.WriteLine($"Index of first element that matches condition is : {result}");
            }
            else
            {
                Console.WriteLine($"No element that matches condition");
            }
            Console.WriteLine();


            Console.WriteLine("------ FindLastIndex Method ------");
            foreach (Customer customer in listCustomersOne)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
            }
            int value = listCustomersOne.FindLastIndex(customer => customer.Balance >= 1000.00);  // 3
            //int value = listCustomersOne.FindLastIndex(2 ,customer => customer.Balance >= 1000.00);  // 3
            //int value = listCustomersOne.FindLastIndex(2,2  ,customer => customer.Balance >= 1000.00); // 2
            if (value != -1)
            {
                Console.WriteLine($"Index of last element that matches condition is : {value}");
            }
            else
            {
                Console.WriteLine($"No element that matches condition");
            }
            Console.WriteLine();


            Console.WriteLine("------ Convert Array To List ------");
            Customer[] arrayCustomerOne = new Customer[4];
            arrayCustomerOne[0] = customer1;
            arrayCustomerOne[1] = customer2;
            arrayCustomerOne[2] = customer3;
            arrayCustomerOne[3] = customer4;
            List<Customer> listCustomersTwo = arrayCustomerOne.ToList();
            foreach (Customer customer in listCustomersTwo)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Convert List To Array ------");
            //Customer[] arrayCustomerTwo = listCustomersOne.ToArray<Customer>();
            Customer[] arrayCustomerTwo = listCustomersOne.ToArray();
            foreach (Customer customer in arrayCustomerTwo)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Balance = {customer.Balance}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Convert List To Dictionary ------");
            /*
            // Func<Customer, int> obj = customer => customer.Id;
            Dictionary<int, Customer> dictionaryCutomers = listCustomersTwo.ToDictionary(obj);
            */

            /*
            Dictionary<int, Customer> dictionaryCutomers = listCustomersTwo.ToDictionary(customer => customer.Id);
            */

            /*
            Func<Customer, int> obj = customer => customer.Id;
            Func<Customer, Customer> obj1 = customer => customer;
            Dictionary<int, Customer> dictionaryCutomers = listCustomersTwo.ToDictionary(obj, obj1);
            */

            Dictionary<int, Customer> dictionaryCutomers = listCustomersTwo.ToDictionary(customer => customer.Id, customer => customer);
            foreach (KeyValuePair<int, Customer> keyValuePair in dictionaryCutomers)
            {
                Console.WriteLine($"Id = {keyValuePair.Value.Id} , Name = {keyValuePair.Value.Name} , Balance = {keyValuePair.Value.Balance}");
            }


        }
    }
}