namespace Multicast_Delegates
{
    public delegate void DelegateSample();
    public class SampleClass
    {
        // Methods
        public void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
    }
}
