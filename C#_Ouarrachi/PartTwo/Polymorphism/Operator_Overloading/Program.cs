using System.Security.Cryptography.X509Certificates;

namespace Operator_Overloading
{
    internal class Program
    {
        /*
         - Method overloading : is an approach of defining multiple behaviours to a method and those behaviours will vary based on the parameters of that method.
         - Operator overloading : is also an approach of defining multiple behaviours to an operator and those behaviours will vary based on the operand types between which the operator is used,
            For example : + is an addition operator when used between two numeric operands
                        and it is an concatenation operator when used between two string operands.
                        Number + Number => Addition Operator
                        String + String => Concatenation Operator
         - <modifiers> static <return type> operator <opt>(<operand types>){ - Logic }

         */
        static void Main(string[] args)
        {
            string str = "Hello how are you";
            string str1 = str.Substring(14);    // First Overload of Substring method
            Console.WriteLine(str1);
            string str2 = str.Substring(10, 3);  // Second Overload of Substring method
            Console.WriteLine(str2);


            string string1 = "Youssef ";
            string string2 = "Baba";
            int number1 = 10;
            int number2 = 20;
            int number3 = number1 + number2;  // + Represents a method within the libraries of the language (Operator Method)
            // public static int operator +(int a , int b) { return a + b ; }
            int number4 = number1 - number3;
            // public static int operator -(int a , int b) { return a - b ; }
            bool check1 = number1 > number2;
            // public static bool operator >(int a , int b) { return a > b ; }
            string string3 = string1 + string2;
            // public static string operator +(string a , string b) { return $"{a}{b}" ; }
            bool check2 = string1 == string2;
            // public static bool operator ==(string a , string b) { return a.Equals(b); }
            bool check3 = string1 != string2;
            // public static bool operator !=(string a , string b) { return !(a.Equals(b)); }
            //string string4 = string1 - string2;  // Compile time error : because there is no pre-defined Operator Method in the libraries of the language available for using subtraction between two strings.
        }
    }
}