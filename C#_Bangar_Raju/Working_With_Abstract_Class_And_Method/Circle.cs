namespace Working_With_Abstract_Class_And_Method
{
    internal class Circle : Form
    {
        // Constructors
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Methods
        public override double GetArea() // Overrinding is Mandatory
        {
            return Pi * Radius * Radius;
        }
    }
}
