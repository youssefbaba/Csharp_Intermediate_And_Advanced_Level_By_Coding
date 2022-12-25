namespace Inheritance_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://www.youtube.com/watch?v=OLTk0xAVY00&list=PLAC325451207E3105&index=21
             - C# support multiple indirectly inheritance => OtherTypeEmployee : FullTimeEmployee and FullTimeEmployee : Employee
             - C# support only single directlty inheritance => FullTimeEmployee : Employee not OtherTypeEmployee : Employee , FullTimeEmployee
             - C# support multiple interface inheritance => public class FirstAndSecond: IFirst, ISecond {}
             - Child class is a specialization of base class
             - Base classes are automatically instanciated before direved class
             - Base Class Constructor executes before child class constructor
             - Construsctor not inheritable
            */

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Full";
            fullTimeEmployee.LastName = "Time";
            fullTimeEmployee.Email = "FullTime@gmail.com";
            fullTimeEmployee.YearlySalary = 120000;
            fullTimeEmployee.PrintFullName();


            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "Part";
            partTimeEmployee.LastName = "Time";
            partTimeEmployee.Email = "PartTime@gmail.com";
            partTimeEmployee.HourlyRate = 400;
            partTimeEmployee.PrintFullName();


            OtherTypeEmployee otherTypeEmployee = new OtherTypeEmployee();
            otherTypeEmployee.FirstName = "Other";
            otherTypeEmployee.LastName = "Employee";
            otherTypeEmployee.Email = "OtherEmployee@gmail.com";
            otherTypeEmployee.YearlySalary = 200000;
            otherTypeEmployee.PrintFullName();


            Console.WriteLine($"Number of objects that are created automatically from base class Employee = {Employee.NumberOfInstanceBaseClass}"); // 3 because base classes are automatically instanciated before direved class


            //ChildClass childClassOne = new ChildClass();
            ChildClass childClassTwo = new ChildClass();



        }
    }
}