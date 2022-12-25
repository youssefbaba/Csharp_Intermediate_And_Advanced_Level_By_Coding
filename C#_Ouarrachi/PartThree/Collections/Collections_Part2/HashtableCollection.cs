using System.Collections;

namespace Collections_Part2
{
    public class HashtableCollection
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("IdEmployee", 1);
            hashtable.Add("NameEmployee", "David Gavi");
            hashtable.Add("JobEmployee", "Manager");
            hashtable.Add("SalaryEmployee", 120000.0);
            hashtable.Add("IdManager", 101);
            hashtable.Add("PhoneEmployee", "+21262535689");
            hashtable.Add("EmailEmployee", "David@gmail.com");
            hashtable.Add("DepartementEmployee", "Sales");
            hashtable.Add("Location", "Madrid");
            hashtable.Add("IdDepartement", 30);

            Console.WriteLine($"EmailEmployee = {hashtable["EmailEmployee"]}");
            hashtable["EmailEmployee"] = "DavidGavi@gmail.com";
            Console.WriteLine($"NewEmailEmployee = {hashtable["EmailEmployee"]}");

            Console.WriteLine();

            Console.WriteLine("Displaying the items of hashtable by using keys : ");
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"{key} = {hashtable[key]}");
            }

            Console.WriteLine();

            Console.WriteLine("Displaying the items of hashtable by using values : ");
            foreach (object value in hashtable.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();


        }
    }
}
