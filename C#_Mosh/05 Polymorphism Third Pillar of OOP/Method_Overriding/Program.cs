namespace Method_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - Method Overriding : Modifying the implementation of an inherited method

            */

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);


        }
    }
}