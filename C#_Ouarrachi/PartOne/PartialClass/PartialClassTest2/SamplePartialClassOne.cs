namespace PartialClassTest2
{
    //internal partial class SamplePartialClass
    //public abstract partial class SamplePartialClass
    //public sealed partial class SamplePartialClass
    public partial class SamplePartialClass : BaseSample
    {
        // Fields
        private int _id;
        private string _name;


        // Constructors
        public SamplePartialClass()
        {
        }
        public SamplePartialClass(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}