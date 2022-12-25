namespace Exceptions_Exception_Handling_Part2
{
    internal class ExceptionDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 / number2;
            Console.WriteLine($"The result is : {result}");
            Console.WriteLine("End of the program.");
        }
    }
}