
namespace Polymorphism_Operator_Overloading_Test2
{
    internal class Test
    {
        static void Main(string[] args)
        {
            /*
            string str = "Hello how are you";
            Console.WriteLine(str.Substring(14)); // you
            Console.WriteLine(str.Substring(10)); // are you
            Console.WriteLine(str.Substring(10 ,3)); // are
            */

            Matrix matrix1 = new Matrix(20, 18, 16, 14);
            Matrix matrix2 = new Matrix(10, 8, 6, 4);
            Matrix matrix3 = matrix1 + matrix2;
            Matrix matrix4 = matrix1 - matrix2;

            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);
            Console.WriteLine(matrix3);
            Console.WriteLine(matrix4);

            /*
             public static void WriteLine(Object value)
            {
                string typeName = value.ToString();   // The default implementation of the Object.ToString() method returns the fully qualified name of the type of the Object .
                WriteLine(typeName); // Writes a string to the text stream, followed by a line terminator.
            }
             */



        }
    }
}