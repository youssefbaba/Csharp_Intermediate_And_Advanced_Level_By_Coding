namespace Multicast_Delegates
{
    // Defining a delegate :
    public delegate void DelegateRectangle(double width, double height);
    public class TestRectangle
    {
        /*
         - A delegate is going to hold the reference of a method .
         - In multicast delegate a delegate can hold the reference of more than one method.

         */
        static void Main(string[] args)
        {
            Rectangle rectangle= new Rectangle();
            /*
            rectangle.GetArea(12.34, 56.78);
            rectangle.GetPerimeter(12.34, 56.78);
            rectangle.GetDiagonal(12.34, 56.78);
            */

            // Instantianting the delegate :
            //DelegateRectangle obj = new DelegateRectangle(rectangle.GetArea);  // First way for instantiating the delegate
            DelegateRectangle obj = rectangle.GetArea;  // Second way for instantiating the delegate
            obj = obj + rectangle.GetPerimeter + rectangle.GetDiagonal;
            //obj(12.34, 56.78);
            obj.Invoke(12.34, 56.78);


            Console.WriteLine();
            Console.WriteLine();


            obj.Invoke(10.5, 15.5);


            Console.WriteLine();
            Console.WriteLine();


            obj = obj - rectangle.GetDiagonal - rectangle.GetPerimeter;
            //obj(12.34, 56.78);
            obj.Invoke(12.34, 56.78);


            Console.WriteLine();
            Console.WriteLine();


            obj.Invoke(10.5, 15.5);
        }
    }
}