using System.Collections.Generic;
using System.Linq;

namespace What_Is_Dictionary
{
    public class Test
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 101, Name = "John Doe", Salary = 120000 };
            Customer customer2 = new Customer { Id = 105, Name = "Mike Gavi", Salary = 114000 };
            Customer customer3 = new Customer { Id = 110, Name = "Gerard Alba", Salary = 130000 };
            Customer customer4 = new Customer { Id = 119, Name = "Jim Alonso", Salary = 110000 };

            // Dictionary<Tkey , Tvalue> Name = new Dictionary<Tkey , Tvalue>();
            // key in dictionary is unique
            Dictionary<int, Customer> dictionaryCustomers1 = new Dictionary<int, Customer>();
            dictionaryCustomers1.Add(customer1.Id, customer1);
            dictionaryCustomers1.Add(customer2.Id, customer2);
            dictionaryCustomers1.Add(customer3.Id, customer3);
            dictionaryCustomers1.Add(customer4.Id, customer4);


            Console.WriteLine($"key = 119 => Id = {dictionaryCustomers1[119].Id} , Name = {dictionaryCustomers1[119].Name} , Salary = {dictionaryCustomers1[119].Salary}");
            Console.WriteLine();


            Console.WriteLine("------ Key : Value ------");
            foreach (KeyValuePair<int, Customer> keyValuePair in dictionaryCustomers1)
            {
                Console.WriteLine($"Id = {keyValuePair.Value.Id} , Name = {keyValuePair.Value.Name} , Salary = {keyValuePair.Value.Salary}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Value ------");
            foreach (Customer customer in dictionaryCustomers1.Values)
            {
                Console.WriteLine($"Id = {customer.Id} , Name = {customer.Name} , Salary = {customer.Salary}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Key ------");
            foreach (int key in dictionaryCustomers1.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();


            if (!dictionaryCustomers1.ContainsKey(customer2.Id))
            {
                dictionaryCustomers1.Add(customer2.Id, customer2);
            }
            else
            {
                Console.WriteLine($"An item with the same key = {customer2.Id} has already been added .");
            }
            Console.WriteLine();


            if (dictionaryCustomers1.ContainsKey(135))
            {
                Customer cust = dictionaryCustomers1[135];
            }
            else
            {
                Console.WriteLine($"The given key {135} is not present in the dictionary .");
            }
            Console.WriteLine();


            Customer customer5;
            if (dictionaryCustomers1.TryGetValue(110, out customer5))  // successful operation
            //if (dictionaryCustomers.TryGetValue(102, out customer5))  // failed operation
            {
                Console.WriteLine($"Id = {customer5.Id} , Name = {customer5.Name} , Salary = {customer5.Salary}");
            }
            else
            {
                Console.WriteLine($"The given key {102} is not present in the dictionary .");
            }
            Console.WriteLine();

            //Func<KeyValuePair<int, Customer>, bool> test = keyValuePair => keyValuePair.Value.Salary >= 115000;


            Console.WriteLine($"Total items in the dictionary is : {dictionaryCustomers1.Count}");
            Console.WriteLine($"Total items in the dictionary is : {dictionaryCustomers1.Count()}");
            Console.WriteLine($"Total items those have salary greater than or equal 115000 : {dictionaryCustomers1.Count(keyValuePair => keyValuePair.Value.Salary >= 115000)}");
            Console.WriteLine();


            Customer customer6 = new Customer { Id = 130, Name = "Jim Bernard", Salary = 109000 };
            dictionaryCustomers1.Add(customer6.Id, customer6);
            //if (dictionaryCustomers.Remove(100))
            if (dictionaryCustomers1.Remove(130))
            {
                Console.WriteLine("Successfully removed");
            }
            else
            {
                Console.WriteLine("removal failed");

            }
            Console.WriteLine();


            //dictionaryCustomers.Clear();  // remove all keys:values from the dictionary


            // Declaration of Array Customers
            int[] array = new int[4];
            Customer[] arrayCustomers = new Customer[4];
            arrayCustomers[0] = customer1;
            arrayCustomers[1] = customer2;
            arrayCustomers[2] = customer3;
            arrayCustomers[3] = customer4;

            /*
            Func<Customer, int> obj = customer => customer.Id;
            Dictionary<int , Customer> dicCustomers =  arrayCustomers.ToDictionary(obj);
            */

            /*
            Func<Customer, int> obj = customer => customer.Id;
            Func<Customer, Customer> obj1 = customer => customer;
            Dictionary<int, Customer> dicCustomers = arrayCustomers.ToDictionary(obj , obj1);
            */

            //Dictionary<int, Customer> dicCustomers = arrayCustomers.ToDictionary(customer => customer.Id);
            Dictionary<int, Customer> dicCustomers = arrayCustomers.ToDictionary(customer => customer.Id, customer => customer);

            Console.WriteLine("Convert Array To Dictionary :");
            foreach (KeyValuePair<int , Customer> keyValuePair in dicCustomers)
            {
                Console.WriteLine($"Key = {keyValuePair.Key} , Value = [ Id = {keyValuePair.Value.Id} , Name = {keyValuePair.Value.Name} , Salary = {keyValuePair.Value.Salary}]");
            }
            Console.WriteLine();


            // Declaration a List of Customers
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            listCustomers.Add(customer4);


            //Dictionary<int , Customer> dictionary = listCustomers.ToDictionary(customer => customer.Id);
            Dictionary<int , Customer> dictionary = listCustomers.ToDictionary(customer => customer.Id , customer => customer);
            Console.WriteLine("Convert List To Dictionary :");
            foreach (KeyValuePair<int, Customer> keyValuePair in dictionary)
            {
                Console.WriteLine($"Key = {keyValuePair.Key} , Value = [ Id = {keyValuePair.Value.Id} , Name = {keyValuePair.Value.Name} , Salary = {keyValuePair.Value.Salary}]");
            }
            Console.WriteLine();





























        }
    }
}