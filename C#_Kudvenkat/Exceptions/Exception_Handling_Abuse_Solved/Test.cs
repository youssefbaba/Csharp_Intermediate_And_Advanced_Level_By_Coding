namespace Exception_Handling_Abuse_Solved
{
    public class Test
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Please enter Numerator : ");

                int numerator;
                bool IsNumeratorConversionSucceful = int.TryParse(Console.ReadLine(), out numerator);
                if (IsNumeratorConversionSucceful)
                {
                    Console.Write("Please enter Denominator : ");
                    int denominator;
                    bool IsDenominatorConversionSucceful = int.TryParse(Console.ReadLine(), out denominator);
                    if (IsDenominatorConversionSucceful && denominator != 0)
                    {
                        int result = numerator / denominator;
                        Console.WriteLine($"The result : {result}");
                    }
                    else
                    {
                        if (IsDenominatorConversionSucceful && denominator == 0)
                        {
                            Console.WriteLine("denominator cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine($"Denominator should be a valid number different of zero and between {int.MinValue} and {int.MinValue}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Numerator should be a valid number between {int.MinValue} and {int.MinValue}");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine($"{exp.GetType().Name} : {exp.Message}");
            }
        }
    }
}