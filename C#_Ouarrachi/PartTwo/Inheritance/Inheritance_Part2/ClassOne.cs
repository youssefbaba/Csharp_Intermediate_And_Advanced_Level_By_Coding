namespace Inheritance_Part2
{
    internal class ClassOne
    {
        /*
         - Object
            - ClassOne
         */
        // Constructors
        public ClassOne()
        {
            Console.WriteLine("Parent class parameter-less contructor invoked.");
        }
        public ClassOne(int value)
        {
            Console.WriteLine($"Parent class parameterized contructor invoked : {value}");
        }

        // Methods
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
