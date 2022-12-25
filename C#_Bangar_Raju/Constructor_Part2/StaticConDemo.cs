
namespace Constructor_Part2
{
    internal class StaticConDemo
    {
        /*
         - If you don't provide a static constructor to initialize static fields, the C# compiler initializes static fields to their default value .(implicit static constructor)
         - A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed only once. It is called automatically at most one time before the first instance is created or any static members are referenced.
         - A static constructor doesn't take access modifiers or have parameters.
         - A class or struct can only have one static constructor.
         - Static constructors cannot be inherited or overloaded.
         - A static constructor cannot be called directly and is only meant to be called by the common language runtime (CLR). It is invoked automatically.
         - A static constructor runs before an instance constructor
         */

        static void Main()
        {
            StaticConDemoTwo staticConDemoTwo = new StaticConDemoTwo(10);
            staticConDemoTwo.Display();
            StaticConDemoTwo staticConDemoTwo1 = new StaticConDemoTwo(20);
            staticConDemoTwo1.Display();
        }
    }
    internal class StaticConDemoTwo
    {
        // Fields
        static DateTime _globalStartTime;  // Static field
        int _value; // Insatnce field


        // Constructors
        public StaticConDemoTwo(int value)
        {
            Console.WriteLine("Instance constructor called");
            _value = value;
        }
        static StaticConDemoTwo()  // is private and parameterless and is called one time
        {
            Console.WriteLine("Static constructor called");
            _globalStartTime = DateTime.Now;
        }

        public void Display() // Instance method
        {
            Console.WriteLine($"GlobalStartTime = {_globalStartTime}");
            Console.WriteLine($"Value = {_value}");
        }
    }
}
