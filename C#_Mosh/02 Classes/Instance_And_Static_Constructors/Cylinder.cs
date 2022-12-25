
namespace Instance_And_Static_Constructors
{
    internal class Cylinder : Circle
    {
        // Constructors
        public Cylinder(double radius, double height) : base(radius)
        {
            Y = height;
        }

        // Methods
        public override double Area()
        {
            return (2 * Pi * X * Y) + (2 * base.Area());
        }
    }
}
