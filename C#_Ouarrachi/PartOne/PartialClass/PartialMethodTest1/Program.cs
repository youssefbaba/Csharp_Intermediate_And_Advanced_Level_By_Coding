namespace PartialMethodTest1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SamplePartialClass obj = new SamplePartialClass();
            obj.NoPartialMethod();
            SamplePartialClass.PartialMethodFour();
            Console.WriteLine($"Max = {obj.Max(20, 30)}");

            Func<double, double, double> objDelegate = obj.Add;
            Console.WriteLine($"10 + 20 = {objDelegate(10 ,20)}");
        }
    }
}