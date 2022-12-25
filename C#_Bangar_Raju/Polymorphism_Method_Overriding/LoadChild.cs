
namespace Polymorphism_Method_Overriding
{
    internal class LoadChild : LoadParent
    {
        // Methods
        
        // Overloading parent's Show method in child class
        public void Show(string s) // Overload 3
        {
            Console.WriteLine("Child's show method overload 3 is called.");
        }
        // Overriding parent's Test method in child class
        public override void Test() // Overriding
        {
            Console.WriteLine("Child's test method is called.");
        }
    }
}
