
namespace Instance_And_Static_Constructors
{
    internal class SimpleClass
    {
        // Fields

        // readonly field is only assigned in field declaration and in constructor in the same class.

        public static int Value1 { get; set; }
        public static int Value2 { get; private set; }
        public readonly static int Value3 = 30;
        public static int Value4 { get; } = 40; // is look like readonly

        public static long BaseLine { get; }


        // Constructors
        static SimpleClass()
        {
            Value1 = 10;
            Value2 = 20;
            Value3 = 30;
            Value4 = 40;
        }
        public static void Display()
        {
            Value1 = 100;
            Console.WriteLine($"Value1 = {Value1}");
            Value2 = 200;
            Console.WriteLine($"Value2 = {Value2}");
            //Value3 = 300; // Error Because Value3 is readonly
            Console.WriteLine($"Value3 = {Value3}");
            //Value4 = 400;
            Console.WriteLine($"Value3 = {Value4}");
        }





    }
}
