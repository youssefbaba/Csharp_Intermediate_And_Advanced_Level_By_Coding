namespace Working_With_Abstract_Class_And_Method
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12.67, 56.78);
            Circle circle = new Circle(45.56);
            Cone cone = new Cone(20.35 ,10.2);
            Triangle triangle = new Triangle(25.4 ,11.5);
            Console.WriteLine($"Area of Rectangle : {rectangle.GetArea():F2}");
            Console.WriteLine($"Area of Circle : {circle.GetArea():F2}");
            Console.WriteLine($"Area of Cone : {cone.GetArea():F2}");
            Console.WriteLine($"Area of Triangle : {triangle.GetArea():F2}");

        }
    }
}