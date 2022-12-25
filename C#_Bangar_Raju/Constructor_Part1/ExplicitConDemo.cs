
namespace Constructor_Part1
{
    internal class ExplicitConDemo
    {
        // Fieldsm
        static int counter = 0;

        // Constructors
        public ExplicitConDemo() // Explicit parameterless constrcutor
        {
            Console.WriteLine("Explicit constructor called");
            Console.WriteLine($"Creation of object {counter}");
            counter++;
        }

        // Methods
        static void Main()
        {
            ExplicitConDemo explicitConDemo1 = new ExplicitConDemo(); // calling explicit parameterless constructor
            ExplicitConDemo explicitConDemo2 = new ExplicitConDemo(); // calling explicit parameterless constructor
            ExplicitConDemo explicitConDemo3 = new ExplicitConDemo(); // calling explicit parameterless constructor
        }
    }
}
