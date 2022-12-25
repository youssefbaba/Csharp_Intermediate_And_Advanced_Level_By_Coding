
namespace Instance_And_Static_Constructors
{
    public class Coords
    {
        // Fields
        public int X { get; set; }
        public int Y { get; set; }

        // Constructors
        public Coords() : this(0, 0)
        {
        }
        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"(X = {X} , Y = {Y})";
        }

    }
}
