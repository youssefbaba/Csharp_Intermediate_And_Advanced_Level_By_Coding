namespace Collections_Part5
{
    public class DictionaryCollection
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("IdEmployee", 1);
            dictionary.Add("NameEmployee", "David Gavi");
            dictionary.Add("JobEmployee", "Manager");
            dictionary.Add("SalaryEmployee", 120000.0);
            dictionary.Add("IdManager", 101);
            dictionary.Add("PhoneEmployee", "+21262535689");
            dictionary.Add("EmailEmployee", "David@gmail.com");
            dictionary.Add("DepartementEmployee", "Sales");
            dictionary.Add("Location", "Madrid");
            dictionary.Add("IdDepartement", 30);

            Console.WriteLine($"EmailEmployee = {dictionary["EmailEmployee"]}");
            dictionary["EmailEmployee"] = "Davidgavi@gmail.com";
            Console.WriteLine($"NewEmailEmployee = {dictionary["EmailEmployee"]}");

            Console.WriteLine();

            Console.WriteLine("Display items of dictionary by using keys :");
            foreach (string key in dictionary.Keys)
            {
                Console.WriteLine($"{key} = {dictionary[key]}");
            }

            Console.WriteLine();

            Console.WriteLine("Display items of dictionary by using values :");
            foreach (object value in dictionary.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            Console.WriteLine("Display items of dictionary by using keyvalue :");
            foreach (KeyValuePair<string, object> keyValue in dictionary)
            {
                Console.WriteLine($"{keyValue.Key} = {keyValue.Value}");
            }


            Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();
            dictionaryCustomer.Add(1, new Customer { IdCustomer = 1, NameCustomer = "John Doe", BalanceCustomer = 20000.0 });
            dictionaryCustomer.Add(2, new Customer { IdCustomer = 2, NameCustomer = "Marks Gea", BalanceCustomer = 15000.0 });
            dictionaryCustomer.Add(3, new Customer { IdCustomer = 3, NameCustomer = "Bernard Alba", BalanceCustomer = 30000.0 });
            dictionaryCustomer.Add(4, new Customer { IdCustomer = 4, NameCustomer = "David Pedri", BalanceCustomer = 10000.0 });
            Console.WriteLine("Display items of dictionary by using keys :");
            foreach (int key in dictionaryCustomer.Keys)
            {
                Console.WriteLine($"Id = {dictionaryCustomer[key].IdCustomer} , Name = {dictionaryCustomer[key].NameCustomer} , Balance = {dictionaryCustomer[key].BalanceCustomer}");
            }
            Console.WriteLine("Display items of dictionary by using values :");
            foreach (Customer value in dictionaryCustomer.Values)
            {
                Console.WriteLine($"Id = {value.IdCustomer} , Name = {value.NameCustomer} , Balance = {value.BalanceCustomer}");
            }
            Console.WriteLine("Display items of dictionary by using keyvalue :");
            foreach (KeyValuePair<int , Customer> keyValue in dictionaryCustomer)
            {
                Console.WriteLine($"Id = {keyValue.Value.IdCustomer} , Name = {keyValue.Value.NameCustomer} , Balance = {keyValue.Value.BalanceCustomer}");
            }
            Console.WriteLine();
        }
    }
}