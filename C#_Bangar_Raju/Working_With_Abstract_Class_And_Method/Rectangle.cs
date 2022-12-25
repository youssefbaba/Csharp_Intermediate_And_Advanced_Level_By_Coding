namespace Working_With_Abstract_Class_And_Method
{
    internal class Rectangle : Form
    {
        // Constructors
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Methods
        public override double GetArea() // Overrinding is Mandatory
        {
            return Width * Height;
        }
    }
}
