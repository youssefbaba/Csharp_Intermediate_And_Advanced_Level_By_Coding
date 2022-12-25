
namespace Destructor_Net_Core
{
    internal class Program
    {
        /*
            - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/finalizers
            - link2 : https://ericlippert.com/2015/05/18/when-everything-you-know-is-wrong-part-one/
            - link2 : https://dotnettutorials.net/lesson/destructor-csharp/
        -  When an application terminates, .NET Framework makes every reasonable effort to call finalizers for objects that haven't yet been garbage collected, unless such cleanup has been suppressed (by a call to the library method GC.SuppressFinalize, for example). .NET 5 (including .NET Core) and later versions don't call finalizers as part of application termination.
        - It's possible to force garbage collection by calling Collect, but most of the time, this call should be avoided because it may create performance issues.
        - in .NET 5 (including .NET Core) and later versions you can't rely on destructor anymore 
         */
        static void Main(string[] args)
        {
            DestructorDemo obj1 = new DestructorDemo(1);
            DestructorDemo obj2 = new DestructorDemo(2);


            obj1 = null; //Making obj1 for Garbage Collection There is no guarantee that the GC runs .


            GC.Collect(); // It causes a collection to happen
            GC.WaitForPendingFinalizers();  // doesn't have any role from .NET 5 (including .NET Core) and later versions because it can't rely on destructor anymore 


            DestructorDemo obj3 = new DestructorDemo(3);


            GC.SuppressFinalize(obj2); // doesn't have any role from .NET 5 (including .NET Core) and later versions
            GC.SuppressFinalize(obj3); // doesn't have any role .NET 5 (including .NET Core) and later versions


            Third t = new Third();
            t = null;


        }
    }
}