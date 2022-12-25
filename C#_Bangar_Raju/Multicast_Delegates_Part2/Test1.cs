namespace Multicast_Delegates_Part2
{
    public class Test1
    {
        static void Main(string[] args)
        {
            RectangleTwo rectangleTwo = new RectangleTwo();

            /*
             
            
            RecDelegateTwo recDelegate1 = rectangleTwo.GetArea; // Instantiating the delegate
            double area = recDelegate1.Invoke(20.14, 10.32); // Calling the delegate
            Console.WriteLine($"Area of rectangle : {area:F2}");


            RecDelegateTwo recDelegate2 = rectangleTwo.GetPerimeter; // Instantiating the delegate
            double perimeter = recDelegate2.Invoke(20.14, 10.32); // Calling the delegate
            Console.WriteLine($"Perimeter of rectangle : {perimeter:F2}");


            RecDelegateTwo recDelegate3 = rectangleTwo.GetDiagonalLength; // Instantiating the delegate
            double diagonalLength = recDelegate3.Invoke(20.14, 10.32); // Calling the delegate
            Console.WriteLine($"Diagonal Length of rectangle : {diagonalLength:F2}");
            

           */

            RecDelegateTwo recDelegate = rectangleTwo.GetArea; // Instantiating the delegate
            recDelegate = recDelegate + rectangleTwo.GetPerimeter + rectangleTwo.GetDiagonalLength;  // Instantiating the delegate
            double result = recDelegate.Invoke(20.14, 10.32);
            Console.WriteLine($"Result : {result:F2}");  // result = return value of the last method that's DiagonalLength()

        }
    }
}
