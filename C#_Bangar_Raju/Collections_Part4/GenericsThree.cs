namespace Collections_Part4
{
    public class GenericsThree<T>
    {
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
    public class TestGenericsThree
    {
        static void Main(string[] args)
        {
            GenericsThree<int> generic1 = new GenericsThree<int>();
            generic1.Add(10, 20);
            generic1.Sub(10, 20);
            generic1.Mul(10, 20);
            generic1.Div(10, 20);

            Console.WriteLine();
            Console.WriteLine();

            GenericsThree<float> generic2 = new GenericsThree<float>();
            generic2.Add(10.5f, 20.6f);
            generic2.Sub(10.5f, 20.6f);
            generic2.Mul(10.5f, 20.6f);
            generic2.Div(10.5f, 20.6f);


        }
    }
}

