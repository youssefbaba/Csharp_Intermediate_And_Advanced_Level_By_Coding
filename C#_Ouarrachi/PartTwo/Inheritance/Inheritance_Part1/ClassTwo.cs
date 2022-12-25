namespace Inheritance_Part1
{
    internal class ClassTwo : ClassOne
    {
        // Constructors
        public ClassTwo()
        {
            Console.WriteLine("Child class parameter-less constructor invoked.");
        }
        // Methods
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
    }
}
