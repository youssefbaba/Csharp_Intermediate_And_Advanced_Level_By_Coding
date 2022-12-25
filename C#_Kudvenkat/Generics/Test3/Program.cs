namespace Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator.AreEqual("A", "B");
            //bool equal = Calculator.AreEqual(10, 10);
            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


            bool check = CalculatorTwo<int>.AreEqual(100, 100);
            //bool check = CalculatorTwo<string>.AreEqual("A", "B");
            if (check)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
    }
}
