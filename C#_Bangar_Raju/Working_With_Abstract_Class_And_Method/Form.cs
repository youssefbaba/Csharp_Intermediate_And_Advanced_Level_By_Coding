namespace Working_With_Abstract_Class_And_Method
{
    internal abstract class Form
    {
        // Feilds
        public const float Pi = 3.14f;

        // Properties 
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }

        // Methods
        public abstract double GetArea();
    }
}
