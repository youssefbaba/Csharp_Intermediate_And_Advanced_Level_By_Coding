namespace MyNsp
{
    // Defining our own Exception Class
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message
        {
            get { return "Attempted to divide by odd number"; }
        }
    }
}
