
namespace Constructors_Overview
{
    public class Adult : Person
    {
        // Static Constructor

        // Fields
        private static int _minimumAge;
        private static string _city; // default value of _city is null

        // Constructors 
        public Adult(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        static Adult()
        {
            _minimumAge = 18;
        }

        // Remaining implementation of Adult class.

    }
}
