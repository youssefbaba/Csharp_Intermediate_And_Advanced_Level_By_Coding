namespace Abstract_Classes_And_Members
{
    public abstract class Shape
    {
        // Methods
        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard.");
        }
        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
        

        // Properties
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
