namespace Delegates_Part0
{
    // Defining a delagte :
    public delegate void DelegateOne(int number1, int number2);
    public delegate int DelegateTwo(int number1, int number2);
    public delegate int[] DelegateThree(int[] array);

    public enum Choices
    {
        choice1,
        choice2
    }
    public class Program
    {
        public static void Add(int value1, int value2)
        {
            Console.WriteLine(value1 + value2);
        }
        public static void Mul(int value1, int value2)
        {
            Console.WriteLine(value1 * value2);
        }
        public static int[] Sort1(int[] array)
        {
            Array.Sort(array);
            return array;
        }
        public static int[] Sort2(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
        /*
        public static void Display(int[] array, Choices choice)
        {
            switch (choice)
            {
                case Choices.choice1:
                    foreach (int item in Sort1(array))
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                    break;
                case Choices.choice2:
                    foreach (int item in Sort2(array))
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                    break;
            }
        }
        */

        public static void Display(DelegateThree myDelegate , int[] array)
        {
            foreach (int item in myDelegate(array))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            DelegateOne obj = Add;  // Instantiating the delegate
            obj += Mul;     // Multicast the delegate
            obj(10, 20);    // Calling the delegate


            Console.WriteLine();


            obj -= Mul;
            obj(5, 10);


            Console.WriteLine();


            int[] numbersOne = new int[] { 10, 7, 25, 89, 34, 15, 2, 65 };
            int[] numbersTwo = new int[] { 41, 2, 48, 32, 75, 1, 97, 38 };
            /*
            Display(numbersOne , Choices.choice1);
            Display(numbersTwo , Choices.choice2);
            */


            Display(Sort1, numbersOne);
            Display(Sort2, numbersTwo);




        }
    }
}