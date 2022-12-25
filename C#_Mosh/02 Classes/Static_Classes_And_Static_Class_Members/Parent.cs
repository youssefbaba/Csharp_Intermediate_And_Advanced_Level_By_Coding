
namespace Static_Classes_And_Static_Class_Members
{
    public class Parent
    {
        // Static methods can be overloaded but not overridden
        public static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Sum = {firstNumber + secondNumber}");
        }
        public static void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine($"Sum = {firstNumber + secondNumber + thirdNumber}");
        }
        //public virtual static int Mult(int firstNumber , int secondNumber)
        //{
        //    return firstNumber * secondNumber;  
        //}
    }
}
