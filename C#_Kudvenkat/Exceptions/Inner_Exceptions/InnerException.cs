using System.IO;
using System.Runtime.CompilerServices;

namespace Inner_Exceptions
{
    internal class InnerException
    {
        static void Main(string[] args)
        {
            StreamWriter streamWriter = null;


            try
            {
                try
                {
                    Console.Write("Please enter first number : ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter second number : ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    int result = firstNumber / secondNumber;
                    Console.WriteLine($"The result : {result}");
                }
                catch (Exception exp) // Inner Exception
                {
                    Console.WriteLine("There is a problem , Please try later");
                    string filePath = @"C:\Users\Youssef Baba\Desktop\My_Computer\Log.txt";
                    if (File.Exists(filePath))
                    {
                        streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(exp.GetType().Name);
                        streamWriter.WriteLine();
                        streamWriter.Write(exp.Message);
                    }
                    else
                    {
                        throw new FileNotFoundException($"{filePath} is not present", exp); // Current Exception
                    }
                }

            }
            catch (FileNotFoundException exp1) // Current Exception
            {
                Console.WriteLine($"Current Exception = {exp1.GetType().Name} : {exp1.Message}");
                if (exp1.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception = {exp1.GetType().Name} : {exp1.InnerException.Message}");
                }
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                    Console.WriteLine("File closed");
                }
            }
            Console.WriteLine($"The end of program.");
        }
    }
}