namespace PartialMethod
{
    public class DerivedClassFromSamplePartialClass : SamplePartialClass
    {
        public override void SamplePartialMethodOne()
        {
            Console.WriteLine("Overriding of SamplePartialMethodOne");
        }
    }
}