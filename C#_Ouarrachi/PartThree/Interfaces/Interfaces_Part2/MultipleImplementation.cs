namespace Interfaces_Part2
{
    public class MultipleImplementation : Interface1, Interface2
    {
        // Methods

        // First Way : Implementation
        public void Test()
        {
            Console.WriteLine("Test Method Implemented");
        }

        // Second Way :  Explicit Implementation
        void Interface1.Show() // Accessible only by reference created by using instance of type MultipleImplementation
        {
            Console.WriteLine("Show Method From Interface1 Implemented");
        }
        void Interface2.Show() // Accessible only by reference created by using instance of type MultipleImplementation
        {
            Console.WriteLine("Show Method From Interface2 Implemented");
        }
    }
}
