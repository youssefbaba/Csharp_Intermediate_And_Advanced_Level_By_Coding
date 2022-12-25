namespace Exceptions_Exception_Handling_Part3
{
    public class FinallyDemo
    {
        static void Main(string[] args)
        {
            try
            {
                // - Open a file on hard disk => Exceptions : File not found or Not accessible
                // - Write into the file => Exception : Readonly file
            }
            catch (Exception)
            {
                // - Statements...
            }
            finally  // Mandatory execution
            {
                // - Close file
            }

            try
            {
                Console.Write("Enter first number : ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number : ");
                int number2 = int.Parse(Console.ReadLine());
                if (number2 == 1)
                {
                    return;
                }
                int result = number1 / number2;
                Console.WriteLine($"The result is : {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("The divisor cannot be a null number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be numeric.");
            }
            catch (Exception exp3)
            {
                Console.WriteLine(exp3.Message);
            }
            finally // Mandatory execution (when an exception occurred and the exception did not occur also)
            {
                Console.WriteLine("Finally block is executed.");
            }
            Console.WriteLine("End of the program.");
        } // End of the method
    }
}
