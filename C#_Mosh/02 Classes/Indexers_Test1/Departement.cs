
namespace Indexers_Test1
{
    public class Departement
    {
        // Fields
        List<Employee> Employees;

        // Properties 
        public int DepartementId { get; set; }
        public string DepartementName { get; set; }

        // Constructors
        public Departement()
        {
            DepartementId = 10;
            DepartementName = "Sales";
            Employees = new List<Employee>();
            Employees.Add(new Employee { Id = 1, EmployeeName = "Alex", Salary = 50000.00 });  // Here we use Object initializer to intialize the object of type Employee
            Employees.Add(new Employee { Id = 2, EmployeeName = "Brad", Salary = 45000.00 });  // Here we use Object initializer to intialize the object of type Employee
            Employees.Add(new Employee { Id = 3, EmployeeName = "Chris", Salary = 40000.00 }); // Here we use Object initializer to intialize the object of type Employee
        }
        // Indexers
        public Employee this[int index]
        {
            get
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.Id.Equals(index))
                    {
                        return employee;
                    }
                }
                return null;
            }
        }
        public Employee this[string employeeName]
        {
            get
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.EmployeeName.Equals(employeeName))
                    {
                        return employee;
                    }
                }
                return null;
            }
        }
    }
}
