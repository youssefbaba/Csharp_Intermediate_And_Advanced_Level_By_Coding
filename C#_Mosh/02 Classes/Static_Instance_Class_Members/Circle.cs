
namespace Static_Instance_Class_Members
{
    /*
     - link1 : https://www.youtube.com/watch?v=cFQLmHCguGs&list=PLAC325451207E3105&index=20
     -  internal is the default if no access modifier is specified. for Classes, records, and structs declared directly within a namespace (in other words, that aren't nested within other classes or structs) .
     -  Class and struct members(Fields , Constructors , Methods , Delegates , Events , Indexers ... ), including nested classes and structs, have private access by default .
     -  To initialize instance fields we use instance constructors and to initialize static fields we use static constructor
     */
    class Circle  // internal class Circle
    {
        // Fields : 
        static double _pi; // private static double _pi ; => Static field
        int _radius; // private int _radius; => Instance field

        // Constructor : 
        // access modifiers are not allowed in static constructor
        static Circle() // Instance Constructor => private static Circle
        {
            Console.WriteLine($"Static Constructor Called");
            _pi = 3.141;
        }
        public Circle(int radius) // Instance Constructor
        {
            Console.WriteLine($"Instance Constructor Called");
            _radius = radius;
        }

        // Methods
         public double CalculateArea() // Instance Method
        {
            return _pi * Math.Pow(_radius , 2);
        }

        public static void Print() // Static Method
        {
            Console.WriteLine($"Class Circle .");
        }
    }
}
