namespace Abstract_Classes_Methods_Part2
{
    internal class Program
    {
        /*
         - Abstract method : a method with abstract keyword and without any method body is known as abstract method.
         - Abstract class : a class under which we declare an abstract method is known as abstract class.
         - Entities : - Ractangle  - Circle  - Triangle  - Cone
                - Rectangle : Width , Height
                - Circle : Radius , Pi
                - Triangle : Width , Height
                - Cone  : Radius , Height , Pi
                
                - Common Attributes : Width , Height , Radius , Pi


         */
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12.5 ,20.5);
            Triangle triangle = new Triangle(15.5, 42.3);
            Circle circle = new Circle(14.6);
            Cone cone = new Cone(10.5, 12.4);
            Console.WriteLine($"Area of the rectangle : {rectangle.GetArea()}");
            Console.WriteLine($"Area of the triangle : {triangle.GetArea()}");
            Console.WriteLine($"Area of the circle : {circle.GetArea()}");
            Console.WriteLine($"Area of the cone : {cone.GetArea()}");
        }
    }
}