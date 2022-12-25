
namespace Private_Constructors
{
    public class Counter  // this calss contains only static members (static property and static method)
    {
        // Properties
        public static int CurrentCounter { get; set; } // Static property
        public static string Description { get; set; } // Static property

        // Constructors 
        private Counter() // private constructor = special instance constructor
        {
        }

        // Methods
        public static int IncrementCounter() // Static Method
        {
            return ++CurrentCounter ;
        }

        public class NestedClass
        {
           Counter counter = new Counter(); // for a nested class it can instantiate the class which has private constructor
        }
    }
}
