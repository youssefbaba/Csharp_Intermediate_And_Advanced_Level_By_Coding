namespace Test2
{
    public class ListString
    {
        // Fields
        private string[] _array = new string[4];
        private int _currentIndex;


        // Methods
        public void Add(string value)
        {
            if (_currentIndex == _array.Length)
            {
                Grow();
            }
            _array[_currentIndex++] = value;
        }
        public string Get(int index)
        {
            return _array[index];
        }
        public void Display(ListString listString)
        {
            for (int i = 0; i < listString.Length; i++)
            {
                Console.Write($"{listString.Get(i)} ");
            }
            Console.WriteLine();
        }

        private void Grow()
        {
            string[] emp = new string[_array.Length * 2];
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
