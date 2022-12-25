namespace Keyword_Is_And_As
{
    public class Test
    {
        /*
         - Is operator returns true if an object can be cast to a specific type , otherwise false. => Implicit Cast
         - As operator attempts to cast an object to a specific type , and returns null if it fails. => Explicit  Cast
         - Cast operator throws an exception if the conversion cannot be done, where as the As operator returns null if the conversion cannot be done.
         - Object
            - Employee
                -ContractEmployee
                -PermanentEmployee
         */
        static void Main(string[] args)
        {
            Employee employee = new Employee(3, "Marks");
            //ContractEmployee contractEmployee = (ContractEmployee)employee; // at run-time throws an exception (InvalidCastException)
            ContractEmployee contractEmployee = employee as ContractEmployee; // null
            if (contractEmployee == null)
            {
                Console.WriteLine("contractEmployee is null"); // contractEmployee is null
            }
            else
            {
                Console.WriteLine("contractEmployee is not null");
            }

            Console.WriteLine();

            //PermanentEmployee permanentEmployee = (PermanentEmployee)employee; // at run-time throws an exception (InvalidCastException)
            PermanentEmployee permanentEmployee = employee as PermanentEmployee; // null
            if (permanentEmployee == null)
            {
                Console.WriteLine("permanentEmployee is null"); // permanentEmployee is null
            }
            else
            {
                Console.WriteLine("permanentEmployee is not null");
            }

            Console.WriteLine();

            Employee employee1 = new ContractEmployee(4, "Jim", 100000);
            //ContractEmployee contractEmployee1 = (ContractEmployee)employee1;  // cast succed
            ContractEmployee contractEmployee1 = (ContractEmployee)employee1;  // cast succed : Not null
            if (contractEmployee1 == null)
            {
                Console.WriteLine("contractEmployee1 is null");
            }
            else
            {
                Console.WriteLine("contractEmployee1 is not null"); // contractEmployee1 is not null
            }

            Console.WriteLine();
            //PermanentEmployee permanentEmployee1 = (PermanentEmployee)employee1; // at run-time throws an exception (InvalidCastException)
            PermanentEmployee permanentEmployee1 = employee1 as PermanentEmployee; // null
            if (permanentEmployee1 == null)
            {
                Console.WriteLine("permanentEmployee1 is null"); // permanentEmployee1 is null
            }
            else
            {
                Console.WriteLine("permanentEmployee1 is not null");
            }

            Console.WriteLine();

            ContractEmployee contractEmployee2 = new ContractEmployee(7 ,"Jean" ,450000);
            //Employee employee2 = contractEmployee2 as Employee;
            Employee employee2 = contractEmployee2; // Implicit cast
            if (employee2 == null)
            {
                Console.WriteLine("employee2 is null");
            }
            else
            {
                Console.WriteLine("employee2 is not null"); // employee2 is not null
            }

            Console.WriteLine();

            PermanentEmployee permanentEmployee2 = new PermanentEmployee(9, "Said", 124000);
            //Employee employee3 = contractEmployee2 as Employee;
            Employee employee3 = contractEmployee2; // Implicit cast
            if (employee3 == null)
            {
                Console.WriteLine("employee3 is null");
            }
            else
            {
                Console.WriteLine("employee3 is not null"); // employee3 is not null
            }
        }
    }
}
