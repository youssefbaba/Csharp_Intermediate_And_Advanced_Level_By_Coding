namespace Test2
{
    public class ListInt
    {
        // Fields
        private int[] _array = new int[4];
        private int _currentIndex;


        // Methods
        public void Add(int value)
        {
            if (_currentIndex == _array.Length)
            {
                Grow();
            }
            _array[_currentIndex++] = value;
        }
        public int Get(int index)
        {
            return _array[index];
        }
        public void Display(ListInt listInt)
        {
            for (int i = 0; i < listInt.Length; i++)
            {
                Console.Write($"{listInt.Get(i)} ");
            }
            Console.WriteLine();
        }

        private void Grow()
        {
            int[] emp = new int[_array.Length * 2];
            Array.Copy(_array, emp, _array.Length);
            _array = emp;
        }

        // Properties
        public int Length
        {
            get
            {
                return _array.Length;
            }
        }
    }
}