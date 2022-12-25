namespace Abstract_Classes_And_Abstract_Methods_Test1;

internal class AbsChild : AbsParent
{
    public override void Mul(int number1, int number2) // Overriding in Mandatory
    {
        Console.WriteLine(number1 * number2);
    }
    public override void Div(int number1, int number2) // Overriding in Mandatory
    {
        Console.WriteLine(number1 / number2);
    }
}
