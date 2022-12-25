
namespace Method_Overriding_Test1
{
    internal class Manager : Employee
    {
        // Constructors
        public Manager(double salary, string designation, string name, int age) : base(salary, designation, name, age)
        {
        }

        // Methods 
        public sealed override void Display() // keyword sealed : cannot override sealed inherited member
        {
            Console.WriteLine($"Is manager");
        }
    }
}
