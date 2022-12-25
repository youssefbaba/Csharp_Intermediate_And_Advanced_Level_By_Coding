namespace Multicast_Delegates_Part2
{
    // Defining the delegate
    public delegate void RecDelegate(double width, double height);
    public class RectangleOne
    {
        // Methods
        public void GetArea(double width, double height)
        {
            Console.WriteLine($"Area of rectangle : {width * height:F2}");
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine($"Perimeter of rectangle : {2 * (width + height):F2}");
        }
        public void GetDiagonalLength(double width, double height)
        {
            Console.WriteLine($"Diagonal Length of rectangle : {Math.Sqrt((width * width) + (height * height)):F2}");
        }
    }
}
