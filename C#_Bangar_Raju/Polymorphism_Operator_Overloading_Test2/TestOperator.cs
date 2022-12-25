
namespace Polymorphism_Operator_Overloading_Test2
{
    internal class TestOperator
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 20;
            int number3 = number1 + number2; // there is predefined operator method in class libraries : public static int operator +(int a , int b){ // statements} that does this operation .
            int number4 = number1 - number2; // there is predefined operator method in class libraries : public static int operator -(int a , int b){ // statements} that does this operation .
            bool check = number1 < number2; // there is predefined operator method in class libraries : public static bool operator <(int a , int b){ // statements} that does this operation .

            string string1 = "Hello";
            string string2 = "World";
            string string3 = string1 + string2; // there is predefined operator method in class libraries : public static string operator +(string a , string b){ // statements} that does this operation .
            bool check1 = string1 == string2; // there is predefined operator method in class libraries : public static bool operator ==(string a , string b){ // statements} that does this operation .
            bool check2 = string1 != string2; // there is predefined operator method in class libraries : public static bool operator !=(string a , string b){ // statements} that does this operation .
            //Console.WriteLine(string1 - string2); // because there is no predefined operator method in class libraries that allow you to do this operation .

        }
    }
}
