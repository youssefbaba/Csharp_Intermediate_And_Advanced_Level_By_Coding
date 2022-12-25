namespace Delegates_Part1
{
    public class Test
    {
        static void Main(string[] args)
        {
            // Step 2 : Instantiating the delegate
            DelegateClass delegateClass = new DelegateClass();
            //AddDelegate addDelegate = new AddDelegate(delegateClass.AddNumbers);
            AddDelegate addDelegate = delegateClass.AddNumbers;
            //SayDelegate sayDelegate = new SayDelegate(DelegateClass.SayHello);
            SayDelegate sayDelegate = DelegateClass.SayHello;

            // Step 3 : Calling the method whith delegate
            addDelegate(100, 50); // First way
            addDelegate.Invoke(100, 50); // Second way
            Console.WriteLine(sayDelegate("Youssef Baba")); // First way
            Console.WriteLine(sayDelegate.Invoke("Youssef Baba")); // Second way
        }
    }
}