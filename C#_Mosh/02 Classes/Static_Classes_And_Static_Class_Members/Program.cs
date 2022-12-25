using System.Xml.Schema;

namespace Static_Classes_And_Static_Class_Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
             - link2 : https://www.decodejava.com/csharp-static-keyword.htm
             - link3 : https://dotnettutorials.net/lesson/static-class-in-csharp/
             - .NET runtime guarantees to a static class to be loaded and to have its fields initialized and its static constructor called before the class is referenced for the first time in your program. A static constructor is only called one time
             - A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed once only. It is called automatically before the first instance is created or any static members are referenced
             */

            //UtilityClass utilityClass = new UtilityClass(); // Error because a static class cannot be instantiated.
            Console.WriteLine($"Initial value = {UtilityClass.Value}"); // 0
            UtilityClass.Value = 100;
            UtilityClass.DisplayValue(); // 100


            double amount = -3.456;
            Console.WriteLine(Math.Abs(amount)); // 3.456
            Console.WriteLine(Math.Round(amount)); // -3
            Console.WriteLine(Math.Floor(Math.Abs(amount))); // 3


            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");
            Console.Write(":");
            string selection = Console.ReadLine();
            double fahrenheit = 0;
            double celsius = 0;
            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    fahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine() ?? "0");
                    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
                    break;

                case "2":
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine() ?? "0");
                    Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
                    break;

                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }

            Automobile autombile1 = new Automobile();
            autombile1.Module = "BMW";
            autombile1.DisplayOne();
            Automobile.NumberOfWheels = 4;
            Console.WriteLine($"Automobile.NumberOfWheels = {Automobile.NumberOfWheels}");
            Automobile.DisplayTwo();
            for (int i = 0; i < 5; i++)
            {
                Automobile automobile2 = new Automobile();
            }
            Console.WriteLine($"Number of objects that are created until now = {Automobile.NumberOfObjects}");
            double val = Automobile.Amount; // const field is essentially static in its behavior  Name_Class.Cont_Field
            Console.WriteLine(val);







        }
    }
}