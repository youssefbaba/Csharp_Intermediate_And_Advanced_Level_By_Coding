namespace BaseKeyword
{
    internal class Shape
    {
        // Properties
        public int X { get; set; }
        public int Y { get; set; }


        // Constructors
        public Shape()
        {
            Console.WriteLine("Parameter-less constructor of parent class invoked");
        }
        public Shape(int x, int y)
        {
            Console.WriteLine("Parameterized constructor of parent class invoked");
            X = x;
            Y = y;
        }
        

        // Methods
        public string Print()
        {
            return $"X = {X} ; Y = {Y}";
        }
    }
}
