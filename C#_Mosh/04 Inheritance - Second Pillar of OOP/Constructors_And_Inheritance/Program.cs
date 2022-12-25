namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - during instantiating the object base class constructors are always executed first
             - base class constructors are not inherited so we need to redefine them in the derived class
             - derived class constructors implicitly calls to parameterless base class

            */
            Car car1 = new Car();
            Car car2 = new Car("ABCD12345");

        }
    }
}