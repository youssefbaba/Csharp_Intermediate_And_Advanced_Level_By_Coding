namespace Exception_Handling_Abuse
{
    public class Test
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter Numerator : ");
                int numerator = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter Denominator : ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine($"The result : {result}");
            }
            catch (FormatException)
            {
                //Console.WriteLine($"{exp1.GetType().Name} : {exp1.Message}");
                Console.WriteLine("Please try to enter a number .");
            }
            catch (OverflowException)
            {
                //Console.WriteLine($"{exp2.GetType().Name} : {exp2.Message}");
                Console.WriteLine($"Only numbers between {int.MinValue} and {int.MaxValue} are allowed .");
            }
            catch (DivideByZeroException)
            {
                //Console.WriteLine($"{exp3.GetType().Name} : {exp3.Message}");
                Console.WriteLine($"Denominator cannot be zero .");
            }
            catch (Exception exp)
            {
                Console.WriteLine($"{exp.GetType().Name} : {exp.Message}");
            }
            Console.WriteLine("The end od the programm");
 


        }
    }
}