
namespace Using_Constructors
{
    public class Taxi
    {
        // Fields
        public bool IsInitialized { get; set; } // default value of IsInitialized field is false
        public int Number { get; set; }  // default value of Number field is 0

        // Constructors
        public Taxi() // Parameterless constructor
        {
            IsInitialized = true;
        }
    }
}
