

namespace Object_Initializer_Test2
{
    internal class IndexersExample
    {
        // Fields
        public string Name;
        private char[] _letters;

        // Properties
        public double Size { get; set; }

        // Constructors 
        public IndexersExample(int length)
        {
            _letters = new char[length];
        }


        public char this[int i]
        {
            set
            {
                _letters[i] = value;
            }
        }

    }

}
