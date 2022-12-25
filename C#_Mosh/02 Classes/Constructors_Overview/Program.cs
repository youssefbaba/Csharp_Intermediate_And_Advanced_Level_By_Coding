namespace Constructors_Overview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 :https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
             */

            Person person1 = new Person(); // _firstName = null , _lastName = null 
            Person person2 = new Person("Youssef", "Baba"); // _firstName = Youssef , _lastName = Baba

            Adult adult = new Adult("Hassna", "Baba");

            Child child = new Child("John", "Doe");

        }
    }
}