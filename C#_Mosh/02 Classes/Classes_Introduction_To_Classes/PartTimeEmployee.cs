
namespace Classes_Introduction_To_Classes
{
    public class PartTimeEmployee : Employee   // derived class
    {
        // Fields
        public float HourlyRate { get; set; }

        // Constructor
        public PartTimeEmployee()
        {
            Console.WriteLine($"PartTimeEmployee is created.");
        }
    }
}
