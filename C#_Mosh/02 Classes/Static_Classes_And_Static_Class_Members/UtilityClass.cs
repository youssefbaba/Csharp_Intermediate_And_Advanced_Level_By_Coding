
namespace Static_Classes_And_Static_Class_Members
{
    public static class UtilityClass
    {
        // Fields
        public static int Value { get; set; }
        
        // Constructor
        static UtilityClass() // By default is private
        {
            Console.WriteLine($"Static constructor called one time before static members are referenced");
        }

        // Methods 
        public static void DisplayValue()
        {
            Console.WriteLine($"Value = {Value}");
        }
    }

    //public class Child : UtilityClass // Eroor because cannot derive from static class
    //{

    //}
}
