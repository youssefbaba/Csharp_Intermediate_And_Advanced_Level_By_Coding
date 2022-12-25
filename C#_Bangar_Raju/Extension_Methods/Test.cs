namespace Extension_Methods
{
    public class Test
    {
        static void Main(string[] args)
        {
            ExtensionMethods extensionMethods = new ExtensionMethods("Youssef Baba");
            extensionMethods.Test1();
            extensionMethods.Test2();
            extensionMethods.Test3(10);


            int number = 5;
            Console.WriteLine($"Factorial of {number} = {number.Factorial()}");


            string sentence = "hElLo hOw Are yoU";
            Console.WriteLine($"{sentence} ==> {sentence.ToProper()}");


        }
    }
}