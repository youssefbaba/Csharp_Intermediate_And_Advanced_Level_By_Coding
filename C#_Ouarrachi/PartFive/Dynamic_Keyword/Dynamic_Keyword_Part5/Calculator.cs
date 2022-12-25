namespace Dynamic_Keyword_Part5
{
    public class Calculator
    {
        public double Add(params double[] numbers)
        {
            return numbers.Sum();
        }
        public double Mul(params double[] numbers)
        {
            double mult = 1;
            foreach (double number in numbers)
            {
                mult *= number;
            }
            return mult;
        }
    }
}