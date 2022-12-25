namespace Multicast_Delegates
{
    public class RectangleOne
    {
        public double GetArea(double width, double height)
        {
            return width * height;
        }
        public double GetPerimeter(double width, double height)
        {
             return (width + height) * 2;
        }
        public double GetDiagonal(double width, double height)
        {
             return Math.Sqrt((width * width) + (height * height));
        }
    }
}
