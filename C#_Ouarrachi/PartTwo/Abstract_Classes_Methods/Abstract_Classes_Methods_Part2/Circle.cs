namespace Abstract_Classes_Methods_Part2
{
    public class Circle : Shape
    {
        // Constructors
        public Circle(double radius)
        {
            Radius = radius;
        }


        // Methods
        public override double GetArea()
        {
            return Radius * Radius * Pi;
        }
    }

}
