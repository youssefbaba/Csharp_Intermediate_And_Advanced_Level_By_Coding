
namespace Instance_And_Static_Constructors
{
    internal class Bus
    {

        /*
         - Bus class has a static constructor
         - When the first instance of Bus is created (bus1), the static constructor is invoked to initialize the class
         - the sample output verifies that the static constructor runs only one time, even though two instances of Bus are created
         - static constructor runs before the instance constructor runs.
         
         */

        // Fields
        //protected static readonly DateTime GlobalStartTime; // Static field
        protected static DateTime GlobalStartTime { get; } // Static field
        protected int RouteNumber { get; set; } // Non-static field

        // Constructors
        static Bus()  // Static constructor
        {
            GlobalStartTime = DateTime.Now;
            Console.WriteLine($"Static constructor sets global start time to {GlobalStartTime.ToLongTimeString()}");
        }
        public Bus(int routeNumber) // Instance constructor
        {
            RouteNumber = routeNumber;
            Console.WriteLine($"Bus {RouteNumber} is created.");
        }

        // Methods

        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - GlobalStartTime;
            Console.WriteLine($"{RouteNumber} is starting its route {elapsedTime.Milliseconds} minutes after global start time {GlobalStartTime.ToShortTimeString()}");
        }



    }
}
