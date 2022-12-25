namespace Multicast_Delegates_Part2
{
    // Defining the delegate
    public delegate double RecDelegateTwo(double width, double height);
    public class RectangleTwo
    {
        // Methods
        public double GetArea(double width, double height)
        {
            //Console.WriteLine($"Area of rectangle : {width * height:F2}");
            return width * height;
        }
        public double GetPerimeter(double width, double height)
        {
            //Console.WriteLine($"Perimeter of rectangle : {2 * (width + height):F2}");
            return 2 * (width + height);
        }
        public double GetDiagonalLength(double width, double height)
        {
            //Console.WriteLine($"Diagonal Length of rectangle : {Math.Sqrt((width * width) + (height * height)):F2}");
            return Math.Sqrt((width * width) + (height * height));
        }
    }
}
