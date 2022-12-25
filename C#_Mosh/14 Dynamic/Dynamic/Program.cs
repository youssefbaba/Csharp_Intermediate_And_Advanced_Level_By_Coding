using System.ComponentModel;
using System.Reflection;

namespace DynamicTest1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             Link1 : https://www.youtube.com/watch?v=0ovCJ9uI6Tk
             - In C#  we have several Buil-in types for example string , bool , int , double , etc ...
             - All Built-in type are static type .
             - Static type : type checking and type safety are enforced at compile time 
             - Dynamic type : type checking and type safety are enforced at run time
             - Conversion form Static types to Dynamic types and vice versa is Implicitly.


             */
            /*
             - Type Conversions :
                - Without data loss => Implicit conversion are allowed : true for static types and dynamic types
                - With potential of data loss  => Explicit conversion are allowed , In the case of static types an error throws at compile time but in the case of static types an exception throws an run time

             */


            int intNumber1 = 100;
            long longNumber1 = intNumber1;  // Implicit Conversion from int to long and compiler allows this without data loss
            Console.WriteLine($"intNumber1 = {intNumber1} & longNumber1 = {longNumber1} ");


            Console.WriteLine();


            long longNumber2 = 200;
            int intNumber2 = (int)longNumber2; // Implicit conversion from long to int and there is a potential of data loss
            Console.WriteLine($"intNumber2 = {intNumber2} & longNumber2 = {longNumber2} ");


            Console.WriteLine();


            string string1 = "Good Evening Youssef";
            Console.WriteLine(string1.ToUpper());


            Console.WriteLine();



            /*
            string string2 = "Hello Youssef";
            Console.WriteLine(string2.NonExistingMethod());  // Compiler Error because type string doesn't contain NonExistingMethod() method => this Complie time checking of the code is called Static Binding
            */


            dynamic dynamicString1 = "Dynamic keyword";
            Console.WriteLine(dynamicString1.ToUpper());


            Console.WriteLine();

            try
            {

                dynamic dynamicString2 = "Hello World";
                Console.WriteLine(dynamicString2.NonExistingMethod());  // Checking start at run time and because of that we don't have a compiler error but at run time we have an Exception throwing => string type does not contain NonExistingMethod() method
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Exception : {exp.Message}");
            }


            Console.WriteLine();


            dynamic dynamicString3 = "John Doe";
            Console.WriteLine($"Type of dynamicString3 at compile time : {dynamicString3.GetType().Name}");
            Console.WriteLine($"Type of dynamicStrin3 at run time : {GetTypeAtRunTime(dynamicString3)}");


            Console.WriteLine();


            dynamic dynamicInt1 = 1000;
            Console.WriteLine($"Type of dynamicInt1 at compile time : {dynamicInt1.GetType().Name}");
            Console.WriteLine($"Type of dynamicInt1 at run time : {GetTypeAtRunTime(dynamicInt1)}");


            Console.WriteLine();


            int intNumber3 = 10;
            dynamic dynamicInt3 = intNumber3; // Implicit conversion from Static types to Dynamic types
            Console.WriteLine(dynamicInt3);


            Console.WriteLine();


            dynamic dynamicBool1 = true;
            bool boolValue = dynamicBool1; // Implicit Conversion from Dynamic types to static types
            Console.WriteLine(boolValue);


            Console.WriteLine();


            Employee employee1 = new Employee
            {
                Id = 1,
                FullName = "David Alonso"
            };
            dynamic dynamicEmployee1 = employee1;
            Console.WriteLine($"Id = {dynamicEmployee1.Id} - FullName = {dynamicEmployee1.FullName}");


            Console.WriteLine();


            dynamic dynamicEmployee2 = new Employee
            {
                Id = 2,
                FullName = "Marks Gea"
            };
            Employee employee2 = dynamicEmployee2;
            Console.WriteLine($"Id = {employee2.Id} - FullName = {employee2.FullName}");



            Console.WriteLine();

            // Implicit Conversion : Static Types & Dynamic Types
            int intNumber4 = 123;
            double doubleNumber1 = intNumber4; // Static types : Implicit conversion from int data type to double data type
            Console.WriteLine(doubleNumber1);


            Console.WriteLine();


            dynamic dynamicInt2 = 456;
            double doubleNumber2 = dynamicInt2; // Dynamic types : Implicit conversion from dynamic type that is int type to satatic type that is double
            Console.WriteLine(doubleNumber2);


            Console.WriteLine();


            // Explicit Conversion : Static Types & Dynamic Types
            double doubleNumber3 = 123.5;
            //int intNumber5 = doubleNumber3; // An error throw at a compile time because connot convert implicitly double data type to int data type
            int intNumber5 = (int)doubleNumber3; // Solution (Static types) : Casting to int data type but there is data loss
            Console.WriteLine(intNumber5);


            Console.WriteLine();


            dynamic dynamicDouble1 = 456.5;
            // int intNumber6 = dynamicDouble1; // An Exception throws at run time because connot convert implicitly dynamic type that is double to a static type that is int
            int intNumber6 = (int)dynamicDouble1;    // Solution (Dynamic types) : Casting to int data type but there is data loss
            Console.WriteLine(intNumber6);


            Console.WriteLine();


            // Invoking Add method bu using reflection
            /*
            Calculator calculator = new Calculator();
            object result = calculator.GetType().InvokeMember("Add", BindingFlags.InvokeMethod, null, calculator, new object[] { 10.5, 20 });
            Console.WriteLine($"10.5 + 20.5 = {result}");
            */
            dynamic calculator = new Calculator();
            Console.WriteLine($"10.2 + 2.5 = {calculator.Add(10.5 , 2.5)}");


        }
        public static string GetTypeAtRunTime<T>(T value)
        {
            return typeof(T).Name;
        }
    }
}