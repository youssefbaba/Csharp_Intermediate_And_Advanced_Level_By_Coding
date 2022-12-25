namespace PartialClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
             - link2 : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/partial-type
             */
            Person person = new Person("John", "Doe");
            person.Welcome();

            Employee employee = new Employee();
            employee.DoWork();
            employee.GoToLunch();


        }
    }
}