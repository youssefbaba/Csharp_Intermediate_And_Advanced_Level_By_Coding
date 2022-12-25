using System.IO;

namespace Exception_Handling
{
    public class ExceptionHandling
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            // Handling Exception
            try
            {
                streamReader = new StreamReader(@"C:\Users\Youssef Baba\Desktop\My_Computer\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                return;
            }
            catch (FileNotFoundException exp1) // Specific exception
            {
                Console.WriteLine($"Please check if the file exists : {exp1.FileName}");
            }
            catch (Exception exp) // general exception
            {
                Console.WriteLine(exp.Message);
            }

            /*
            if (streamReader != null)
            {
                streamReader.Close();
                Console.WriteLine("File Closed.");
            }
            */

            finally // Mandatory is executed
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                    Console.WriteLine("File Closed.");
                }
            }
            Console.WriteLine("The end of programm.");
        }
    }
}
