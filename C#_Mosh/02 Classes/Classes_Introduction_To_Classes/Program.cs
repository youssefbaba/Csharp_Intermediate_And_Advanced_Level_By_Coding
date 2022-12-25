namespace Classes_Introduction_To_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes
             - link2 : https://www.youtube.com/watch?v=OLTk0xAVY00
             */
            //Declaring an object of type Person.
            Person person1; // the variable contains the value null


            //Creating an object of type Person.
            Person person2 = new Person("Youssef");


            //Creating another object of the same type, assigning it the value of the first object.
            person1 = person2;


            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Full";
            fullTimeEmployee.LastName = "Time";
            fullTimeEmployee.YearlySalary = 120000;
            fullTimeEmployee.PrintFullName();


            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "Part";
            partTimeEmployee.LastName = "Time";
            partTimeEmployee.HourlyRate = 1000;
            partTimeEmployee.PrintFullName();


            OtherClass otherClass = new OtherClass();
            otherClass.FirstName = "Other";
            otherClass.LastName = "Class";
            otherClass.YearlySalary = 200000;
            otherClass.PrintFullName();


            ChildClass childClassOne = new ChildClass();


            Person person3 = new Person();
            Console.WriteLine($"{person3.Name}"); // Unknown


            Person person4 = new Person("Hassna");
            Console.WriteLine($"{person4.Name}"); // Hassna
            Console.WriteLine($"{person4}"); //  Your name is Hassna










        }
    }
}