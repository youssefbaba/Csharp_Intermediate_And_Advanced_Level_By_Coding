namespace Var_Keyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            // - var : type inference , but it is not a data type , it is highly recommended to use fixed data type (int , double , string ,...) for clarity instead of using var keyword.
            // - Based on the data type of the right-hand side expression in the declaration compiler will automatically infer the type of the variable.
            // - Once inferred the type cannot be changed , strongly typed.

            var value1 = 10;            // value1 is int
            //value1 = "Hello";   // Compile-time error , because we cannot change value of value1 from int to string , value1 always it is going to store integer values only
            value1 = 14;
            Console.WriteLine(value1);
            var value2 = "azerty";      // value2 is string
            //value2 = 10;        // Compile-time error , because we cannot change value of value2 from string to int , value2 always it is going to store string values only
            value2 = "Hi";
            Console.WriteLine(value2);
            var value3 = true;          // value3 in bool
            //value3 = 10.2;       // Compile-time error , because we cannot change value of value3 from bool to double , value3 always it is going to store boolean values only
            value3 = false;
            Console.WriteLine(value3);


            // - var is static typed - the compiler and runtime know the type - they just save you some typing, the following are 100% identical.
            var str1 = "Hello";
            Console.WriteLine(str1.Length);
            string str2 = "Hello";
            Console.WriteLine(str2.Length);


            // An object at different times can store different types of data : (static type) there is an intellisense and type checking at compile-time
            object object1 = 120;       // object1 is int
            Console.WriteLine($"Type = {object1.GetType().Name} - Value = {object1}");
            object1 = "Hello World";    // object1 is string
            Console.WriteLine($"Type = {object1.GetType().Name} - Value = {object1}");
            object1 = true;             // object1 is boolean
            Console.WriteLine($"Type = {object1.GetType().Name} - Value = {object1}");


            // dynamic type also at different times can store different types of data : (dynamic type) there is not an intellisense and type checking at run-time
            dynamic dynamic1 = 12.54;   // dynamic1 is double
            Console.WriteLine($"Type = {dynamic1.GetType().Name} - Value = {dynamic1}");
            dynamic1 = "A";             // dynamic1 is char
            Console.WriteLine($"Type = {dynamic1.GetType().Name} - Value = {dynamic1}");
            dynamic1 = 186.5M;          // dynamic1 is decimal
            Console.WriteLine($"Type = {dynamic1.GetType().Name} - Value = {dynamic1}");


            /*
            var value4;  // Compile-time error , because implicitly typed variables must be initialized
            value4 = 100;
            */
            int number;
            number = 14;


            var name1 = "David Alves";  // in this case, using the var keyword is bad practice
            string name2 = "John Doe";  // much clear and readable


            IEnumerable<IEnumerable<double>> value5 = Foo();    // lots of typing here
            var value6 = Foo();         // in this case, using the var keyword is best practice , because we have complex type

        }

        static IEnumerable<IEnumerable<double>> Foo()
        {
            // Some logic here ...
            return null;
        }
    }
}