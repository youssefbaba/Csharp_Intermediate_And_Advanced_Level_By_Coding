
namespace Access_Specifier_Demo1
{
    // Case 1 : Consuming members of a class from same class.
    public class FirstClass // Public class
    {
        // Methods
        private void PrivateMember() // Private method
        {
            Console.WriteLine("Private method.");
        }
        internal void InternalMember() // Internal method
        {
            Console.WriteLine("Internal method.");
        }
        protected void ProtectedMember() // Protected method
        {
            Console.WriteLine("Protected method.");
        }
        protected internal void ProtectedInternalMember() // Protected Internal method
        {
            Console.WriteLine("Protected Internal method.");
        }
        private protected void PrivateProtectedMember() // Private Protected method
        {
            Console.WriteLine("Private Protected method.");
        }
        public void PublicMember() // Public method
        {
            Console.WriteLine("Public method.");
        }

        static void Main(string[] args)
        {
            /*
             - Classes,structs declared directly within a namespace (in other words, that aren't nested within other classes or structs) can be either public or internal. internal is the default if no access modifier is specified.
             - Any class o struct members are private by default
            */

            FirstClass firstClass = new FirstClass();
            firstClass.PrivateMember();
            firstClass.InternalMember();
            firstClass.ProtectedMember();
            firstClass.ProtectedInternalMember();
            firstClass.PrivateProtectedMember();
            firstClass.PublicMember();
        }
    }
}