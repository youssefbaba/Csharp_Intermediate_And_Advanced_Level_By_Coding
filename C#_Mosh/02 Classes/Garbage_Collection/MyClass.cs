
namespace Garbage_Collection_Net_Core_Test1
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
        //This may run at the termination of the program
        ~MyClass()
        {
            Console.WriteLine($"Destructing an object {Num}");
        }
    }
}
