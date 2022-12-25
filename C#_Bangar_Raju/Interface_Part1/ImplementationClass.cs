namespace Interfaces_Part1
{
    internal class ImplementationClass : Interface2
    {

        public void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
        public void Sub(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        /*
        void Interface1.Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
        void Interface2.Sub(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }
        */

    }
}
