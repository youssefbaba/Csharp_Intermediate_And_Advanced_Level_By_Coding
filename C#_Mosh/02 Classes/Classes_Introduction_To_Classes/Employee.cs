
namespace Classes_Introduction_To_Classes
{
    public class Employee  // base class
    {
        // Fields
       public string FirstName { get; set; }
       public string LastName { get; set; } 
        public string Email { get; set; }

        // Constructor
        public Employee()
        {
            Console.WriteLine($"Employee is created.");
        }

        // Methods
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }
}
