
namespace Instance_And_Static_Constructors
{
    internal class Circle : Shape
    {
        // Constructors
        public Circle(double radius) : base(radius, 0)
        {
        }

        // Methods
        public override double Area()
        {
            return Pi * X * X;
        }
    }
}
