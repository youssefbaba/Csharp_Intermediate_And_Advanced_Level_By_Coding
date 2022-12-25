namespace Properties_Part2
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(101, false, "John", 5000.00);
            Console.WriteLine($"Customer Id : {customer.CustomerId}");
            //customer.CustomerId = 102; // cannot be assigned any value to this property because it's read-only
            if (customer.Status)
            {
                Console.WriteLine($"Customer Status : Active");
            }
            else
            {
                Console.WriteLine($"Customer Status : In-Active");
            }
            Console.WriteLine($"Customer Name : {customer.CustomerName}");
            customer.CustomerName += " Doe"; // Assignment failed , so below statement prints old name only
            Console.WriteLine($"Modified Name : {customer.CustomerName}");
            Console.WriteLine($"Customer Balance : {customer.Balance} $");
            customer.Balance -= 3000; // Assignment failed , so below statement prints old balance only
            Console.WriteLine($"Modified Balance : {customer.Balance} $");

            Console.WriteLine();
            Console.WriteLine("<------- Activated the account ------->");
            Console.WriteLine();

            customer.Status = true;
            if (customer.Status)
            {
                Console.WriteLine($"Customer Status : Active");
            }
            else
            {
                Console.WriteLine($"Customer Status : In-Active");
            }
            customer.CustomerName += " Doe"; // Assignment succed , so below statement prints new name
            Console.WriteLine($"Modified Name : {customer.CustomerName}");
            customer.Balance -= 3000; // Assignment succed , so below statement prints new balance
            Console.WriteLine($"Modified Balance : {customer.Balance} $"); // 2000 $
            customer.Balance -= 2000;  // Assignment failed , so below statement prints old balance
            Console.WriteLine($"Balance when assignement failed : {customer.Balance} $");  // 2000 $
            customer.Balance -= 1500;  // Assignment succed , so below statement prints new balance
            Console.WriteLine($"Balance when assignement succed : {customer.Balance} $");  // 500 $
        }
    }
}