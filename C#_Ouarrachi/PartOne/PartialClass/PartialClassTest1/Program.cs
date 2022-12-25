namespace PartialClassTest1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PartialCustomer customer = new PartialCustomer();
            customer.FirstName = "David";
            customer.LastName = "Huge";
            Console.WriteLine($"Full Name : {customer.GetFullName()}");


        }
    }
}