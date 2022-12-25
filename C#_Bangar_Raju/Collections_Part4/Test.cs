namespace Collections_Part4
{
    public class Test
    {
        static void Main(string[] args)
        {

            /*
             - var keyword represents the type of variable at compile time.
             - dynamic keyword represents the type of variable at run time.
             - Equals(Object) method checks the equality at run time .
             - Equality operator (==) checks the equality at complie time.
             */

            int number1 = 10;
            int number2 = 10;
            Console.WriteLine($"Run time type of {nameof(number1)} : {number1.GetType().Name}"); // Int32
            Console.WriteLine($"Run time type of {nameof(number2)} : {number2.GetType().Name}"); // Int322
            Console.WriteLine($"Compile time type of {nameof(number1)} : {GetCompileTimeType(number1).Name}"); // Int32
            Console.WriteLine($"Compile time type of {nameof(number2)} : {GetCompileTimeType(number2).Name}"); // Int32
            Console.WriteLine($"{nameof(number1)} == {nameof(number2)} : {number1 == number2}"); // True
            Console.WriteLine($"{nameof(number1)}.Equals({nameof(number2)}): {number1.Equals(number2)}"); // True

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            object obj1 = 10;
            object obj2 = 10;
            Console.WriteLine($"Run time type of {nameof(obj1)} : {obj1.GetType().Name}"); // Int32
            Console.WriteLine($"Run time type of {nameof(obj2)} : {obj2.GetType().Name}"); // Int32
            Console.WriteLine($"Compile time type of {nameof(obj1)} : {GetCompileTimeType(obj1).Name}"); // Object
            Console.WriteLine($"Compile time type of {nameof(obj2)} : {GetCompileTimeType(obj2).Name}"); // Object
            Console.WriteLine($"{nameof(obj1)} == {nameof(obj2)} : {obj1 == obj2}"); // False
            Console.WriteLine($"{nameof(obj1)}.Equals({nameof(obj2)}): {obj1.Equals(obj2)}"); // True
        }

        public static Type GetCompileTimeType<T>(T inputObject)
        {
            return typeof(T);
        }
    }
}
