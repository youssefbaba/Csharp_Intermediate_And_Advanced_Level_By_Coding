namespace Multicast_Delegates
{
    public delegate double DelegateRectangle();
    public class Rectangle
    {
        // Methods
        public double AreaOfRectangle()
        {
            Console.WriteLine($"Are :  {Width * Height}");
            return Width * Height;
        }
        public double PerimeterOfRectangle()
        {
            Console.WriteLine($"Perimeter :  {0.5 * Width * Height}");
            return 0.5 * Width * Height;
        }
        public double DiagonalOfRectangle()
        {
            Console.WriteLine($"Diagonal :  {Math.Sqrt((Width * Width) + (Height * Height))}");

            return Math.Sqrt((Width * Width) + (Height * Height));
        }

        // Properties
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
