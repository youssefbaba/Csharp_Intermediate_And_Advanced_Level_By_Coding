
namespace Polymorphism_Operator_Overloading_Test2
{
    internal class Matrix
    {
        // Fields
        int _number1;
        int _number2;
        int _number3;
        int _number4;

        // Constructors
        public Matrix(int number1 , int number2 , int number3 , int number4)
        {
            _number1 = number1;
            _number2 = number2;
            _number3 = number3;
            _number4 = number4;
        }

        // Methods
        public static Matrix operator +(Matrix matrix1 , Matrix matrix2)
        {
            return new Matrix(matrix1._number1 + matrix2._number1, matrix1._number2 + matrix2._number2, matrix1._number3 + matrix2._number3, matrix1._number4 + matrix2._number4);
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            return new Matrix(matrix1._number1 - matrix2._number1, matrix1._number2 - matrix2._number2, matrix1._number3 - matrix2._number3, matrix1._number4 - matrix2._number4);
        }

        // The default implementation of the Object.ToString method returns the fully qualified name of the type of the Object

        public override string ToString()
        {
            return $"{_number1}     {_number2}\n{_number3}      {_number4}\n";
        }
    }
}
