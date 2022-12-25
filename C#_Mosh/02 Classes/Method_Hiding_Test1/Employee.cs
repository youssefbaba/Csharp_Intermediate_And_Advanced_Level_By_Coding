
namespace Method_Hiding_Test1
{
    public class Employee
    {
        // Fields
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Methods
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
