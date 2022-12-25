namespace Collections_Part4
{
    public class GenericsTwo
    {
        public void Add<T>(T number1 , T number2)
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

        static void Main(string[] args)
        {
            GenericsTwo genericsTwo = new GenericsTwo();
            /*
            genericsTwo.Add<int>(10, 20);
            genericsTwo.Sub<int>(10, 20);
            genericsTwo.Mul<int>(10, 20);
            genericsTwo.Div<int>(10, 20);
            */
            genericsTwo.Add(10, 20);
            genericsTwo.Sub(10, 20);
            genericsTwo.Mul(10, 20);
            genericsTwo.Div(10, 20);

            Console.WriteLine();
            Console.WriteLine();

            /*
            genericsTwo.Add<float>(10.25f, 20.35f); 
            genericsTwo.Sub<float>(10.25f, 20.35f); 
            genericsTwo.Mul<float>(10.25f, 20.35f); 
            genericsTwo.Div<float>(10.25f, 20.35f); 
            */
            genericsTwo.Add(10.25f, 20.35f);
            genericsTwo.Sub(10.25f, 20.35f);
            genericsTwo.Mul(10.25f, 20.35f);
            genericsTwo.Div(10.25f, 20.35f);
        }
    }
}
