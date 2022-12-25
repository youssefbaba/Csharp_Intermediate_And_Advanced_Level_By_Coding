
namespace Inheritance_Test1
{
    public class ChildClass : ParentClass
    {
        // Constructor
        //public ChildClass()
        //{
        //    Console.WriteLine($"ChildClass constructor called");
        //}

        public ChildClass() : base("Derived class controlling base class")
        {
            Console.WriteLine($"ChildClass constructor called");
        }
    }
}
