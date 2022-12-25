namespace Abstract_Classes_Methods_Part1
{
    internal abstract class AbstractParent   // Abstract class 
    {
        // Methods
        public void Add(int number1, int number2)  // Non-abstract method
        {
            Console.WriteLine(number1 + number2);
        }
        public void Sub(int number1, int number2)  // Non-abstract method
        {
            Console.WriteLine(number1 - number2);
        }
        public abstract void Mul(int number1, int number2); // Abstract Method
        public abstract void Div(int number1, int number2); // Abstract Method
    }
}
