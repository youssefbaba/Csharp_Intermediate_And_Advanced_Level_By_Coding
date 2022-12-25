namespace PartialClass
{
    public partial class Employee
    {
        public void GoToLunch()
        {
            Console.WriteLine("GoToLunch Invoked");
        }
    }
    public partial class ClassWithNestedClass
    {
        partial class NestedClass
        {
            public void Test2()
            {
                // Some statements here ...
            }
        }
    }
    public partial class Coords
    {
        // Methods 
        public void PrintCoords()
        {
            Console.WriteLine($"(X = {_x} , Y = {_y})");
        }
    }
    partial interface ITest
    {
        void Interface_Test2();
    }
    partial struct StructTest
    {
        public void Test2()
        {
            // Some statements here ...
        }
    }
}
