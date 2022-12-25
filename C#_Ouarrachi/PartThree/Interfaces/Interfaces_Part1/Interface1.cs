namespace Interfaces_Part1
{
    public interface Interface1
    {
        public static int X;
        static Interface1()
        {
            X = 10;
        }
        // Methods
        void Add(int number1, int number2); // by defaut it's public and abstract

    }
}
