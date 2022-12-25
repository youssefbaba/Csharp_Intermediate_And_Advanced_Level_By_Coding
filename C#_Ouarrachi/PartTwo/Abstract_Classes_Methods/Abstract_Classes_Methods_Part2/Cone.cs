namespace Abstract_Classes_Methods_Part2
{
    public class Cone : Shape
    {
        // Constructors
        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }


        // Methods
        public override double GetArea()
        {
            return (Radius * Pi) * (Radius + Math.Sqrt((Height * Height) + (Radius * Radius)));
        }
    }
}
