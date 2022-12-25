using System.Text;
using System.Diagnostics;

namespace String_And_StringBuilder
{
    internal class Test
    {
            // String is immutable
            // StringBuilder is mmutable
        static void Main(string[] args)
        {
            // GetHashCode() method will return a unique value for each instance.
            string string1 = "Hello";
            Console.WriteLine($"{string1} => {string1.GetHashCode()}"); 
            string1.ToLower();
            Console.WriteLine($"{string1} => {string1.GetHashCode()}");
            string1.Substring(0); 
            Console.WriteLine($"{string1} => {string1.GetHashCode()}");

            Console.WriteLine();

            string string2 = "Whatsap";
            Console.WriteLine($"{string1} => {string1.GetHashCode()}");
            string str1 = string1.ToLower();
            Console.WriteLine($"{str1} => {str1.GetHashCode()}");
            string str2 = string1.ToUpper();
            Console.WriteLine($"{str2} => {str2.GetHashCode()}");

            Console.WriteLine();

            string string3 = "Hi"; // Instance 1 : new allocation is allocated that contains Hi
            Console.WriteLine($"{string3} => {string3.GetHashCode()}");
            string3 += " Youssef"; // Instance 2 : new allocation is allocated that contains Hi Youssef
            Console.WriteLine($"{string3} => {string3.GetHashCode()}");
            string3 += " Baba"; // Instance 3 : new allocation is allocated that contains Hi Youssef Baba
            Console.WriteLine($"{string3} => {string3.GetHashCode()}");

            Console.WriteLine();

            StringBuilder sb1 =  new StringBuilder("Hello");
            Console.WriteLine($"{sb1} => {sb1.GetHashCode()}");
            sb1.Append(" Mohamed"); // the change applies to the same instance
            Console.WriteLine($"{sb1} => {sb1.GetHashCode()}");
            sb1.Append(" Zidani"); // the change applies to the same instance
            Console.WriteLine($"{sb1} => {sb1.GetHashCode()}");

            Console.WriteLine();

            string string4 = string.Empty;
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i = 1; i <= 100000; i++)
            {
                string4 += i; 
            }
            sw1.Stop();

            StringBuilder sb2 = new StringBuilder();
            //StringBuilder sb2 = new StringBuilder(10000); // for more performance
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 1; i <= 100000; i++)
            {
                sb2.Append(i);
            }
            sw2.Stop();

            Console.WriteLine($"Time taken for String : {sw1.ElapsedMilliseconds}");
            Console.WriteLine($"Time taken for StringBuilder : {sw2.ElapsedMilliseconds}");
           
        }
    }
}