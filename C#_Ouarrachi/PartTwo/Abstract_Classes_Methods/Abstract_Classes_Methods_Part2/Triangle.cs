namespace Abstract_Classes_Methods_Part2
{
    public class Triangle : Shape
    {
        // Constructors
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


        // Methods
        public override double GetArea()
        {
            return (Width * Height) * 0.5;
        }
    }

}
