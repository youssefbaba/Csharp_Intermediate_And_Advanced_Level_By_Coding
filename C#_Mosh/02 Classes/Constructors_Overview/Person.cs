
namespace Constructors_Overview
{
    public class Person
    {
        // Constructor syntax : 

        // Fields
        private string _firstName;
        private string _lastName;

        // Constructor
        public Person()
        {
        }
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        // Remaining implementation of Person class.
    }
}
