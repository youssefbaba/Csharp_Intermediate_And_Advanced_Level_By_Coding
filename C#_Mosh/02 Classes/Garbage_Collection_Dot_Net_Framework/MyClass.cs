
using System;

namespace Garbage_Collection_Dot_Net_Framework
{
    public class MyClass
    {
        // Fields :
        public int Num;

        // Constructors : 
        public MyClass(int number)
        {
            Num = number;
            Console.WriteLine($"Creating an object {Num}");
        }

        // Destructor : 
        // we use destructor (finalizer) to destroy the object when the instance is no longer required .
        ~MyClass()
        {
            Console.WriteLine($"Destructing an object {Num}");
        }
    }
}
