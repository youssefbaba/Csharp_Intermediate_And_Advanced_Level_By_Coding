namespace Inheritance_Part2
{
    internal class ClassTwo : ClassOne
    {
        /*
         - Object
            - ClassOne
                - ClassTwo
         */
        // Constructors

        public ClassTwo()
        {
            Console.WriteLine("Child class parameter-less constructor invoked.");
        }
        public ClassTwo(int value)
        {
            Console.WriteLine("Child class parameterized constructor invoked.");
        }
        public ClassTwo(int value1 , int value2) : base(value1)
        {
            Console.WriteLine($"Child class parameterized constructor invoked. {value2}");
        }
        // Methods
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
    }
}
