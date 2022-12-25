namespace Multicast_Delegates
{
    // Defining a delegate :
    public delegate double DelegateRec(double width, double height);
    public class TestRectangleOne
    {
        static void Main(string[] args)
        {
            RectangleOne rec = new RectangleOne();
            Console.WriteLine($"Area = {rec.GetArea(10.5,15.5)}");
            Console.WriteLine($"Perimeter = {rec.GetPerimeter(10.5,15.5)}");
            Console.WriteLine($"Diagonal = {rec.GetDiagonal(10.5,15.5)}");

            
            Console.WriteLine();


            DelegateRec obj = rec.GetArea;
            obj = obj + rec.GetPerimeter + rec.GetDiagonal;
            double result1 = obj.Invoke(10.5, 15.5);
            Console.WriteLine(result1);  //  the result is Diagonal 


            Console.WriteLine();


            obj = obj - rec.GetDiagonal;
            double result2 = obj.Invoke(10.5, 15.5);
            Console.WriteLine(result2);  //  the result is Perimeter
        }
    }
}
