
namespace Destructor_Net_Core
{
    internal class First
    {
        // Constructor :
        public First()
        {
            Console.WriteLine($"First is created");
        }
        // Destructor :
        ~First()
        {
            Console.WriteLine($"First is destroyed");
        }
    }
}
