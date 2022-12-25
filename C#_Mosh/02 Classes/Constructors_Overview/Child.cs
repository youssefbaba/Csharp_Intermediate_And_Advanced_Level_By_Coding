
namespace Constructors_Overview
{
    public class Child : Person
    {
        // using expression body definition :

        // Fields
        private static int _maximumAge;
        private static string _address; // default value of _address is null

        // Constructors
        public Child(string firstName , string lastName):base(firstName ,lastName)
        {
        }
        static Child() => _maximumAge = 20;

        // Remaining implementation of Child class.
    }
}
