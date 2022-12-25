namespace Method_Overriding
{
    public class Canvas
    {
        // Methods
        public void DrawShapes( List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
