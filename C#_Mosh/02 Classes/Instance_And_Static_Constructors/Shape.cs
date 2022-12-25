
namespace Instance_And_Static_Constructors
{
    //abstract class Shape // default access modifier is internal
    internal abstract class Shape
    {
        // Fields
        public const double Pi = Math.PI;
        protected double X;
        protected double Y;

        // Constructors
        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Methods
        public abstract double Area();

    }
}
