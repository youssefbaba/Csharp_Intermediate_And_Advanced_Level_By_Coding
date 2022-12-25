namespace Constant
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - Const field has approximately same behavior of static field.
             - We cannot access to const field with an instance of reference.
             - One constant copy of it shared between all object.
             - The constant must be initialized when declaring
             - its value cannot be changed after initialization
             - Const field can be only initialized by value type
             */

            Circle circle = new Circle();
            // Console.WriteLine(circle._pi); // Error : We cannot access to const field with an instance of reference.
            Console.WriteLine($"Pi = {Circle._pi}");




        }
    }
}