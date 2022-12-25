namespace Working_With_Abstract_Class_And_Method
{
    internal class Triangle : Form
    {
        // Constructors
        public Triangle(double width , double height)
        {
           Width = width;
           Height = height; 
        }

        // Methods
        public override double GetArea() // Overrinding is Mandatory
        {
            return 0.5 * Width * Height;
        }
    }
}
