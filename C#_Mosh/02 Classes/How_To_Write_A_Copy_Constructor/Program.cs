namespace How_To_Write_A_Copy_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
    
             -link1 :  https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-write-a-copy-constructor

             */

            Person person1 = new Person("Youssef Baba", 25);
            Person person2 = new Person(person1);
            person2.Name = "Mohamed Zidani";
            person2.Age = 30;
            Console.WriteLine(person1.Detail());
            Console.WriteLine(person2.Detail());
        }
    }
}