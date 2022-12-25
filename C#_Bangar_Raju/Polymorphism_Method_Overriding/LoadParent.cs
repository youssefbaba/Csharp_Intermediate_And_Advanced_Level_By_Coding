

namespace Polymorphism_Method_Overriding
{
    internal class LoadParent
    {

        // Methods
        public void Show() // Overload 1
        {
            Console.WriteLine("Parent's show method overload 1 is called.");
        }
        public void Show(int i) // Overload 2
        {
            Console.WriteLine("Parent's show method overload 2 is called.");
        }
        public virtual void Test() // overridable
        {
            Console.WriteLine("Parent's test method is called.");
        }

    }
}
