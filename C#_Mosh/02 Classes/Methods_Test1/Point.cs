
namespace Methods_Test1
{
    public class Point
    {
        // Properties
        public int X { get; set; }
        public int Y { get; set; }

        // Constructors
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Methods
        public void Move(int x, int y) // Overload1 of Move method
        {
            X = x;
            Y = y;
        }
        public void Move(Point newLocation) // Overload2 of Move method
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }

            Move(newLocation.X, newLocation.Y);
        }

        public override string ToString()
        {
            return $"Point( X = {X} , Y = {Y})";
        }

    }
}
