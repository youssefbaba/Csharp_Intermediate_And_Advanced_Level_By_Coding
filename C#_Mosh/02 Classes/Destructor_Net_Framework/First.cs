using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor_Net_Framework
{
    public  class First
    {
        // Constructor :
        public First()
        {
            Console.WriteLine("First is created.");
        }

        // Destructor : 
        ~First()
        {
            Console.WriteLine("First is destroyed.");

        }

    }
}
