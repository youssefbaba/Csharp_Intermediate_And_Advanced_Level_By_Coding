
namespace Constructor_Part4
{
    internal class StaticInstanceConDemo
    {
        // Fields
        public static DateTime Date; // Static field
        public int Value; // Instance field

        // Constrcutors
        static StaticInstanceConDemo() // Static constructor
        {
            Date = DateTime.Now;  // Static constructor is used for initialazing the static data
            Console.WriteLine("Static constructor is called.");
        }
        public StaticInstanceConDemo()  // // Instance contructor (overload1)
        {
        }
        public StaticInstanceConDemo(int value) // Instance contructor (overload2)
        {
            Value = value; // Instance constructor is used for initialazing the instance data
            Console.WriteLine("Instance constructor is called.");
        }
    }
}
