namespace Garbage_Collection_Net_Core_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://www.decodejava.com/csharp-garbage-collection.htm 
             - link2 : https://stackoverflow.com/questions/54316893/destructor-in-c-sharp-basic-program-does-not-work-output-missing
             - .NET Core does not run finalizers (Destructor) at the end of the program
             - .NET Framework makes every reasonable effort to call finalizers for objects that haven't yet been garbage collected, unless such cleanup has been suppressed (by a call to the library method GC.SuppressFinalize, for example). .NET 5 (including .NET Core) and later versions don't call finalizers as part of application termination.
            
             */

            ////Automatically execution Garbage Collection :
            //for (int i = 0; i < 5; i++)
            //{
            //    MyClass myClass = new MyClass(i);
            //}

            // Manually forcing the execution of Garbage Collection :

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