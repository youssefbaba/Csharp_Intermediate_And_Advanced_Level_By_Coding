using System;

namespace Destructor_Net_Framework
{
    public class Third:Second
    {
        // Constructor :
        public Third()
        {
            Console.WriteLine("Third is created.");
        }

        // Destructor : 
        ~Third()
        {
            Console.WriteLine("Third is destroyed.");

        }

    }
}
