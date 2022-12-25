
namespace Constructors
{
    public class Vehicle
    {
        // Fields
        private string _registrationNumber;


        // Constructors
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine($"Vehicle is being initialized. {registrationNumber}");

        }
    }
}
