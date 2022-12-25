namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OverloadingDemo demo = new OverloadingDemo();
            demo.Test();
            demo.Test(25);
            demo.Test(new int[] { 1, 2, 3, 4, 5, 6 });
            demo.Test("Hello Youssef");
            demo.Test(24, "Hello Mohamed");
            demo.Test("Hello Hassna", 30);
            int val;
            demo.Test("Hello Omar", out val);

            string sentence = "Hello Worlld";
            Console.WriteLine(sentence.IndexOf('o')); // 4
            Console.WriteLine(sentence.IndexOf("ll")); // 2
            Console.WriteLine(sentence.IndexOf('o' ,5)); // 7
            Console.WriteLine(sentence.IndexOf("ll" ,5)); // 9
        }
    }
}