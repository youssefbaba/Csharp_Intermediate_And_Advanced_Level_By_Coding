namespace Method_Overriding
{
    public class Shape
    {
        // Methods
        public virtual void Draw()
        {
            Console.WriteLine("Draw a shape.");
        }

        //Properties
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
