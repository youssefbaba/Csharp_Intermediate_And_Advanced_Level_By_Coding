namespace Method_Overriding
{
    internal class LoadChild : LoadParent
    {
        // Methods
        public void Show(string str) // Overload 3 of Show method
        {
            Console.WriteLine("child's show method is called.");
        }
        public override void Test()  // Overriding method 
        {
            Console.WriteLine("child's test method is called.");
        }

    }
}
