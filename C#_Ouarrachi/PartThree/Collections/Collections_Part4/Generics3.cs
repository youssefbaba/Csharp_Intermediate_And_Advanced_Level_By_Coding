namespace Collections_Part4
{
    public class Generics3<T>  // Generic Class
    {
        // Methods
        public void Add(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            Console.WriteLine(value1 + value2);
        }
        public void Sub(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            Console.WriteLine(value1 - value2);
        }
        public void Mul(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            Console.WriteLine(value1 * value2);
        }
        public void Div(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            Console.WriteLine(value1 / value2);
        }
    }
}