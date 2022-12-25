
namespace Destructor_Net_Core
{
    internal class Third : Second
    {
        // Constructor :
        public Third()
        {
            Console.WriteLine($"Third is created");
        }
        // Destructor :
        ~Third()
        {
            Console.WriteLine($"Third is destroyed");
        }
    }
}
