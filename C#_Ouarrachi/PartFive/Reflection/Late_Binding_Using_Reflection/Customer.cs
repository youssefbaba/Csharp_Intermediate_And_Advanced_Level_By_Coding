namespace Late_Binding_Using_Reflection
{
    public class Customer
    {
        //Methods
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
        public static void Display()
        {
            Console.WriteLine("Display method invoked from customer class.");
        }
    }
}