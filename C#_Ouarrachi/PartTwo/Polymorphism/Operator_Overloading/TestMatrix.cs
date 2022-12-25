namespace Operator_Overloading
{
    internal class TestMatrix
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(20, 18, 16, 14);
            Console.WriteLine(matrix1);
            Console.WriteLine();
            Matrix matrix2 = new Matrix(10, 8, 6, 4);
            Console.WriteLine(matrix2);
            Console.WriteLine();
            Matrix matrix3 = matrix1 + matrix2;
            Console.WriteLine(matrix3);
            Console.WriteLine();
            Matrix matrix4 = matrix1 - matrix2;
            Console.WriteLine(matrix4);
        }
    }

}
