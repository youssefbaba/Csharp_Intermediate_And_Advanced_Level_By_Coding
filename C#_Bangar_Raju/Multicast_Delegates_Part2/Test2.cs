namespace Multicast_Delegates_Part2
{
    public class Test2
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            CalDelgate calDelgate = calculator.Add;
            calDelgate += calculator.Mul;
            int res = 0;
            calDelgate.Invoke(10 ,20 , out res);
            Console.WriteLine($"Value of result : {res}");
        }
    }
}
