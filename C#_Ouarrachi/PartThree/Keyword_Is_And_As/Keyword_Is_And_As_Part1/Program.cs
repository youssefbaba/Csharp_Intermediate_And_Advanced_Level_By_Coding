namespace Keyword_Is_And_As
{
    public class Program
    {
        /*
         - Is operator returns true if an object can be cast to a specific type , otherwise false.  => Implicit Cast
         - As operator attempts to cast an object to a specific type , and returns null if it fails. => Explicit Cast
         - Cast operator throws an exception if the conversion cannot be done, where as the As operator returns null if the conversion cannot be done.
         - Object
            - Employee
                -ContractEmployee
                -PermanentEmployee
         */
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "David");

            if (employee is Employee)
            {
                Console.WriteLine($"{employee.Name} is Employee"); // David is Employee
            }
            else
            {
                Console.WriteLine($"{employee.Name} is not Employee");
            }

            Console.WriteLine();

            if (employee is ContractEmployee)
            {
                Console.WriteLine($"{employee.Name} is ContractEmployee");
            }
            else
            {
                Console.WriteLine($"{employee.Name} is not ContractEmployee"); // David is not ContractEmployee
            }

            Console.WriteLine();

            if (employee is PermanentEmployee)
            {
                Console.WriteLine($"{employee.Name} is PermanentEmployee");
            }
            else
            {
                Console.WriteLine($"{employee.Name} is not PermanentEmployee"); // David is not PermanentEmployee
            }

            Console.WriteLine();

            Employee employee1 = new ContractEmployee(2, "John", 120000);
            if (employee1 is Employee)
            {
                Console.WriteLine($"{employee1.Name} is Employee"); // John is Employee
            }
            else
            {
                Console.WriteLine($"{employee1.Name} is Employee");
            }

            Console.WriteLine();

            if (employee1 is ContractEmployee)
            {
                Console.WriteLine($"{employee1.Name} is ContractEmployee"); // John is ContractEmployee
            }
            else
            {
                Console.WriteLine($"{employee1.Name} is not ContractEmployee");
            }

            Console.WriteLine();

            if (employee1 is PermanentEmployee)
            {
                Console.WriteLine($"{employee1.Name} is PermanentEmployee"); 
            }
            else
            {
                Console.WriteLine($"{employee1.Name} is not PermanentEmployee"); // John is not PermanentEmployee
            }

        }
    }
}