namespace PartialClass
{
    public partial class Employee
    {
        // Methods
        public void DoWork()
        {
            Console.WriteLine("DoWork Invoked");
        }
    }

    // The nested class can be partial inside athoer partial class
    public partial class ClassWithNestedClass
    {

        partial class NestedClass
        {
            public void Test1()
            {
                // Some statements here ...
            }
        }
    }

    public partial class Coords
    {
        // Fields
        private int _x;
        private int _y;


        // Constructors
        public Coords(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    partial interface ITest
    {
        void Interface_Test1();
    }

    partial struct StructTest
    {
        public void Test1()
        {
            // Some Statement here ...
        }
    }
}
