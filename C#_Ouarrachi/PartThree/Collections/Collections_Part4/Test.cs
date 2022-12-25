namespace Collections_Part4
{
    public class Test
    {
        static void Main(string[] args)
        {
            Generics2 obj = new Generics2();
            obj.Add(20, 10); // => obj.Add<int>(20, 10);
            obj.Sub(20, 10); // => obj.Sub<int>(20, 10);
            obj.Mul(20, 10); // => obj.Mul<int>(20, 10);
            obj.Div(20, 10); // => obj.Div<int>(20, 10);

            Console.WriteLine();

            Generics3<int> obj1 = new Generics3<int>();
            obj1.Add(20, 10);
            obj1.Sub(20, 10);
            obj1.Mul(20, 10);
            obj1.Div(20, 10);

        }
    }
}
