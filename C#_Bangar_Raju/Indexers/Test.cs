namespace Indexers
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Gerard Gavi", "Manager", 20000.00, "Sales", "Madrid");
            Console.WriteLine($"Employee Id : {employee[1]}");
            Console.WriteLine($"Employee Name : {employee[2]}");
            Console.WriteLine($"Employee Job : {employee[3]}");
            Console.WriteLine($"Employee Salary : {employee[4]} $");
            Console.WriteLine($"Employee Departement : {employee[5]}");
            Console.WriteLine($"Employee Location : {employee[6]}");


            employee[1] = 2;
            employee[2] = "Xavi Morata";
            employee[3] = "Senior Manager";
            employee[4] = 40000.00;


            Console.WriteLine();
            Console.WriteLine("<------------------------>");
            Console.WriteLine();


            Console.WriteLine($"Employee Id : {employee[1]}");
            Console.WriteLine($"Employee Name : {employee[2]}");
            Console.WriteLine($"Employee Job : {employee[3]}");
            Console.WriteLine($"Employee Salary : {employee[4]} $");
            Console.WriteLine($"Employee Departement : {employee[5]}");
            Console.WriteLine($"Employee Location : {employee[6]}");


        }
    }
}