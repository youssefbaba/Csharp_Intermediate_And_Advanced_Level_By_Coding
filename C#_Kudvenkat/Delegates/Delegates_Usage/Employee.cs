namespace Delegates_Usage
{
    public class Employee
    {
        // Methods
        public static void PromoteEmploye(List<Employee> employees, DelegatePromotableEmployee IsPromotableEmployee)
        {
            foreach (Employee employee in employees)
            {
                if (IsPromotableEmployee(employee))  // Calling the delegate
                {
                    Console.WriteLine($"{employee.Name} promoted");
                }
            }
        }

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

    }
}
