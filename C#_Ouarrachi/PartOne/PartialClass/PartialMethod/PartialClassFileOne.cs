using System.Xml;

namespace PartialMethod
{
    public partial class SamplePartialClass
    {
        // Definition of the partial method
        partial void SamplePartialMethod();  // it is private by default
        // Implementation of the partial method , which is optional in this case 
        partial void SamplePartialMethod()  // it is private by default
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }

        /*
        // Error : Because we don't have any definition part of this partial method
        partial void SamplePartialMethodTwo() 
        {
            Console.WriteLine("Some text here");
        }
        */

        partial void SamplePartialMethodThree(); // Because we don't have anyy access modifier , the return type must be void
        partial void SamplePartialMethodThree()
        {
            Console.WriteLine("Print something here .....");
        }

        public partial void SamplePartialMethodFour(); // Because we have an access modifier , we can use any return type int , void , double .....
        public partial void SamplePartialMethodFour()
        {
            Console.WriteLine("Print something here .....");
        }


        partial void SamplePartialMethodFive();
        partial void SamplePartialMethodFive()
        {
            Console.WriteLine("Something here");
        }

        // Definition of the partial method
        public virtual partial void SamplePartialMethodOne();
        // Implementation of the partial method , which is mandatory in this case
        public virtual partial void SamplePartialMethodOne()
        {
            Console.WriteLine("Mandatory implementation.");
        }


        public void NonPartialMethod()
        {
            Console.WriteLine("NonPartialMethod Invoked");
            SamplePartialMethod();
        }
    }
}