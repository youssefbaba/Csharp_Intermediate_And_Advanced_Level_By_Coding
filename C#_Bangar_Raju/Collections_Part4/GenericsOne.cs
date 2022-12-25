namespace Collections_Part4
{
    public class GenericsOne
    {
        public bool Compare<T>(T number1 , T number2)
        {
            if (number1.Equals(number2))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            GenericsOne genericsOne = new GenericsOne();
            //Console.WriteLine($"The result : {genericsOne.Compare(12.45f ,25.4)}");  // double : because of implicit conversion
            //Console.WriteLine($"The result : {genericsOne.Compare(12.45f ,10)}");  // float : because of implicit conversion
            //Console.WriteLine($"The result : {genericsOne.Compare(12.45f ,'b')}");  // float : because of implicit conversion
            Console.WriteLine($"The result : {genericsOne.Compare<float>(12.45f ,10.25f)}");  // mandatory two agruments must be float
            Console.WriteLine($"The result : {genericsOne.Compare<int>(10, 10)}");   // mandatory two agruments must be int


        }
    }
}