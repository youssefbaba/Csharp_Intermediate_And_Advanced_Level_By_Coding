
namespace Method_Overriding_Test1
{
    public class Employee : Person
    {
        // Fields
        public double Salary { get; set; }
        public string Designation { get; set; }

        // Constructors
        public Employee(double salary, string designation, string name, int age) : base(name, age)
        {
            Salary = salary;
            Designation = designation;
        }

        // Methods
        public new void Work()  // we use new keyword to hide base class member
        {
            Console.WriteLine($"It earns...");
        }

        public override void Display()
        {
            Console.WriteLine($"Is employee");
        }

    }
}
