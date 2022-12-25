
namespace Polymorphism_Method_Hiding
{
    internal class ParentClass
    {
        // Methods
        public virtual void Test1()
        {
            Console.WriteLine("Method Test1 from parent class.");
        }
        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class.");
        }
    }
}
