
namespace Object_Initializer_Test2
{
    public class Form
    {
        // Fields
        private int[,] _storage;

        // Constructors 
        public Form(int row, int column)
        {
            _storage = new int[row, column];
        }

        // Indexers
        public int this[int row, int column]
        {
            get { return _storage[row, column]; }
            set { _storage[row, column] = value; }
        }
    }
}
