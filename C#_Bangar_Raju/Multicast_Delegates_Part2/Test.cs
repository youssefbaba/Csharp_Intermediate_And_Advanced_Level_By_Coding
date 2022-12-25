namespace Multicast_Delegates_Part2
{
    public class Test
    {
        static void Main(string[] args)
        {
            RectangleOne rectangleOne = new RectangleOne();

            /*
             

            RecDelegate recDelegate1 = rectangleOne.GetArea; // Instantiating the delegate
            recDelegate1.Invoke(40.12, 15.32); // Calling the delegate

            
            RecDelegate recDelegate2 = rectangleOne.GetPerimeter; // Instantiating the delegate
            recDelegate2.Invoke(40.12, 15.32); // Calling the delegate

            
            RecDelegate recDelegate3 = rectangleOne.GetDiagonalLength; // Instantiating the delegate
            recDelegate3.Invoke(40.12, 15.32); // Calling the delegate


            */

            RecDelegate recDelegate = rectangleOne.GetArea;
            recDelegate = recDelegate + rectangleOne.GetPerimeter + rectangleOne.GetDiagonalLength;
            recDelegate.Invoke(40.12, 15.32);
            Console.WriteLine();
            recDelegate.Invoke(20.14, 10.25);
        }
    }
}