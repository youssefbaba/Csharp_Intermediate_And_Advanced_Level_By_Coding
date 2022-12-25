namespace Lambda_Expressions_Delegates_Part4
{
    // Defining the delegate
    public delegate void DelegateOne(int number1, int number2);
    public delegate string DelegateTwo(string name);
    public class LambdaExpressions
    {
        static void Main(string[] args)
        {
            // Lambda Expressions is short hand for writing anonymous method
            DelegateOne delegateOne = (number1, number2) =>
            {
                Console.WriteLine($"Result : {number1 + number2}");
            };
            delegateOne.Invoke(10, 5);

            DelegateTwo delegateTwo = (name) =>
            {
                return $"Your name is : {name}";
            };
            Console.WriteLine(delegateTwo.Invoke("Youssef Baba"));

        }
    }
}
