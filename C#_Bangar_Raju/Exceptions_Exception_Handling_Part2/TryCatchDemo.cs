namespace Exceptions_Exception_Handling_Part2
{
    public class TryCatchDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number : ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number : ");
                int number2 = int.Parse(Console.ReadLine());
                int result = number1 / number2;
                Console.WriteLine($"The result is : {result}");
            }
            catch (DivideByZeroException exp1)
            {
                Console.WriteLine(exp1.Message);
                //Console.WriteLine("The divisor cannoit be a null number.");
            }
            catch (FormatException exp2)
            {
                //Console.WriteLine(exp2.Message);
                Console.WriteLine("Input must be numeric.");
            }
            catch (Exception exp3)
            {
                Console.WriteLine(exp3.Message);
            }
            Console.WriteLine("End of the program.");
        }
    }
}
