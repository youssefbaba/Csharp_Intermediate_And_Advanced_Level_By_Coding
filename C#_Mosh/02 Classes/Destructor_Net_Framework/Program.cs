
using System;

namespace Destructor_Net_Framework
{
    public class Program
    {
        /*
            - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/finalizers
            - link2 : https://ericlippert.com/2015/05/18/when-everything-you-know-is-wrong-part-one/
            - link3 : https://dotnettutorials.net/lesson/destructor-csharp/
            -  When an application terminates, .NET Framework makes every reasonable effort to call finalizers for objects that haven't yet been garbage collected, unless such cleanup has been suppressed (by a call to the library method GC.SuppressFinalize, for example). .NET 5 (including .NET Core) and later versions don't call finalizers as part of application termination.
            - It's possible to force garbage collection by calling Collect, but most of the time, this call should be avoided because it may create performance issues.sed (by a call to the library method GC.SuppressFinalize, for example). .NET 5 (including .NET Core) and later versions don't call finalizers as part of application termination.
         */
        static void Main(string[] args)
        {

            
            DestructorDemo obj1 = new DestructorDemo(1);
            DestructorDemo obj2 = new DestructorDemo(2);


            obj1 = null; //Making obj1 for Garbage Collection There is no guarantee that the GC runs .


            GC.Collect(); // It causes a collection to happen
            GC.WaitForPendingFinalizers();  // force the finalizer to run


            DestructorDemo obj3 = new DestructorDemo(3);
           


            GC.SuppressFinalize(obj2); // causes finalization to be suppressed
            //GC.SuppressFinalize(obj3); // causes finalization to be suppressed



            Third t = new Third();
            t = null;







        }
    }
}
