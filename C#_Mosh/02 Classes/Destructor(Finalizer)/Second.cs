
namespace Destructor_Net_Core
{
    internal class Second : First
    {
        // Constructor :
        public Second()
        {
            Console.WriteLine($"Second is created");
        }
        // Destructor :
        ~Second()
        {
            Console.WriteLine($"Second is destroyed");
        }
    }
}
