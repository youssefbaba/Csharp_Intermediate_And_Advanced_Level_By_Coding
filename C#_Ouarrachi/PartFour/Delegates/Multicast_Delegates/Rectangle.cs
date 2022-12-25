namespace Multicast_Delegates
{
    public class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine($"Area = {width * height}");
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine($"Perimeter = {(width + height) * 2}");
        }
        public void GetDiagonal(double width, double height)
        {
            Console.WriteLine($"Diagonal = {Math.Sqrt((width * width) + (height * height))}");
        }
    }
}