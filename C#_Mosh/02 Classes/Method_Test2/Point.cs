namespace Method_Test2
{
    public class Point
    {
        // Fields
        public int X;
        public int Y;


        // Constructors
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        // Methods
        public void Move(int x, int y) // First Overload of Move method
        {
            X = x;
            Y = y;
        }
        public void Move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            Move(newLocation.X, newLocation.Y);
        }

    }
}
