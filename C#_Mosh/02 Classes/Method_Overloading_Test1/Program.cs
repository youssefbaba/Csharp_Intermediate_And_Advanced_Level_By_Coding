namespace Method_Overloading_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://www.youtube.com/watch?v=lSYpddX1jVI&list=PLAC325451207E3105&index=25
             */
            Add(10, 20);
            Add(10.2f, 15);
            Add(10, 20, 30);
            Add(10, 20, 30, 40);
            Mult(10, 12);
            Mult(10, 15.5, 20);
            Mult(10, 20, new int[] { 10, 20, 30 });
        }

        public static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Sum = {firstNumber + secondNumber}");
        }
        public static void Add(float firstNumber, int secondNumber)
        {
            Console.WriteLine($"Sum = {firstNumber + secondNumber}");
        }
        public static void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine($"Sum = {firstNumber + secondNumber + thirdNumber}");
        }
        public static void Add(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            Console.WriteLine($"Sum = {firstNumber + secondNumber + thirdNumber + fourthNumber}");
        }

        public static void Mult(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Mult = {firstNumber * secondNumber}");
        }
        public static void Mult(int firstNumber, double secondNumber, int thirdNumber)
        {
            Console.WriteLine($"Mult = {firstNumber * secondNumber * thirdNumber}");
        }
        public static void Mult(int firstNumber, double secondNumber, out int mult)
        {
            mult = firstNumber * (int)secondNumber;
            Console.WriteLine($"Mult = {firstNumber * secondNumber}");
        }

        // This is not Method overloading because we have change just in the return type
        //public static int Mult(int firstNumber, double secondNumber, out int mult)
        //{
        //    mult = firstNumber * (int)secondNumber;
        //    Console.WriteLine($"Mult = {firstNumber * secondNumber}");
        //    return mult;
        //}

        public static void Mult(int firstNumber, int secondNumber, int[] thirdNumber)
        {
            int mult = 1;
            foreach (int item in thirdNumber)
            {
                mult *= item;
            }
            Console.WriteLine($"Mult = {firstNumber * secondNumber * mult}");
        }

        // This is not Method overloading because we have change just in the params modifier
        //public static void Mult(int firstNumber, int secondNumber, params int[] thirdNumber)
        //{
        //    int mult = 1;
        //    foreach (int item in thirdNumber)
        //    {
        //        mult *= item;
        //    }
        //    Console.WriteLine($"Mult = {firstNumber * secondNumber * mult}");
        //}

    }
}