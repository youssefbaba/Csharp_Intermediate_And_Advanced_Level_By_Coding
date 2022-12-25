
using System.Reflection;

namespace Static_Classes_And_Static_Class_Members
{
    public class Automobile // Non-static class
    {
        // Fields
        public string Module { get; set; } // non-static field
        public static int NumberOfWheels { get; set; } // static field
        public static int NumberOfObjects { get; set; }
        //public static const double Amount = 3.14; // field cannot be declared as static const
        public const double Amount = 3.14; // const field is essentially static in its behavior

        // Constructors
        public Automobile()
        {
            NumberOfObjects++;
        }

        public static int SizeOfGasTank // static property
        {
            // Static methods and properties cannot access non-static fields and events in their containing type
            get
            {
                //string module = Module; // Static methods and properties cannot access non-static fields and events in their containing type
                //EventHandler handler = ThresholdReached; // Static methods and properties cannot access non-static fields and events in their containing type
                return 15;
            }
        }

        public void DisplayOne() // Non-static void
        {
            Console.WriteLine($"Non-static method");
        }
        public static void DisplayTwo() // static void
        {
            //string module = Module; // Static methods and properties cannot access non-static fields and events in their containing type
            //EventHandler handler = ThresholdReached; // Static methods and properties cannot access non-static fields and events in their containing type

            Console.WriteLine($"static method");
        }

        public event EventHandler ThresholdReached; // Non-static event

        /*
         EventHandler handler = ThresholdReached;
        handler?.Invoke(this, e);
         
         */
    }

}
