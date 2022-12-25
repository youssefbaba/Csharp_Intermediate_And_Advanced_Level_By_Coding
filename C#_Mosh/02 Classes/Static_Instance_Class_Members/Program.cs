namespace Static_Instance_Class_Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Console.WriteLine($"AreaOne = {circle1.CalculateArea():0.000}");


            Circle circle2 = new Circle(6);
            Console.WriteLine($"AreaTwo = {circle2.CalculateArea():0.000}");


            //circle1.Print(); // Error
            //Circle.CalculateArea(); // Error
            Circle.Print();




        }
    }
}