using System.Collections;

namespace Collections_Part2
{
    internal class HashCollection
    {
        static void Main(string[] args)
        {

            /*
             - Hashtable : key,value combination which key is user defined of type object.
             - Array and ArrayList : key,value combination which key is predefined.
             */

            //creating a Hashtable using collection-initializer syntax :
            /*
            Hashtable hashtable = new Hashtable()
            {
                {"EmployeeId" , 1010},
                {"EmployeeName" , "John Doe"},
                {"Job" , "Manager"},
                {"Salary" , 25000.00},
                {"MangerId" , 1002},
                {"Phone" , +221251485745},
                {"Email" , "John@gmail.com"},
                {"DepartementName" , "Sales"},
                {"Location" , "Madrid"},
                {"DepartmentId" , 30},
            };
             */

            //creating a Hashtable using Add() method :
            Hashtable hashtable = new Hashtable();
            hashtable.Add("EmployeeId", 1010);
            hashtable.Add("EmployeeName", "John Doe");
            hashtable.Add("Job", "Manager");
            hashtable.Add("Salary", 25000.00);
            hashtable.Add("MangerId", 1002);
            hashtable.Add("Phone", +221251485745);
            hashtable.Add("Email", "John@gmail.com");
            hashtable.Add("DepartementName", "Sales");
            hashtable.Add("Location", "Madrid");
            hashtable.Add("DepartmentId", 30);

            Console.WriteLine($"Salary : {hashtable["Salary"]}");
            Console.WriteLine();
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine();
            hashtable.Remove("DepartmentId");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine();
            hashtable.Add("DepartmentId", 40);
            Console.WriteLine($"------ Key ------");
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();
            Console.WriteLine($"------ Value ------");
            foreach (object value in hashtable.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            Console.WriteLine($"------ Key : Value ------");
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine($"{key} : {hashtable[key]}");
            }
        }
    }
}