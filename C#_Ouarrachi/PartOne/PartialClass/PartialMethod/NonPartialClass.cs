namespace PartialMethod
{
    public class NonPartialClass
    {
        /*
        // Error : because a partial method must be declared within a partial type
        partial void PatialMethod();
        partial void PatialMethod()
        {
            Console.WriteLine("PatialMethod Invoked");
        }
        */

        /*
        // Error : because a partial method must be declared within a partial type
        private partial int PatialMethod();
        private partial int PatialMethod()
        {
            Console.WriteLine("PatialMethod Invoked");
        }
        */
    }
}