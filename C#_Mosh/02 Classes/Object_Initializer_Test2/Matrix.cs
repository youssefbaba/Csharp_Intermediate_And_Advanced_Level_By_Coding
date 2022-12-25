
namespace Object_Initializer_Test2
{
    public class Matrix
    {
        // Fields
        private double[,] _data;

        // Constructors
        public Matrix(int row, int column)
        {
            _data = new double[row, column];
        }

        // Indexers
        public double this[int row, int column]
        {
            get { return _data[row, column]; }
            set { _data[row, column] = value; }
        }
    }
}
