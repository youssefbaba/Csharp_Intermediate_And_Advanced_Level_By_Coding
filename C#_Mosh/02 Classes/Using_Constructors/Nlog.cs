
namespace Using_Constructors
{
    public static class Nlog
    {
        // Fields 
        public static int Value { get; set; }
        public static double e;

        // Constructor
        static Nlog()
        {
            Value = 100;
            e = Math.E;
        }
    }
}
