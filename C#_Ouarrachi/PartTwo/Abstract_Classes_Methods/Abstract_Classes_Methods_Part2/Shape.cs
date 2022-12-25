namespace Abstract_Classes_Methods_Part2
{
    public abstract class Shape // Abstract class
    {
        // Field
        public const double Pi = 3.41;


        // Methods
        public abstract double GetArea();   // Abstract class


        // Properties
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
    }
}
