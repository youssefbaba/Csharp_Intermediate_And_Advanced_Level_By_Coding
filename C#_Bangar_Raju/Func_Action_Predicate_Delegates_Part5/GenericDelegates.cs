namespace Func_Action_Predicate_Delegates_Part5
{
    public class GenericDelegates
    {
        // Methods
        // Lambda Expression
        public static string GetWeatherDisplay(double temperature) => (temperature < 20.0) ? "Cold" : "Hot";
        static void Main(string[] args)
        {
            // Predefined delagates : Func , Action , Predicate
            // We can use Func delegate if my method has a return type
            // We can use Action delegate if my method doesn't have a return type (void)
            // We can use Predicate delagate if my method has a return type of type boolean

            Func<int, float, double, double> delegateOne = (number1, number2, number3) => number1 + number2 + number3;
            Console.WriteLine($"Result : {delegateOne.Invoke(20, 25.14f, 14.56):F2}");

            Action<int, float, double> delegateTwo = (number1, number2, number3) => Console.WriteLine($"Result : {number1 + number2 + number3:F2}");
            delegateTwo.Invoke(20, 25.14f, 14.56);

            Predicate<string> delegateThree = (word) => (word.Length > 5) ? true : false;
            Console.WriteLine(delegateThree.Invoke("Hello World"));

            Console.WriteLine(GetWeatherDisplay(15));
            Console.WriteLine(GetWeatherDisplay(35));

        }
    }
}
