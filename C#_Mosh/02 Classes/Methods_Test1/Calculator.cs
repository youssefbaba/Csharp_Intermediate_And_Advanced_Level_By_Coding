
namespace Methods_Test1
{
    public class Calculator
    {
        // cannot passed properties or indexers as out or ref

        // Fields
        public int Number;

        // Methods
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public void Square(int number)  // Overload1 of Square method
        {
            number *= number;
            Console.WriteLine(number); // 100
        }
        public void Square(ref int number) // Overload2 of Square method
        {
            number *= number;
            Console.WriteLine(number); // 100
        }

    }
}
