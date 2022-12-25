namespace Operator_Overloading
{
    internal class TestOperator
    {
        static void Main(string[] args)
        {
            string string1 = "Hello ";
            string string2 = "World";
            Console.WriteLine(string1 + string2);
            // Console.WriteLine(string1 - string2); // Error : Because there is no pre-defined operator method in the libraries of the language available for using substraction between two string



        }
    }
}
