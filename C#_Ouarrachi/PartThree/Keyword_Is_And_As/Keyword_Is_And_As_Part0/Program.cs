namespace Keyword_Is_And_As_Part0
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            long number2 = number1;      // Implicit cast because  int < long .
            Console.WriteLine(number2);

            
            double value1 = 10.5;
            int value2 = (int)value1;    // Explicit cast because double > int and we have lost of data .
            Console.WriteLine(value2);



            object obj = "Hello World";
            string str1 = (string)obj;    //Cast operator throws an exception if the conversion cannot be done, where as the As operator returns null if the conversion cannot be done.
            string str2 = obj as string;  //Cast operator throws an exception if the conversion cannot be done, where as the As operator returns null if the conversion cannot be done.
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            //int value3 = value1 as int; //  Error : As operator must be used with a reference type .
        }
    }
}