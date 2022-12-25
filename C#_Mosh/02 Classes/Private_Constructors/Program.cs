namespace Private_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/private-constructors
             - Private constructors are used to prevent creating instances of a class when there are no instance fields or methods
             */

            //Counter counter = new Counter(); // Error because the constructor is inaccessible (private constructor)
            Console.WriteLine($"{Counter.CurrentCounter}"); 
            Console.WriteLine($"{Counter.Description ?? "null"}"); 
            Counter.CurrentCounter = 100;
            Counter.Description = "Description text";
            Counter.IncrementCounter();
            Console.WriteLine($"New count : {Counter.CurrentCounter}");
            Console.WriteLine($"Description : {Counter.Description}");

        }

    }
}