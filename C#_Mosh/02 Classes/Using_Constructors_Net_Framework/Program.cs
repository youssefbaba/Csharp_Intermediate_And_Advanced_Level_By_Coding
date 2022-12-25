
using System;

namespace Using_Constructors_Net_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Measurement measurement = new Measurement();  // Instantiation of struct
            Console.WriteLine($"Value = {measurement.Value}");
            Console.WriteLine($"Description = {measurement.Description ?? "null"}");

            Measurement measurement1 = new Measurement(12.5 , "Test");
            Console.WriteLine($"Value = {measurement1.Value}");
            Console.WriteLine($"Description = {measurement1.Description}");
        }
    }
}
