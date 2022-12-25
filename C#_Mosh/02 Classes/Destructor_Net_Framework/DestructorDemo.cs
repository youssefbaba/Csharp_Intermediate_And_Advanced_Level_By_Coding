using System;

namespace Destructor_Net_Framework
{
    public class DestructorDemo
    {
        // Fields : 
        public int Value { get; set; }

        // Constructor :
        public DestructorDemo(int value)
        {
            Value = value;
            Console.WriteLine($"Object {Value} is created");
        }

        // Destructor : 
        ~DestructorDemo()
        {
            Console.WriteLine($"Object {Value} is destroyed");
        }
    }
}
