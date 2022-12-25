namespace Anonymous_Methods_Delegates_Part3
{
    // Defining delegate
    public delegate void DelegateOne(int number1, int number2);
    public delegate string DelegateTwo(string name);
    public class AnonymousMethods
    {
        static void Main(string[] args)
        {
            AnonymousMethods anonymousMethods = new AnonymousMethods();
            DelegateOne delegateOne = delegate (int number1, int number2)  // Anonymous Methods
            {
                Console.WriteLine($"Result : {number1 + number2}");
            };
            delegateOne.Invoke(100,50); // Calling the delegate

            DelegateTwo delegateTwo = delegate (string name)  // Anonymous Methods
            {
                return $"Hello {name}";
            };
            Console.WriteLine(delegateTwo.Invoke("Youssef Baba"));  // Calling the delegate
        }
    }
}
