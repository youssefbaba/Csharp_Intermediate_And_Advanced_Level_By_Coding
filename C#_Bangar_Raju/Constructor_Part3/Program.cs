namespace Constructor_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass firstClass1 = new FirstClass();
            FirstClass firstClass2 = new FirstClass();
            FirstClass firstClass3 = new FirstClass();
            Console.WriteLine($"{firstClass1}  {firstClass2}  {firstClass3}");

            SecondClass secondClass1 = new SecondClass(100);   
            SecondClass secondClass2 = new SecondClass(200);   
            SecondClass secondClass3 = new SecondClass(300);
            Console.WriteLine($"{secondClass1}  {secondClass2}  {secondClass3}");
        }
    }
}