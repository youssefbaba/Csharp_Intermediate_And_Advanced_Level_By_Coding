using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection_Net_Core_Test2
{
    public class Person
    {
        // Fields :
        public string Name { get; set; }
        public Person ChildOne { get; set; }
        public Person ChildTwo { get; set; }


        // Destructor : 
        ~Person()
        {
            Console.WriteLine($"Collecting {Name}.");
        }
    }
}
