
namespace Constructor_Part2
{
    internal class CopyConDemo
    {
        // Fields 
        string _name;
        double _salary;

        // Constructors
        public CopyConDemo() // Parameterless constructor
        {
        }
        public CopyConDemo(string name , double salary) // Parameterized constructor
        {
            _name = name;
            _salary = salary;
        }
        public CopyConDemo(CopyConDemo copyConDemo) // Copy constructor
        {
            _name = copyConDemo._name;
            _salary = copyConDemo._salary;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($"Name = {_name ?? "null"} , Salary = {_salary}");
        }

        static void Main()
        {
            CopyConDemo copyConDemo1 = new CopyConDemo();
            copyConDemo1.Display();
            CopyConDemo copyConDemo2 = new CopyConDemo("John Doe" ,120000.500);
            copyConDemo2.Display();
            CopyConDemo copyConDemo3 = new CopyConDemo(copyConDemo2);
            copyConDemo3.Display();
        }
    }
}
