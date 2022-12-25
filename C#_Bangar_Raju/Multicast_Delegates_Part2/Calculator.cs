namespace Multicast_Delegates_Part2
{
    // Defining the delegate
    public delegate void CalDelgate(int number1, int number2, out int result);
    public class Calculator
    {
        public void Add(int number1 , int number2 , out int result)
        {
            result = number1 + number2;
        }
        public void Mul(int number1 , int number2, out int result)
        {
            result = number1 * number2;
        }
    }
}
