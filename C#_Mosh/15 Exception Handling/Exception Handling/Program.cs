using System.IO;

namespace Exception_Handling
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - we can handling exception by using try catch blocks try{ //... } catch(){  // ... } 
             -Exception
                -SystemException
                    - ArithmeticException
                        -DivideByZeroException
             */
            // catch exception and loging it inside a file



            // handling Exception :
            StreamWriter? streamWriter = default;
            try
            {
                try
                {
                    Calculator calculator = new Calculator();
                    int result = calculator.Divide(100, 5);
                    //int result = calculator.Divide(100, 0);
                    Console.WriteLine($"The result of 100 / 5 = {result}");
                }
                catch (DivideByZeroException exception1)
                {
                    //streamWriter = new StreamWriter(@"C:\Users\Youssef Baba\Desktop\My_Computer2\Log.txt" , true);
                    streamWriter = new StreamWriter(@"C:\Users\Youssef Baba\Desktop\My_Computer\Log.txt" , true);
                    streamWriter.WriteLine($"{exception1.GetType().Name} : {exception1.Message} => {DateTime.Now}");
                }
            }
            catch (Exception)
            {
                // throw; // Rethrow an exception
                Console.WriteLine("Sorry, an exception arror occurred.");
                return;
            }
            finally // is mandatory executed
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose(); // For releasing unmanaged resources
                    Console.WriteLine("Resource released");
                }
            }


            // There is a cleaner way to release resource without using finally block , so wa can use using statement
            try
            {
                try
                {
                    Calculator calculator = new Calculator();
                    int result = calculator.Divide(100, 0);
                    Console.WriteLine($"The result = {result}");
                }
                catch (DivideByZeroException exception1)
                {
                    //using (StreamWriter streamWriter1 = new StreamWriter(@"C:\Users\Youssef Baba\Desktop\My_Computer2\Log.txt"))
                    using (StreamWriter streamWriter1 = new StreamWriter(@"C:\Users\Youssef Baba\Desktop\My_Computer\Log.txt" , true))  // Releases implicitly unmanaged resources without calling to Dispose() method
                    {
                        streamWriter1.WriteLine($"{exception1.GetType().Name} : {exception1.Message} => {DateTime.Now}");
                        Console.WriteLine("Resource released.");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an exception error occurred.");
            }
        }
    }
}