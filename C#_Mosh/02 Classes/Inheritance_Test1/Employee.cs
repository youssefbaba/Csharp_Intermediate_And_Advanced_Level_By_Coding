
namespace Inheritance_Test1
{
    public class Employee // Base class
    {
        // Fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public static int NumberOfInstanceBaseClass = 0;

        // Constructor
        public Employee()
        {
            NumberOfInstanceBaseClass++;
        }

        // Methods
        public void PrintFullName()
        {
            Console.WriteLine($"FullName = {FirstName} {LastName}");
        }
    }
}
