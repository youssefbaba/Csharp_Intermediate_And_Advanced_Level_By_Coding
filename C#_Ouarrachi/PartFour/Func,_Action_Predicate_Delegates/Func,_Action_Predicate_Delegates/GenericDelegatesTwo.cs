namespace Func__Action_Predicate_Delegates
{
    public class GenericDelegatesTwo
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (number1, number2, number3) => number1 + number2 + number3;
            double result1 = obj1.Invoke(10, 15.5f, 20.2);
            Console.WriteLine(result1);


            Action<int, float, double> obj2 = (number1, number2, number3) => Console.WriteLine(number1 + number2 + number3);
            obj2.Invoke(10, 15.5f, 20.2);


            Predicate<string> obj3 = (str) => (str.Length >= 5) ? true : false;
            bool result2 = obj3.Invoke("Hello World");
            Console.WriteLine(result2);

        }
    }
}
