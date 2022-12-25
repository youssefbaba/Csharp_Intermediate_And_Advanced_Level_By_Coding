namespace Instance_And_Static_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors
             - link2 :https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
             - link3 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
             - Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own. Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.
             - An abstract method is implicitly a virtual method.
             - A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.
            */


            // Instance Constructor : 

            Coords coord1 = new Coords();
            Console.WriteLine(coord1); //  => coord1.ToString()
            Coords coord2 = new Coords(1,3);
            Console.WriteLine(coord2); //  => coord2.ToString()


            double radius = 2.5;
            double height = 4.0;
            Circle ring = new Circle(radius);
            Console.WriteLine($"Area of the ring = {ring.Area():F4}");
            Cylinder tube = new Cylinder(radius , height);
            Console.WriteLine($"Area of the tube = {tube.Area():F4}");


            Person person = new Person(); // default parameterless constructor that is provided by C#
            Console.WriteLine($"Default age = {person.Age}");
            Console.WriteLine($"Default name = {person.Name}");


            // Static Constructor : 
            Console.WriteLine("#################");
            SimpleClass.Value1 = 1000;
            Console.WriteLine(SimpleClass.Value1);
            SimpleClass.Display();

            //SimpleClass.Value2 = 1000; // Error because Value2 is private
            Console.WriteLine(SimpleClass.Value2);
            SimpleClass.Display();

            //SimpleClass.Value3 = 3000; // Error because Value3 is readonly
            Console.WriteLine(SimpleClass.Value3);
            SimpleClass.Display();

            //SimpleClass.Value4 = 4000; 
            Console.WriteLine(SimpleClass.Value4);
            SimpleClass.Display();

            TestClass testClass = new TestClass();
            Console.WriteLine(TestClass.BaseLine);
            TestClass testClass1 = new TestClass();
            Console.WriteLine(TestClass.BaseLine + 10);

            Console.WriteLine("################");
            Bus bus1 = new Bus(1234);
            Bus bus2 = new Bus(5678);
            bus1.Drive();
            Thread.Sleep(30);
            bus2.Drive();













        }
    }
}