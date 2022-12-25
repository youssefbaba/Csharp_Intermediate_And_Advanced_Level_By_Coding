namespace Working_With_Abstract_Class_And_Method
{
    internal class Cone : Form
    {
        // Constructors
        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        // Methods
        public override double GetArea() // Overrinding is Mandatory
        {
            return Pi * Radius * (Radius + Math.Sqrt((Height * Height) + (Radius * Radius)));
        }
    }
}
