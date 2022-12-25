
namespace Classes_Introduction_To_Classes
{
    public  class ChildClass : ParentClass
    {
        // Constructor
        public ChildClass():base("Derived class controlling Parent class")
        {
            Console.WriteLine($"ChildClass Constructor Called.");
        }
    }
}
