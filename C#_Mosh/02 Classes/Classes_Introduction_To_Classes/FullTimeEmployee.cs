
namespace Classes_Introduction_To_Classes
{
    public class FullTimeEmployee : Employee  // derived class
    {
        // Fields
        public float YearlySalary { get; set; }

        // Constructor
        public FullTimeEmployee()
        {
            Console.WriteLine($"FullTimeEmployee is created.");
        }
    }
}
