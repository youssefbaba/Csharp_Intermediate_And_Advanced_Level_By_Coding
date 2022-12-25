namespace PartialMethodTest1
{
    public partial class SamplePartialClass
    {
        partial void PartialMethodOne() // Implementation Part
        {
            Console.WriteLine("PartialMethodOne Invoked.");
        }
        public partial void PartialMethodTwo() // Implementation Part which is mandatory
        {
            Console.WriteLine("PartialMethodTwo Invoked");
        }
        public partial int PartialMethodThree(int i) // Implementation Part which is mandatory
        {
            Console.WriteLine("PartialMethodThree Invoked");
            return i;
        }
        public static partial void PartialMethodFour() // Implementation Part which is mandatory
        {
            Console.WriteLine("PartialMethodThree Invoked");
        }
        public partial T Max<T>(T number1, T number2) where T : IComparable
        { 
            return (number1.CompareTo(number2) >= 0) ? number1 : number2; 
        }
        public partial double Add(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
