namespace Collections_Part4
{
    public class Generics2
    {
        // Methods
        public void Add<T>(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            Console.WriteLine(value1 + value2);
        }
        public void Sub<T>(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            Console.WriteLine(value1 - value2);
        }
        public void Mul<T>(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            Console.WriteLine(value1 * value2);
        }
        public void Div<T>(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            Console.WriteLine(value1 / value2);
        }
    }
}