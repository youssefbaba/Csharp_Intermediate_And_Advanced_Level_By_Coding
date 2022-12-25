
namespace Instance_And_Static_Constructors
{
    internal class TestClass
    {
        // Fields
        public static long BaseLine { get; }

        // Constructors
        static TestClass() // by default is private
        {
            BaseLine = DateTime.Now.Ticks;
            Console.WriteLine("Static constructor called");
        }

    }
}
