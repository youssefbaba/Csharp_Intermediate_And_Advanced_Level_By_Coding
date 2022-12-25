
namespace Destructor_Net_Core
{
    public class DestructorDemo
    {
        // Fields : 
        public int Value { get; set; }

        // Constructor :
        public DestructorDemo(int value)
        {
            Value = value;
            Console.WriteLine("Constructor Object Created");
        }

        // Destructor : 
        ~DestructorDemo()
        {
            Console.WriteLine($"Object {Value} is Destroyed");
        }
    }
}
