using System;

namespace Destructor_Net_Framework
{
    public class Second:First
    {
        // Constructor :
        public Second()
        {
            Console.WriteLine("Second is created.");
        }

        // Destructor : 
        ~Second()
        {
            Console.WriteLine("Second is destroyed.");

        }
    }
}
