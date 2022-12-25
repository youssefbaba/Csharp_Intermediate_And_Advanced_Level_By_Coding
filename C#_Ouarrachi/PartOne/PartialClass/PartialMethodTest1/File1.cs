namespace PartialMethodTest1
{
    public partial class SamplePartialClass
    {
        partial void PartialMethodOne(); // Definition Part
        //partial void PartialMethodOne() // Implementation Part which is optional
        //{
        //    Console.WriteLine("PartialMethodOne Invoked.");
        //}

        public partial void PartialMethodTwo(); // Definition Part
        public partial int PartialMethodThree(int i); // Definition Part
        public static partial void PartialMethodFour(); // Definition Part

        public partial T Max<T>(T number1, T number2) where T : IComparable;
        public partial double Add(double number1, double number2);


        public void NoPartialMethod()
        {
            Console.WriteLine("NoPartialMethod Invoked.");
            PartialMethodOne();
        }
    }
}
