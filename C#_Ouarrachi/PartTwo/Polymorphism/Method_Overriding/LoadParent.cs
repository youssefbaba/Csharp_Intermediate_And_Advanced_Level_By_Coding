namespace Method_Overriding
{
    internal class LoadParent
    {
        // Methods
        public void Show() // Overload 1 of Show method
        {
            Console.WriteLine("Parent's show method is called.");
        }
        public void Show(int value) // Overload 2 of Show method
        {
            Console.WriteLine("Parent's show method is called.");
        }
        public virtual void Test() // Overridable method
        {
            Console.WriteLine("Parent's test method is called.");
        }
        public virtual void Print() // Overridable method
        {
            Console.WriteLine("Parent's print method is called.");
        }
    }
}
