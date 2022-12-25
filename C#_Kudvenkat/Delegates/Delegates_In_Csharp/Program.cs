namespace Delegates_In_Csharp
{
    // Defining the delegate
    public delegate void DelegateHello(string Message);

    internal class Program
    {
        /*
         - Delegates is a type safe function pointer
         */
        // Methods
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        static void Main(string[] args)
        {
            // Instantiating the delegate 
            //DelegateHello delegateHello = new DelegateHello(Hello); // First Way
            DelegateHello delegateHello = Hello;  // Second way

            // Calling the delegate
            //delegateHello("Hello From Delegate"); // First way
            delegateHello.Invoke("Hello From Delegate");  // Second way


        }
    }
} 