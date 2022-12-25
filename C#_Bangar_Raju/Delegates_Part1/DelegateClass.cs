namespace Delegates_Part1
{
    // Step 1 : Defining a delegate
    public delegate void AddDelegate(int value1, int value2);
    public delegate string SayDelegate(string noun);
    public class DelegateClass
    {
        // Methods
        public void AddNumbers(int number1, int number2) // Instance method
        {
            Console.WriteLine(number1 + number2);
        }
        public static string SayHello(string name) // Static method
        {
            return $"Hello {name}";
        }
    }
}
