namespace Abstract_Classes_Methods_Part1
{
    internal class ChildClass : AbstractParent
    {
        public override void Mul(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }
        public override void Div(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }

    }
}
