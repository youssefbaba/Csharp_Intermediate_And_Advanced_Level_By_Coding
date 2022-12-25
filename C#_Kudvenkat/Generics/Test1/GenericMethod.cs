namespace Test1
{
    public class GenericMethod
    {
        // Methods

        public static T[] Tri<T>(T[] array)
        {
            Array.Sort(array);
            return array;
        }

        /*
        public static double[] TriDoubles(double[] array)
        {
            Array.Sort(array);
            return array;
        }
        public static string[] TriStrings(string[] array)
        {
            Array.Sort(array);
            return array;
        }
        */

        public static void Display<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        /*
        public static void DisplayDoubles(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static void DisplayStrings(string[] array)
        {
            foreach (string item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        */

        public static bool IsEqual<T , U>(T value1 , U value2)
        {
            return value1.Equals(value2);
        }

        static void Main(string[] args)
        {
            int[] integers = new int[] { 10, 5, 78, 45, 1, 6, 49 };
            double[] doubles = new double[] { 10.2, 78.3, 45.1, 2, 9.8 };
            string[] strings = new string[] { "Toyota", "Honda", "Ford", "Renault" };


            //Tri<int>(integers);
            //Display<int>(integers);           
            Tri(integers);
            Display(integers);


            //Tri<double>(doubles);
            //Display<double>(doubles);
            Tri(doubles);
            Display(doubles);


            //Tri<string>(strings);
            //Display<string>(strings);
            Tri(strings);
            Display(strings);


            int number1 = 10;
            double number2 = 10;
            Console.WriteLine($"Is number1 equal to number2 ? {IsEqual(number1 , number2)}");


        }
    }
}
