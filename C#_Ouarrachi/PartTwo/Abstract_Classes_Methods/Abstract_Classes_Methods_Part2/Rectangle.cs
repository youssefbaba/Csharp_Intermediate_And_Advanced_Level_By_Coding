namespace Abstract_Classes_Methods_Part2
{
    public class Rectangle : Shape
    {
        // Constructors
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


        // Methods
        public override double GetArea()
        {
            return (Width * Height);    
        }   
    }
}
