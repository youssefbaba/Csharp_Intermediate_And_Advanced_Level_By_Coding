namespace Test2
{
    public class GenericClass<T>
    {
        // Fields
        private T[] _array = new T[4];
        private int _currentIndex;


        // Methods
        public void Add(T value)
        {
            if (_currentIndex == _array.Length)
            {
                Grow();
            }
            _array[_currentIndex++] = value;
        }
        public T Get(int index)
        {
            return _array[index];
        }
        public void Display(GenericClass<T> genericClass)
        {
            for (int i = 0; i < genericClass.Length; i++)
            {
                Console.Write($"{genericClass.Get(i)} ");
            }
            Console.WriteLine();
        }

        private void Grow()
        {
            T[] emp = new T[_array.Length * 2];
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
