
using System;

namespace Garbage_Collection_Dot_Net_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             - link1 :https://www.decodejava.com/csharp-garbage-collection.htm
             - link2 : https://dotnettutorials.net/lesson/garbage-collector/
             */
            // automaticlly execution Garbage Collection :
            /*
             - when the termination of the program, the garbage collector runs,and calls the destructor(finalizer) of the class,before it takes the unreferenced object off the Heap memory.
            - .NET Framework makes every reasonable effort to call finalizers for objects that haven't yet been garbage collected, unless such cleanup has been suppressed (by a call to the library method GC.SuppressFinalize, for example). .NET 5 (including .NET Core) and later versions don't call finalizers as part of application termination.
             */

            //for (int i = 0; i < 5; i++)
            //{
            //    MyClass myClass = new MyClass(i);
            //    //GC.SuppressFinalize(myClass); // to stop calling Finalizer
            //}


            // Manually forcing the execution of Garbage Collection : this call should be avoided because it may create performance issues

            Console.WriteLine($"mount of used memory at the beginning of program : {GC.GetTotalMemory(false)}");
            MyClassTwo myClassTwo;
            for (int i = 0; i < 100000; i++)
            {
                myClassTwo = new MyClassTwo(i);

            }
            Console.WriteLine($"Amount of used memory after creating 100000 objects : {GC.GetTotalMemory(false)}");
            GC.Collect();
            Console.WriteLine($"Amount of used memory after running garbage collector : {GC.GetTotalMemory(true)}");

        }
    }
}
