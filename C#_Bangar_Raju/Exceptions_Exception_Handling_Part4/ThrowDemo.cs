using MyNsp;
namespace Exceptions_Exception_Handling_Part4
{
    internal class ThrowDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int number2 = int.Parse(Console.ReadLine());
            if ((number2 % 2) != 0)
            {
                /*
                  ApplicationException ex = new ApplicationException();
                  throw ex;
                */
                //throw new ApplicationException();


                /*
                  ApplicationException ex = new ApplicationException("Attempted to divide by odd number");
                  throw ex;
                */
                //throw new ApplicationException("Attempted to divide by odd number");


                throw new DivideByOddNoException();

            }
            int result = number1 / number2;
            Console.WriteLine($"The result is : {result}");
            
        }
    }
}