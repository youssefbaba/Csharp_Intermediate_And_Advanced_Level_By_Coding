namespace Interfaces_Part2
{
    internal class MultipleInheritance : Interface1, Interface2
    {
        // Methods
        public void Test() // Implementation
        {
            Console.WriteLine("Interfaces method implemented in child class.");
        }
        void Interface1.Show() // Explicit implementation
        {
            Console.WriteLine("Declared in Interface1 and implemented in child class");
        }
        void Interface2.Show() // Explicit implementation
        {
            Console.WriteLine("Declared in Interface2 and implemented in child class");
        }
    }
}
