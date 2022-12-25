namespace Multicast_Delegates
{
    public delegate void DelegateTest(out int value);
    public class Test
    {
        // Methods
        public static void MethodOne(out int number)
        {
            number = 10;
        }
        public static void MethodTwo(out int number)
        {
            number = 20;
        }
        static void Main()
        {


            /*
            
            // First Approach : 
            SampleClass sampleClass = new SampleClass();
            DelegateSample delegateSample1, delegateSample2, delegateSample3, delegateSample4;
            delegateSample1 = sampleClass.SampleMethodOne;
            delegateSample2 = sampleClass.SampleMethodTwo;
            delegateSample3 = sampleClass.SampleMethodThree;
            delegateSample4  = delegateSample1 + delegateSample2 + delegateSample3 - delegateSample2;
            delegateSample4();
            
            */


            // Second Approach : 
            SampleClass sampleClass = new SampleClass();
            DelegateSample delegateSample1 = sampleClass.SampleMethodOne;
            delegateSample1 = delegateSample1 + sampleClass.SampleMethodTwo + sampleClass.SampleMethodThree - sampleClass.SampleMethodTwo;
            delegateSample1();
            Console.WriteLine();


            Rectangle rectangle = new Rectangle { Width = 20.14, Height = 10.54 };
            DelegateRectangle delegateRectangle = rectangle.AreaOfRectangle;
            delegateRectangle = delegateRectangle + rectangle.PerimeterOfRectangle + rectangle.DiagonalOfRectangle;
            Console.WriteLine($"{delegateRectangle()}");
            Console.WriteLine();


            DelegateTest delegateTest = MethodOne;
            delegateTest += MethodTwo;
            int outputNumber = -1;
            delegateTest(out outputNumber);
            Console.WriteLine($"outputNumber : {outputNumber}");

        }
    }
}