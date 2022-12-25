
using System.Runtime.InteropServices;

namespace Garbage_Collection_Net_Core_Test2
{
    internal class Program
    {
        public static void ShortLives(Person parent)
        {
            Person fred = new Person
            {
                Name = "Fred",
                ChildOne = new Person { Name = "Bamm-Bamm" }
            };
            parent.ChildTwo = fred.ChildOne;
            //Console.WriteLine($"{parent.ChildTwo.Name}");
        }
        public static void Run()
        {
            Person wilma = new Person
            {
                Name = "Wilma",
                ChildOne = new Person { Name = "Pebbles" }
            };
            ShortLives(wilma);
            //Console.WriteLine($"{wilma.ChildTwo.Name}");
            Console.WriteLine($"Leaving 'ShortLives'... ");
            GC.Collect();
            GC.WaitForPendingFinalizers(); // program won't terminate before the finalize have been called
        }
        static void Main(string[] args)
        {
            Run();
            Console.WriteLine("\nLeaving 'Run'...");
            GC.Collect();
            GC.WaitForPendingFinalizers(); // program won't terminate before the finalize have been called


            /*
            IntWrapper wrapped1 = new IntWrapper();
            IntWrapper wrapped2 = new IntWrapper();
            IntWrapper wrapped3 = new IntWrapper();
            wrapped1.WrappedInt = 1;
            wrapped2.WrappedInt = 2;
            wrapped3.WrappedInt = 3;
            GC.Collect();
            wrapped2 = null;
            GC.Collect();
            */


        }
    }
}