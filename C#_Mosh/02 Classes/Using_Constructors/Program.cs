using System.Diagnostics.Metrics;

namespace Using_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-constructors
             */
            Taxi taxi = new Taxi(); // invokding the parameterless constructor
            Console.WriteLine(taxi.IsInitialized);  // True
            Console.WriteLine(taxi.Number);  // 0

            Console.WriteLine(Nlog.Value);
            Console.WriteLine(Nlog.e);

            //PreventInstantiation preventInstantiation = new PreventInstantiation(); // cannot instantiate an object from class PreventInstantiation because we have a private constructor


            Measurement measurement = new Measurement();
            Console.WriteLine($"Value = {measurement.Value}");
            Console.WriteLine($"Description = {measurement.Description ?? "null"}");

            Measurement measurement1 = new Measurement(15.5, "Evaluation");
            Console.WriteLine($"Value = {measurement1.Value}");
            Console.WriteLine($"Description = {measurement1.Description}");

            int defaultValueInteger = new int();
            Console.WriteLine($"Default value of integer = {defaultValueInteger}"); // Default value of integer = 0

            bool defaultValueBoolean = new bool();
            Console.WriteLine($"Default value of boolean = {defaultValueBoolean}"); // Default value of boolean = False

            int value;
            //Console.WriteLine(value); // we have an error because tha local variable value doesn't have any value (default value or assigned value)
            value = new int();
            Console.WriteLine(value);
            value = 10;
            Console.WriteLine(value);

            Employee employee1 = new Employee();
            Console.WriteLine($"Salary = {employee1.Salary} $"); // Salary = 0 $
            Employee employee2 = new Employee(120000);
            Console.WriteLine($"Salary = {employee2.Salary} $"); // Salary = 120000 $
            Employee employee3 = new Employee(10000, 12); 
            Console.WriteLine($"Salary = {employee3.Salary} $"); // Salary = 120000 $


            Person person1 = new Person();
            Console.WriteLine($"Id = {person1.Id}");
            Console.WriteLine($"Name = {person1.Name ?? "null"}");
            Person person2 = new Person(1);
            Console.WriteLine($"Id = {person2.Id}");
            Console.WriteLine($"Name = {person2.Name ?? "null"}");
            Person person3 = new Person(2, "Yousse Baba");
            Console.WriteLine($"Id = {person3.Id}");
            Console.WriteLine($"Name = {person3.Name}");


            Manager manager = new Manager(); // Base class parameterless constructor, is called implicitly
            Console.WriteLine($"Id = {manager.Id}");
            Console.WriteLine($"Salary = {manager.Salary}");


            Manager manager1 = new Manager(1, 200000);
            Console.WriteLine($"Id = {manager1.Id}");
            Console.WriteLine($"Salary = {manager1.Salary}");


            User user = new User();
            Transaction transaction1 = new Transaction(100, DateTime.Now , "Text...") ;
            user.Transactions.Add(transaction1);
            Console.WriteLine($"Name = {user.Name ?? "null"}");
            Console.WriteLine($"Age = {user.Age}");
            foreach (var item in user.Transactions)
            {
                Console.WriteLine($"{item.Amount} - {item.Date} - {item.Description}");
            }


            User user1 = new User("Youssef");
            Transaction transaction2 = new Transaction(150, DateTime.Now, "Text...");
            user1.Transactions.Add(transaction2);
            Console.WriteLine($"Name = {user1.Name}");
            Console.WriteLine($"Age = {user1.Age}");
            foreach (var item in user1.Transactions)
            {
                Console.WriteLine($"{item.Amount} - {item.Date} - {item.Description}");
            }


            User user2 = new User("Youssef" ,25);
            Transaction transaction3 = new Transaction(200, DateTime.Now, "Text...");
            user2.Transactions.Add(transaction3);
            Console.WriteLine($"Name = {user2.Name}");
            Console.WriteLine($"Age = {user2.Age}");
            foreach (var item in user2.Transactions)
            {
                Console.WriteLine($"{item.Amount} - {item.Date} - {item.Description}");
            }











        }
    }
}