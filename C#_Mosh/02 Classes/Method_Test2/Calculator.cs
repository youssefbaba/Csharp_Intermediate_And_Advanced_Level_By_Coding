namespace Method_Test2
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}
