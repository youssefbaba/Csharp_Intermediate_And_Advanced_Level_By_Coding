namespace Abstract_Classes_And_Abstract_Methods_Test1
{
    internal abstract class AbsParent // Abstract Class
    {
        // Abstract class can contain abstract methods and non-abstract methods
        public void Add(int number1, int number2) // Non-abstract methods
        {
            Console.WriteLine(number1 + number2);
        }
        public void Sub(int number1, int number2) // Non-abstract methods
        {
            Console.WriteLine(number1 - number2);
        }
        public abstract void Mul(int number1, int number2); // Abstract methods
        public abstract void Div(int number1, int number2); // Abstract methods
    }
}
